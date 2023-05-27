using System;
using System.Messaging;

namespace PruebaMSMQ_RcvDelegado
{

    //Basado en: https://learn.microsoft.com/en-us/dotnet/api/system.messaging.messagequeue.receivecompleted?view=netframework-4.8.1
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MessageQueue. Set its formatter.
            MessageQueue myQueue = new MessageQueue(@".\private$\testQueue");  //new MessageQueue(".\\myQueue");
            myQueue.Formatter = new XmlMessageFormatter(new Type[]
                {typeof(String)});

            // Add an event handler for the ReceiveCompleted event.
            myQueue.ReceiveCompleted += new
                ReceiveCompletedEventHandler(MyReceiveCompleted);

            // Begin the asynchronous receive operation.
            myQueue.BeginReceive();

            // Do other work on the current thread.
            Console.WriteLine("Escuchando msjes de la cola. Para salir presiona una tecla");
            Console.ReadKey();

            return;
        }


        private static void MyReceiveCompleted(Object source, ReceiveCompletedEventArgs asyncResult)
        {
            // Connect to the queue.
            MessageQueue mq = (MessageQueue)source;

            // End the asynchronous Receive operation.
            Message message = mq.EndReceive(asyncResult.AsyncResult);

            // Display message information on the screen.
            Console.WriteLine("Mensaje: " + message.Body.ToString());

            // Restart the asynchronous Receive operation.
            mq.BeginReceive();

            return;
        }
    }
}
