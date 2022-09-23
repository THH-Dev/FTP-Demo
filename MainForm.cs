using Confluent.Kafka;
using JohnNguyen.Lib;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FTP_Demo
{
    public partial class MainForm : Form
    {
        string file_name;

        public MainForm()
        {
            InitializeComponent();
            InitProducer();
            InitConsummer();

            this.FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReleaseObject();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            file_name = MyLib.OpenFileDialog(eTypeFile.File_jpg);
            if (file_name == null)
                return;

            txtPath.Text = file_name;

        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            MyLib.UploadImage(file_name);
        }

        private void Download_Btn_Click(object sender, EventArgs e)
        {
            MyLib.DownloadFileFTP();
        }



        Action<DeliveryReport<Null, string>> handler_producer;
        IProducer<Null, string> producerBuilder;

        void InitProducer()
        {
            handler_producer = r => {
                string log = !r.Error.IsError
                                   ? $"Delivered message to {r.TopicPartitionOffset}"
                                   : $"Delivery Error: {r.Error.Reason}";

                listBoxLog.BeginInvoke(new Action(() => { 
                    listBoxLog.Items.Insert(0, log);
                }));
            };


            var conf = new ProducerConfig { BootstrapServers = Broker_Producer_Txt.Text };
            producerBuilder = new ProducerBuilder<Null, string>(conf).Build();
        }


        void ReleaseObject()
        {
            StopScanData();
            Thread.Sleep(100);
            producerBuilder.Dispose();
            consumer.Close();
            consumer.Dispose();
        }
        private void KafkaTestBtn_Click(object sender, EventArgs e)
        {

            producerBuilder.Produce(Topic_Producer_Txt.Text, new Message<Null, string> { Value = Data2Send_Txt.Text }, handler_producer);
            // wait for up to 10 seconds for any inflight messages to be delivered.
            producerBuilder.Flush(TimeSpan.FromSeconds(1));
        }


        IConsumer<Ignore, string> consumer;
        void InitConsummer()
        {

            var conf = new ConsumerConfig
            {
                GroupId = "test-consumer-group",
                BootstrapServers = Broker_Consummer_Txt.Text,
                // Note: The AutoOffsetReset property determines the start offset in the event
                // there are not yet any committed offsets for the consumer group for the
                // topic/partitions of interest. By default, offsets are committed
                // automatically, so in this example, consumption will only start from the
                // earliest message in the topic 'my-topic' the first time you run the program.
                AutoOffsetReset = AutoOffsetReset.Earliest
            };


            consumer = new ConsumerBuilder<Ignore, string>(conf).Build();
            consumer.Subscribe(Topic_Consummer_Txt.Text);

         
        }


        #region task loop -> scan PLC



        public void StopScanData()
        {
            MyParam.taskLoops[(int)eTaskLoop.Task_Comsummer].StopLoop();
        }
        public void RunLoopScanData()
        {
            MyParam.taskLoops[(int)eTaskLoop.Task_Comsummer].ResetToken();
            MyParam.taskLoops[(int)eTaskLoop.Task_Comsummer].RunLoop(100, ConsummerData).ContinueWith((a) =>
            {
                MessageBox.Show($"Done task Consum");
                //Console.WriteLine("Stop task scan PLC");
            });

        }

        void ConsummerData()
        {
            try
            {
                if (MyParam.taskLoops[(int)eTaskLoop.Task_Comsummer].CancelSource.IsCancellationRequested)
                {
                    Console.WriteLine("Return, not consider consummer data!");
                    return;
                }

                var cr = consumer.Consume();
                var log = $"Consumed message '{cr.Value}' at: '{cr.TopicPartitionOffset}'.";

                listBoxDataReceiver.BeginInvoke(new Action(() =>
                {
                    listBoxDataReceiver.Items.Insert(0, log);
                }));
            }
            catch (ConsumeException ex)
            {
                Console.WriteLine($"Error occured: {ex.Error.Reason}");
            }
        }
        #endregion


        static bool isPressConsummer = false;
        private void KafkaGet_btn_Click(object sender, EventArgs e)
        {
            if(!isPressConsummer)
            {
                RunLoopScanData();
            }
            else
            {
                StopScanData();
            }

            isPressConsummer = !isPressConsummer;

        }
    }
}
