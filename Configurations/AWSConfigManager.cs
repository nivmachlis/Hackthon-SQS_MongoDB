using Amazon;
using Amazon.Runtime;
using Amazon.SQS;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HacktonSQS
{
    public class AWSConfigManager
    {
        private static AWSConfigManager instance;
        private AWSConfigManager() { }

        public static AWSConfigManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AWSConfigManager();
                    instance.LoadAWSConfig();
                }
                return instance;
            }
        }

        public string AccessKey { get; private set; }
        public string SecretKey { get; private set; }
        public RegionEndpoint Region { get; private set; }
        public string Qurl { get; private set; }
        public BasicAWSCredentials Credentials { get; private set; }
        public AmazonSQSClient SqsClient { get; private set; }

        private void LoadAWSConfig()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..","..","..","Configurations"))
                .AddJsonFile(path: "appsettings.json")
                .Build();

            AccessKey = configuration.GetSection("AWS:AccessKey").Value;
            SecretKey = configuration.GetSection("AWS:SecretKey").Value;
            Region = RegionEndpoint.GetBySystemName(configuration.GetSection("AWS:Region").Value);
            Qurl = configuration.GetSection("AWS:Qurl").Value;

            Credentials = new BasicAWSCredentials(AccessKey, SecretKey);
            SqsClient = new AmazonSQSClient(Credentials, Region);
        }
    }

}
