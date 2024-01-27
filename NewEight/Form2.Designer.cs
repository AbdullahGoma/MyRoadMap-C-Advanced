namespace NewEight
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.numericH = new System.Windows.Forms.NumericUpDown();
            this.numericW = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(846, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(1477, 36);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(302, 93);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(412, 91);
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(194, 38);
            this.numericX.TabIndex = 2;
            // 
            // numericH
            // 
            this.numericH.Location = new System.Drawing.Point(945, 91);
            this.numericH.Name = "numericH";
            this.numericH.Size = new System.Drawing.Size(194, 38);
            this.numericH.TabIndex = 3;
            // 
            // numericW
            // 
            this.numericW.Location = new System.Drawing.Point(1195, 91);
            this.numericW.Name = "numericW";
            this.numericW.Size = new System.Drawing.Size(194, 38);
            this.numericW.TabIndex = 4;
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(662, 91);
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(203, 38);
            this.numericY.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1963, 960);
            this.Controls.Add(this.numericY);
            this.Controls.Add(this.numericW);
            this.Controls.Add(this.numericH);
            this.Controls.Add(this.numericX);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.NumericUpDown numericH;
        private System.Windows.Forms.NumericUpDown numericW;
        private System.Windows.Forms.NumericUpDown numericY;
    }
}