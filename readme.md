# Hackthon-SQS_MongoDB

This project consists of two applications: "HacktonQueueSender" and a message consumer called "HacktonSQSConsumer." The "HacktonQueueSender" reads data from a JSON file and sends messages to an AWS SQS (Simple Queue Service) queue. The consumer application listens to the SQS queue, processes the messages, and stores them in a MongoDB collection based on the message type.

## Requirements

Before you begin, make sure you have the following requirements:

- MongoDB Server: Install MongoDB on your local machine or server. You can download and install MongoDB from [MongoDB Downloads](https://www.mongodb.com/try/download/community).
  
  - MongoDB Driver for .NET: You will also need the MongoDB C#/.NET driver to interact with MongoDB. You can install it using NuGet Package Manager or add it to your project's dependencies. 

- AWS Account: You need an AWS account with the necessary permissions to access SQS services.

## Getting Started

1. Clone this repository to your local machine:

   ```shell
   git clone https://github.com/nivmachlis/Hackthon-SQS_MongoDB.git
   
2. Open the solution in your preferred development environment (e.g., Visual Studio, Visual Studio Code).

3. Update the configuration settings in the `Configurations/appsettings.json` file to match your environment. You should configure:

   - AWS SQS settings (e.g., access key, secret key, queue URL).
   - MongoDB connection settings (e.g., connection string, database name).

## HacktonQueueSender

The "HacktonQueueSender" application is responsible for reading data from a JSON file and sending messages to an AWS SQS queue. To use this application:

1. Ensure that you have updated the configuration settings in `Configurations/appsettings.json`.

2. Build and run the "HacktonQueueSender" application.

3. It will read the JSON file, create messages, and send them when clicking the button to the specified SQS queue.

## HacktonSQSConsumer

The message consumer application processes messages from the SQS queue and saves them to a MongoDB collection based on the message type. To use this application:

1. Make sure the configuration settings in `Configurations/appsettings.json` match your environment.

2. Build and run the message consumer application.

3. It will continuously listen to the specified SQS queue and process incoming messages when clicking the message.

4. Depending on the message type, it will store the data in the appropriate MongoDB collection.

## Updating Configurations

To change the configurations for either application, you should update the `Configurations/appsettings.json` file. Make sure to keep sensitive information secure and use environment-specific settings when necessary.

## Dependencies

This project uses the following dependencies:

- Microsoft.Extensions.Configuration for configuration settings.
- AWS SDK for accessing AWS SQS.
- MongoDB.Driver for interacting with MongoDB.


