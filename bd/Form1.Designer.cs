namespace bd
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWorkerAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWorkerDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWorkerEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInventoryAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInventoryDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInventoryEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDWorkerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDataSet = new bd.AccountDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aInvNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aObjNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new bd.AccountDataSetTableAdapters.AccountTableAdapter();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new bd.AccountDataSetTableAdapters.WorkerTableAdapter();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWorker,
            this.menuInventory,
            this.menuReports,
            this.menuExit});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(778, 33);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuWorker
            // 
            this.menuWorker.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWorkerAdd,
            this.menuWorkerDelete,
            this.menuWorkerEdit});
            this.menuWorker.Name = "menuWorker";
            this.menuWorker.Size = new System.Drawing.Size(85, 29);
            this.menuWorker.Text = "Worker";
            // 
            // menuWorkerAdd
            // 
            this.menuWorkerAdd.Name = "menuWorkerAdd";
            this.menuWorkerAdd.Size = new System.Drawing.Size(270, 34);
            this.menuWorkerAdd.Text = "Add...";
            // 
            // menuWorkerDelete
            // 
            this.menuWorkerDelete.Name = "menuWorkerDelete";
            this.menuWorkerDelete.Size = new System.Drawing.Size(270, 34);
            this.menuWorkerDelete.Text = "Delete";
            // 
            // menuWorkerEdit
            // 
            this.menuWorkerEdit.Name = "menuWorkerEdit";
            this.menuWorkerEdit.Size = new System.Drawing.Size(270, 34);
            this.menuWorkerEdit.Text = "Edit...";
            // 
            // menuInventory
            // 
            this.menuInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInventoryAdd,
            this.menuInventoryDelete,
            this.menuInventoryEdit});
            this.menuInventory.Name = "menuInventory";
            this.menuInventory.Size = new System.Drawing.Size(103, 29);
            this.menuInventory.Text = "Inventory";
            // 
            // menuInventoryAdd
            // 
            this.menuInventoryAdd.Name = "menuInventoryAdd";
            this.menuInventoryAdd.Size = new System.Drawing.Size(270, 34);
            this.menuInventoryAdd.Text = "Add...";
            // 
            // menuInventoryDelete
            // 
            this.menuInventoryDelete.Name = "menuInventoryDelete";
            this.menuInventoryDelete.Size = new System.Drawing.Size(270, 34);
            this.menuInventoryDelete.Text = "Delete";
            // 
            // menuInventoryEdit
            // 
            this.menuInventoryEdit.Name = "menuInventoryEdit";
            this.menuInventoryEdit.Size = new System.Drawing.Size(270, 34);
            this.menuInventoryEdit.Text = "Edit...";
            // 
            // menuReports
            // 
            this.menuReports.Name = "menuReports";
            this.menuReports.Size = new System.Drawing.Size(89, 29);
            this.menuReports.Text = "Reports";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(55, 29);
            this.menuExit.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(651, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(651, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(651, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 41);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(651, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 41);
            this.button5.TabIndex = 8;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(651, 289);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 41);
            this.button6.TabIndex = 9;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDWorkerDataGridViewTextBoxColumn1,
            this.wNameDataGridViewTextBoxColumn,
            this.wPositionDataGridViewTextBoxColumn,
            this.wSexDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(603, 181);
            this.dataGridView1.TabIndex = 10;
            // 
            // iDWorkerDataGridViewTextBoxColumn1
            // 
            this.iDWorkerDataGridViewTextBoxColumn1.DataPropertyName = "ID_Worker";
            this.iDWorkerDataGridViewTextBoxColumn1.HeaderText = "ID_Worker";
            this.iDWorkerDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.iDWorkerDataGridViewTextBoxColumn1.Name = "iDWorkerDataGridViewTextBoxColumn1";
            this.iDWorkerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDWorkerDataGridViewTextBoxColumn1.Visible = false;
            this.iDWorkerDataGridViewTextBoxColumn1.Width = 150;
            // 
            // wNameDataGridViewTextBoxColumn
            // 
            this.wNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wNameDataGridViewTextBoxColumn.DataPropertyName = "WName";
            this.wNameDataGridViewTextBoxColumn.HeaderText = "Name of worker";
            this.wNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.wNameDataGridViewTextBoxColumn.Name = "wNameDataGridViewTextBoxColumn";
            this.wNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.wNameDataGridViewTextBoxColumn.Width = 156;
            // 
            // wPositionDataGridViewTextBoxColumn
            // 
            this.wPositionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wPositionDataGridViewTextBoxColumn.DataPropertyName = "WPosition";
            this.wPositionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.wPositionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.wPositionDataGridViewTextBoxColumn.Name = "wPositionDataGridViewTextBoxColumn";
            this.wPositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.wPositionDataGridViewTextBoxColumn.Width = 109;
            // 
            // wSexDataGridViewTextBoxColumn
            // 
            this.wSexDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wSexDataGridViewTextBoxColumn.DataPropertyName = "WSex";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.wSexDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.wSexDataGridViewTextBoxColumn.HeaderText = "M/F";
            this.wSexDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.wSexDataGridViewTextBoxColumn.Name = "wSexDataGridViewTextBoxColumn";
            this.wSexDataGridViewTextBoxColumn.ReadOnly = true;
            this.wSexDataGridViewTextBoxColumn.Width = 75;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.accountDataSet;
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 26);
            this.textBox1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAccountDataGridViewTextBoxColumn,
            this.iDWorkerDataGridViewTextBoxColumn,
            this.aNumDataGridViewTextBoxColumn,
            this.aDateDataGridViewTextBoxColumn,
            this.aInvNumDataGridViewTextBoxColumn,
            this.aObjNameDataGridViewTextBoxColumn,
            this.aCountDataGridViewTextBoxColumn,
            this.aPriceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.accountBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(0, 350);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(778, 192);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // iDAccountDataGridViewTextBoxColumn
            // 
            this.iDAccountDataGridViewTextBoxColumn.DataPropertyName = "ID_Account";
            this.iDAccountDataGridViewTextBoxColumn.HeaderText = "ID_Account";
            this.iDAccountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDAccountDataGridViewTextBoxColumn.Name = "iDAccountDataGridViewTextBoxColumn";
            this.iDAccountDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAccountDataGridViewTextBoxColumn.Visible = false;
            this.iDAccountDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDWorkerDataGridViewTextBoxColumn
            // 
            this.iDWorkerDataGridViewTextBoxColumn.DataPropertyName = "ID_Worker";
            this.iDWorkerDataGridViewTextBoxColumn.HeaderText = "ID_Worker";
            this.iDWorkerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDWorkerDataGridViewTextBoxColumn.Name = "iDWorkerDataGridViewTextBoxColumn";
            this.iDWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDWorkerDataGridViewTextBoxColumn.Visible = false;
            this.iDWorkerDataGridViewTextBoxColumn.Width = 150;
            // 
            // aNumDataGridViewTextBoxColumn
            // 
            this.aNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aNumDataGridViewTextBoxColumn.DataPropertyName = "ANum";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aNumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.aNumDataGridViewTextBoxColumn.HeaderText = "Number";
            this.aNumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aNumDataGridViewTextBoxColumn.Name = "aNumDataGridViewTextBoxColumn";
            this.aNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.aNumDataGridViewTextBoxColumn.Width = 107;
            // 
            // aDateDataGridViewTextBoxColumn
            // 
            this.aDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aDateDataGridViewTextBoxColumn.DataPropertyName = "ADate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.aDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.aDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aDateDataGridViewTextBoxColumn.Name = "aDateDataGridViewTextBoxColumn";
            this.aDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDateDataGridViewTextBoxColumn.Width = 84;
            // 
            // aInvNumDataGridViewTextBoxColumn
            // 
            this.aInvNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aInvNumDataGridViewTextBoxColumn.DataPropertyName = "AInvNum";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aInvNumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.aInvNumDataGridViewTextBoxColumn.HeaderText = "Inv.Number";
            this.aInvNumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aInvNumDataGridViewTextBoxColumn.Name = "aInvNumDataGridViewTextBoxColumn";
            this.aInvNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.aInvNumDataGridViewTextBoxColumn.Width = 136;
            // 
            // aObjNameDataGridViewTextBoxColumn
            // 
            this.aObjNameDataGridViewTextBoxColumn.DataPropertyName = "AObjName";
            this.aObjNameDataGridViewTextBoxColumn.HeaderText = "Object name";
            this.aObjNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aObjNameDataGridViewTextBoxColumn.Name = "aObjNameDataGridViewTextBoxColumn";
            this.aObjNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.aObjNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // aCountDataGridViewTextBoxColumn
            // 
            this.aCountDataGridViewTextBoxColumn.DataPropertyName = "ACount";
            this.aCountDataGridViewTextBoxColumn.HeaderText = "Count";
            this.aCountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aCountDataGridViewTextBoxColumn.Name = "aCountDataGridViewTextBoxColumn";
            this.aCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCountDataGridViewTextBoxColumn.Width = 150;
            // 
            // aPriceDataGridViewTextBoxColumn
            // 
            this.aPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aPriceDataGridViewTextBoxColumn.DataPropertyName = "APrice";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.aPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.aPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aPriceDataGridViewTextBoxColumn.Name = "aPriceDataGridViewTextBoxColumn";
            this.aPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.aPriceDataGridViewTextBoxColumn.Width = 85;
            // 
            // accountBindingSource1
            // 
            this.accountBindingSource1.DataMember = "Account";
            this.accountBindingSource1.DataSource = this.accountDataSet;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Inventory accounting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuWorker;
        private System.Windows.Forms.ToolStripMenuItem menuWorkerAdd;
        private System.Windows.Forms.ToolStripMenuItem menuWorkerDelete;
        private System.Windows.Forms.ToolStripMenuItem menuWorkerEdit;
        private System.Windows.Forms.ToolStripMenuItem menuInventory;
        private System.Windows.Forms.ToolStripMenuItem menuInventoryAdd;
        private System.Windows.Forms.ToolStripMenuItem menuInventoryDelete;
        private System.Windows.Forms.ToolStripMenuItem menuInventoryEdit;
        private System.Windows.Forms.ToolStripMenuItem menuReports;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private AccountDataSet accountDataSet;
        private AccountDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.BindingSource accountBindingSource1;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private AccountDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWorkerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aInvNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aObjNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPriceDataGridViewTextBoxColumn;
    }
}

