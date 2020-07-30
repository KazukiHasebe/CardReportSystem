namespace CardReportSystem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvCardData = new System.Windows.Forms.DataGridView();
            this.tbSearchCardName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bfSearchExe = new System.Windows.Forms.Button();
            this.tbSearchAuthor = new System.Windows.Forms.TextBox();
            this.dbSearchDate = new System.Windows.Forms.DateTimePicker();
            this.gbSearchElemental = new System.Windows.Forms.GroupBox();
            this.rbSearchFire = new System.Windows.Forms.RadioButton();
            this.rbSearchAqua = new System.Windows.Forms.RadioButton();
            this.rbSearchLight = new System.Windows.Forms.RadioButton();
            this.rbSearchGod = new System.Windows.Forms.RadioButton();
            this.rbSearchWind = new System.Windows.Forms.RadioButton();
            this.rbSearchDark = new System.Windows.Forms.RadioButton();
            this.rbSearchMagic = new System.Windows.Forms.RadioButton();
            this.rbSearchTrap = new System.Windows.Forms.RadioButton();
            this.rbSearchNorth = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbAND = new System.Windows.Forms.RadioButton();
            this.rbOR = new System.Windows.Forms.RadioButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cardReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202022DataSet = new CardReportSystem.infosys202022DataSet();
            this.cardReportTableAdapter = new CardReportSystem.infosys202022DataSetTableAdapters.CardReportTableAdapter();
            this.tableAdapterManager = new CardReportSystem.infosys202022DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).BeginInit();
            this.groupElemental.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbSearchElemental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202022DataSet)).BeginInit();
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
            this.dbCreatedDate.Location = new System.Drawing.Point(84, 42);
            this.dbCreatedDate.Name = "dbCreatedDate";
            this.dbCreatedDate.Size = new System.Drawing.Size(200, 19);
            this.dbCreatedDate.TabIndex = 1;
            this.dbCreatedDate.Value = new System.DateTime(2020, 7, 28, 15, 10, 41, 0);
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
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
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
            // dgvCardData
            // 
            this.dgvCardData.AllowUserToAddRows = false;
            this.dgvCardData.AllowUserToDeleteRows = false;
            this.dgvCardData.AutoGenerateColumns = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCardData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCardData.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCardData.Location = new System.Drawing.Point(83, 459);
            this.dgvCardData.MultiSelect = false;
            this.dgvCardData.Name = "dgvCardData";
            this.dgvCardData.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCardData.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCardData.RowTemplate.Height = 21;
            this.dgvCardData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCardData.Size = new System.Drawing.Size(754, 220);
            this.dgvCardData.TabIndex = 22;
            this.dgvCardData.Click += new System.EventHandler(this.dgvCardData_Click);
            // 
            // tbSearchCardName
            // 
            this.tbSearchCardName.Location = new System.Drawing.Point(76, 147);
            this.tbSearchCardName.Name = "tbSearchCardName";
            this.tbSearchCardName.Size = new System.Drawing.Size(174, 19);
            this.tbSearchCardName.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.rbOR);
            this.groupBox1.Controls.Add(this.rbAND);
            this.groupBox1.Controls.Add(this.bfSearchExe);
            this.groupBox1.Controls.Add(this.tbSearchAuthor);
            this.groupBox1.Controls.Add(this.tbSearchCardName);
            this.groupBox1.Controls.Add(this.dbSearchDate);
            this.groupBox1.Controls.Add(this.gbSearchElemental);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(806, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 314);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索";
            // 
            // bfSearchExe
            // 
            this.bfSearchExe.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bfSearchExe.Location = new System.Drawing.Point(96, 240);
            this.bfSearchExe.Name = "bfSearchExe";
            this.bfSearchExe.Size = new System.Drawing.Size(134, 47);
            this.bfSearchExe.TabIndex = 25;
            this.bfSearchExe.Text = "実行";
            this.bfSearchExe.UseVisualStyleBackColor = false;
            this.bfSearchExe.Click += new System.EventHandler(this.bfSearchExe_Click);
            // 
            // tbSearchAuthor
            // 
            this.tbSearchAuthor.Location = new System.Drawing.Point(76, 52);
            this.tbSearchAuthor.Name = "tbSearchAuthor";
            this.tbSearchAuthor.Size = new System.Drawing.Size(174, 19);
            this.tbSearchAuthor.TabIndex = 23;
            // 
            // dbSearchDate
            // 
            this.dbSearchDate.Location = new System.Drawing.Point(76, 19);
            this.dbSearchDate.Name = "dbSearchDate";
            this.dbSearchDate.Size = new System.Drawing.Size(200, 19);
            this.dbSearchDate.TabIndex = 1;
            this.dbSearchDate.Value = new System.DateTime(2020, 7, 28, 15, 10, 41, 0);
            // 
            // gbSearchElemental
            // 
            this.gbSearchElemental.Controls.Add(this.rbSearchFire);
            this.gbSearchElemental.Controls.Add(this.rbSearchAqua);
            this.gbSearchElemental.Controls.Add(this.rbSearchLight);
            this.gbSearchElemental.Controls.Add(this.rbSearchGod);
            this.gbSearchElemental.Controls.Add(this.rbSearchWind);
            this.gbSearchElemental.Controls.Add(this.rbSearchDark);
            this.gbSearchElemental.Controls.Add(this.rbSearchMagic);
            this.gbSearchElemental.Controls.Add(this.rbSearchTrap);
            this.gbSearchElemental.Controls.Add(this.rbSearchNorth);
            this.gbSearchElemental.Location = new System.Drawing.Point(76, 77);
            this.gbSearchElemental.Name = "gbSearchElemental";
            this.gbSearchElemental.Size = new System.Drawing.Size(217, 50);
            this.gbSearchElemental.TabIndex = 6;
            this.gbSearchElemental.TabStop = false;
            // 
            // rbSearchFire
            // 
            this.rbSearchFire.AutoSize = true;
            this.rbSearchFire.Checked = true;
            this.rbSearchFire.Location = new System.Drawing.Point(6, 10);
            this.rbSearchFire.Name = "rbSearchFire";
            this.rbSearchFire.Size = new System.Drawing.Size(35, 16);
            this.rbSearchFire.TabIndex = 3;
            this.rbSearchFire.TabStop = true;
            this.rbSearchFire.Tag = "1";
            this.rbSearchFire.Text = "火";
            this.rbSearchFire.UseVisualStyleBackColor = true;
            // 
            // rbSearchAqua
            // 
            this.rbSearchAqua.AutoSize = true;
            this.rbSearchAqua.Location = new System.Drawing.Point(47, 10);
            this.rbSearchAqua.Name = "rbSearchAqua";
            this.rbSearchAqua.Size = new System.Drawing.Size(35, 16);
            this.rbSearchAqua.TabIndex = 3;
            this.rbSearchAqua.Tag = "2";
            this.rbSearchAqua.Text = "水";
            this.rbSearchAqua.UseVisualStyleBackColor = true;
            // 
            // rbSearchLight
            // 
            this.rbSearchLight.AutoSize = true;
            this.rbSearchLight.Location = new System.Drawing.Point(6, 32);
            this.rbSearchLight.Name = "rbSearchLight";
            this.rbSearchLight.Size = new System.Drawing.Size(35, 16);
            this.rbSearchLight.TabIndex = 3;
            this.rbSearchLight.Tag = "6";
            this.rbSearchLight.Text = "光";
            this.rbSearchLight.UseVisualStyleBackColor = true;
            // 
            // rbSearchGod
            // 
            this.rbSearchGod.AutoSize = true;
            this.rbSearchGod.Location = new System.Drawing.Point(47, 32);
            this.rbSearchGod.Name = "rbSearchGod";
            this.rbSearchGod.Size = new System.Drawing.Size(35, 16);
            this.rbSearchGod.TabIndex = 3;
            this.rbSearchGod.Tag = "7";
            this.rbSearchGod.Text = "神";
            this.rbSearchGod.UseVisualStyleBackColor = true;
            // 
            // rbSearchWind
            // 
            this.rbSearchWind.AutoSize = true;
            this.rbSearchWind.Location = new System.Drawing.Point(88, 10);
            this.rbSearchWind.Name = "rbSearchWind";
            this.rbSearchWind.Size = new System.Drawing.Size(35, 16);
            this.rbSearchWind.TabIndex = 3;
            this.rbSearchWind.Tag = "3";
            this.rbSearchWind.Text = "風";
            this.rbSearchWind.UseVisualStyleBackColor = true;
            // 
            // rbSearchDark
            // 
            this.rbSearchDark.AutoSize = true;
            this.rbSearchDark.Location = new System.Drawing.Point(171, 10);
            this.rbSearchDark.Name = "rbSearchDark";
            this.rbSearchDark.Size = new System.Drawing.Size(35, 16);
            this.rbSearchDark.TabIndex = 3;
            this.rbSearchDark.Tag = "5";
            this.rbSearchDark.Text = "闇";
            this.rbSearchDark.UseVisualStyleBackColor = true;
            // 
            // rbSearchMagic
            // 
            this.rbSearchMagic.AutoSize = true;
            this.rbSearchMagic.Location = new System.Drawing.Point(88, 31);
            this.rbSearchMagic.Name = "rbSearchMagic";
            this.rbSearchMagic.Size = new System.Drawing.Size(47, 16);
            this.rbSearchMagic.TabIndex = 3;
            this.rbSearchMagic.Tag = "8";
            this.rbSearchMagic.Text = "魔法";
            this.rbSearchMagic.UseVisualStyleBackColor = true;
            // 
            // rbSearchTrap
            // 
            this.rbSearchTrap.AutoSize = true;
            this.rbSearchTrap.Location = new System.Drawing.Point(141, 32);
            this.rbSearchTrap.Name = "rbSearchTrap";
            this.rbSearchTrap.Size = new System.Drawing.Size(35, 16);
            this.rbSearchTrap.TabIndex = 3;
            this.rbSearchTrap.Tag = "9";
            this.rbSearchTrap.Text = "罠";
            this.rbSearchTrap.UseVisualStyleBackColor = true;
            // 
            // rbSearchNorth
            // 
            this.rbSearchNorth.AutoSize = true;
            this.rbSearchNorth.Location = new System.Drawing.Point(129, 10);
            this.rbSearchNorth.Name = "rbSearchNorth";
            this.rbSearchNorth.Size = new System.Drawing.Size(35, 16);
            this.rbSearchNorth.TabIndex = 3;
            this.rbSearchNorth.Tag = "4";
            this.rbSearchNorth.Text = "地";
            this.rbSearchNorth.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(30, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "日付：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(17, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "記録者：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(30, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "属性：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(882, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 19);
            this.textBox2.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(14, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "カード名：";
            // 
            // rbAND
            // 
            this.rbAND.AutoSize = true;
            this.rbAND.Checked = true;
            this.rbAND.Location = new System.Drawing.Point(76, 203);
            this.rbAND.Name = "rbAND";
            this.rbAND.Size = new System.Drawing.Size(47, 16);
            this.rbAND.TabIndex = 26;
            this.rbAND.TabStop = true;
            this.rbAND.Text = "AND";
            this.rbAND.UseVisualStyleBackColor = true;
            // 
            // rbOR
            // 
            this.rbOR.AutoSize = true;
            this.rbOR.Location = new System.Drawing.Point(211, 203);
            this.rbOR.Name = "rbOR";
            this.rbOR.Size = new System.Drawing.Size(39, 16);
            this.rbOR.TabIndex = 26;
            this.rbOR.Text = "OR";
            this.rbOR.UseVisualStyleBackColor = true;
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
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Elemental";
            this.dataGridViewTextBoxColumn4.HeaderText = "Elemental";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Text";
            this.dataGridViewTextBoxColumn6.HeaderText = "Text";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // cardReportBindingSource
            // 
            this.cardReportBindingSource.DataMember = "CardReport";
            this.cardReportBindingSource.DataSource = this.infosys202022DataSet;
            // 
            // infosys202022DataSet
            // 
            this.infosys202022DataSet.DataSetName = "infosys202022DataSet";
            this.infosys202022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 704);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCardData);
            this.Controls.Add(this.btImageDelete);
            this.Controls.Add(this.btCardDelete);
            this.Controls.Add(this.btCardChange);
            this.Controls.Add(this.textBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSearchElemental.ResumeLayout(false);
            this.gbSearchElemental.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202022DataSet)).EndInit();
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
        private System.Windows.Forms.TextBox tbSearchCardName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bfSearchExe;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dbSearchDate;
        private System.Windows.Forms.GroupBox gbSearchElemental;
        private System.Windows.Forms.RadioButton rbSearchFire;
        private System.Windows.Forms.RadioButton rbSearchAqua;
        private System.Windows.Forms.RadioButton rbSearchLight;
        private System.Windows.Forms.RadioButton rbSearchGod;
        private System.Windows.Forms.RadioButton rbSearchWind;
        private System.Windows.Forms.RadioButton rbSearchDark;
        private System.Windows.Forms.RadioButton rbSearchMagic;
        private System.Windows.Forms.RadioButton rbSearchTrap;
        private System.Windows.Forms.RadioButton rbSearchNorth;
        private System.Windows.Forms.TextBox tbSearchAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbOR;
        private System.Windows.Forms.RadioButton rbAND;
        private System.Windows.Forms.Label label11;
    }
}

