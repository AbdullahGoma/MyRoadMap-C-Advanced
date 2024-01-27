using System;

namespace NewSeven
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnMsg = new System.Windows.Forms.Button();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonYellow = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 115);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Here";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnMsg
            // 
            this.btnMsg.Location = new System.Drawing.Point(431, 172);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(282, 119);
            this.btnMsg.TabIndex = 1;
            this.btnMsg.Text = "button2";
            this.btnMsg.UseVisualStyleBackColor = true;
            this.btnMsg.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMsg.Location = new System.Drawing.Point(441, 367);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.PasswordChar = '*';
            this.textBoxMsg.Size = new System.Drawing.Size(673, 61);
            this.textBoxMsg.TabIndex = 3;
            this.textBoxMsg.TextChanged += new System.EventHandler(this.textBoxMsg_TextChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRed.Location = new System.Drawing.Point(695, 494);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(146, 58);
            this.radioButtonRed.TabIndex = 4;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.RadioButtonColors_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGreen.Location = new System.Drawing.Point(695, 556);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(191, 58);
            this.radioButtonGreen.TabIndex = 5;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.RadioButtonColors_CheckedChanged);
            // 
            // radioButtonYellow
            // 
            this.radioButtonYellow.AutoSize = true;
            this.radioButtonYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYellow.Location = new System.Drawing.Point(695, 611);
            this.radioButtonYellow.Name = "radioButtonYellow";
            this.radioButtonYellow.Size = new System.Drawing.Size(163, 58);
            this.radioButtonYellow.TabIndex = 6;
            this.radioButtonYellow.TabStop = true;
            this.radioButtonYellow.Text = "Yello";
            this.radioButtonYellow.UseVisualStyleBackColor = true;
            this.radioButtonYellow.CheckedChanged += new System.EventHandler(this.RadioButtonColors_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1251, 512);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(191, 36);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1251, 577);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(191, 36);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1251, 646);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(191, 36);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(729, 754);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(129, 54);
            this.lblMsg.TabIndex = 10;
            this.lblMsg.Text = "Hello";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1734, 975);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButtonYellow);
            this.Controls.Add(this.radioButtonGreen);
            this.Controls.Add(this.radioButtonRed);
            this.Controls.Add(this.textBoxMsg);
            this.Controls.Add(this.btnMsg);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMsg;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonYellow;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label lblMsg;
    }
}

