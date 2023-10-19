using HacktonSQS;
using System;
using System.Windows.Forms;

namespace HacktonSQS
{
    public partial class FormConsumer : Form
    {
        private readonly AWSConfigManager awsConfigManager;
        private readonly SQSConsumer sqsConsumer;
        public FormConsumer()
        {    
            InitializeComponent();
            awsConfigManager = AWSConfigManager.Instance;
            sqsConsumer = new SQSConsumer(awsConfigManager.SqsClient, awsConfigManager.Qurl);
            
        }

        private void buttonConsumeMessage_Click(object sender, EventArgs e)
        {
            sqsConsumer.MessageConsuming();
            RefreshMessagesAmount();
        }

        private void buttonRefreshMessagesAmount_Click(object sender, EventArgs e)
        {
            RefreshMessagesAmount();
        }

        private void RefreshMessagesAmount()
        {
            labelNumOfMessages.Text = sqsConsumer.GetApproximateNumberOfMessages().ToString();
        }

    }
}
