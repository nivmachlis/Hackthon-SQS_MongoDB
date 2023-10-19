using Amazon.SQS;
using DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HacktonSQS
{
    public class SqsMessageSender
    {
        private readonly IAmazonSQS sqsClient;
        private readonly string qurl;

        public SqsMessageSender(IAmazonSQS sqsClient, string qurl)
        {
            this.sqsClient = sqsClient;
            this.qurl = qurl;
        }

        public void SendMessages(List<MessageDTO> objectsToSend)
        {
            foreach(MessageDTO message in objectsToSend)
            {
                SendMessage(sqsClient, JsonConvert.SerializeObject(message));
            }
        }
        private void SendMessage(IAmazonSQS sqsClient, string messageBody)
        {
            sqsClient.SendMessage(qurl, messageBody);
        }
    }
}
