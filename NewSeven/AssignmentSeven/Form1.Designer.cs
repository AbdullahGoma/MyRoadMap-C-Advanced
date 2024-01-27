namespace AssignmentSeven
{
    partial class Converter
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
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.radioButtonKilometer = new System.Windows.Forms.RadioButton();
            this.radioButtonMile = new System.Windows.Forms.RadioButton();
            this.radioButtonMeter = new System.Windows.Forms.RadioButton();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.ChooseUnit = new System.Windows.Forms.Label();
            this.Value = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxValue
            // 
            this.textBoxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValue.Location = new System.Drawing.Point(331, 187);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(565, 61);
            this.textBoxValue.TabIndex = 1;
            this.textBoxValue.TextChanged += new System.EventHandler(this.textBoxValue_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.Location = new System.Drawing.Point(331, 412);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(565, 61);
            this.textBoxResult.TabIndex = 2;
            // 
            // radioButtonKilometer
            // 
            this.radioButtonKilometer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonKilometer.AutoSize = true;
            this.radioButtonKilometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKilometer.Location = new System.Drawing.Point(1004, 190);
            this.radioButtonKilometer.Name = "radioButtonKilometer";
            this.radioButtonKilometer.Size = new System.Drawing.Size(440, 58);
            this.radioButtonKilometer.TabIndex = 3;
            this.radioButtonKilometer.TabStop = true;
            this.radioButtonKilometer.Text = "Meter to Kilometer";
            this.radioButtonKilometer.UseVisualStyleBackColor = true;
            // 
            // radioButtonMile
            // 
            this.radioButtonMile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonMile.AutoSize = true;
            this.radioButtonMile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMile.Location = new System.Drawing.Point(1004, 307);
            this.radioButtonMile.Name = "radioButtonMile";
            this.radioButtonMile.Size = new System.Drawing.Size(328, 58);
            this.radioButtonMile.TabIndex = 4;
            this.radioButtonMile.TabStop = true;
            this.radioButtonMile.Text = "Meter to Mile";
            this.radioButtonMile.UseVisualStyleBackColor = true;
            // 
            // radioButtonMeter
            // 
            this.radioButtonMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonMeter.AutoSize = true;
            this.radioButtonMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMeter.Location = new System.Drawing.Point(1004, 415);
            this.radioButtonMeter.Name = "radioButtonMeter";
            this.radioButtonMeter.Size = new System.Drawing.Size(328, 58);
            this.radioButtonMeter.TabIndex = 5;
            this.radioButtonMeter.TabStop = true;
            this.radioButtonMeter.Text = "Mile to Meter";
            this.radioButtonMeter.UseVisualStyleBackColor = true;
            // 
            // buttonConverter
            // 
            this.buttonConverter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConverter.Location = new System.Drawing.Point(331, 609);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(404, 103);
            this.buttonConverter.TabIndex = 6;
            this.buttonConverter.Text = "Convert";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // ChooseUnit
            // 
            this.ChooseUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseUnit.AutoSize = true;
            this.ChooseUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseUnit.Location = new System.Drawing.Point(1084, 97);
            this.ChooseUnit.Name = "ChooseUnit";
            this.ChooseUnit.Size = new System.Drawing.Size(311, 58);
            this.ChooseUnit.TabIndex = 7;
            this.ChooseUnit.Text = "Choose Unit";
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.Location = new System.Drawing.Point(88, 190);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(161, 54);
            this.Value.TabIndex = 8;
            this.Value.Text = "Value:";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(61, 401);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(188, 58);
            this.Result.TabIndex = 9;
            this.Result.Text = "Result:";
            // 
            // Reset
            // 
            this.Reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(1042, 609);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(402, 103);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1735, 837);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.ChooseUnit);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.radioButtonMeter);
            this.Controls.Add(this.radioButtonMile);
            this.Controls.Add(this.radioButtonKilometer);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxValue);
            this.Name = "Converter";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.RadioButton radioButtonKilometer;
        private System.Windows.Forms.RadioButton radioButtonMile;
        private System.Windows.Forms.RadioButton radioButtonMeter;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.Label ChooseUnit;
        private System.Windows.Forms.Label Value;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Reset;
    }
}

