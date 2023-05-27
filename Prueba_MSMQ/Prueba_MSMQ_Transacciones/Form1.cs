using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_MSMQ_Transacciones
{

    //Basado en: https://www.codeproject.com/Articles/4348/Programming-MSMQ-in-NET-Part-2-Transactional-Messa

    public partial class Form1 : Form
    {

        private const string NOMBRE_COLA_A = @".\private$\transaccionalqueueA";
        private const string NOMBRE_COLA_B = @".\private$\transaccionalqueueB";

        public Form1()
        {
            InitializeComponent();
        }

        //Envio transaccional a 2 colas. O se envia a las 2 o a ninguna
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageQueue queueA = new MessageQueue(NOMBRE_COLA_A);
            MessageQueue queueB = new MessageQueue(NOMBRE_COLA_B);

            if (!MessageQueue.Exists(queueA.Path)) MessageQueue.Create(queueA.Path, true);
            if (!MessageQueue.Exists(queueB.Path)) MessageQueue.Create(queueB.Path, true);

            MessageQueueTransaction transaccion = new MessageQueueTransaction();
            transaccion.Begin();

            try
            {
                queueA.Send(txtEnviar.Text, "Label A", transaccion);
                queueB.Send(txtEnviar.Text, "Label B", transaccion);
                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Abort();
                MessageBox.Show(this, "Error al enviar a las colas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                queueA.Close();
                queueB.Close();
            }
        }


        //Recepcion Transaccional. Si se procesa correctamente el msje y se comittea, se quita efectivzmente de la cola.
        //Si no, ante un Abort(), el msje se vuelve a dejar en la cola.
        private void btnRecibir_Click(object sender, EventArgs e)
        {
            using (MessageQueue testQueue = new MessageQueue())
            {
                testQueue.Path = NOMBRE_COLA_A;
                System.Messaging.Message myMessage = new System.Messaging.Message();

                MessageQueueTransaction transaccion = new MessageQueueTransaction();
                transaccion.Begin();
                try
                {
                    myMessage = testQueue.Receive(new TimeSpan(0,0,2), transaccion);
                    myMessage.Formatter = new XmlMessageFormatter(new string[] { "System.String,mscorlib" });
                    string msg = myMessage.Body.ToString();
                    txtRecibir.Text = msg;
                    transaccion.Commit();
                }
                catch (MessageQueueException)
                {
                    MessageBox.Show($"No se hallaron mensajes en la cola. Timeout de lectura alcanzado.");
                    transaccion.Abort();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    transaccion.Abort();
                }
            }
        }

    }
}
