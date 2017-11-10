using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NewsCommon.Other
{
    public class QueueHelper<T> where T : class
    {
        private CloudQueue _queue;

        public void Initialize(string connectionString, string queueName)
        {
            CloudStorageAccount storageAccount=CloudStorageAccount.Parse(connectionString);
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
            CloudQueue queue = queueClient.GetQueueReference(queueName);
            queue.CreateIfNotExists();
            _queue = queue;
        }

        public void SendMessage(T item)
        {
            string message = JsonConvert.SerializeObject(item);
            CloudQueueMessage cloudMessage = new CloudQueueMessage(message);
            _queue.AddMessage(cloudMessage);
        }

        public async Task SendMessageAsync(T item)
        {
            string message = JsonConvert.SerializeObject(item);
            CloudQueueMessage cloudMessage = new CloudQueueMessage(message);
            await _queue.AddMessageAsync(cloudMessage);
        }
    }
}