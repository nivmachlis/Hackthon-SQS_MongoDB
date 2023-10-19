using DTOs;
using HacktonQueueSender.JsonDataReader;
using System;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace HacktonSQS
{
    public partial class SenderForm : Form
    {
        private readonly JsonDataDTO  jsonData;
        private readonly AWSConfigManager configManager;
        private readonly SqsMessageSender messageSender;

        public SenderForm()
        {
            InitializeComponent();
            configManager = AWSConfigManager.Instance;
            messageSender = new SqsMessageSender(configManager.SqsClient, configManager.Qurl);

            jsonData = JsonDataReader.ReadJsonFile(filePath: Path.Combine("..","..","data.json"));
        }

        private void buttonSendEventMessages_Click (object sender, EventArgs e)
        {
            messageSender.SendMessages(jsonData.EventValues);
            messageSender.SendMessages(jsonData.UsersValues);
            messageSender.SendMessages(jsonData.SessionsValues);
        }
    }
}
