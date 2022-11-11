﻿namespace RabbitMQClient
{
    partial class RabbitMQClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RabbitMQClient));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQueue = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPayload = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExchange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogs = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clrLogs = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtVirtualhostname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RabbitMQClient.Properties.Resources.RabbitMQ_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(673, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 46);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtVirtualhostname);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtQueue);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.btnRead);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPayload);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtExchange);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtHostname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(335, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 367);
            this.panel1.TabIndex = 1;
            // 
            // txtQueue
            // 
            this.txtQueue.Location = new System.Drawing.Point(724, 114);
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.Size = new System.Drawing.Size(352, 31);
            this.txtQueue.TabIndex = 11;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(729, 328);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 34);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Publish";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(858, 328);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(112, 34);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Consume";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Queue";
            // 
            // txtPayload
            // 
            this.txtPayload.Location = new System.Drawing.Point(184, 153);
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.Size = new System.Drawing.Size(892, 169);
            this.txtPayload.TabIndex = 9;
            this.txtPayload.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Payload";
            // 
            // txtExchange
            // 
            this.txtExchange.Location = new System.Drawing.Point(723, 63);
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.Size = new System.Drawing.Size(353, 31);
            this.txtExchange.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Exchange";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(184, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(352, 31);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(183, 57);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(353, 31);
            this.txtUsername.TabIndex = 4;
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(183, 8);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(353, 31);
            this.txtHostname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hostname";
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(17, 30);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.Size = new System.Drawing.Size(1396, 353);
            this.txtLogs.TabIndex = 8;
            this.txtLogs.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLogs);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(185, 447);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1437, 389);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity Logs";
            // 
            // clrLogs
            // 
            this.clrLogs.BackColor = System.Drawing.Color.Transparent;
            this.clrLogs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clrLogs.BackgroundImage")));
            this.clrLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clrLogs.FlatAppearance.BorderSize = 0;
            this.clrLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrLogs.Location = new System.Drawing.Point(1604, 447);
            this.clrLogs.Name = "clrLogs";
            this.clrLogs.Size = new System.Drawing.Size(39, 49);
            this.clrLogs.TabIndex = 10;
            this.clrLogs.UseVisualStyleBackColor = false;
            this.clrLogs.Click += new System.EventHandler(this.clrLogs_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Virtual Host";
            // 
            // txtVirtualhostname
            // 
            this.txtVirtualhostname.Location = new System.Drawing.Point(723, 11);
            this.txtVirtualhostname.Name = "txtVirtualhostname";
            this.txtVirtualhostname.Size = new System.Drawing.Size(353, 31);
            this.txtVirtualhostname.TabIndex = 13;
            // 
            // RabbitMQClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 845);
            this.Controls.Add(this.clrLogs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RabbitMQClient";
            this.Text = "RabbitMQClientApp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnConnect;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtHostname;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtExchange;
        private Label label4;
        private RichTextBox txtPayload;
        private Label label5;
        private Button btnRead;
        private RichTextBox txtLogs;
        private TextBox txtQueue;
        private Label label6;
        private GroupBox groupBox1;
        private Button clrLogs;
        private TextBox txtVirtualhostname;
        private Label label7;
        private ImageList imageList1;
    }
}