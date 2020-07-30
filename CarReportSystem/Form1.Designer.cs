namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCreate = new System.Windows.Forms.DateTimePicker();
            this.carReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202029DataSet = new CarReportSystem.infosys202029DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbtoyota = new System.Windows.Forms.RadioButton();
            this.rdbniisan = new System.Windows.Forms.RadioButton();
            this.rdbhonda = new System.Windows.Forms.RadioButton();
            this.rdbsubaru = new System.Windows.Forms.RadioButton();
            this.rdbgaisya = new System.Windows.Forms.RadioButton();
            this.rdboter = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btOpenImage = new System.Windows.Forms.Button();
            this.btDeleteImage = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btFix = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveDate = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenDate = new System.Windows.Forms.OpenFileDialog();
            this.carReportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carReportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvcardate = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbSearchCarName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSearchCarMaker = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btSearchExe = new System.Windows.Forms.Button();
            this.carReportTableAdapter = new CarReportSystem.infosys202029DataSetTableAdapters.CarReportTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202029DataSetTableAdapters.TableAdapterManager();
            this.rbCarName = new System.Windows.Forms.RadioButton();
            this.rbCarDate = new System.Windows.Forms.RadioButton();
            this.rbCarMaker = new System.Windows.Forms.RadioButton();
            this.dtpSearchCardate = new System.Windows.Forms.DateTimePicker();
            this.rbAND = new System.Windows.Forms.RadioButton();
            this.rbOR = new System.Windows.Forms.RadioButton();
            this.cbCarName = new System.Windows.Forms.CheckBox();
            this.cbCarDate = new System.Windows.Forms.CheckBox();
            this.cbCarMaker = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202029DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingNavigator)).BeginInit();
            this.carReportBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcardate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpCreate
            // 
            this.dtpCreate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carReportBindingSource, "CreatedDate", true));
            this.dtpCreate.Location = new System.Drawing.Point(86, 27);
            this.dtpCreate.Name = "dtpCreate";
            this.dtpCreate.Size = new System.Drawing.Size(200, 19);
            this.dtpCreate.TabIndex = 1;
            // 
            // carReportBindingSource
            // 
            this.carReportBindingSource.DataMember = "CarReport";
            this.carReportBindingSource.DataSource = this.infosys202029DataSet;
            // 
            // infosys202029DataSet
            // 
            this.infosys202029DataSet.DataSetName = "infosys202029DataSet";
            this.infosys202029DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(86, 63);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(200, 20);
            this.cbAuthor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "メーカー：";
            // 
            // rdbtoyota
            // 
            this.rdbtoyota.AutoSize = true;
            this.rdbtoyota.Location = new System.Drawing.Point(4, 11);
            this.rdbtoyota.Name = "rdbtoyota";
            this.rdbtoyota.Size = new System.Drawing.Size(47, 16);
            this.rdbtoyota.TabIndex = 3;
            this.rdbtoyota.TabStop = true;
            this.rdbtoyota.Text = "トヨタ";
            this.rdbtoyota.UseVisualStyleBackColor = true;
            // 
            // rdbniisan
            // 
            this.rdbniisan.AutoSize = true;
            this.rdbniisan.Location = new System.Drawing.Point(57, 11);
            this.rdbniisan.Name = "rdbniisan";
            this.rdbniisan.Size = new System.Drawing.Size(47, 16);
            this.rdbniisan.TabIndex = 3;
            this.rdbniisan.TabStop = true;
            this.rdbniisan.Text = "日産";
            this.rdbniisan.UseVisualStyleBackColor = true;
            // 
            // rdbhonda
            // 
            this.rdbhonda.AutoSize = true;
            this.rdbhonda.Location = new System.Drawing.Point(110, 11);
            this.rdbhonda.Name = "rdbhonda";
            this.rdbhonda.Size = new System.Drawing.Size(51, 16);
            this.rdbhonda.TabIndex = 3;
            this.rdbhonda.TabStop = true;
            this.rdbhonda.Text = "ホンダ";
            this.rdbhonda.UseVisualStyleBackColor = true;
            // 
            // rdbsubaru
            // 
            this.rdbsubaru.AutoSize = true;
            this.rdbsubaru.Location = new System.Drawing.Point(167, 11);
            this.rdbsubaru.Name = "rdbsubaru";
            this.rdbsubaru.Size = new System.Drawing.Size(52, 16);
            this.rdbsubaru.TabIndex = 3;
            this.rdbsubaru.TabStop = true;
            this.rdbsubaru.Text = "スバル";
            this.rdbsubaru.UseVisualStyleBackColor = true;
            // 
            // rdbgaisya
            // 
            this.rdbgaisya.AutoSize = true;
            this.rdbgaisya.Location = new System.Drawing.Point(225, 11);
            this.rdbgaisya.Name = "rdbgaisya";
            this.rdbgaisya.Size = new System.Drawing.Size(47, 16);
            this.rdbgaisya.TabIndex = 3;
            this.rdbgaisya.TabStop = true;
            this.rdbgaisya.Text = "外車";
            this.rdbgaisya.UseVisualStyleBackColor = true;
            // 
            // rdboter
            // 
            this.rdboter.AutoSize = true;
            this.rdboter.Location = new System.Drawing.Point(278, 11);
            this.rdboter.Name = "rdboter";
            this.rdboter.Size = new System.Drawing.Size(54, 16);
            this.rdboter.TabIndex = 3;
            this.rdboter.TabStop = true;
            this.rdboter.Text = "その他";
            this.rdboter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdboter);
            this.groupBox1.Controls.Add(this.rdbgaisya);
            this.groupBox1.Controls.Add(this.rdbsubaru);
            this.groupBox1.Controls.Add(this.rdbhonda);
            this.groupBox1.Controls.Add(this.rdbniisan);
            this.groupBox1.Controls.Add(this.rdbtoyota);
            this.groupBox1.Location = new System.Drawing.Point(82, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 44);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "レポート：";
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(86, 140);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(200, 20);
            this.cbName.TabIndex = 2;
            this.cbName.Text = "faf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "車名：";
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(91, 180);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(350, 105);
            this.tbReport.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧：";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(483, 47);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(228, 202);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "画像：";
            // 
            // btOpenImage
            // 
            this.btOpenImage.Location = new System.Drawing.Point(536, 23);
            this.btOpenImage.Name = "btOpenImage";
            this.btOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btOpenImage.TabIndex = 9;
            this.btOpenImage.Text = "開く";
            this.btOpenImage.UseVisualStyleBackColor = true;
            this.btOpenImage.Click += new System.EventHandler(this.btOpenImage_Click);
            // 
            // btDeleteImage
            // 
            this.btDeleteImage.Location = new System.Drawing.Point(627, 23);
            this.btDeleteImage.Name = "btDeleteImage";
            this.btDeleteImage.Size = new System.Drawing.Size(75, 23);
            this.btDeleteImage.TabIndex = 9;
            this.btDeleteImage.Text = "削除";
            this.btDeleteImage.UseVisualStyleBackColor = true;
            this.btDeleteImage.Click += new System.EventHandler(this.btDeleteImage_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(483, 255);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btFix
            // 
            this.btFix.Location = new System.Drawing.Point(564, 255);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(75, 23);
            this.btFix.TabIndex = 9;
            this.btFix.Text = "修正";
            this.btFix.UseVisualStyleBackColor = true;
            this.btFix.Click += new System.EventHandler(this.btFix_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(645, 255);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(6, 323);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 10;
            this.btOpen.Text = "接続";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(6, 363);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(672, 556);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(75, 23);
            this.btEnd.TabIndex = 10;
            this.btEnd.Text = "終了";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            // 
            // ofdOpenDate
            // 
            this.ofdOpenDate.FileName = "openFileDialog1";
            // 
            // carReportBindingNavigator
            // 
            this.carReportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carReportBindingNavigator.BindingSource = this.carReportBindingSource;
            this.carReportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carReportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carReportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.carReportBindingNavigatorSaveItem});
            this.carReportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carReportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carReportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carReportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carReportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carReportBindingNavigator.Name = "carReportBindingNavigator";
            this.carReportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carReportBindingNavigator.Size = new System.Drawing.Size(1012, 25);
            this.carReportBindingNavigator.TabIndex = 11;
            this.carReportBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // carReportBindingNavigatorSaveItem
            // 
            this.carReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carReportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carReportBindingNavigatorSaveItem.Image")));
            this.carReportBindingNavigatorSaveItem.Name = "carReportBindingNavigatorSaveItem";
            this.carReportBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carReportBindingNavigatorSaveItem.Text = "データの保存";
            this.carReportBindingNavigatorSaveItem.Click += new System.EventHandler(this.carReportBindingNavigatorSaveItem_Click);
            // 
            // dgvcardate
            // 
            this.dgvcardate.AllowUserToAddRows = false;
            this.dgvcardate.AutoGenerateColumns = false;
            this.dgvcardate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcardate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dgvcardate.DataSource = this.carReportBindingSource;
            this.dgvcardate.Location = new System.Drawing.Point(82, 323);
            this.dgvcardate.MultiSelect = false;
            this.dgvcardate.Name = "dgvcardate";
            this.dgvcardate.RowTemplate.Height = 21;
            this.dgvcardate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcardate.Size = new System.Drawing.Size(737, 220);
            this.dgvcardate.TabIndex = 22;
            this.dgvcardate.Click += new System.EventHandler(this.dgvcardate_Click_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // makerDataGridViewTextBoxColumn
            // 
            this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
            this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
            this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // reportDataGridViewTextBoxColumn
            // 
            this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
            this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // tbSearchCarName
            // 
            this.tbSearchCarName.Location = new System.Drawing.Point(66, 24);
            this.tbSearchCarName.Name = "tbSearchCarName";
            this.tbSearchCarName.Size = new System.Drawing.Size(154, 19);
            this.tbSearchCarName.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "車名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCarMaker);
            this.groupBox2.Controls.Add(this.cbCarDate);
            this.groupBox2.Controls.Add(this.cbCarName);
            this.groupBox2.Controls.Add(this.rbAND);
            this.groupBox2.Controls.Add(this.rbOR);
            this.groupBox2.Controls.Add(this.dtpSearchCardate);
            this.groupBox2.Controls.Add(this.rbCarMaker);
            this.groupBox2.Controls.Add(this.rbCarDate);
            this.groupBox2.Controls.Add(this.rbCarName);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tbSearchCarMaker);
            this.groupBox2.Controls.Add(this.btSearch);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btSearchExe);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbSearchCarName);
            this.groupBox2.Location = new System.Drawing.Point(708, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 175);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "検索";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSearchCarMaker
            // 
            this.tbSearchCarMaker.Location = new System.Drawing.Point(66, 97);
            this.tbSearchCarMaker.Name = "tbSearchCarMaker";
            this.tbSearchCarMaker.Size = new System.Drawing.Size(154, 19);
            this.tbSearchCarMaker.TabIndex = 31;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(232, 57);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(63, 23);
            this.btSearch.TabIndex = 29;
            this.btSearch.Text = "button1";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "メーカー";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "日付";
            // 
            // btSearchExe
            // 
            this.btSearchExe.Location = new System.Drawing.Point(232, 22);
            this.btSearchExe.Name = "btSearchExe";
            this.btSearchExe.Size = new System.Drawing.Size(75, 23);
            this.btSearchExe.TabIndex = 26;
            this.btSearchExe.Text = "実行";
            this.btSearchExe.UseVisualStyleBackColor = true;
            this.btSearchExe.Click += new System.EventHandler(this.btSearchExe_Click);
            // 
            // carReportTableAdapter
            // 
            this.carReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportTableAdapter = this.carReportTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202029DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rbCarName
            // 
            this.rbCarName.AutoSize = true;
            this.rbCarName.Location = new System.Drawing.Point(0, 25);
            this.rbCarName.Name = "rbCarName";
            this.rbCarName.Size = new System.Drawing.Size(47, 16);
            this.rbCarName.TabIndex = 33;
            this.rbCarName.TabStop = true;
            this.rbCarName.Text = "車名";
            this.rbCarName.UseVisualStyleBackColor = true;
            // 
            // rbCarDate
            // 
            this.rbCarDate.AutoSize = true;
            this.rbCarDate.Location = new System.Drawing.Point(0, 60);
            this.rbCarDate.Name = "rbCarDate";
            this.rbCarDate.Size = new System.Drawing.Size(47, 16);
            this.rbCarDate.TabIndex = 34;
            this.rbCarDate.TabStop = true;
            this.rbCarDate.Text = "日付";
            this.rbCarDate.UseVisualStyleBackColor = true;
            // 
            // rbCarMaker
            // 
            this.rbCarMaker.AutoSize = true;
            this.rbCarMaker.Location = new System.Drawing.Point(0, 98);
            this.rbCarMaker.Name = "rbCarMaker";
            this.rbCarMaker.Size = new System.Drawing.Size(60, 16);
            this.rbCarMaker.TabIndex = 35;
            this.rbCarMaker.TabStop = true;
            this.rbCarMaker.Text = "メーカー";
            this.rbCarMaker.UseVisualStyleBackColor = true;
            // 
            // dtpSearchCardate
            // 
            this.dtpSearchCardate.Location = new System.Drawing.Point(66, 61);
            this.dtpSearchCardate.Name = "dtpSearchCardate";
            this.dtpSearchCardate.Size = new System.Drawing.Size(160, 19);
            this.dtpSearchCardate.TabIndex = 36;
            // 
            // rbAND
            // 
            this.rbAND.AutoSize = true;
            this.rbAND.Location = new System.Drawing.Point(66, 137);
            this.rbAND.Name = "rbAND";
            this.rbAND.Size = new System.Drawing.Size(47, 16);
            this.rbAND.TabIndex = 27;
            this.rbAND.TabStop = true;
            this.rbAND.Text = "AND";
            this.rbAND.UseVisualStyleBackColor = true;
            // 
            // rbOR
            // 
            this.rbOR.AutoSize = true;
            this.rbOR.Location = new System.Drawing.Point(181, 138);
            this.rbOR.Name = "rbOR";
            this.rbOR.Size = new System.Drawing.Size(39, 16);
            this.rbOR.TabIndex = 28;
            this.rbOR.TabStop = true;
            this.rbOR.Text = "OR";
            this.rbOR.UseVisualStyleBackColor = true;
            // 
            // cbCarName
            // 
            this.cbCarName.AutoSize = true;
            this.cbCarName.Location = new System.Drawing.Point(0, 26);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(48, 16);
            this.cbCarName.TabIndex = 37;
            this.cbCarName.Text = "車名";
            this.cbCarName.UseVisualStyleBackColor = true;
            // 
            // cbCarDate
            // 
            this.cbCarDate.AutoSize = true;
            this.cbCarDate.Location = new System.Drawing.Point(0, 60);
            this.cbCarDate.Name = "cbCarDate";
            this.cbCarDate.Size = new System.Drawing.Size(48, 16);
            this.cbCarDate.TabIndex = 38;
            this.cbCarDate.Text = "日付";
            this.cbCarDate.UseVisualStyleBackColor = true;
            // 
            // cbCarMaker
            // 
            this.cbCarMaker.AutoSize = true;
            this.cbCarMaker.Location = new System.Drawing.Point(0, 97);
            this.cbCarMaker.Name = "cbCarMaker";
            this.cbCarMaker.Size = new System.Drawing.Size(61, 16);
            this.cbCarMaker.TabIndex = 39;
            this.cbCarMaker.Text = "メーカー";
            this.cbCarMaker.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvcardate);
            this.Controls.Add(this.carReportBindingNavigator);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btDeleteImage);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btFix);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btOpenImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.dtpCreate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202029DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingNavigator)).EndInit();
            this.carReportBindingNavigator.ResumeLayout(false);
            this.carReportBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcardate)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbtoyota;
        private System.Windows.Forms.RadioButton rdbniisan;
        private System.Windows.Forms.RadioButton rdbhonda;
        private System.Windows.Forms.RadioButton rdbsubaru;
        private System.Windows.Forms.RadioButton rdbgaisya;
        private System.Windows.Forms.RadioButton rdboter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btOpenImage;
        private System.Windows.Forms.Button btDeleteImage;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.SaveFileDialog sfdSaveDate;
        private System.Windows.Forms.OpenFileDialog ofdOpenDate;
        private System.Windows.Forms.Button btOpen;
        private infosys202029DataSet infosys202029DataSet;
        private System.Windows.Forms.BindingSource carReportBindingSource;
        private infosys202029DataSetTableAdapters.CarReportTableAdapter carReportTableAdapter;
        private infosys202029DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator carReportBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carReportBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvcardate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.TextBox tbSearchCarName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSearchExe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSearchCarMaker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbCarMaker;
        private System.Windows.Forms.RadioButton rbCarDate;
        private System.Windows.Forms.RadioButton rbCarName;
        private System.Windows.Forms.DateTimePicker dtpSearchCardate;
        private System.Windows.Forms.RadioButton rbAND;
        private System.Windows.Forms.RadioButton rbOR;
        private System.Windows.Forms.CheckBox cbCarMaker;
        private System.Windows.Forms.CheckBox cbCarDate;
        private System.Windows.Forms.CheckBox cbCarName;
    }
}

