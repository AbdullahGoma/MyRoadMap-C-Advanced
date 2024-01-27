namespace ChatServer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtRecievedMsgs = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsgs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(1143, 130);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtRecievedMsgs
            // 
            this.txtRecievedMsgs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRecievedMsgs.Location = new System.Drawing.Point(69, 150);
            this.txtRecievedMsgs.Multiline = true;
            this.txtRecievedMsgs.Name = "txtRecievedMsgs";
            this.txtRecievedMsgs.ReadOnly = true;
            this.txtRecievedMsgs.Size = new System.Drawing.Size(722, 477);
            this.txtRecievedMsgs.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(885, 689);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(212, 123);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsgs
            // 
            this.txtMsgs.Location = new System.Drawing.Point(69, 642);
            this.txtMsgs.Multiline = true;
            this.txtMsgs.Name = "txtMsgs";
            this.txtMsgs.Size = new System.Drawing.Size(722, 188);
            this.txtMsgs.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 859);
            this.Controls.Add(this.txtRecievedMsgs);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsgs);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Chat Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtRecievedMsgs;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMsgs;
    }
}

