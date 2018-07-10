namespace EmailSend
{
    partial class Form1
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReject = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSmpt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmailPassowrd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmailSender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Settings.SuspendLayout();
            this.Message.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAccept.Location = new System.Drawing.Point(24, 183);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(150, 40);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Send Acceptance";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAccept_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTime,
            this.Sender,
            this.Subject,
            this.Body});
            this.dataGridView1.Location = new System.Drawing.Point(12, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Red;
            this.btnReject.Location = new System.Drawing.Point(24, 229);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(150, 40);
            this.btnReject.TabIndex = 7;
            this.btnReject.Text = "Send Rejection";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnReject_MouseClick);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.btnSend);
            this.Settings.Controls.Add(this.btnAccept);
            this.Settings.Controls.Add(this.btnReject);
            this.Settings.Controls.Add(this.chkSSL);
            this.Settings.Controls.Add(this.txtPort);
            this.Settings.Controls.Add(this.label8);
            this.Settings.Controls.Add(this.txtSmpt);
            this.Settings.Controls.Add(this.label7);
            this.Settings.Controls.Add(this.txtEmailPassowrd);
            this.Settings.Controls.Add(this.label6);
            this.Settings.Controls.Add(this.txtEmailSender);
            this.Settings.Controls.Add(this.label5);
            this.Settings.Location = new System.Drawing.Point(608, 13);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(519, 280);
            this.Settings.TabIndex = 0;
            this.Settings.TabStop = false;
            this.Settings.Text = "Settings";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(347, 183);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(150, 40);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSend_MouseClick);
            // 
            // chkSSL
            // 
            this.chkSSL.Location = new System.Drawing.Point(347, 139);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(150, 30);
            this.chkSSL.TabIndex = 4;
            this.chkSSL.Text = "SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(147, 139);
            this.txtPort.Multiline = true;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(150, 30);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "587";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(21, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 30);
            this.label8.TabIndex = 11;
            this.label8.Text = "Port";
            // 
            // txtSmpt
            // 
            this.txtSmpt.Location = new System.Drawing.Point(147, 103);
            this.txtSmpt.Multiline = true;
            this.txtSmpt.Name = "txtSmpt";
            this.txtSmpt.Size = new System.Drawing.Size(350, 30);
            this.txtSmpt.TabIndex = 2;
            this.txtSmpt.Text = "smtp.gmail.com";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(21, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Smtp";
            // 
            // txtEmailPassowrd
            // 
            this.txtEmailPassowrd.Location = new System.Drawing.Point(147, 67);
            this.txtEmailPassowrd.Multiline = true;
            this.txtEmailPassowrd.Name = "txtEmailPassowrd";
            this.txtEmailPassowrd.PasswordChar = '*';
            this.txtEmailPassowrd.Size = new System.Drawing.Size(350, 30);
            this.txtEmailPassowrd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(21, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sender Email";
            // 
            // txtEmailSender
            // 
            this.txtEmailSender.Location = new System.Drawing.Point(147, 31);
            this.txtEmailSender.Multiline = true;
            this.txtEmailSender.Name = "txtEmailSender";
            this.txtEmailSender.Size = new System.Drawing.Size(350, 30);
            this.txtEmailSender.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(21, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // Message
            // 
            this.Message.Controls.Add(this.label10);
            this.Message.Controls.Add(this.txtCC);
            this.Message.Controls.Add(this.txtSubject);
            this.Message.Controls.Add(this.label9);
            this.Message.Controls.Add(this.txtName);
            this.Message.Controls.Add(this.txtID);
            this.Message.Controls.Add(this.txtMessage);
            this.Message.Controls.Add(this.txtTo);
            this.Message.Controls.Add(this.label2);
            this.Message.Controls.Add(this.label1);
            this.Message.Controls.Add(this.label4);
            this.Message.Controls.Add(this.label3);
            this.Message.Location = new System.Drawing.Point(12, 13);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(590, 280);
            this.Message.TabIndex = 0;
            this.Message.TabStop = false;
            this.Message.Text = "Message";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(18, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "CC";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(144, 64);
            this.txtCC.Multiline = true;
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(415, 30);
            this.txtCC.TabIndex = 1;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(144, 100);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(415, 30);
            this.txtSubject.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(18, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "To";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 172);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(415, 30);
            this.txtName.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(144, 136);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(415, 30);
            this.txtID.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(144, 208);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(415, 60);
            this.txtMessage.TabIndex = 5;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(144, 28);
            this.txtTo.Multiline = true;
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(415, 30);
            this.txtTo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Emp Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emp ID";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Message";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject";
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "Date";
            this.DateTime.HeaderText = "DateTime";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // Sender
            // 
            this.Sender.DataPropertyName = "Sender";
            this.Sender.HeaderText = "Sender";
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // Body
            // 
            this.Body.DataPropertyName = "Body";
            this.Body.HeaderText = "Body";
            this.Body.Name = "Body";
            this.Body.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 687);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.Message.ResumeLayout(false);
            this.Message.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.TextBox txtEmailPassowrd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmailSender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSmpt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox Message;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkSSL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Body;
    }
}

