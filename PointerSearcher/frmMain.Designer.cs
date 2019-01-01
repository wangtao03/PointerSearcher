namespace PointerSearcher
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splMain = new System.Windows.Forms.SplitContainer();
            this.grpDump = new System.Windows.Forms.GroupBox();
            this.labAddress4 = new System.Windows.Forms.Label();
            this.txtMemDump4 = new System.Windows.Forms.TextBox();
            this.txtAddress4 = new System.Windows.Forms.TextBox();
            this.chkMemDump4 = new System.Windows.Forms.CheckBox();
            this.labMemDump4 = new System.Windows.Forms.Label();
            this.labAddress3 = new System.Windows.Forms.Label();
            this.txtMemDump3 = new System.Windows.Forms.TextBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtBaseAddress = new System.Windows.Forms.TextBox();
            this.labBaseAddress = new System.Windows.Forms.Label();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.txtMaxOffset = new System.Windows.Forms.TextBox();
            this.labMemDump2 = new System.Windows.Forms.Label();
            this.labMemDump1 = new System.Windows.Forms.Label();
            this.labMode = new System.Windows.Forms.Label();
            this.labAddress2 = new System.Windows.Forms.Label();
            this.labAddress1 = new System.Windows.Forms.Label();
            this.txtMemDump2 = new System.Windows.Forms.TextBox();
            this.txtMemDump1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.labMaxOffset = new System.Windows.Forms.Label();
            this.chkMemDump3 = new System.Windows.Forms.CheckBox();
            this.labMemDump3 = new System.Windows.Forms.Label();
            this.grp = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbPointerSearcherBitType32 = new System.Windows.Forms.RadioButton();
            this.rdbPointerSearcherBitType8 = new System.Windows.Forms.RadioButton();
            this.rdbPointerSearcherBitType16 = new System.Windows.Forms.RadioButton();
            this.grpOtheOption = new System.Windows.Forms.GroupBox();
            this.chkFilteringInvalid = new System.Windows.Forms.CheckBox();
            this.chkRealAddresses = new System.Windows.Forms.CheckBox();
            this.chkOptimizePointerPaths = new System.Windows.Forms.CheckBox();
            this.chkRAWCode = new System.Windows.Forms.CheckBox();
            this.chkIncludeNegatives = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFindPointers = new System.Windows.Forms.Button();
            this.splMain_Data = new System.Windows.Forms.SplitContainer();
            this.tvwPointers = new System.Windows.Forms.TreeView();
            this.splMain_Data_Code = new System.Windows.Forms.SplitContainer();
            this.rdoCodeTypeAR = new System.Windows.Forms.RadioButton();
            this.rdoCodeTypeCWCheat = new System.Windows.Forms.RadioButton();
            this.cmbPsvCheatCodeType = new System.Windows.Forms.ComboBox();
            this.rdoCpdeTypePsvCheat = new System.Windows.Forms.RadioButton();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            this.grpDump.SuspendLayout();
            this.grp.SuspendLayout();
            this.grpOtheOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMain_Data)).BeginInit();
            this.splMain_Data.Panel1.SuspendLayout();
            this.splMain_Data.Panel2.SuspendLayout();
            this.splMain_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMain_Data_Code)).BeginInit();
            this.splMain_Data_Code.Panel1.SuspendLayout();
            this.splMain_Data_Code.Panel2.SuspendLayout();
            this.splMain_Data_Code.SuspendLayout();
            this.SuspendLayout();
            // 
            // splMain
            // 
            this.splMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splMain.IsSplitterFixed = true;
            this.splMain.Location = new System.Drawing.Point(0, 0);
            this.splMain.Name = "splMain";
            // 
            // splMain.Panel1
            // 
            this.splMain.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splMain.Panel1.Controls.Add(this.grpDump);
            this.splMain.Panel1.Controls.Add(this.grp);
            this.splMain.Panel1.Controls.Add(this.grpOtheOption);
            this.splMain.Panel1MinSize = 300;
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.splMain_Data);
            this.splMain.Panel2MinSize = 400;
            this.splMain.Size = new System.Drawing.Size(784, 492);
            this.splMain.SplitterDistance = 300;
            this.splMain.SplitterWidth = 2;
            this.splMain.TabIndex = 0;
            // 
            // grpDump
            // 
            this.grpDump.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDump.BackColor = System.Drawing.Color.White;
            this.grpDump.Controls.Add(this.labAddress4);
            this.grpDump.Controls.Add(this.txtMemDump4);
            this.grpDump.Controls.Add(this.txtAddress4);
            this.grpDump.Controls.Add(this.chkMemDump4);
            this.grpDump.Controls.Add(this.labMemDump4);
            this.grpDump.Controls.Add(this.labAddress3);
            this.grpDump.Controls.Add(this.txtMemDump3);
            this.grpDump.Controls.Add(this.txtAddress3);
            this.grpDump.Controls.Add(this.txtBaseAddress);
            this.grpDump.Controls.Add(this.labBaseAddress);
            this.grpDump.Controls.Add(this.cmbMode);
            this.grpDump.Controls.Add(this.txtMaxOffset);
            this.grpDump.Controls.Add(this.labMemDump2);
            this.grpDump.Controls.Add(this.labMemDump1);
            this.grpDump.Controls.Add(this.labMode);
            this.grpDump.Controls.Add(this.labAddress2);
            this.grpDump.Controls.Add(this.labAddress1);
            this.grpDump.Controls.Add(this.txtMemDump2);
            this.grpDump.Controls.Add(this.txtMemDump1);
            this.grpDump.Controls.Add(this.txtAddress2);
            this.grpDump.Controls.Add(this.txtAddress1);
            this.grpDump.Controls.Add(this.labMaxOffset);
            this.grpDump.Controls.Add(this.chkMemDump3);
            this.grpDump.Controls.Add(this.labMemDump3);
            this.grpDump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDump.Location = new System.Drawing.Point(3, 3);
            this.grpDump.Name = "grpDump";
            this.grpDump.Size = new System.Drawing.Size(292, 290);
            this.grpDump.TabIndex = 0;
            this.grpDump.TabStop = false;
            this.grpDump.Text = "转储信息";
            // 
            // labAddress4
            // 
            this.labAddress4.AutoSize = true;
            this.labAddress4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labAddress4.Location = new System.Drawing.Point(6, 189);
            this.labAddress4.Name = "labAddress4";
            this.labAddress4.Size = new System.Drawing.Size(41, 12);
            this.labAddress4.TabIndex = 39;
            this.labAddress4.Text = "地址4:";
            this.labAddress4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMemDump4
            // 
            this.txtMemDump4.AllowDrop = true;
            this.txtMemDump4.Enabled = false;
            this.txtMemDump4.Location = new System.Drawing.Point(97, 161);
            this.txtMemDump4.Name = "txtMemDump4";
            this.txtMemDump4.ReadOnly = true;
            this.txtMemDump4.Size = new System.Drawing.Size(189, 21);
            this.txtMemDump4.TabIndex = 38;
            this.txtMemDump4.Click += new System.EventHandler(this.TxtFile_Click);
            this.txtMemDump4.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFile_DragDrop);
            this.txtMemDump4.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFileDragDrop_DragEnter);
            // 
            // txtAddress4
            // 
            this.txtAddress4.Enabled = false;
            this.txtAddress4.ForeColor = System.Drawing.Color.Red;
            this.txtAddress4.Location = new System.Drawing.Point(97, 185);
            this.txtAddress4.MaxLength = 10;
            this.txtAddress4.Name = "txtAddress4";
            this.txtAddress4.Size = new System.Drawing.Size(189, 21);
            this.txtAddress4.TabIndex = 40;
            // 
            // chkMemDump4
            // 
            this.chkMemDump4.AutoSize = true;
            this.chkMemDump4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMemDump4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkMemDump4.Location = new System.Drawing.Point(80, 164);
            this.chkMemDump4.Name = "chkMemDump4";
            this.chkMemDump4.Size = new System.Drawing.Size(15, 14);
            this.chkMemDump4.TabIndex = 41;
            this.chkMemDump4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMemDump4.UseVisualStyleBackColor = true;
            this.chkMemDump4.CheckedChanged += new System.EventHandler(this.ChkMemDump4_CheckedChanged);
            // 
            // labMemDump4
            // 
            this.labMemDump4.AutoSize = true;
            this.labMemDump4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labMemDump4.Location = new System.Drawing.Point(6, 165);
            this.labMemDump4.Name = "labMemDump4";
            this.labMemDump4.Size = new System.Drawing.Size(77, 12);
            this.labMemDump4.TabIndex = 37;
            this.labMemDump4.Text = "转储4(可选):";
            this.labMemDump4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labAddress3
            // 
            this.labAddress3.AutoSize = true;
            this.labAddress3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labAddress3.Location = new System.Drawing.Point(6, 140);
            this.labAddress3.Name = "labAddress3";
            this.labAddress3.Size = new System.Drawing.Size(41, 12);
            this.labAddress3.TabIndex = 34;
            this.labAddress3.Text = "地址3:";
            this.labAddress3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMemDump3
            // 
            this.txtMemDump3.AllowDrop = true;
            this.txtMemDump3.Enabled = false;
            this.txtMemDump3.Location = new System.Drawing.Point(97, 112);
            this.txtMemDump3.Name = "txtMemDump3";
            this.txtMemDump3.ReadOnly = true;
            this.txtMemDump3.Size = new System.Drawing.Size(189, 21);
            this.txtMemDump3.TabIndex = 33;
            this.txtMemDump3.Click += new System.EventHandler(this.TxtFile_Click);
            this.txtMemDump3.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFile_DragDrop);
            this.txtMemDump3.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFileDragDrop_DragEnter);
            // 
            // txtAddress3
            // 
            this.txtAddress3.Enabled = false;
            this.txtAddress3.ForeColor = System.Drawing.Color.Blue;
            this.txtAddress3.Location = new System.Drawing.Point(97, 136);
            this.txtAddress3.MaxLength = 10;
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(189, 21);
            this.txtAddress3.TabIndex = 35;
            // 
            // txtBaseAddress
            // 
            this.txtBaseAddress.Location = new System.Drawing.Point(97, 237);
            this.txtBaseAddress.MaxLength = 10;
            this.txtBaseAddress.Name = "txtBaseAddress";
            this.txtBaseAddress.Size = new System.Drawing.Size(189, 21);
            this.txtBaseAddress.TabIndex = 27;
            // 
            // labBaseAddress
            // 
            this.labBaseAddress.AutoSize = true;
            this.labBaseAddress.Location = new System.Drawing.Point(6, 241);
            this.labBaseAddress.Name = "labBaseAddress";
            this.labBaseAddress.Size = new System.Drawing.Size(59, 12);
            this.labBaseAddress.TabIndex = 26;
            this.labBaseAddress.Text = "内存基址:";
            this.labBaseAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMode
            // 
            this.cmbMode.DisplayMember = "1";
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "PlayStation Portable",
            "Nintendo DS",
            "PlayStation VITA",
            "其他..."});
            this.cmbMode.Location = new System.Drawing.Point(97, 212);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(189, 20);
            this.cmbMode.TabIndex = 25;
            this.cmbMode.SelectedIndexChanged += new System.EventHandler(this.CmbMode_SelectedIndexChanged);
            // 
            // txtMaxOffset
            // 
            this.txtMaxOffset.Location = new System.Drawing.Point(97, 261);
            this.txtMaxOffset.MaxLength = 10;
            this.txtMaxOffset.Name = "txtMaxOffset";
            this.txtMaxOffset.Size = new System.Drawing.Size(189, 21);
            this.txtMaxOffset.TabIndex = 29;
            this.txtMaxOffset.Text = "0x1000";
            // 
            // labMemDump2
            // 
            this.labMemDump2.AutoSize = true;
            this.labMemDump2.Location = new System.Drawing.Point(6, 67);
            this.labMemDump2.Name = "labMemDump2";
            this.labMemDump2.Size = new System.Drawing.Size(77, 12);
            this.labMemDump2.TabIndex = 20;
            this.labMemDump2.Text = "转储2(必须):";
            this.labMemDump2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labMemDump1
            // 
            this.labMemDump1.AutoSize = true;
            this.labMemDump1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labMemDump1.Location = new System.Drawing.Point(6, 19);
            this.labMemDump1.Name = "labMemDump1";
            this.labMemDump1.Size = new System.Drawing.Size(77, 12);
            this.labMemDump1.TabIndex = 16;
            this.labMemDump1.Text = "转储1(必须):";
            this.labMemDump1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labMode
            // 
            this.labMode.AutoSize = true;
            this.labMode.Location = new System.Drawing.Point(6, 216);
            this.labMode.Name = "labMode";
            this.labMode.Size = new System.Drawing.Size(35, 12);
            this.labMode.TabIndex = 24;
            this.labMode.Text = "模式:";
            this.labMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labAddress2
            // 
            this.labAddress2.AutoSize = true;
            this.labAddress2.Location = new System.Drawing.Point(6, 91);
            this.labAddress2.Name = "labAddress2";
            this.labAddress2.Size = new System.Drawing.Size(41, 12);
            this.labAddress2.TabIndex = 22;
            this.labAddress2.Text = "地址2:";
            this.labAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labAddress1
            // 
            this.labAddress1.AutoSize = true;
            this.labAddress1.Location = new System.Drawing.Point(6, 43);
            this.labAddress1.Name = "labAddress1";
            this.labAddress1.Size = new System.Drawing.Size(41, 12);
            this.labAddress1.TabIndex = 18;
            this.labAddress1.Text = "地址1:";
            this.labAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMemDump2
            // 
            this.txtMemDump2.AllowDrop = true;
            this.txtMemDump2.Location = new System.Drawing.Point(97, 63);
            this.txtMemDump2.Name = "txtMemDump2";
            this.txtMemDump2.ReadOnly = true;
            this.txtMemDump2.Size = new System.Drawing.Size(189, 21);
            this.txtMemDump2.TabIndex = 21;
            this.txtMemDump2.Click += new System.EventHandler(this.TxtFile_Click);
            this.txtMemDump2.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFile_DragDrop);
            this.txtMemDump2.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFileDragDrop_DragEnter);
            // 
            // txtMemDump1
            // 
            this.txtMemDump1.AllowDrop = true;
            this.txtMemDump1.Location = new System.Drawing.Point(97, 15);
            this.txtMemDump1.Name = "txtMemDump1";
            this.txtMemDump1.ReadOnly = true;
            this.txtMemDump1.Size = new System.Drawing.Size(189, 21);
            this.txtMemDump1.TabIndex = 17;
            this.txtMemDump1.Click += new System.EventHandler(this.TxtFile_Click);
            this.txtMemDump1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtFile_DragDrop);
            this.txtMemDump1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtFileDragDrop_DragEnter);
            // 
            // txtAddress2
            // 
            this.txtAddress2.ForeColor = System.Drawing.Color.Green;
            this.txtAddress2.Location = new System.Drawing.Point(97, 87);
            this.txtAddress2.MaxLength = 10;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(189, 21);
            this.txtAddress2.TabIndex = 23;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(97, 39);
            this.txtAddress1.MaxLength = 10;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(189, 21);
            this.txtAddress1.TabIndex = 19;
            // 
            // labMaxOffset
            // 
            this.labMaxOffset.AutoSize = true;
            this.labMaxOffset.Location = new System.Drawing.Point(6, 265);
            this.labMaxOffset.Name = "labMaxOffset";
            this.labMaxOffset.Size = new System.Drawing.Size(71, 12);
            this.labMaxOffset.TabIndex = 28;
            this.labMaxOffset.Text = "最大偏移量:";
            this.labMaxOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkMemDump3
            // 
            this.chkMemDump3.AutoSize = true;
            this.chkMemDump3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMemDump3.Location = new System.Drawing.Point(79, 115);
            this.chkMemDump3.Name = "chkMemDump3";
            this.chkMemDump3.Size = new System.Drawing.Size(15, 14);
            this.chkMemDump3.TabIndex = 36;
            this.chkMemDump3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMemDump3.UseVisualStyleBackColor = true;
            this.chkMemDump3.CheckedChanged += new System.EventHandler(this.ChkMemDump3_CheckedChanged);
            // 
            // labMemDump3
            // 
            this.labMemDump3.AutoSize = true;
            this.labMemDump3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labMemDump3.Location = new System.Drawing.Point(6, 116);
            this.labMemDump3.Name = "labMemDump3";
            this.labMemDump3.Size = new System.Drawing.Size(77, 12);
            this.labMemDump3.TabIndex = 32;
            this.labMemDump3.Text = "转储3(可选):";
            this.labMemDump3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grp
            // 
            this.grp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp.BackColor = System.Drawing.Color.White;
            this.grp.Controls.Add(this.label3);
            this.grp.Controls.Add(this.rdbPointerSearcherBitType32);
            this.grp.Controls.Add(this.rdbPointerSearcherBitType8);
            this.grp.Controls.Add(this.rdbPointerSearcherBitType16);
            this.grp.Location = new System.Drawing.Point(3, 290);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(293, 41);
            this.grp.TabIndex = 1;
            this.grp.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "数据类型:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdbPointerSearcherBitType32
            // 
            this.rdbPointerSearcherBitType32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbPointerSearcherBitType32.AutoSize = true;
            this.rdbPointerSearcherBitType32.Checked = true;
            this.rdbPointerSearcherBitType32.Location = new System.Drawing.Point(233, 15);
            this.rdbPointerSearcherBitType32.Name = "rdbPointerSearcherBitType32";
            this.rdbPointerSearcherBitType32.Size = new System.Drawing.Size(53, 16);
            this.rdbPointerSearcherBitType32.TabIndex = 3;
            this.rdbPointerSearcherBitType32.TabStop = true;
            this.rdbPointerSearcherBitType32.Text = "32 位";
            this.rdbPointerSearcherBitType32.UseVisualStyleBackColor = true;
            // 
            // rdbPointerSearcherBitType8
            // 
            this.rdbPointerSearcherBitType8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbPointerSearcherBitType8.AutoSize = true;
            this.rdbPointerSearcherBitType8.Location = new System.Drawing.Point(98, 15);
            this.rdbPointerSearcherBitType8.Name = "rdbPointerSearcherBitType8";
            this.rdbPointerSearcherBitType8.Size = new System.Drawing.Size(47, 16);
            this.rdbPointerSearcherBitType8.TabIndex = 4;
            this.rdbPointerSearcherBitType8.Text = "8 位";
            this.rdbPointerSearcherBitType8.UseVisualStyleBackColor = true;
            // 
            // rdbPointerSearcherBitType16
            // 
            this.rdbPointerSearcherBitType16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbPointerSearcherBitType16.AutoSize = true;
            this.rdbPointerSearcherBitType16.Location = new System.Drawing.Point(163, 15);
            this.rdbPointerSearcherBitType16.Name = "rdbPointerSearcherBitType16";
            this.rdbPointerSearcherBitType16.Size = new System.Drawing.Size(53, 16);
            this.rdbPointerSearcherBitType16.TabIndex = 5;
            this.rdbPointerSearcherBitType16.Text = "16 位";
            this.rdbPointerSearcherBitType16.UseVisualStyleBackColor = true;
            // 
            // grpOtheOption
            // 
            this.grpOtheOption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOtheOption.BackColor = System.Drawing.Color.White;
            this.grpOtheOption.Controls.Add(this.chkFilteringInvalid);
            this.grpOtheOption.Controls.Add(this.chkRealAddresses);
            this.grpOtheOption.Controls.Add(this.chkOptimizePointerPaths);
            this.grpOtheOption.Controls.Add(this.chkRAWCode);
            this.grpOtheOption.Controls.Add(this.chkIncludeNegatives);
            this.grpOtheOption.Controls.Add(this.btnClear);
            this.grpOtheOption.Controls.Add(this.btnFindPointers);
            this.grpOtheOption.Location = new System.Drawing.Point(2, 328);
            this.grpOtheOption.Name = "grpOtheOption";
            this.grpOtheOption.Size = new System.Drawing.Size(293, 159);
            this.grpOtheOption.TabIndex = 2;
            this.grpOtheOption.TabStop = false;
            // 
            // chkFilteringInvalid
            // 
            this.chkFilteringInvalid.AutoSize = true;
            this.chkFilteringInvalid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkFilteringInvalid.Location = new System.Drawing.Point(8, 103);
            this.chkFilteringInvalid.Name = "chkFilteringInvalid";
            this.chkFilteringInvalid.Size = new System.Drawing.Size(132, 16);
            this.chkFilteringInvalid.TabIndex = 29;
            this.chkFilteringInvalid.Text = "仅显示最可能的指针";
            this.chkFilteringInvalid.UseVisualStyleBackColor = true;
            // 
            // chkRealAddresses
            // 
            this.chkRealAddresses.AutoSize = true;
            this.chkRealAddresses.Checked = true;
            this.chkRealAddresses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRealAddresses.Location = new System.Drawing.Point(8, 81);
            this.chkRealAddresses.Name = "chkRealAddresses";
            this.chkRealAddresses.Size = new System.Drawing.Size(96, 16);
            this.chkRealAddresses.TabIndex = 26;
            this.chkRealAddresses.Text = "显示实际地址";
            this.chkRealAddresses.UseVisualStyleBackColor = true;
            // 
            // chkOptimizePointerPaths
            // 
            this.chkOptimizePointerPaths.AutoSize = true;
            this.chkOptimizePointerPaths.Checked = true;
            this.chkOptimizePointerPaths.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOptimizePointerPaths.Location = new System.Drawing.Point(7, 15);
            this.chkOptimizePointerPaths.Name = "chkOptimizePointerPaths";
            this.chkOptimizePointerPaths.Size = new System.Drawing.Size(168, 16);
            this.chkOptimizePointerPaths.TabIndex = 23;
            this.chkOptimizePointerPaths.Text = "显示结构优化后的指针地址";
            this.chkOptimizePointerPaths.UseVisualStyleBackColor = true;
            // 
            // chkRAWCode
            // 
            this.chkRAWCode.AutoSize = true;
            this.chkRAWCode.Location = new System.Drawing.Point(8, 37);
            this.chkRAWCode.Name = "chkRAWCode";
            this.chkRAWCode.Size = new System.Drawing.Size(72, 16);
            this.chkRAWCode.TabIndex = 24;
            this.chkRAWCode.Text = "RAW 代码";
            this.chkRAWCode.UseVisualStyleBackColor = true;
            // 
            // chkIncludeNegatives
            // 
            this.chkIncludeNegatives.AutoSize = true;
            this.chkIncludeNegatives.Location = new System.Drawing.Point(8, 59);
            this.chkIncludeNegatives.Name = "chkIncludeNegatives";
            this.chkIncludeNegatives.Size = new System.Drawing.Size(120, 16);
            this.chkIncludeNegatives.TabIndex = 25;
            this.chkIncludeNegatives.Text = "包含负偏移量指针";
            this.chkIncludeNegatives.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(117, 118);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 30);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnFindPointers
            // 
            this.btnFindPointers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindPointers.Location = new System.Drawing.Point(185, 118);
            this.btnFindPointers.Name = "btnFindPointers";
            this.btnFindPointers.Size = new System.Drawing.Size(100, 30);
            this.btnFindPointers.TabIndex = 28;
            this.btnFindPointers.Text = "搜索指针";
            this.btnFindPointers.UseVisualStyleBackColor = true;
            this.btnFindPointers.Click += new System.EventHandler(this.BtnFindPointers_Click);
            // 
            // splMain_Data
            // 
            this.splMain_Data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splMain_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain_Data.Location = new System.Drawing.Point(0, 0);
            this.splMain_Data.Name = "splMain_Data";
            this.splMain_Data.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splMain_Data.Panel1
            // 
            this.splMain_Data.Panel1.Controls.Add(this.tvwPointers);
            this.splMain_Data.Panel1MinSize = 100;
            // 
            // splMain_Data.Panel2
            // 
            this.splMain_Data.Panel2.Controls.Add(this.splMain_Data_Code);
            this.splMain_Data.Panel2MinSize = 100;
            this.splMain_Data.Size = new System.Drawing.Size(482, 492);
            this.splMain_Data.SplitterDistance = 246;
            this.splMain_Data.SplitterWidth = 2;
            this.splMain_Data.TabIndex = 0;
            // 
            // tvwPointers
            // 
            this.tvwPointers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwPointers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwPointers.Location = new System.Drawing.Point(0, 0);
            this.tvwPointers.Name = "tvwPointers";
            this.tvwPointers.Size = new System.Drawing.Size(480, 244);
            this.tvwPointers.TabIndex = 0;
            this.tvwPointers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwPointers_AfterSelect);
            this.tvwPointers.DoubleClick += new System.EventHandler(this.TvwPointers_DoubleClick);
            // 
            // splMain_Data_Code
            // 
            this.splMain_Data_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splMain_Data_Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain_Data_Code.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splMain_Data_Code.IsSplitterFixed = true;
            this.splMain_Data_Code.Location = new System.Drawing.Point(0, 0);
            this.splMain_Data_Code.Name = "splMain_Data_Code";
            this.splMain_Data_Code.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splMain_Data_Code.Panel1
            // 
            this.splMain_Data_Code.Panel1.Controls.Add(this.rdoCodeTypeAR);
            this.splMain_Data_Code.Panel1.Controls.Add(this.rdoCodeTypeCWCheat);
            this.splMain_Data_Code.Panel1.Controls.Add(this.cmbPsvCheatCodeType);
            this.splMain_Data_Code.Panel1.Controls.Add(this.rdoCpdeTypePsvCheat);
            this.splMain_Data_Code.Panel1MinSize = 30;
            // 
            // splMain_Data_Code.Panel2
            // 
            this.splMain_Data_Code.Panel2.Controls.Add(this.progressBar1);
            this.splMain_Data_Code.Panel2.Controls.Add(this.txtCode);
            this.splMain_Data_Code.Panel2MinSize = 100;
            this.splMain_Data_Code.Size = new System.Drawing.Size(482, 244);
            this.splMain_Data_Code.SplitterDistance = 30;
            this.splMain_Data_Code.SplitterWidth = 1;
            this.splMain_Data_Code.TabIndex = 0;
            // 
            // rdoCodeTypeAR
            // 
            this.rdoCodeTypeAR.AutoSize = true;
            this.rdoCodeTypeAR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoCodeTypeAR.Location = new System.Drawing.Point(306, 6);
            this.rdoCodeTypeAR.Name = "rdoCodeTypeAR";
            this.rdoCodeTypeAR.Size = new System.Drawing.Size(35, 16);
            this.rdoCodeTypeAR.TabIndex = 3;
            this.rdoCodeTypeAR.Text = "AR";
            this.rdoCodeTypeAR.UseVisualStyleBackColor = true;
            // 
            // rdoCodeTypeCWCheat
            // 
            this.rdoCodeTypeCWCheat.AutoSize = true;
            this.rdoCodeTypeCWCheat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdoCodeTypeCWCheat.Location = new System.Drawing.Point(235, 6);
            this.rdoCodeTypeCWCheat.Name = "rdoCodeTypeCWCheat";
            this.rdoCodeTypeCWCheat.Size = new System.Drawing.Size(65, 16);
            this.rdoCodeTypeCWCheat.TabIndex = 2;
            this.rdoCodeTypeCWCheat.Text = "CWCheat";
            this.rdoCodeTypeCWCheat.UseVisualStyleBackColor = true;
            // 
            // cmbPsvCheatCodeType
            // 
            this.cmbPsvCheatCodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPsvCheatCodeType.FormattingEnabled = true;
            this.cmbPsvCheatCodeType.Items.AddRange(new object[] {
            "指针写入码",
            "指针传送码",
            "指针压缩码"});
            this.cmbPsvCheatCodeType.Location = new System.Drawing.Point(85, 4);
            this.cmbPsvCheatCodeType.Name = "cmbPsvCheatCodeType";
            this.cmbPsvCheatCodeType.Size = new System.Drawing.Size(121, 20);
            this.cmbPsvCheatCodeType.TabIndex = 1;
            // 
            // rdoCpdeTypePsvCheat
            // 
            this.rdoCpdeTypePsvCheat.AutoSize = true;
            this.rdoCpdeTypePsvCheat.Checked = true;
            this.rdoCpdeTypePsvCheat.Location = new System.Drawing.Point(8, 6);
            this.rdoCpdeTypePsvCheat.Name = "rdoCpdeTypePsvCheat";
            this.rdoCpdeTypePsvCheat.Size = new System.Drawing.Size(71, 16);
            this.rdoCpdeTypePsvCheat.TabIndex = 0;
            this.rdoCpdeTypePsvCheat.TabStop = true;
            this.rdoCpdeTypePsvCheat.Text = "PsvCheat";
            this.rdoCpdeTypePsvCheat.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(0, 0);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(480, 211);
            this.txtCode.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(480, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 492);
            this.Controls.Add(this.splMain);
            this.MinimumSize = new System.Drawing.Size(800, 530);
            this.Name = "frmMain";
            this.Text = "指针搜索器";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            this.grpDump.ResumeLayout(false);
            this.grpDump.PerformLayout();
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.grpOtheOption.ResumeLayout(false);
            this.grpOtheOption.PerformLayout();
            this.splMain_Data.Panel1.ResumeLayout(false);
            this.splMain_Data.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain_Data)).EndInit();
            this.splMain_Data.ResumeLayout(false);
            this.splMain_Data_Code.Panel1.ResumeLayout(false);
            this.splMain_Data_Code.Panel1.PerformLayout();
            this.splMain_Data_Code.Panel2.ResumeLayout(false);
            this.splMain_Data_Code.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMain_Data_Code)).EndInit();
            this.splMain_Data_Code.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splMain;
        private System.Windows.Forms.SplitContainer splMain_Data;
        private System.Windows.Forms.TreeView tvwPointers;
        private System.Windows.Forms.SplitContainer splMain_Data_Code;
        private System.Windows.Forms.RadioButton rdoCpdeTypePsvCheat;
        private System.Windows.Forms.RadioButton rdoCodeTypeAR;
        private System.Windows.Forms.RadioButton rdoCodeTypeCWCheat;
        private System.Windows.Forms.ComboBox cmbPsvCheatCodeType;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.GroupBox grpDump;
        private System.Windows.Forms.TextBox txtBaseAddress;
        private System.Windows.Forms.Label labBaseAddress;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.Label labMaxOffset;
        private System.Windows.Forms.TextBox txtMaxOffset;
        private System.Windows.Forms.Label labMemDump2;
        private System.Windows.Forms.Label labMemDump1;
        private System.Windows.Forms.Label labMode;
        private System.Windows.Forms.Label labAddress2;
        private System.Windows.Forms.Label labAddress1;
        private System.Windows.Forms.TextBox txtMemDump2;
        private System.Windows.Forms.TextBox txtMemDump1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label labMemDump3;
        private System.Windows.Forms.Label labAddress3;
        private System.Windows.Forms.TextBox txtMemDump3;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.CheckBox chkMemDump3;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.RadioButton rdbPointerSearcherBitType32;
        private System.Windows.Forms.RadioButton rdbPointerSearcherBitType8;
        private System.Windows.Forms.RadioButton rdbPointerSearcherBitType16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpOtheOption;
        private System.Windows.Forms.CheckBox chkRealAddresses;
        private System.Windows.Forms.CheckBox chkOptimizePointerPaths;
        private System.Windows.Forms.CheckBox chkRAWCode;
        private System.Windows.Forms.CheckBox chkIncludeNegatives;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFindPointers;
        private System.Windows.Forms.CheckBox chkFilteringInvalid;
        private System.Windows.Forms.Label labAddress4;
        private System.Windows.Forms.TextBox txtMemDump4;
        private System.Windows.Forms.TextBox txtAddress4;
        private System.Windows.Forms.CheckBox chkMemDump4;
        private System.Windows.Forms.Label labMemDump4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

