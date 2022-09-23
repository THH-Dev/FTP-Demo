namespace FTP_Demo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLoad = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.Download_Btn = new System.Windows.Forms.Button();
            this.Send_Producer_Txt = new System.Windows.Forms.Button();
            this.KafkaGet_btn = new System.Windows.Forms.Button();
            this.Data2Send_Txt = new System.Windows.Forms.TextBox();
            this.listBoxDataReceiver = new System.Windows.Forms.ListBox();
            this.Broker_Producer_Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Topic_Producer_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Broker_Consummer_Txt = new System.Windows.Forms.TextBox();
            this.Topic_Consummer_Txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(622, 13);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 0;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 15);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(579, 20);
            this.txtPath.TabIndex = 1;
            // 
            // BtnUpload
            // 
            this.BtnUpload.Location = new System.Drawing.Point(713, 13);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(75, 23);
            this.BtnUpload.TabIndex = 0;
            this.BtnUpload.Text = "Upload";
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // Download_Btn
            // 
            this.Download_Btn.Location = new System.Drawing.Point(713, 72);
            this.Download_Btn.Name = "Download_Btn";
            this.Download_Btn.Size = new System.Drawing.Size(75, 23);
            this.Download_Btn.TabIndex = 0;
            this.Download_Btn.Text = "Download";
            this.Download_Btn.UseVisualStyleBackColor = true;
            this.Download_Btn.Click += new System.EventHandler(this.Download_Btn_Click);
            // 
            // Send_Producer_Txt
            // 
            this.Send_Producer_Txt.Location = new System.Drawing.Point(262, 46);
            this.Send_Producer_Txt.Name = "Send_Producer_Txt";
            this.Send_Producer_Txt.Size = new System.Drawing.Size(75, 23);
            this.Send_Producer_Txt.TabIndex = 0;
            this.Send_Producer_Txt.Text = "Send";
            this.Send_Producer_Txt.UseVisualStyleBackColor = true;
            this.Send_Producer_Txt.Click += new System.EventHandler(this.KafkaTestBtn_Click);
            // 
            // KafkaGet_btn
            // 
            this.KafkaGet_btn.Location = new System.Drawing.Point(266, 20);
            this.KafkaGet_btn.Name = "KafkaGet_btn";
            this.KafkaGet_btn.Size = new System.Drawing.Size(75, 23);
            this.KafkaGet_btn.TabIndex = 0;
            this.KafkaGet_btn.Text = "Receiver";
            this.KafkaGet_btn.UseVisualStyleBackColor = true;
            this.KafkaGet_btn.Click += new System.EventHandler(this.KafkaGet_btn_Click);
            // 
            // Data2Send_Txt
            // 
            this.Data2Send_Txt.Location = new System.Drawing.Point(8, 85);
            this.Data2Send_Txt.Name = "Data2Send_Txt";
            this.Data2Send_Txt.Size = new System.Drawing.Size(329, 20);
            this.Data2Send_Txt.TabIndex = 1;
            // 
            // listBoxDataReceiver
            // 
            this.listBoxDataReceiver.FormattingEnabled = true;
            this.listBoxDataReceiver.Location = new System.Drawing.Point(13, 105);
            this.listBoxDataReceiver.Name = "listBoxDataReceiver";
            this.listBoxDataReceiver.Size = new System.Drawing.Size(328, 160);
            this.listBoxDataReceiver.TabIndex = 2;
            // 
            // Broker_Producer_Txt
            // 
            this.Broker_Producer_Txt.Location = new System.Drawing.Point(71, 20);
            this.Broker_Producer_Txt.Name = "Broker_Producer_Txt";
            this.Broker_Producer_Txt.Size = new System.Drawing.Size(115, 20);
            this.Broker_Producer_Txt.TabIndex = 1;
            this.Broker_Producer_Txt.Text = "localhost:9092";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broker";
            // 
            // Topic_Producer_Txt
            // 
            this.Topic_Producer_Txt.Location = new System.Drawing.Point(71, 47);
            this.Topic_Producer_Txt.Name = "Topic_Producer_Txt";
            this.Topic_Producer_Txt.Size = new System.Drawing.Size(115, 20);
            this.Topic_Producer_Txt.TabIndex = 1;
            this.Topic_Producer_Txt.Text = "tuanna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Topic";
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(9, 111);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(328, 160);
            this.listBoxLog.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBoxLog);
            this.groupBox1.Controls.Add(this.Topic_Producer_Txt);
            this.groupBox1.Controls.Add(this.Broker_Producer_Txt);
            this.groupBox1.Controls.Add(this.Data2Send_Txt);
            this.groupBox1.Controls.Add(this.Send_Producer_Txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 282);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBoxDataReceiver);
            this.groupBox2.Controls.Add(this.Topic_Consummer_Txt);
            this.groupBox2.Controls.Add(this.KafkaGet_btn);
            this.groupBox2.Controls.Add(this.Broker_Consummer_Txt);
            this.groupBox2.Location = new System.Drawing.Point(390, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 282);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consummer";
            // 
            // Broker_Consummer_Txt
            // 
            this.Broker_Consummer_Txt.Location = new System.Drawing.Point(74, 20);
            this.Broker_Consummer_Txt.Name = "Broker_Consummer_Txt";
            this.Broker_Consummer_Txt.Size = new System.Drawing.Size(115, 20);
            this.Broker_Consummer_Txt.TabIndex = 1;
            this.Broker_Consummer_Txt.Text = "localhost:9092";
            // 
            // Topic_Consummer_Txt
            // 
            this.Topic_Consummer_Txt.Location = new System.Drawing.Point(74, 47);
            this.Topic_Consummer_Txt.Name = "Topic_Consummer_Txt";
            this.Topic_Consummer_Txt.Size = new System.Drawing.Size(115, 20);
            this.Topic_Consummer_Txt.TabIndex = 1;
            this.Topic_Consummer_Txt.Text = "tuanna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Broker";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Topic";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.Download_Btn);
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.BtnLoad);
            this.Name = "MainForm";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.Button Download_Btn;
        private System.Windows.Forms.Button Send_Producer_Txt;
        private System.Windows.Forms.Button KafkaGet_btn;
        private System.Windows.Forms.TextBox Data2Send_Txt;
        private System.Windows.Forms.ListBox listBoxDataReceiver;
        private System.Windows.Forms.TextBox Broker_Producer_Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Topic_Producer_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Topic_Consummer_Txt;
        private System.Windows.Forms.TextBox Broker_Consummer_Txt;
    }
}

