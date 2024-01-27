namespace NewNine
{
    partial class Form2
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
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.digitalClock1 = new NewNine.DigitalClock();
            this.colorMixer1 = new NewNine.ColorMixer();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeColor.Location = new System.Drawing.Point(737, 78);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(328, 126);
            this.btnChangeColor.TabIndex = 1;
            this.btnChangeColor.Text = "ChangeColor";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // digitalClock1
            // 
            this.digitalClock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalClock1.Location = new System.Drawing.Point(166, 323);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(491, 193);
            this.digitalClock1.TabIndex = 2;
            this.digitalClock1.Text = "digitalClock1";
            // 
            // colorMixer1
            // 
            this.colorMixer1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colorMixer1.Location = new System.Drawing.Point(1116, 142);
            this.colorMixer1.Name = "colorMixer1";
            this.colorMixer1.Size = new System.Drawing.Size(625, 622);
            this.colorMixer1.TabIndex = 0;
            this.colorMixer1.ColorChanged += new System.EventHandler(this.colorMixer1_ColorChanged);
            this.colorMixer1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorMixer1_MouseMove);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1847, 1082);
            this.Controls.Add(this.digitalClock1);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.colorMixer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private ColorMixer colorMixer1;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Timer timer1;
        private DigitalClock digitalClock1;
        private System.Windows.Forms.Timer timer2;
    }
}