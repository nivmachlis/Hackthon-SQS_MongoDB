using Amazon.SQS;
using Amazon.SQS.Model;
using DataBase;
using DTOs;
using HacktonQueueSender.JsonDataReader;
using HacktonSQS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HacktonSQS
{
    public class SQSConsumer
    {
        private readonly IAmazonSQS sqsClient;
        private readonly string qurl;
        private readonly MongoDBHandler mongoDBHandler;  

        public SQSConsumer(IAmazonSQS sqsClient, string qurl)
        {
            this.sqsClient = sqsClient;
            this.qurl = qurl;
            this.mongoDBHandler = new MongoDBHandler();
        }
        public int GetApproximateNumberOfMessages()
        {
            var request = new GetQueueAttributesRequest
            {
                QueueUrl = qurl,
                AttributeNames = new List<string> { "ApproximateNumberOfMessages" }
            };

            var response = sqsClient.GetQueueAttributes(request);

            if (response.Attributes.TryGetValue("ApproximateNumberOfMessages", out var numberOfMessagesStr) &&
                int.TryParse(numberOfMessagesStr, out var numberOfMessages))
            {
                return numberOfMessages;
            }

            return -1; 
        }

        private ReceiveMessageRequest GetReceiveMessageRequest()
        {
            return new ReceiveMessageRequest
            {
                QueueUrl = qurl,
                MaxNumberOfMessages = 2,
                WaitTimeSeconds = 20
            };
        }

        public void MessageConsuming()
        {
            ReceiveMessageRequest receiveMessageRequest = GetReceiveMessageRequest();
            ReceiveMessageResponse receiveMessageResponse = sqsClient.ReceiveMessage(receiveMessageRequest);

            if (receiveMessageResponse.Messages.Any())
            {
                foreach (var message in receiveMessageResponse.Messages)
                {
                    MessageDTO messageDTO = JsonConvert.DeserializeObject<MessageDTO>(message.Body, new MessageDTOConverter());

                    mongoDBHandler.ProcessMessageToDB(messageDTO.AnalyticsName, messageDTO.data);

                    DeleteMessage(message.ReceiptHandle);

                }
            }
        }

        private void DeleteMessage(string receiptHandle)
        {
            DeleteMessageRequest deleteRequest = new DeleteMessageRequest
            {
                QueueUrl = qurl,
                ReceiptHandle = receiptHandle
            };
            sqsClient.DeleteMessage(deleteRequest);
        }
    }
}
