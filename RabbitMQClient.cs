using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQClient.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQClient
{
    public partial class RabbitMQClient : Form
    {
        public IRabbitMQConfigurations rabbitMQConfig;
        public IRabbitMQbroker rabbitMQBroker;
        public IRabbitMQReader rabbitMQReader;
        public static string readerLog;
        public RabbitMQClient(IRabbitMQConfigurations _rabbitMQConfig, IRabbitMQbroker _rabbitMQBroker, IRabbitMQReader _rabbitMQReader)
        {
            InitializeComponent();
            this.rabbitMQConfig = _rabbitMQConfig;
            this.rabbitMQBroker = _rabbitMQBroker;
            this.rabbitMQReader = _rabbitMQReader;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            RichTextBox.CheckForIllegalCrossThreadCalls = false;

            // Debugging tobe removed.
            txtHostname.Text = "localhost";
            txtUsername.Text = "guest";
            txtPassword.Text = "guest";
            txtExchange.Text = "QualitydataEx";
            txtQueue.Text = "Qualitydataqueue";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHostname.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtExchange.Text != "" && txtPayload.Text != "")
                {
                    this.rabbitMQConfig.RabbitMQHostname = txtHostname.Text;
                    this.rabbitMQConfig.RabbitMQUserName = txtUsername.Text;
                    this.rabbitMQConfig.RabbitMQPassword = txtPassword.Text;
                    this.rabbitMQConfig.RabbitMQVirtualhost = txtVirtualhostname.Text;
                    this.rabbitMQConfig.Exchange = txtExchange.Text;
                    this.rabbitMQConfig.Queue = txtQueue.Text;
                    logActivity("\n" + "Preparing to send . . .");
                    if (rabbitMQBroker.WriteToMQByFanoutExchange(txtPayload.Text))
                    {
                        logActivity("\nPayload : " + txtPayload.Text);
                        logActivity("\n" + "Sucessfully sent on " + DateTime.Now.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Rabbitmq Host|Username|Password|Payload");
                }
            }
            catch (Exception ex)
            {
                logActivity("\n" + "Failed to sent");
                logActivity("\n" + ex.Message.ToString());
                logActivity("\n" + ex.ToString());
            }
        }


        ConnectionFactory connectionFactoryread;
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtHostname.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtExchange.Text != "" && txtQueue.Text != "")
                {
                    this.rabbitMQConfig.RabbitMQHostname = txtHostname.Text;
                    this.rabbitMQConfig.RabbitMQVirtualhost = txtVirtualhostname.Text;
                    this.rabbitMQConfig.RabbitMQUserName = txtUsername.Text;
                    this.rabbitMQConfig.RabbitMQPassword = txtPassword.Text;
                    this.rabbitMQConfig.Exchange = txtExchange.Text;
                    this.rabbitMQConfig.Queue = txtQueue.Text;
                    logActivity("Preparing to read . . .");

                    connectionFactoryread = new RabbitMQ.Client.ConnectionFactory()
                    {
                        HostName = rabbitMQConfig.RabbitMQHostname,
                        UserName = rabbitMQConfig.RabbitMQUserName,
                        Password = rabbitMQConfig.RabbitMQPassword,
                        VirtualHost = rabbitMQConfig.RabbitMQVirtualhost
                    };

                    string queueName = rabbitMQConfig.Queue;
                    var rabbitMqConnection = connectionFactoryread.CreateConnection();
                    var rabbitMqChannel = rabbitMqConnection.CreateModel();

                    rabbitMqChannel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

                    int messageCount = Convert.ToInt16(rabbitMqChannel.MessageCount(queueName));
                    logActivity("\n" + string.Format("Listening to the queue. This channels has {0} messages on the queue", messageCount));

                    var consumer = new EventingBasicConsumer(rabbitMqChannel);
                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body.ToArray();
                        //byte[] bytearray = new byte[body];
                        var message = Encoding.UTF8.GetString(body);
                        logActivity("\n" + message);
                        logActivity("\n" + "New message received at " + DateTime.Now.ToString() + ": ");


                        rabbitMqChannel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
                        Thread.Sleep(1000);
                    };
                    rabbitMqChannel.BasicConsume(queue: queueName,
                                         autoAck: false,
                                         consumer: consumer);

                    Thread.Sleep(1000 * messageCount);
                    logActivity("\n" + "Connection closed, no more messages.");
                }
                else
                {
                    MessageBox.Show("Please Enter Rabbitmq Host|Username|Password");
                }
            }
            catch (Exception ex)
            {
                logActivity("\n" + ex.Message.ToString());
                logActivity("\n" + ex.ToString());
            }

        }

        private void clrLogs_Click(object sender, EventArgs e)
        {
            txtLogs.Text = "";
        }
        public void logActivity(string logs)
        {
            txtLogs.Select(0, 0);
            txtLogs.SelectedText = logs + "\r\n";
        }
    }
}
