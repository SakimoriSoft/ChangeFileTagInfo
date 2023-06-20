namespace ファイルTAG情報変更ツール
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlFolder = new System.Windows.Forms.Panel();
            this.pnlFolderName = new System.Windows.Forms.Panel();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.pnlFolderLabel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSystemActions = new System.Windows.Forms.Panel();
            this.pnlTargetExtension = new System.Windows.Forms.Panel();
            this.pnlComboExtensions = new System.Windows.Forms.Panel();
            this.pnlExtensions = new System.Windows.Forms.Panel();
            this.cmbExtensions = new System.Windows.Forms.ComboBox();
            this.pnlCombo = new System.Windows.Forms.Panel();
            this.cmbTarget = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlSystemBtns = new System.Windows.Forms.Panel();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlList = new System.Windows.Forms.Panel();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.pnlTagActions = new System.Windows.Forms.Panel();
            this.cmbDigit = new System.Windows.Forms.ComboBox();
            this.cmbPattern = new System.Windows.Forms.ComboBox();
            this.btnTrackNoReNumber = new System.Windows.Forms.Button();
            this.btnReNumber = new System.Windows.Forms.Button();
            this.btnChangeFilenameWithNumber = new System.Windows.Forms.Button();
            this.btnChangeAllFileInfo = new System.Windows.Forms.Button();
            this.pnlTag = new System.Windows.Forms.Panel();
            this.pnlImageTrack = new System.Windows.Forms.Panel();
            this.pnlTrackNo = new System.Windows.Forms.Panel();
            this.txtTrackNO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.pnlTagInfo = new System.Windows.Forms.Panel();
            this.btnItemUnification = new System.Windows.Forms.Button();
            this.cmbItemUnification = new System.Windows.Forms.ComboBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtAlbumArtists = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArtists = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlFolder.SuspendLayout();
            this.pnlFolderName.SuspendLayout();
            this.pnlFolderLabel.SuspendLayout();
            this.pnlSystemActions.SuspendLayout();
            this.pnlTargetExtension.SuspendLayout();
            this.pnlComboExtensions.SuspendLayout();
            this.pnlExtensions.SuspendLayout();
            this.pnlCombo.SuspendLayout();
            this.pnlSystemBtns.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.pnlTagActions.SuspendLayout();
            this.pnlTag.SuspendLayout();
            this.pnlImageTrack.SuspendLayout();
            this.pnlTrackNo.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.pnlTagInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.pnlFolder);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1424, 79);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlFolder
            // 
            this.pnlFolder.Controls.Add(this.pnlFolderName);
            this.pnlFolder.Controls.Add(this.pnlFolderLabel);
            this.pnlFolder.Controls.Add(this.pnlSystemActions);
            this.pnlFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFolder.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlFolder.Location = new System.Drawing.Point(0, 0);
            this.pnlFolder.Name = "pnlFolder";
            this.pnlFolder.Size = new System.Drawing.Size(1424, 79);
            this.pnlFolder.TabIndex = 1;
            // 
            // pnlFolderName
            // 
            this.pnlFolderName.Controls.Add(this.txtFolder);
            this.pnlFolderName.Controls.Add(this.btnSelectFolder);
            this.pnlFolderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFolderName.Location = new System.Drawing.Point(103, 0);
            this.pnlFolderName.Name = "pnlFolderName";
            this.pnlFolderName.Padding = new System.Windows.Forms.Padding(3, 22, 20, 22);
            this.pnlFolderName.Size = new System.Drawing.Size(769, 79);
            this.pnlFolderName.TabIndex = 19;
            // 
            // txtFolder
            // 
            this.txtFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.txtFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFolder.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFolder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFolder.Location = new System.Drawing.Point(3, 22);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(718, 35);
            this.txtFolder.TabIndex = 10;
            this.txtFolder.Enter += new System.EventHandler(this.txtFolder_Enter);
            this.txtFolder.Leave += new System.EventHandler(this.txtFolder_Leave);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectFolder.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSelectFolder.Location = new System.Drawing.Point(721, 22);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(28, 35);
            this.btnSelectFolder.TabIndex = 9;
            this.btnSelectFolder.Text = "…";
            this.btnSelectFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // pnlFolderLabel
            // 
            this.pnlFolderLabel.Controls.Add(this.label1);
            this.pnlFolderLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFolderLabel.Location = new System.Drawing.Point(0, 0);
            this.pnlFolderLabel.Name = "pnlFolderLabel";
            this.pnlFolderLabel.Padding = new System.Windows.Forms.Padding(40, 30, 3, 30);
            this.pnlFolderLabel.Size = new System.Drawing.Size(103, 79);
            this.pnlFolderLabel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "フォルダ";
            // 
            // pnlSystemActions
            // 
            this.pnlSystemActions.Controls.Add(this.pnlTargetExtension);
            this.pnlSystemActions.Controls.Add(this.pnlSystemBtns);
            this.pnlSystemActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSystemActions.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlSystemActions.Location = new System.Drawing.Point(872, 0);
            this.pnlSystemActions.Margin = new System.Windows.Forms.Padding(20);
            this.pnlSystemActions.Name = "pnlSystemActions";
            this.pnlSystemActions.Size = new System.Drawing.Size(552, 79);
            this.pnlSystemActions.TabIndex = 13;
            // 
            // pnlTargetExtension
            // 
            this.pnlTargetExtension.AutoSize = true;
            this.pnlTargetExtension.Controls.Add(this.pnlComboExtensions);
            this.pnlTargetExtension.Controls.Add(this.label8);
            this.pnlTargetExtension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTargetExtension.Location = new System.Drawing.Point(0, 0);
            this.pnlTargetExtension.Name = "pnlTargetExtension";
            this.pnlTargetExtension.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTargetExtension.Size = new System.Drawing.Size(312, 79);
            this.pnlTargetExtension.TabIndex = 6;
            // 
            // pnlComboExtensions
            // 
            this.pnlComboExtensions.Controls.Add(this.pnlExtensions);
            this.pnlComboExtensions.Controls.Add(this.pnlCombo);
            this.pnlComboExtensions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlComboExtensions.Location = new System.Drawing.Point(10, 36);
            this.pnlComboExtensions.Name = "pnlComboExtensions";
            this.pnlComboExtensions.Size = new System.Drawing.Size(292, 33);
            this.pnlComboExtensions.TabIndex = 8;
            // 
            // pnlExtensions
            // 
            this.pnlExtensions.Controls.Add(this.cmbExtensions);
            this.pnlExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExtensions.Location = new System.Drawing.Point(186, 0);
            this.pnlExtensions.Name = "pnlExtensions";
            this.pnlExtensions.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlExtensions.Size = new System.Drawing.Size(106, 33);
            this.pnlExtensions.TabIndex = 1;
            // 
            // cmbExtensions
            // 
            this.cmbExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbExtensions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExtensions.Font = new System.Drawing.Font("メイリオ", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbExtensions.FormattingEnabled = true;
            this.cmbExtensions.Location = new System.Drawing.Point(5, 0);
            this.cmbExtensions.Name = "cmbExtensions";
            this.cmbExtensions.Size = new System.Drawing.Size(101, 33);
            this.cmbExtensions.TabIndex = 0;
            // 
            // pnlCombo
            // 
            this.pnlCombo.Controls.Add(this.cmbTarget);
            this.pnlCombo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCombo.Location = new System.Drawing.Point(0, 0);
            this.pnlCombo.Name = "pnlCombo";
            this.pnlCombo.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnlCombo.Size = new System.Drawing.Size(186, 33);
            this.pnlCombo.TabIndex = 0;
            // 
            // cmbTarget
            // 
            this.cmbTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarget.Font = new System.Drawing.Font("メイリオ", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Location = new System.Drawing.Point(0, 0);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(181, 33);
            this.cmbTarget.TabIndex = 9;
            this.cmbTarget.SelectedValueChanged += new System.EventHandler(this.cmbTarget_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "対象拡張子";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSystemBtns
            // 
            this.pnlSystemBtns.Controls.Add(this.btnOpenFolder);
            this.pnlSystemBtns.Controls.Add(this.btnExit);
            this.pnlSystemBtns.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSystemBtns.Location = new System.Drawing.Point(312, 0);
            this.pnlSystemBtns.Name = "pnlSystemBtns";
            this.pnlSystemBtns.Padding = new System.Windows.Forms.Padding(10, 18, 20, 18);
            this.pnlSystemBtns.Size = new System.Drawing.Size(240, 79);
            this.pnlSystemBtns.TabIndex = 5;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpenFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOpenFolder.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOpenFolder.Location = new System.Drawing.Point(10, 18);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(91, 43);
            this.btnOpenFolder.TabIndex = 6;
            this.btnOpenFolder.Text = "開　く";
            this.btnOpenFolder.UseVisualStyleBackColor = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Font = new System.Drawing.Font("メイリオ", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExit.Location = new System.Drawing.Point(129, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "終　了";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1424, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.pnlBody);
            this.pnlInfo.Controls.Add(this.pnlTag);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(0, 79);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(1424, 580);
            this.pnlInfo.TabIndex = 4;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlList);
            this.pnlBody.Controls.Add(this.pnlTagActions);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlBody.Location = new System.Drawing.Point(319, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1105, 580);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvFiles);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Font = new System.Drawing.Font("メイリオ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pnlList.Location = new System.Drawing.Point(0, 60);
            this.pnlList.Margin = new System.Windows.Forms.Padding(0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Padding = new System.Windows.Forms.Padding(15, 10, 20, 20);
            this.pnlList.Size = new System.Drawing.Size(1105, 520);
            this.pnlList.TabIndex = 1;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowDrop = true;
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.dgvFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFiles.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFiles.Location = new System.Drawing.Point(15, 10);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowHeadersWidth = 31;
            this.dgvFiles.RowTemplate.Height = 21;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.ShowCellToolTips = false;
            this.dgvFiles.Size = new System.Drawing.Size(1070, 490);
            this.dgvFiles.TabIndex = 1;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellClick);
            this.dgvFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellDoubleClick);
            this.dgvFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvFiles_DragDrop);
            this.dgvFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvFiles_DragOver);
            this.dgvFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvFiles_MouseDown);
            this.dgvFiles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvFiles_MouseMove);
            // 
            // pnlTagActions
            // 
            this.pnlTagActions.Controls.Add(this.cmbDigit);
            this.pnlTagActions.Controls.Add(this.cmbPattern);
            this.pnlTagActions.Controls.Add(this.btnTrackNoReNumber);
            this.pnlTagActions.Controls.Add(this.btnReNumber);
            this.pnlTagActions.Controls.Add(this.btnChangeFilenameWithNumber);
            this.pnlTagActions.Controls.Add(this.btnChangeAllFileInfo);
            this.pnlTagActions.Controls.Add(this.label9);
            this.pnlTagActions.Controls.Add(this.label10);
            this.pnlTagActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTagActions.Location = new System.Drawing.Point(0, 0);
            this.pnlTagActions.Name = "pnlTagActions";
            this.pnlTagActions.Padding = new System.Windows.Forms.Padding(15, 15, 20, 5);
            this.pnlTagActions.Size = new System.Drawing.Size(1105, 60);
            this.pnlTagActions.TabIndex = 0;
            // 
            // cmbDigit
            // 
            this.cmbDigit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDigit.FormattingEnabled = true;
            this.cmbDigit.Location = new System.Drawing.Point(793, 20);
            this.cmbDigit.Name = "cmbDigit";
            this.cmbDigit.Size = new System.Drawing.Size(56, 31);
            this.cmbDigit.TabIndex = 11;
            // 
            // cmbPattern
            // 
            this.cmbPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPattern.FormattingEnabled = true;
            this.cmbPattern.Location = new System.Drawing.Point(616, 20);
            this.cmbPattern.Name = "cmbPattern";
            this.cmbPattern.Size = new System.Drawing.Size(124, 31);
            this.cmbPattern.TabIndex = 10;
            this.cmbPattern.SelectedValueChanged += new System.EventHandler(this.cmbPattern_SelectedValueChanged);
            // 
            // btnTrackNoReNumber
            // 
            this.btnTrackNoReNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTrackNoReNumber.Font = new System.Drawing.Font("メイリオ", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTrackNoReNumber.Location = new System.Drawing.Point(126, 18);
            this.btnTrackNoReNumber.Name = "btnTrackNoReNumber";
            this.btnTrackNoReNumber.Size = new System.Drawing.Size(169, 34);
            this.btnTrackNoReNumber.TabIndex = 8;
            this.btnTrackNoReNumber.Text = "トラック番号再振";
            this.btnTrackNoReNumber.UseVisualStyleBackColor = false;
            this.btnTrackNoReNumber.Click += new System.EventHandler(this.btnTrackNoReNumber_Click);
            // 
            // btnReNumber
            // 
            this.btnReNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReNumber.Font = new System.Drawing.Font("メイリオ", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReNumber.Location = new System.Drawing.Point(18, 18);
            this.btnReNumber.Name = "btnReNumber";
            this.btnReNumber.Size = new System.Drawing.Size(102, 34);
            this.btnReNumber.TabIndex = 7;
            this.btnReNumber.Text = "番号再振";
            this.btnReNumber.UseVisualStyleBackColor = false;
            this.btnReNumber.Click += new System.EventHandler(this.btnReNumber_Click);
            // 
            // btnChangeFilenameWithNumber
            // 
            this.btnChangeFilenameWithNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeFilenameWithNumber.Font = new System.Drawing.Font("メイリオ", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnChangeFilenameWithNumber.Location = new System.Drawing.Point(316, 18);
            this.btnChangeFilenameWithNumber.Name = "btnChangeFilenameWithNumber";
            this.btnChangeFilenameWithNumber.Size = new System.Drawing.Size(189, 34);
            this.btnChangeFilenameWithNumber.TabIndex = 6;
            this.btnChangeFilenameWithNumber.Text = "ファイル名連番付与";
            this.btnChangeFilenameWithNumber.UseVisualStyleBackColor = false;
            this.btnChangeFilenameWithNumber.Click += new System.EventHandler(this.btnChangeFilenameWithNumber_Click);
            // 
            // btnChangeAllFileInfo
            // 
            this.btnChangeAllFileInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeAllFileInfo.Font = new System.Drawing.Font("メイリオ", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnChangeAllFileInfo.Location = new System.Drawing.Point(891, 18);
            this.btnChangeAllFileInfo.Name = "btnChangeAllFileInfo";
            this.btnChangeAllFileInfo.Size = new System.Drawing.Size(194, 34);
            this.btnChangeAllFileInfo.TabIndex = 5;
            this.btnChangeAllFileInfo.Text = "ファイル情報一括変更";
            this.btnChangeAllFileInfo.UseVisualStyleBackColor = false;
            this.btnChangeAllFileInfo.Click += new System.EventHandler(this.btnChangeFileInfo_Click);
            // 
            // pnlTag
            // 
            this.pnlTag.Controls.Add(this.pnlImageTrack);
            this.pnlTag.Controls.Add(this.pnlTagInfo);
            this.pnlTag.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTag.Location = new System.Drawing.Point(0, 0);
            this.pnlTag.Name = "pnlTag";
            this.pnlTag.Size = new System.Drawing.Size(319, 580);
            this.pnlTag.TabIndex = 0;
            // 
            // pnlImageTrack
            // 
            this.pnlImageTrack.Controls.Add(this.pnlTrackNo);
            this.pnlImageTrack.Controls.Add(this.pnlImage);
            this.pnlImageTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImageTrack.Location = new System.Drawing.Point(0, 420);
            this.pnlImageTrack.Name = "pnlImageTrack";
            this.pnlImageTrack.Size = new System.Drawing.Size(319, 160);
            this.pnlImageTrack.TabIndex = 2;
            // 
            // pnlTrackNo
            // 
            this.pnlTrackNo.Controls.Add(this.txtTrackNO);
            this.pnlTrackNo.Controls.Add(this.label7);
            this.pnlTrackNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrackNo.Location = new System.Drawing.Point(155, 0);
            this.pnlTrackNo.Name = "pnlTrackNo";
            this.pnlTrackNo.Size = new System.Drawing.Size(164, 160);
            this.pnlTrackNo.TabIndex = 1;
            // 
            // txtTrackNO
            // 
            this.txtTrackNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.txtTrackNO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrackNO.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTrackNO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTrackNO.Location = new System.Drawing.Point(114, 6);
            this.txtTrackNO.Name = "txtTrackNO";
            this.txtTrackNO.Size = new System.Drawing.Size(44, 29);
            this.txtTrackNO.TabIndex = 18;
            this.txtTrackNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(6, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "トラック番号:";
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.picImage);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Padding = new System.Windows.Forms.Padding(5);
            this.pnlImage.Size = new System.Drawing.Size(155, 160);
            this.pnlImage.TabIndex = 0;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(16, 8);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(125, 125);
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // pnlTagInfo
            // 
            this.pnlTagInfo.Controls.Add(this.btnItemUnification);
            this.pnlTagInfo.Controls.Add(this.cmbItemUnification);
            this.pnlTagInfo.Controls.Add(this.txtAlbum);
            this.pnlTagInfo.Controls.Add(this.txtAlbumArtists);
            this.pnlTagInfo.Controls.Add(this.label5);
            this.pnlTagInfo.Controls.Add(this.label6);
            this.pnlTagInfo.Controls.Add(this.txtTitle);
            this.pnlTagInfo.Controls.Add(this.label4);
            this.pnlTagInfo.Controls.Add(this.txtArtists);
            this.pnlTagInfo.Controls.Add(this.label3);
            this.pnlTagInfo.Controls.Add(this.txtFilename);
            this.pnlTagInfo.Controls.Add(this.label2);
            this.pnlTagInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTagInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlTagInfo.Name = "pnlTagInfo";
            this.pnlTagInfo.Padding = new System.Windows.Forms.Padding(20, 20, 20, 5);
            this.pnlTagInfo.Size = new System.Drawing.Size(319, 420);
            this.pnlTagInfo.TabIndex = 1;
            // 
            // btnItemUnification
            // 
            this.btnItemUnification.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnItemUnification.Font = new System.Drawing.Font("メイリオ", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnItemUnification.Location = new System.Drawing.Point(201, 371);
            this.btnItemUnification.Name = "btnItemUnification";
            this.btnItemUnification.Size = new System.Drawing.Size(99, 34);
            this.btnItemUnification.TabIndex = 18;
            this.btnItemUnification.Text = "統一する";
            this.btnItemUnification.UseVisualStyleBackColor = false;
            this.btnItemUnification.Click += new System.EventHandler(this.btnItemUnification_Click);
            // 
            // cmbItemUnification
            // 
            this.cmbItemUnification.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbItemUnification.FormattingEnabled = true;
            this.cmbItemUnification.Items.AddRange(new object[] {
            "アーティスト",
            "アルバム名",
            "アルバムアーティスト"});
            this.cmbItemUnification.Location = new System.Drawing.Point(16, 371);
            this.cmbItemUnification.Name = "cmbItemUnification";
            this.cmbItemUnification.Size = new System.Drawing.Size(179, 31);
            this.cmbItemUnification.TabIndex = 17;
            // 
            // txtAlbum
            // 
            this.txtAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.txtAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlbum.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAlbum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAlbum.Location = new System.Drawing.Point(16, 256);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(284, 29);
            this.txtAlbum.TabIndex = 16;
            // 
            // txtAlbumArtists
            // 
            this.txtAlbumArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.txtAlbumArtists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlbumArtists.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAlbumArtists.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAlbumArtists.Location = new System.Drawing.Point(16, 326);
            this.txtAlbumArtists.Name = "txtAlbumArtists";
            this.txtAlbumArtists.Size = new System.Drawing.Size(284, 29);
            this.txtAlbumArtists.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "アルバムアーティスト:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "アルバム名:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTitle.Location = new System.Drawing.Point(16, 116);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(284, 29);
            this.txtTitle.TabIndex = 12;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "タイトル:";
            // 
            // txtArtists
            // 
            this.txtArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.txtArtists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArtists.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtArtists.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtArtists.Location = new System.Drawing.Point(16, 186);
            this.txtArtists.Name = "txtArtists";
            this.txtArtists.Size = new System.Drawing.Size(284, 29);
            this.txtArtists.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "アーティスト:";
            // 
            // txtFilename
            // 
            this.txtFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.txtFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilename.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFilename.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFilename.Location = new System.Drawing.Point(16, 46);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(284, 29);
            this.txtFilename.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "ファイル名:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(511, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "付与パターン";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(750, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "桁数";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1424, 681);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1440, 720);
            this.Name = "Form1";
            this.Text = "ｚ";
            this.pnlTop.ResumeLayout(false);
            this.pnlFolder.ResumeLayout(false);
            this.pnlFolderName.ResumeLayout(false);
            this.pnlFolderName.PerformLayout();
            this.pnlFolderLabel.ResumeLayout(false);
            this.pnlFolderLabel.PerformLayout();
            this.pnlSystemActions.ResumeLayout(false);
            this.pnlSystemActions.PerformLayout();
            this.pnlTargetExtension.ResumeLayout(false);
            this.pnlTargetExtension.PerformLayout();
            this.pnlComboExtensions.ResumeLayout(false);
            this.pnlExtensions.ResumeLayout(false);
            this.pnlCombo.ResumeLayout(false);
            this.pnlSystemBtns.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.pnlTagActions.ResumeLayout(false);
            this.pnlTagActions.PerformLayout();
            this.pnlTag.ResumeLayout(false);
            this.pnlImageTrack.ResumeLayout(false);
            this.pnlTrackNo.ResumeLayout(false);
            this.pnlTrackNo.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.pnlTagInfo.ResumeLayout(false);
            this.pnlTagInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlFolder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlTag;
        private System.Windows.Forms.Panel pnlTagInfo;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlbumArtists;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArtists;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Panel pnlTagActions;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.Button btnChangeAllFileInfo;
        private System.Windows.Forms.Button btnChangeFilenameWithNumber;
        private System.Windows.Forms.Button btnReNumber;
        private System.Windows.Forms.Panel pnlImageTrack;
        private System.Windows.Forms.Panel pnlTrackNo;
        private System.Windows.Forms.TextBox txtTrackNO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Panel pnlFolderName;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Panel pnlFolderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSystemActions;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnTrackNoReNumber;
        private System.Windows.Forms.ComboBox cmbItemUnification;
        private System.Windows.Forms.Button btnItemUnification;
        private System.Windows.Forms.Panel pnlTargetExtension;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlSystemBtns;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlComboExtensions;
        private System.Windows.Forms.Panel pnlCombo;
        private System.Windows.Forms.ComboBox cmbTarget;
        private System.Windows.Forms.Panel pnlExtensions;
        private System.Windows.Forms.ComboBox cmbExtensions;
        private System.Windows.Forms.ComboBox cmbDigit;
        private System.Windows.Forms.ComboBox cmbPattern;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

