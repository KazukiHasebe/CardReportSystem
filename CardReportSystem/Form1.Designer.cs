﻿namespace CardReportSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.dbCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbFire = new System.Windows.Forms.RadioButton();
            this.rbAqua = new System.Windows.Forms.RadioButton();
            this.rbWind = new System.Windows.Forms.RadioButton();
            this.rbNorth = new System.Windows.Forms.RadioButton();
            this.rbDark = new System.Windows.Forms.RadioButton();
            this.rbLight = new System.Windows.Forms.RadioButton();
            this.rbGod = new System.Windows.Forms.RadioButton();
            this.rbMagic = new System.Windows.Forms.RadioButton();
            this.rbTrap = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCardName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbCard = new System.Windows.Forms.PictureBox();
            this.groupElemental = new System.Windows.Forms.GroupBox();
            this.btImageOpen = new System.Windows.Forms.Button();
            this.btImageDelete = new System.Windows.Forms.Button();
            this.btCardRegister = new System.Windows.Forms.Button();
            this.btCardChange = new System.Windows.Forms.Button();
            this.btCardDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btCardLoad = new System.Windows.Forms.Button();
            this.btCardSave = new System.Windows.Forms.Button();
            this.ofdOpenFileImage = new System.Windows.Forms.OpenFileDialog();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規入力ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infosys202022DataSet = new CardReportSystem.infosys202022DataSet();
            this.cardReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardReportTableAdapter = new CardReportSystem.infosys202022DataSetTableAdapters.CardReportTableAdapter();
            this.tableAdapterManager = new CardReportSystem.infosys202022DataSetTableAdapters.TableAdapterManager();
            this.dgvCardData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).BeginInit();
            this.groupElemental.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dbCreatedDate
            // 
            this.dbCreatedDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardReportBindingSource, "CreatedDate", true));
            this.dbCreatedDate.Location = new System.Drawing.Point(84, 42);
            this.dbCreatedDate.Name = "dbCreatedDate";
            this.dbCreatedDate.Size = new System.Drawing.Size(200, 19);
            this.dbCreatedDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者：";
            // 
            // cbAuthor
            // 
            this.cbAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardReportBindingSource, "Author", true));
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(84, 77);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(248, 20);
            this.cbAuthor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(45, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "属性：";
            // 
            // rbFire
            // 
            this.rbFire.AutoSize = true;
            this.rbFire.Checked = true;
            this.rbFire.Location = new System.Drawing.Point(6, 10);
            this.rbFire.Name = "rbFire";
            this.rbFire.Size = new System.Drawing.Size(35, 16);
            this.rbFire.TabIndex = 3;
            this.rbFire.TabStop = true;
            this.rbFire.Tag = "0";
            this.rbFire.Text = "火";
            this.rbFire.UseVisualStyleBackColor = true;
            // 
            // rbAqua
            // 
            this.rbAqua.AutoSize = true;
            this.rbAqua.Location = new System.Drawing.Point(47, 10);
            this.rbAqua.Name = "rbAqua";
            this.rbAqua.Size = new System.Drawing.Size(35, 16);
            this.rbAqua.TabIndex = 3;
            this.rbAqua.Tag = "1";
            this.rbAqua.Text = "水";
            this.rbAqua.UseVisualStyleBackColor = true;
            // 
            // rbWind
            // 
            this.rbWind.AutoSize = true;
            this.rbWind.Location = new System.Drawing.Point(88, 10);
            this.rbWind.Name = "rbWind";
            this.rbWind.Size = new System.Drawing.Size(35, 16);
            this.rbWind.TabIndex = 3;
            this.rbWind.Tag = "2";
            this.rbWind.Text = "風";
            this.rbWind.UseVisualStyleBackColor = true;
            // 
            // rbNorth
            // 
            this.rbNorth.AutoSize = true;
            this.rbNorth.Location = new System.Drawing.Point(129, 10);
            this.rbNorth.Name = "rbNorth";
            this.rbNorth.Size = new System.Drawing.Size(35, 16);
            this.rbNorth.TabIndex = 3;
            this.rbNorth.Tag = "3";
            this.rbNorth.Text = "地";
            this.rbNorth.UseVisualStyleBackColor = true;
            // 
            // rbDark
            // 
            this.rbDark.AutoSize = true;
            this.rbDark.Location = new System.Drawing.Point(171, 10);
            this.rbDark.Name = "rbDark";
            this.rbDark.Size = new System.Drawing.Size(35, 16);
            this.rbDark.TabIndex = 3;
            this.rbDark.Tag = "4";
            this.rbDark.Text = "闇";
            this.rbDark.UseVisualStyleBackColor = true;
            // 
            // rbLight
            // 
            this.rbLight.AutoSize = true;
            this.rbLight.Location = new System.Drawing.Point(212, 11);
            this.rbLight.Name = "rbLight";
            this.rbLight.Size = new System.Drawing.Size(35, 16);
            this.rbLight.TabIndex = 3;
            this.rbLight.Tag = "5";
            this.rbLight.Text = "光";
            this.rbLight.UseVisualStyleBackColor = true;
            // 
            // rbGod
            // 
            this.rbGod.AutoSize = true;
            this.rbGod.Location = new System.Drawing.Point(253, 11);
            this.rbGod.Name = "rbGod";
            this.rbGod.Size = new System.Drawing.Size(35, 16);
            this.rbGod.TabIndex = 3;
            this.rbGod.Tag = "6";
            this.rbGod.Text = "神";
            this.rbGod.UseVisualStyleBackColor = true;
            // 
            // rbMagic
            // 
            this.rbMagic.AutoSize = true;
            this.rbMagic.Location = new System.Drawing.Point(294, 11);
            this.rbMagic.Name = "rbMagic";
            this.rbMagic.Size = new System.Drawing.Size(47, 16);
            this.rbMagic.TabIndex = 3;
            this.rbMagic.Tag = "7";
            this.rbMagic.Text = "魔法";
            this.rbMagic.UseVisualStyleBackColor = true;
            // 
            // rbTrap
            // 
            this.rbTrap.AutoSize = true;
            this.rbTrap.Location = new System.Drawing.Point(347, 11);
            this.rbTrap.Name = "rbTrap";
            this.rbTrap.Size = new System.Drawing.Size(35, 16);
            this.rbTrap.TabIndex = 3;
            this.rbTrap.Tag = "8";
            this.rbTrap.Text = "罠";
            this.rbTrap.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(29, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "カード名：";
            // 
            // cbCardName
            // 
            this.cbCardName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardReportBindingSource, "Name", true));
            this.cbCardName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbCardName.FormattingEnabled = true;
            this.cbCardName.Location = new System.Drawing.Point(85, 138);
            this.cbCardName.Name = "cbCardName";
            this.cbCardName.Size = new System.Drawing.Size(385, 24);
            this.cbCardName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(31, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "テキスト：";
            // 
            // tbText
            // 
            this.tbText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardReportBindingSource, "Text", true));
            this.tbText.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbText.Location = new System.Drawing.Point(84, 174);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(384, 243);
            this.tbText.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(502, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "画像：";
            // 
            // pbCard
            // 
            this.pbCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCard.Location = new System.Drawing.Point(505, 77);
            this.pbCard.Name = "pbCard";
            this.pbCard.Size = new System.Drawing.Size(235, 316);
            this.pbCard.TabIndex = 5;
            this.pbCard.TabStop = false;
            // 
            // groupElemental
            // 
            this.groupElemental.Controls.Add(this.rbFire);
            this.groupElemental.Controls.Add(this.rbAqua);
            this.groupElemental.Controls.Add(this.rbLight);
            this.groupElemental.Controls.Add(this.rbGod);
            this.groupElemental.Controls.Add(this.rbWind);
            this.groupElemental.Controls.Add(this.rbDark);
            this.groupElemental.Controls.Add(this.rbMagic);
            this.groupElemental.Controls.Add(this.rbTrap);
            this.groupElemental.Controls.Add(this.rbNorth);
            this.groupElemental.Location = new System.Drawing.Point(85, 103);
            this.groupElemental.Name = "groupElemental";
            this.groupElemental.Size = new System.Drawing.Size(392, 34);
            this.groupElemental.TabIndex = 6;
            this.groupElemental.TabStop = false;
            // 
            // btImageOpen
            // 
            this.btImageOpen.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btImageOpen.Location = new System.Drawing.Point(548, 42);
            this.btImageOpen.Name = "btImageOpen";
            this.btImageOpen.Size = new System.Drawing.Size(84, 29);
            this.btImageOpen.TabIndex = 7;
            this.btImageOpen.Text = "開く...";
            this.btImageOpen.UseVisualStyleBackColor = true;
            this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click);
            // 
            // btImageDelete
            // 
            this.btImageDelete.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btImageDelete.Location = new System.Drawing.Point(650, 42);
            this.btImageDelete.Name = "btImageDelete";
            this.btImageDelete.Size = new System.Drawing.Size(87, 29);
            this.btImageDelete.TabIndex = 7;
            this.btImageDelete.Text = "削除";
            this.btImageDelete.UseVisualStyleBackColor = true;
            this.btImageDelete.Click += new System.EventHandler(this.btImageDelete_Click);
            // 
            // btCardRegister
            // 
            this.btCardRegister.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCardRegister.Location = new System.Drawing.Point(487, 399);
            this.btCardRegister.Name = "btCardRegister";
            this.btCardRegister.Size = new System.Drawing.Size(84, 29);
            this.btCardRegister.TabIndex = 7;
            this.btCardRegister.Text = "追加";
            this.btCardRegister.UseVisualStyleBackColor = true;
            this.btCardRegister.Click += new System.EventHandler(this.btCardRegister_Click);
            // 
            // btCardChange
            // 
            this.btCardChange.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCardChange.Location = new System.Drawing.Point(577, 399);
            this.btCardChange.Name = "btCardChange";
            this.btCardChange.Size = new System.Drawing.Size(84, 29);
            this.btCardChange.TabIndex = 7;
            this.btCardChange.Text = "修正";
            this.btCardChange.UseVisualStyleBackColor = true;
            this.btCardChange.Click += new System.EventHandler(this.btCardChange_Click);
            // 
            // btCardDelete
            // 
            this.btCardDelete.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCardDelete.Location = new System.Drawing.Point(667, 399);
            this.btCardDelete.Name = "btCardDelete";
            this.btCardDelete.Size = new System.Drawing.Size(84, 29);
            this.btCardDelete.TabIndex = 7;
            this.btCardDelete.Text = "削除";
            this.btCardDelete.UseVisualStyleBackColor = true;
            this.btCardDelete.Click += new System.EventHandler(this.btCardDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(11, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "記事一覧：";
            // 
            // btCardLoad
            // 
            this.btCardLoad.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCardLoad.Location = new System.Drawing.Point(4, 459);
            this.btCardLoad.Name = "btCardLoad";
            this.btCardLoad.Size = new System.Drawing.Size(74, 29);
            this.btCardLoad.TabIndex = 7;
            this.btCardLoad.Text = "接続...";
            this.btCardLoad.UseVisualStyleBackColor = true;
            this.btCardLoad.Click += new System.EventHandler(this.btCardLoad_Click);
            // 
            // btCardSave
            // 
            this.btCardSave.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCardSave.Location = new System.Drawing.Point(3, 494);
            this.btCardSave.Name = "btCardSave";
            this.btCardSave.Size = new System.Drawing.Size(74, 29);
            this.btCardSave.TabIndex = 7;
            this.btCardSave.Text = "保存";
            this.btCardSave.UseVisualStyleBackColor = true;
            this.btCardSave.Click += new System.EventHandler(this.btCardSave_Click);
            // 
            // ofdOpenFileImage
            // 
            this.ofdOpenFileImage.FileName = "openFileDialog1";
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.FileName = "openFileDialog2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規入力ToolStripMenuItem,
            this.開くToolStripMenuItem,
            this.名前を付けて保存ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 新規入力ToolStripMenuItem
            // 
            this.新規入力ToolStripMenuItem.Name = "新規入力ToolStripMenuItem";
            this.新規入力ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.新規入力ToolStripMenuItem.Text = "新規入力";
            this.新規入力ToolStripMenuItem.Click += new System.EventHandler(this.新規入力ToolStripMenuItem_Click);
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.開くToolStripMenuItem.Text = "開く...";
            // 
            // 名前を付けて保存ToolStripMenuItem
            // 
            this.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem";
            this.名前を付けて保存ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.名前を付けて保存ToolStripMenuItem.Text = "名前を付けて保存...";
            this.名前を付けて保存ToolStripMenuItem.Click += new System.EventHandler(this.名前を付けて保存ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.終了ToolStripMenuItem.Text = "終了(&X)";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // infosys202022DataSet
            // 
            this.infosys202022DataSet.DataSetName = "infosys202022DataSet";
            this.infosys202022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardReportBindingSource
            // 
            this.cardReportBindingSource.DataMember = "CardReport";
            this.cardReportBindingSource.DataSource = this.infosys202022DataSet;
            // 
            // cardReportTableAdapter
            // 
            this.cardReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CardReportTableAdapter = this.cardReportTableAdapter;
            this.tableAdapterManager.UpdateOrder = CardReportSystem.infosys202022DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgvCardData
            // 
            this.dgvCardData.AllowUserToAddRows = false;
            this.dgvCardData.AutoGenerateColumns = false;
            this.dgvCardData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCardData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.dgvCardData.DataSource = this.cardReportBindingSource;
            this.dgvCardData.Location = new System.Drawing.Point(85, 433);
            this.dgvCardData.MultiSelect = false;
            this.dgvCardData.Name = "dgvCardData";
            this.dgvCardData.ReadOnly = true;
            this.dgvCardData.RowTemplate.Height = 21;
            this.dgvCardData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCardData.Size = new System.Drawing.Size(754, 220);
            this.dgvCardData.TabIndex = 22;
            this.dgvCardData.Click += new System.EventHandler(this.dgvCardData_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CreatedDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "CreatedDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Elemental";
            this.dataGridViewTextBoxColumn4.HeaderText = "Elemental";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Text";
            this.dataGridViewTextBoxColumn6.HeaderText = "Text";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 704);
            this.Controls.Add(this.dgvCardData);
            this.Controls.Add(this.btImageDelete);
            this.Controls.Add(this.btCardDelete);
            this.Controls.Add(this.btCardChange);
            this.Controls.Add(this.btCardSave);
            this.Controls.Add(this.btCardLoad);
            this.Controls.Add(this.btCardRegister);
            this.Controls.Add(this.btImageOpen);
            this.Controls.Add(this.groupElemental);
            this.Controls.Add(this.pbCard);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.cbCardName);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.dbCreatedDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "カード登録アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).EndInit();
            this.groupElemental.ResumeLayout(false);
            this.groupElemental.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dbCreatedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbFire;
        private System.Windows.Forms.RadioButton rbAqua;
        private System.Windows.Forms.RadioButton rbWind;
        private System.Windows.Forms.RadioButton rbNorth;
        private System.Windows.Forms.RadioButton rbDark;
        private System.Windows.Forms.RadioButton rbLight;
        private System.Windows.Forms.RadioButton rbGod;
        private System.Windows.Forms.RadioButton rbMagic;
        private System.Windows.Forms.RadioButton rbTrap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCardName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbCard;
        private System.Windows.Forms.GroupBox groupElemental;
        private System.Windows.Forms.Button btImageOpen;
        private System.Windows.Forms.Button btImageDelete;
        private System.Windows.Forms.Button btCardRegister;
        private System.Windows.Forms.Button btCardChange;
        private System.Windows.Forms.Button btCardDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCardLoad;
        private System.Windows.Forms.Button btCardSave;
        private System.Windows.Forms.OpenFileDialog ofdOpenFileImage;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規入力ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private infosys202022DataSet infosys202022DataSet;
        private System.Windows.Forms.BindingSource cardReportBindingSource;
        private infosys202022DataSetTableAdapters.CardReportTableAdapter cardReportTableAdapter;
        private infosys202022DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvCardData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}

