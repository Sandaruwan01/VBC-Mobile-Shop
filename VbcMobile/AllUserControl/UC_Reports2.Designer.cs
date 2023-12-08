namespace VbcMobile.AllUserControl
{
    partial class UC_Reports2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Reports2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lb = new System.Windows.Forms.Label();
            this.ReportDG = new System.Windows.Forms.DataGridView();
            this.btnGo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtTo3 = new System.Windows.Forms.DateTimePicker();
            this.dtFrom3 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnGo2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo4 = new System.Windows.Forms.DateTimePicker();
            this.dtFrom4 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ReportDG2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDG2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "REPORTS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb.Location = new System.Drawing.Point(290, 57);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(165, 33);
            this.lb.TabIndex = 37;
            this.lb.Text = "Top Sellings";
            // 
            // ReportDG
            // 
            this.ReportDG.AllowUserToAddRows = false;
            this.ReportDG.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReportDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ReportDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportDG.DefaultCellStyle = dataGridViewCellStyle4;
            this.ReportDG.EnableHeadersVisualStyles = false;
            this.ReportDG.Location = new System.Drawing.Point(105, 140);
            this.ReportDG.Name = "ReportDG";
            this.ReportDG.ReadOnly = true;
            this.ReportDG.RowHeadersVisible = false;
            this.ReportDG.RowHeadersWidth = 51;
            this.ReportDG.RowTemplate.Height = 24;
            this.ReportDG.Size = new System.Drawing.Size(537, 169);
            this.ReportDG.TabIndex = 38;
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Teal;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGo.Location = new System.Drawing.Point(544, 94);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(98, 29);
            this.btnGo.TabIndex = 44;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(222, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "To";
            // 
            // dtTo3
            // 
            this.dtTo3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo3.Location = new System.Drawing.Point(265, 94);
            this.dtTo3.Name = "dtTo3";
            this.dtTo3.Size = new System.Drawing.Size(98, 30);
            this.dtTo3.TabIndex = 41;
            // 
            // dtFrom3
            // 
            this.dtFrom3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom3.Location = new System.Drawing.Point(105, 94);
            this.dtFrom3.Name = "dtFrom3";
            this.dtFrom3.Size = new System.Drawing.Size(98, 30);
            this.dtFrom3.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(30, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Filter By";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Back Cover",
            "Charger",
            "Head Set",
            "New Phone",
            "Power Bank",
            "Other",
            "Specker",
            "Temperd Glass"});
            this.comboBox1.Location = new System.Drawing.Point(388, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.Text = "Select Item";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "All"});
            this.comboBox2.Location = new System.Drawing.Point(388, 376);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 52;
            this.comboBox2.Text = "Select Item";
            // 
            // btnGo2
            // 
            this.btnGo2.BackColor = System.Drawing.Color.Teal;
            this.btnGo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo2.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGo2.Location = new System.Drawing.Point(544, 377);
            this.btnGo2.Name = "btnGo2";
            this.btnGo2.Size = new System.Drawing.Size(98, 29);
            this.btnGo2.TabIndex = 51;
            this.btnGo2.Text = "Go";
            this.btnGo2.UseVisualStyleBackColor = false;
            this.btnGo2.Click += new System.EventHandler(this.btnGo2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(222, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "To";
            // 
            // dtTo4
            // 
            this.dtTo4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTo4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo4.Location = new System.Drawing.Point(265, 377);
            this.dtTo4.Name = "dtTo4";
            this.dtTo4.Size = new System.Drawing.Size(98, 30);
            this.dtTo4.TabIndex = 49;
            // 
            // dtFrom4
            // 
            this.dtFrom4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFrom4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom4.Location = new System.Drawing.Point(105, 377);
            this.dtFrom4.Name = "dtFrom4";
            this.dtFrom4.Size = new System.Drawing.Size(98, 30);
            this.dtFrom4.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Filter By";
            // 
            // ReportDG2
            // 
            this.ReportDG2.AllowUserToAddRows = false;
            this.ReportDG2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReportDG2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReportDG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportDG2.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReportDG2.EnableHeadersVisualStyles = false;
            this.ReportDG2.Location = new System.Drawing.Point(105, 423);
            this.ReportDG2.Name = "ReportDG2";
            this.ReportDG2.ReadOnly = true;
            this.ReportDG2.RowHeadersVisible = false;
            this.ReportDG2.RowHeadersWidth = 51;
            this.ReportDG2.RowTemplate.Height = 24;
            this.ReportDG2.Size = new System.Drawing.Size(537, 169);
            this.ReportDG2.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(290, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 33);
            this.label4.TabIndex = 53;
            this.label4.Text = "Repairings";
            // 
            // UC_Reports2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnGo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTo4);
            this.Controls.Add(this.dtFrom4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReportDG2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtTo3);
            this.Controls.Add(this.dtFrom3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ReportDG);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label1);
            this.Name = "UC_Reports2";
            this.Size = new System.Drawing.Size(856, 602);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDG2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.DataGridView ReportDG;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtTo3;
        private System.Windows.Forms.DateTimePicker dtFrom3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnGo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo4;
        private System.Windows.Forms.DateTimePicker dtFrom4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ReportDG2;
    }
}
