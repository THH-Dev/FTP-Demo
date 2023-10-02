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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Topic_Consummer_Txt = new System.Windows.Forms.TextBox();
            this.Broker_Consummer_Txt = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(9, 19);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 0;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(90, 20);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(620, 20);
            this.txtPath.TabIndex = 1;
            // 
            // BtnUpload
            // 
            this.BtnUpload.Location = new System.Drawing.Point(9, 48);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(75, 23);
            this.BtnUpload.TabIndex = 0;
            this.BtnUpload.Text = "Upload";
            this.BtnUpload.UseVisualStyleBackColor = true;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // Download_Btn
            // 
            this.Download_Btn.Location = new System.Drawing.Point(9, 76);
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
            this.groupBox1.Location = new System.Drawing.Point(6, 272);
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
            this.groupBox2.Location = new System.Drawing.Point(384, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 282);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consummer";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Broker";
            // 
            // Topic_Consummer_Txt
            // 
            this.Topic_Consummer_Txt.Location = new System.Drawing.Point(74, 47);
            this.Topic_Consummer_Txt.Name = "Topic_Consummer_Txt";
            this.Topic_Consummer_Txt.Size = new System.Drawing.Size(115, 20);
            this.Topic_Consummer_Txt.TabIndex = 1;
            this.Topic_Consummer_Txt.Text = "tuanna";
            // 
            // Broker_Consummer_Txt
            // 
            this.Broker_Consummer_Txt.Location = new System.Drawing.Point(74, 20);
            this.Broker_Consummer_Txt.Name = "Broker_Consummer_Txt";
            this.Broker_Consummer_Txt.Size = new System.Drawing.Size(115, 20);
            this.Broker_Consummer_Txt.TabIndex = 1;
            this.Broker_Consummer_Txt.Text = "localhost:9092";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(74, 16);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(115, 20);
            this.txtServer.TabIndex = 1;
            this.txtServer.Text = "192.168.100.124";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(74, 43);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(69, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "thh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "User";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnSet);
            this.groupBox3.Controls.Add(this.txtPass);
            this.groupBox3.Controls.Add(this.txtUserName);
            this.groupBox3.Controls.Add(this.txtDir);
            this.groupBox3.Controls.Add(this.txtServer);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(724, 73);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FTP Server";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(598, 16);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(115, 20);
            this.txtDir.TabIndex = 1;
            this.txtDir.Text = "robot";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(192, 43);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(69, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "thh@2023";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "FTP Dir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Pass";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(638, 40);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "KAFKA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPath);
            this.groupBox4.Controls.Add(this.BtnLoad);
            this.groupBox4.Controls.Add(this.BtnUpload);
            this.groupBox4.Controls.Add(this.Download_Btn);
            this.groupBox4.Location = new System.Drawing.Point(15, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(721, 110);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Test FTP";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 565);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

