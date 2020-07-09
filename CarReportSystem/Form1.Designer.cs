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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCreate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRecorder = new System.Windows.Forms.ComboBox();
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
            this.dgvcardate = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcardate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
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
            this.dtpCreate.Location = new System.Drawing.Point(86, 27);
            this.dtpCreate.Name = "dtpCreate";
            this.dtpCreate.Size = new System.Drawing.Size(200, 19);
            this.dtpCreate.TabIndex = 1;
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
            // cbRecorder
            // 
            this.cbRecorder.FormattingEnabled = true;
            this.cbRecorder.Location = new System.Drawing.Point(86, 63);
            this.cbRecorder.Name = "cbRecorder";
            this.cbRecorder.Size = new System.Drawing.Size(200, 20);
            this.cbRecorder.TabIndex = 2;
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
            // dgvcardate
            // 
            this.dgvcardate.AllowUserToAddRows = false;
            this.dgvcardate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcardate.Location = new System.Drawing.Point(93, 291);
            this.dgvcardate.MultiSelect = false;
            this.dgvcardate.Name = "dgvcardate";
            this.dgvcardate.ReadOnly = true;
            this.dgvcardate.RowTemplate.Height = 21;
            this.dgvcardate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcardate.Size = new System.Drawing.Size(643, 137);
            this.dgvcardate.TabIndex = 6;
           
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(519, 45);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(228, 202);
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "画像：";
            // 
            // btOpenImage
            // 
            this.btOpenImage.Location = new System.Drawing.Point(573, 21);
            this.btOpenImage.Name = "btOpenImage";
            this.btOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btOpenImage.TabIndex = 9;
            this.btOpenImage.Text = "開く";
            this.btOpenImage.UseVisualStyleBackColor = true;
            this.btOpenImage.Click += new System.EventHandler(this.btOpenImage_Click);
            // 
            // btDeleteImage
            // 
            this.btDeleteImage.Location = new System.Drawing.Point(659, 21);
            this.btDeleteImage.Name = "btDeleteImage";
            this.btDeleteImage.Size = new System.Drawing.Size(75, 23);
            this.btDeleteImage.TabIndex = 9;
            this.btDeleteImage.Text = "削除";
            this.btDeleteImage.UseVisualStyleBackColor = true;
            this.btDeleteImage.Click += new System.EventHandler(this.btDeleteImage_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(501, 262);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btFix
            // 
            this.btFix.Location = new System.Drawing.Point(582, 262);
            this.btFix.Name = "btFix";
            this.btFix.Size = new System.Drawing.Size(75, 23);
            this.btFix.TabIndex = 9;
            this.btFix.Text = "修正";
            this.btFix.UseVisualStyleBackColor = true;
            this.btFix.Click += new System.EventHandler(this.btFix_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(659, 262);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(12, 323);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 23);
            this.btOpen.TabIndex = 10;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(12, 361);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(717, 434);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 484);
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
            this.Controls.Add(this.dgvcardate);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbRecorder);
            this.Controls.Add(this.dtpCreate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcardate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRecorder;
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
        private System.Windows.Forms.DataGridView dgvcardate;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btOpenImage;
        private System.Windows.Forms.Button btDeleteImage;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.SaveFileDialog sfdSaveDate;
        private System.Windows.Forms.OpenFileDialog ofdOpenDate;
    }
}

