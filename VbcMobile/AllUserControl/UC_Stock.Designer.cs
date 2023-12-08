namespace VbcMobile.AllUserControl
{
    partial class UC_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Stock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtSearchBy1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTOSET1 = new System.Windows.Forms.Label();
            this.txtSearch1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.lblModNum = new System.Windows.Forms.Label();
            this.lblModName = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.TextBox();
            this.DataArray = new Guna.UI2.WinForms.Guna2DataGridView();
            this.midDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vbcbaseDataSet5 = new VbcMobile.vbcbaseDataSet5();
            this.addItemTableAdapter = new VbcMobile.vbcbaseDataSet5TableAdapters.addItemTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vbcbaseDataSet5)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(268, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "VBC Stock";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtSearchBy1
            // 
            this.txtSearchBy1.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchBy1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtSearchBy1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSearchBy1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchBy1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBy1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBy1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBy1.ForeColor = System.Drawing.Color.White;
            this.txtSearchBy1.ItemHeight = 30;
            this.txtSearchBy1.Items.AddRange(new object[] {
            "Item",
            "Brand"});
            this.txtSearchBy1.Location = new System.Drawing.Point(489, 52);
            this.txtSearchBy1.Name = "txtSearchBy1";
            this.txtSearchBy1.Size = new System.Drawing.Size(207, 36);
            this.txtSearchBy1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchBy1.TabIndex = 25;
            this.txtSearchBy1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchBy1.SelectedIndexChanged += new System.EventHandler(this.txtSearchBy1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(353, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Search By";
            // 
            // labelTOSET1
            // 
            this.labelTOSET1.AutoSize = true;
            this.labelTOSET1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTOSET1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTOSET1.Location = new System.Drawing.Point(353, 95);
            this.labelTOSET1.Name = "labelTOSET1";
            this.labelTOSET1.Size = new System.Drawing.Size(0, 25);
            this.labelTOSET1.TabIndex = 27;
            // 
            // txtSearch1
            // 
            this.txtSearch1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch1.DefaultText = "";
            this.txtSearch1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch1.ForeColor = System.Drawing.Color.White;
            this.txtSearch1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch1.Location = new System.Drawing.Point(489, 90);
            this.txtSearch1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.PasswordChar = '\0';
            this.txtSearch1.PlaceholderText = "";
            this.txtSearch1.SelectedText = "";
            this.txtSearch1.Size = new System.Drawing.Size(207, 30);
            this.txtSearch1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch1.TabIndex = 28;
            this.txtSearch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch1
            // 
            this.btnSearch1.CheckedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnSearch1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSearch1.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch1.Image")));
            this.btnSearch1.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSearch1.ImageRotate = 0F;
            this.btnSearch1.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearch1.Location = new System.Drawing.Point(702, 87);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSearch1.Size = new System.Drawing.Size(56, 33);
            this.btnSearch1.TabIndex = 29;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(506, 527);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(147, 27);
            this.lblPrice.TabIndex = 41;
            this.lblPrice.Text = "...........................";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.ForeColor = System.Drawing.Color.White;
            this.lblqty.Location = new System.Drawing.Point(506, 488);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(147, 27);
            this.lblqty.TabIndex = 40;
            this.lblqty.Text = "...........................";
            // 
            // lblModNum
            // 
            this.lblModNum.AutoSize = true;
            this.lblModNum.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModNum.ForeColor = System.Drawing.Color.White;
            this.lblModNum.Location = new System.Drawing.Point(506, 447);
            this.lblModNum.Name = "lblModNum";
            this.lblModNum.Size = new System.Drawing.Size(147, 27);
            this.lblModNum.TabIndex = 39;
            this.lblModNum.Text = "...........................";
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModName.ForeColor = System.Drawing.Color.White;
            this.lblModName.Location = new System.Drawing.Point(228, 527);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(147, 27);
            this.lblModName.TabIndex = 38;
            this.lblModName.Text = "...........................";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(228, 488);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(147, 27);
            this.lblBrand.TabIndex = 37;
            this.lblBrand.Text = "...........................";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.White;
            this.lblItem.Location = new System.Drawing.Point(228, 447);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(147, 27);
            this.lblItem.TabIndex = 36;
            this.lblItem.Text = "...........................";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(362, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 27);
            this.label9.TabIndex = 35;
            this.label9.Text = "Unit Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(362, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 27);
            this.label7.TabIndex = 34;
            this.label7.Text = "Quntity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(362, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "Modle Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(105, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 27);
            this.label5.TabIndex = 32;
            this.label5.Text = "Modle Name";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.l.Location = new System.Drawing.Point(105, 488);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(72, 27);
            this.l.TabIndex = 31;
            this.l.Text = "Brand";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lb.Location = new System.Drawing.Point(105, 447);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(58, 27);
            this.lb.TabIndex = 30;
            this.lb.Text = "Item";
            // 
            // lblNote
            // 
            this.lblNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNote.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Yellow;
            this.lblNote.Location = new System.Drawing.Point(641, 455);
            this.lblNote.Multiline = true;
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(184, 125);
            this.lblNote.TabIndex = 42;
            this.lblNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataArray
            // 
            this.DataArray.AllowUserToAddRows = false;
            this.DataArray.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataArray.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataArray.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataArray.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataArray.ColumnHeadersHeight = 29;
            this.DataArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataArray.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn,
            this.inameDataGridViewTextBoxColumn,
            this.bnameDataGridViewTextBoxColumn,
            this.mdnameDataGridViewTextBoxColumn,
            this.mdnumDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.date1DataGridViewTextBoxColumn,
            this.otimeDataGridViewTextBoxColumn});
            this.DataArray.DataSource = this.addItemBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataArray.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataArray.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataArray.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataArray.Location = new System.Drawing.Point(32, 151);
            this.DataArray.Name = "DataArray";
            this.DataArray.ReadOnly = true;
            this.DataArray.RowHeadersVisible = false;
            this.DataArray.RowHeadersWidth = 51;
            this.DataArray.RowTemplate.Height = 24;
            this.DataArray.Size = new System.Drawing.Size(805, 263);
            this.DataArray.TabIndex = 43;
            this.DataArray.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataArray.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataArray.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataArray.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataArray.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataArray.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataArray.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataArray.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataArray.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataArray.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataArray.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataArray.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataArray.ThemeStyle.HeaderStyle.Height = 29;
            this.DataArray.ThemeStyle.ReadOnly = true;
            this.DataArray.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataArray.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataArray.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataArray.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataArray.ThemeStyle.RowsStyle.Height = 24;
            this.DataArray.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataArray.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataArray.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataArray_CellClick);
            // 
            // midDataGridViewTextBoxColumn
            // 
            this.midDataGridViewTextBoxColumn.DataPropertyName = "mid";
            this.midDataGridViewTextBoxColumn.HeaderText = "MID";
            this.midDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.midDataGridViewTextBoxColumn.Name = "midDataGridViewTextBoxColumn";
            this.midDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inameDataGridViewTextBoxColumn
            // 
            this.inameDataGridViewTextBoxColumn.DataPropertyName = "iname";
            this.inameDataGridViewTextBoxColumn.HeaderText = "Item";
            this.inameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inameDataGridViewTextBoxColumn.Name = "inameDataGridViewTextBoxColumn";
            this.inameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bnameDataGridViewTextBoxColumn
            // 
            this.bnameDataGridViewTextBoxColumn.DataPropertyName = "bname";
            this.bnameDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.bnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bnameDataGridViewTextBoxColumn.Name = "bnameDataGridViewTextBoxColumn";
            this.bnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mdnameDataGridViewTextBoxColumn
            // 
            this.mdnameDataGridViewTextBoxColumn.DataPropertyName = "mdname";
            this.mdnameDataGridViewTextBoxColumn.HeaderText = "Model";
            this.mdnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mdnameDataGridViewTextBoxColumn.Name = "mdnameDataGridViewTextBoxColumn";
            this.mdnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mdnumDataGridViewTextBoxColumn
            // 
            this.mdnumDataGridViewTextBoxColumn.DataPropertyName = "mdnum";
            this.mdnumDataGridViewTextBoxColumn.HeaderText = "Mod No.";
            this.mdnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mdnumDataGridViewTextBoxColumn.Name = "mdnumDataGridViewTextBoxColumn";
            this.mdnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "About";
            this.noteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // date1DataGridViewTextBoxColumn
            // 
            this.date1DataGridViewTextBoxColumn.DataPropertyName = "date1";
            this.date1DataGridViewTextBoxColumn.HeaderText = "Date";
            this.date1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.date1DataGridViewTextBoxColumn.Name = "date1DataGridViewTextBoxColumn";
            this.date1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otimeDataGridViewTextBoxColumn
            // 
            this.otimeDataGridViewTextBoxColumn.DataPropertyName = "otime";
            this.otimeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.otimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.otimeDataGridViewTextBoxColumn.Name = "otimeDataGridViewTextBoxColumn";
            this.otimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addItemBindingSource
            // 
            this.addItemBindingSource.DataMember = "addItem";
            this.addItemBindingSource.DataSource = this.vbcbaseDataSet5;
            // 
            // vbcbaseDataSet5
            // 
            this.vbcbaseDataSet5.DataSetName = "vbcbaseDataSet5";
            this.vbcbaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addItemTableAdapter
            // 
            this.addItemTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(682, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 44;
            this.label2.Text = "Description";
            // 
            // UC_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataArray);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.lblModNum);
            this.Controls.Add(this.lblModName);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.labelTOSET1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchBy1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch1);
            this.Name = "UC_Stock";
            this.Size = new System.Drawing.Size(856, 602);
            this.Enter += new System.EventHandler(this.UC_Stock_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.DataArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vbcbaseDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox txtSearchBy1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTOSET1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch1;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Label lblModNum;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox lblNote;
        private Guna.UI2.WinForms.Guna2DataGridView DataArray;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addItemBindingSource;
        private vbcbaseDataSet5 vbcbaseDataSet5;
        private vbcbaseDataSet5TableAdapters.addItemTableAdapter addItemTableAdapter;
        private System.Windows.Forms.Label label2;
    }
}
