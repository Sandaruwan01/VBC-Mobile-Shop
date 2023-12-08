namespace VbcMobile.AllUserControl
{
    partial class UC_Sold
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Sold));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTOSET = new System.Windows.Forms.Label();
            this.txtSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SoldDataGrid = new System.Windows.Forms.DataGridView();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vbcbaseDataSet3 = new VbcMobile.vbcbaseDataSet3();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.combSelect = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.soldTableAdapter = new VbcMobile.vbcbaseDataSet3TableAdapters.soldTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SoldDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vbcbaseDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sold Items";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(365, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search By";
            // 
            // labelTOSET
            // 
            this.labelTOSET.AutoSize = true;
            this.labelTOSET.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTOSET.ForeColor = System.Drawing.Color.White;
            this.labelTOSET.Location = new System.Drawing.Point(324, 82);
            this.labelTOSET.Name = "labelTOSET";
            this.labelTOSET.Size = new System.Drawing.Size(0, 24);
            this.labelTOSET.TabIndex = 4;
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSearchBy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBy.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBy.ForeColor = System.Drawing.Color.White;
            this.txtSearchBy.ItemHeight = 30;
            this.txtSearchBy.Items.AddRange(new object[] {
            "Customer Name",
            "Phone Number"});
            this.txtSearchBy.Location = new System.Drawing.Point(465, 45);
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(197, 36);
            this.txtSearchBy.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchBy.TabIndex = 5;
            this.txtSearchBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchBy.SelectedIndexChanged += new System.EventHandler(this.txtSearchBy_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(466, 82);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(196, 22);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnSearch
            // 
            this.btnSearch.CheckedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnSearch.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearch.ImageRotate = 0F;
            this.btnSearch.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearch.Location = new System.Drawing.Point(679, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSearch.Size = new System.Drawing.Size(56, 33);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(662, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Sellings";
            // 
            // SoldDataGrid
            // 
            this.SoldDataGrid.AllowUserToAddRows = false;
            this.SoldDataGrid.AllowUserToDeleteRows = false;
            this.SoldDataGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SoldDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SoldDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoldDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.cusnameDataGridViewTextBoxColumn,
            this.cuphoneDataGridViewTextBoxColumn,
            this.cuaddressDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modleDataGridViewTextBoxColumn,
            this.modnumDataGridViewTextBoxColumn,
            this.imeiDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.sdateDataGridViewTextBoxColumn,
            this.stimeDataGridViewTextBoxColumn});
            this.SoldDataGrid.DataSource = this.soldBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SoldDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.SoldDataGrid.EnableHeadersVisualStyles = false;
            this.SoldDataGrid.Location = new System.Drawing.Point(10, 123);
            this.SoldDataGrid.Name = "SoldDataGrid";
            this.SoldDataGrid.ReadOnly = true;
            this.SoldDataGrid.RowHeadersVisible = false;
            this.SoldDataGrid.RowHeadersWidth = 51;
            this.SoldDataGrid.RowTemplate.Height = 24;
            this.SoldDataGrid.Size = new System.Drawing.Size(878, 318);
            this.SoldDataGrid.TabIndex = 13;
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
            // cusnameDataGridViewTextBoxColumn
            // 
            this.cusnameDataGridViewTextBoxColumn.DataPropertyName = "cusname";
            this.cusnameDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.cusnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusnameDataGridViewTextBoxColumn.Name = "cusnameDataGridViewTextBoxColumn";
            this.cusnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cuphoneDataGridViewTextBoxColumn
            // 
            this.cuphoneDataGridViewTextBoxColumn.DataPropertyName = "cuphone";
            this.cuphoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.cuphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cuphoneDataGridViewTextBoxColumn.Name = "cuphoneDataGridViewTextBoxColumn";
            this.cuphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuphoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // cuaddressDataGridViewTextBoxColumn
            // 
            this.cuaddressDataGridViewTextBoxColumn.DataPropertyName = "cuaddress";
            this.cuaddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.cuaddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cuaddressDataGridViewTextBoxColumn.Name = "cuaddressDataGridViewTextBoxColumn";
            this.cuaddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuaddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // modleDataGridViewTextBoxColumn
            // 
            this.modleDataGridViewTextBoxColumn.DataPropertyName = "modle";
            this.modleDataGridViewTextBoxColumn.HeaderText = "Modle";
            this.modleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modleDataGridViewTextBoxColumn.Name = "modleDataGridViewTextBoxColumn";
            this.modleDataGridViewTextBoxColumn.ReadOnly = true;
            this.modleDataGridViewTextBoxColumn.Width = 125;
            // 
            // modnumDataGridViewTextBoxColumn
            // 
            this.modnumDataGridViewTextBoxColumn.DataPropertyName = "modnum";
            this.modnumDataGridViewTextBoxColumn.HeaderText = "Mod No.";
            this.modnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modnumDataGridViewTextBoxColumn.Name = "modnumDataGridViewTextBoxColumn";
            this.modnumDataGridViewTextBoxColumn.ReadOnly = true;
            this.modnumDataGridViewTextBoxColumn.Width = 125;
            // 
            // imeiDataGridViewTextBoxColumn
            // 
            this.imeiDataGridViewTextBoxColumn.DataPropertyName = "imei";
            this.imeiDataGridViewTextBoxColumn.HeaderText = "Imei";
            this.imeiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeiDataGridViewTextBoxColumn.Name = "imeiDataGridViewTextBoxColumn";
            this.imeiDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeiDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // sdateDataGridViewTextBoxColumn
            // 
            this.sdateDataGridViewTextBoxColumn.DataPropertyName = "sdate";
            this.sdateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.sdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sdateDataGridViewTextBoxColumn.Name = "sdateDataGridViewTextBoxColumn";
            this.sdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.sdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // stimeDataGridViewTextBoxColumn
            // 
            this.stimeDataGridViewTextBoxColumn.DataPropertyName = "stime";
            this.stimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.stimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stimeDataGridViewTextBoxColumn.Name = "stimeDataGridViewTextBoxColumn";
            this.stimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.stimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // soldBindingSource
            // 
            this.soldBindingSource.DataMember = "sold";
            this.soldBindingSource.DataSource = this.vbcbaseDataSet3;
            // 
            // vbcbaseDataSet3
            // 
            this.vbcbaseDataSet3.DataSetName = "vbcbaseDataSet3";
            this.vbcbaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotal.Location = new System.Drawing.Point(630, 544);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(260, 35);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "...................................";
            this.lblTotal.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(162, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Filter By";
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(237, 529);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(87, 22);
            this.dtFrom.TabIndex = 19;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(369, 531);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(91, 22);
            this.dtTo.TabIndex = 20;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(335, 531);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "To";
            // 
            // combSelect
            // 
            this.combSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combSelect.FormattingEnabled = true;
            this.combSelect.Items.AddRange(new object[] {
            "All",
            "Period"});
            this.combSelect.Location = new System.Drawing.Point(466, 531);
            this.combSelect.Name = "combSelect";
            this.combSelect.Size = new System.Drawing.Size(98, 24);
            this.combSelect.TabIndex = 23;
            this.combSelect.Tag = "";
            this.combSelect.Text = "Select";
            this.combSelect.SelectedIndexChanged += new System.EventHandler(this.combSelect_SelectedIndexChanged);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Teal;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGo.Location = new System.Drawing.Point(466, 564);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(98, 26);
            this.btnGo.TabIndex = 24;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(594, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 27);
            this.label3.TabIndex = 25;
            this.label3.Text = "According To Mentioned Period";
            // 
            // soldTableAdapter
            // 
            this.soldTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Sold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.combSelect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SoldDataGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtSearchBy);
            this.Controls.Add(this.labelTOSET);
            this.Controls.Add(this.label1);
            this.Name = "UC_Sold";
            this.Size = new System.Drawing.Size(856, 602);
            ((System.ComponentModel.ISupportInitialize)(this.SoldDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vbcbaseDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTOSET;
        private Guna.UI2.WinForms.Guna2ComboBox txtSearchBy;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView SoldDataGrid;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox combSelect;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource soldBindingSource;
        private vbcbaseDataSet3 vbcbaseDataSet3;
        private vbcbaseDataSet3TableAdapters.soldTableAdapter soldTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stimeDataGridViewTextBoxColumn;
    }
}
