namespace NewEight
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
            this.lblContinent = new System.Windows.Forms.Label();
            this.cmbContinents = new System.Windows.Forms.ComboBox();
            this.btnContinent = new System.Windows.Forms.Button();
            this.lstBxCountries = new System.Windows.Forms.ListBox();
            this.btnCountries = new System.Windows.Forms.Button();
            this.lblCountries = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContinent
            // 
            this.lblContinent.AutoSize = true;
            this.lblContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContinent.Location = new System.Drawing.Point(430, 30);
            this.lblContinent.Name = "lblContinent";
            this.lblContinent.Size = new System.Drawing.Size(147, 54);
            this.lblContinent.TabIndex = 0;
            this.lblContinent.Text = "label1";
            // 
            // cmbContinents
            // 
            this.cmbContinents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContinents.FormattingEnabled = true;
            this.cmbContinents.Location = new System.Drawing.Point(31, 45);
            this.cmbContinents.Name = "cmbContinents";
            this.cmbContinents.Size = new System.Drawing.Size(334, 39);
            this.cmbContinents.TabIndex = 1;
            this.cmbContinents.SelectedIndexChanged += new System.EventHandler(this.cmbContinents_SelectedIndexChanged);
            // 
            // btnContinent
            // 
            this.btnContinent.Location = new System.Drawing.Point(949, 339);
            this.btnContinent.Name = "btnContinent";
            this.btnContinent.Size = new System.Drawing.Size(253, 71);
            this.btnContinent.TabIndex = 2;
            this.btnContinent.Text = "Continent";
            this.btnContinent.UseVisualStyleBackColor = true;
            this.btnContinent.Click += new System.EventHandler(this.btnContinents_Click);
            // 
            // lstBxCountries
            // 
            this.lstBxCountries.FormattingEnabled = true;
            this.lstBxCountries.ItemHeight = 31;
            this.lstBxCountries.Location = new System.Drawing.Point(3, 104);
            this.lstBxCountries.Name = "lstBxCountries";
            this.lstBxCountries.Size = new System.Drawing.Size(409, 283);
            this.lstBxCountries.TabIndex = 3;
            this.lstBxCountries.SelectedIndexChanged += new System.EventHandler(this.lstBxCountries_SelectedIndexChanged);
            // 
            // btnCountries
            // 
            this.btnCountries.Location = new System.Drawing.Point(888, 526);
            this.btnCountries.Name = "btnCountries";
            this.btnCountries.Size = new System.Drawing.Size(314, 89);
            this.btnCountries.TabIndex = 4;
            this.btnCountries.Text = "Countries";
            this.btnCountries.UseVisualStyleBackColor = true;
            this.btnCountries.Click += new System.EventHandler(this.btnCountries_Click);
            // 
            // lblCountries
            // 
            this.lblCountries.AutoSize = true;
            this.lblCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountries.Location = new System.Drawing.Point(975, 216);
            this.lblCountries.Name = "lblCountries";
            this.lblCountries.Size = new System.Drawing.Size(147, 54);
            this.lblCountries.TabIndex = 5;
            this.lblCountries.Text = "label1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Egypt",
            "Libya",
            "Sudan"});
            this.checkedListBox1.Location = new System.Drawing.Point(32, 492);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(349, 284);
            this.checkedListBox1.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(590, 354);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 214;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 262;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Population";
            this.columnHeader3.Width = 270;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(380, 321);
            this.dataGridView1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbContinents);
            this.panel1.Controls.Add(this.lblContinent);
            this.panel1.Controls.Add(this.lstBxCountries);
            this.panel1.Location = new System.Drawing.Point(1889, 563);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 390);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.checkedListBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 1192);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 354);
            this.panel3.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(6, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 409);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "hELLO";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1237, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 572);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(626, 514);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1965, 372);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(433, 38);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2649, 1192);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCountries);
            this.Controls.Add(this.btnContinent);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCountries);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContinent;
        private System.Windows.Forms.ComboBox cmbContinents;
        private System.Windows.Forms.Button btnContinent;
        private System.Windows.Forms.ListBox lstBxCountries;
        private System.Windows.Forms.Button btnCountries;
        private System.Windows.Forms.Label lblCountries;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

