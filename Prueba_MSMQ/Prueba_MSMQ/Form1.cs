using System;
using System.Messaging;
using System.Windows.Forms;

namespace Prueba_MSMQ
{
    /* Basado en:
        https://www.youtube.com/watch?v=GArHz5YhThQ
        https://www.youtube.com/watch?v=UAC-QGhIvJs
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            using (MessageQueue testQueue = new MessageQueue())
            {
                testQueue.Path = @".\private$\testQueue";
                testQueue.DefaultPropertiesToSend.Recoverable = true;
                if (! MessageQueue.Exists(testQueue.Path)) MessageQueue.Create(testQueue.Path);

                System.Messaging.Message myMessage = new System.Messaging.Message();
                myMessage.Body = txtEnviar.Text;
                testQueue.Send(myMessage);
            }
        }


        private void btnRecibir_Click(object sender, EventArgs e)
        {
            using (MessageQueue testQueue = new MessageQueue())
            {
                testQueue.Path = @".\private$\testQueue";
                System.Messaging.Message myMessage = new System.Messaging.Message();

                try
                {
                    myMessage = testQueue.Receive(new TimeSpan(0, 0, 2));
                    myMessage.Formatter = new XmlMessageFormatter(new string[] { "System.String,mscorlib" });
                    string msg = myMessage.Body.ToString();
                    txtRecibir.Text = msg;
                }
                catch (MessageQueueException) 
                {
                    MessageBox.Show($"No se hallaron mensajes en la cola. Timeout de lectura alcanzado.");
                }
                catch (Exception ex) 
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

    }
}


