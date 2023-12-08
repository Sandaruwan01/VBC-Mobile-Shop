namespace VbcMobile.AllUserControl
{
    partial class UC_Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Reports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGo2 = new System.Windows.Forms.Button();
            this.combSelect2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtTo2 = new System.Windows.Forms.DateTimePicker();
            this.dtFrom2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgComplete = new System.Windows.Forms.DataGridView();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mname1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnum1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpnum1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completedrepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vbcbaseDataSet6 = new VbcMobile.vbcbaseDataSet6();
            this.completed_repTableAdapter = new VbcMobile.vbcbaseDataSet6TableAdapters.completed_repTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgComplete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedrepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vbcbaseDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "completed Repairings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(478, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "According To Mentioned Period";
            // 
            // btnGo2
            // 
            this.btnGo2.BackColor = System.Drawing.Color.Teal;
            this.btnGo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo2.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGo2.Location = new System.Drawing.Point(350, 550);
            this.btnGo2.Name = "btnGo2";
            this.btnGo2.Size = new System.Drawing.Size(98, 26);
            this.btnGo2.TabIndex = 33;
            this.btnGo2.Text = "Go";
            this.btnGo2.UseVisualStyleBackColor = false;
            this.btnGo2.Click += new System.EventHandler(this.btnGo2_Click);
            // 
            // combSelect2
            // 
            this.combSelect2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combSelect2.FormattingEnabled = true;
            this.combSelect2.Items.AddRange(new object[] {
            "All",
            "Period"});
            this.combSelect2.Location = new System.Drawing.Point(350, 517);
            this.combSelect2.Name = "combSelect2";
            this.combSelect2.Size = new System.Drawing.Size(98, 24);
            this.combSelect2.TabIndex = 32;
            this.combSelect2.Tag = "";
            this.combSelect2.Text = "Select";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(219, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "To";
            // 
            // dtTo2
            // 
            this.dtTo2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo2.Location = new System.Drawing.Point(253, 517);
            this.dtTo2.Name = "dtTo2";
            this.dtTo2.Size = new System.Drawing.Size(91, 22);
            this.dtTo2.TabIndex = 30;
            // 
            // dtFrom2
            // 
            this.dtFrom2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom2.Location = new System.Drawing.Point(121, 515);
            this.dtFrom2.Name = "dtFrom2";
            this.dtFrom2.Size = new System.Drawing.Size(87, 22);
            this.dtFrom2.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Filter By";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotal2.Location = new System.Drawing.Point(514, 530);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(260, 35);
            this.lblTotal2.TabIndex = 27;
            this.lblTotal2.Text = "...................................";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(546, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 27);
            this.label5.TabIndex = 26;
            this.label5.Text = "Total Sellings";
            // 
            // dgComplete
            // 
            this.dgComplete.AllowUserToAddRows = false;
            this.dgComplete.AllowUserToDeleteRows = false;
            this.dgComplete.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgComplete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgComplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComplete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.brand1DataGridViewTextBoxColumn,
            this.mname1DataGridViewTextBoxColumn,
            this.mnum1DataGridViewTextBoxColumn,
            this.cname1DataGridViewTextBoxColumn,
            this.cpnum1DataGridViewTextBoxColumn,
            this.note1DataGridViewTextBoxColumn,
            this.price1DataGridViewTextBoxColumn,
            this.comdateDataGridViewTextBoxColumn,
            this.comtimeDataGridViewTextBoxColumn});
            this.dgComplete.DataSource = this.completedrepBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgComplete.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgComplete.EnableHeadersVisualStyles = false;
            this.dgComplete.Location = new System.Drawing.Point(11, 139);
            this.dgComplete.Name = "dgComplete";
            this.dgComplete.ReadOnly = true;
            this.dgComplete.RowHeadersVisible = false;
            this.dgComplete.RowHeadersWidth = 51;
            this.dgComplete.RowTemplate.Height = 24;
            this.dgComplete.Size = new System.Drawing.Size(878, 318);
            this.dgComplete.TabIndex = 35;
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "cid";
            this.cidDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidDataGridViewTextBoxColumn.Width = 125;
            // 
            // brand1DataGridViewTextBoxColumn
            // 
            this.brand1DataGridViewTextBoxColumn.DataPropertyName = "brand1";
            this.brand1DataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brand1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brand1DataGridViewTextBoxColumn.Name = "brand1DataGridViewTextBoxColumn";
            this.brand1DataGridViewTextBoxColumn.ReadOnly = true;
            this.brand1DataGridViewTextBoxColumn.Width = 125;
            // 
            // mname1DataGridViewTextBoxColumn
            // 
            this.mname1DataGridViewTextBoxColumn.DataPropertyName = "mname1";
            this.mname1DataGridViewTextBoxColumn.HeaderText = "Model";
            this.mname1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mname1DataGridViewTextBoxColumn.Name = "mname1DataGridViewTextBoxColumn";
            this.mname1DataGridViewTextBoxColumn.ReadOnly = true;
            this.mname1DataGridViewTextBoxColumn.Width = 125;
            // 
            // mnum1DataGridViewTextBoxColumn
            // 
            this.mnum1DataGridViewTextBoxColumn.DataPropertyName = "mnum1";
            this.mnum1DataGridViewTextBoxColumn.HeaderText = "Mod No.";
            this.mnum1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mnum1DataGridViewTextBoxColumn.Name = "mnum1DataGridViewTextBoxColumn";
            this.mnum1DataGridViewTextBoxColumn.ReadOnly = true;
            this.mnum1DataGridViewTextBoxColumn.Width = 125;
            // 
            // cname1DataGridViewTextBoxColumn
            // 
            this.cname1DataGridViewTextBoxColumn.DataPropertyName = "cname1";
            this.cname1DataGridViewTextBoxColumn.HeaderText = "Customer";
            this.cname1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cname1DataGridViewTextBoxColumn.Name = "cname1DataGridViewTextBoxColumn";
            this.cname1DataGridViewTextBoxColumn.ReadOnly = true;
            this.cname1DataGridViewTextBoxColumn.Width = 125;
            // 
            // cpnum1DataGridViewTextBoxColumn
            // 
            this.cpnum1DataGridViewTextBoxColumn.DataPropertyName = "cpnum1";
            this.cpnum1DataGridViewTextBoxColumn.HeaderText = "Phone";
            this.cpnum1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpnum1DataGridViewTextBoxColumn.Name = "cpnum1DataGridViewTextBoxColumn";
            this.cpnum1DataGridViewTextBoxColumn.ReadOnly = true;
            this.cpnum1DataGridViewTextBoxColumn.Width = 125;
            // 
            // note1DataGridViewTextBoxColumn
            // 
            this.note1DataGridViewTextBoxColumn.DataPropertyName = "note1";
            this.note1DataGridViewTextBoxColumn.HeaderText = "About Issue";
            this.note1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.note1DataGridViewTextBoxColumn.Name = "note1DataGridViewTextBoxColumn";
            this.note1DataGridViewTextBoxColumn.ReadOnly = true;
            this.note1DataGridViewTextBoxColumn.Width = 125;
            // 
            // price1DataGridViewTextBoxColumn
            // 
            this.price1DataGridViewTextBoxColumn.DataPropertyName = "price1";
            this.price1DataGridViewTextBoxColumn.HeaderText = "Price";
            this.price1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.price1DataGridViewTextBoxColumn.Name = "price1DataGridViewTextBoxColumn";
            this.price1DataGridViewTextBoxColumn.ReadOnly = true;
            this.price1DataGridViewTextBoxColumn.Width = 125;
            // 
            // comdateDataGridViewTextBoxColumn
            // 
            this.comdateDataGridViewTextBoxColumn.DataPropertyName = "comdate";
            this.comdateDataGridViewTextBoxColumn.HeaderText = "Completed Date";
            this.comdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comdateDataGridViewTextBoxColumn.Name = "comdateDataGridViewTextBoxColumn";
            this.comdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.comdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // comtimeDataGridViewTextBoxColumn
            // 
            this.comtimeDataGridViewTextBoxColumn.DataPropertyName = "comtime";
            this.comtimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.comtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comtimeDataGridViewTextBoxColumn.Name = "comtimeDataGridViewTextBoxColumn";
            this.comtimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.comtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // completedrepBindingSource
            // 
            this.completedrepBindingSource.DataMember = "completed_rep";
            this.completedrepBindingSource.DataSource = this.vbcbaseDataSet6;
            // 
            // vbcbaseDataSet6
            // 
            this.vbcbaseDataSet6.DataSetName = "vbcbaseDataSet6";
            this.vbcbaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // completed_repTableAdapter
            // 
            this.completed_repTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.dgComplete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGo2);
            this.Controls.Add(this.combSelect2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtTo2);
            this.Controls.Add(this.dtFrom2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "UC_Reports";
            this.Size = new System.Drawing.Size(856, 602);
            ((System.ComponentModel.ISupportInitialize)(this.dgComplete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedrepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vbcbaseDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGo2;
        private System.Windows.Forms.ComboBox combSelect2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtTo2;
        private System.Windows.Forms.DateTimePicker dtFrom2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mname1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnum1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpnum1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn note1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource completedrepBindingSource;
        private vbcbaseDataSet6 vbcbaseDataSet6;
        private vbcbaseDataSet6TableAdapters.completed_repTableAdapter completed_repTableAdapter;
    }
}
