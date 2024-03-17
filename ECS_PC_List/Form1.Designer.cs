namespace ECS_PC_List
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExplorer = new System.Windows.Forms.Button();
            this.btnRemoteDesktop = new System.Windows.Forms.Button();
            this.btnPingt = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRestartPC = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnKillRadmin = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnViewOnly = new System.Windows.Forms.Button();
            this.btnFullControl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSolution = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnpingAll = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnerrLog = new System.Windows.Forms.Button();
            this.btnfindCSR = new System.Windows.Forms.Button();
            this.btnexportExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtError = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtStatusHis = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtSolution = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExplorer
            // 
            this.btnExplorer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExplorer.Location = new System.Drawing.Point(104, 59);
            this.btnExplorer.Name = "btnExplorer";
            this.btnExplorer.Size = new System.Drawing.Size(83, 34);
            this.btnExplorer.TabIndex = 1;
            this.btnExplorer.Text = "Explorer";
            this.btnExplorer.UseVisualStyleBackColor = true;
            this.btnExplorer.Click += new System.EventHandler(this.btnExplorer_Click);
            // 
            // btnRemoteDesktop
            // 
            this.btnRemoteDesktop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoteDesktop.Location = new System.Drawing.Point(15, 98);
            this.btnRemoteDesktop.Name = "btnRemoteDesktop";
            this.btnRemoteDesktop.Size = new System.Drawing.Size(84, 35);
            this.btnRemoteDesktop.TabIndex = 1;
            this.btnRemoteDesktop.Text = "Remote Desk";
            this.btnRemoteDesktop.UseVisualStyleBackColor = true;
            this.btnRemoteDesktop.Click += new System.EventHandler(this.btnRemoteDesktop_Click);
            // 
            // btnPingt
            // 
            this.btnPingt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPingt.Location = new System.Drawing.Point(16, 59);
            this.btnPingt.Name = "btnPingt";
            this.btnPingt.Size = new System.Drawing.Size(83, 35);
            this.btnPingt.TabIndex = 1;
            this.btnPingt.Text = "Ping -t";
            this.btnPingt.UseVisualStyleBackColor = true;
            this.btnPingt.Click += new System.EventHandler(this.btnPingt_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(104, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 35);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(15, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(15, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 35);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRestartPC
            // 
            this.btnRestartPC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRestartPC.Location = new System.Drawing.Point(15, 20);
            this.btnRestartPC.Name = "btnRestartPC";
            this.btnRestartPC.Size = new System.Drawing.Size(84, 35);
            this.btnRestartPC.TabIndex = 1;
            this.btnRestartPC.Text = "Restart PC";
            this.btnRestartPC.UseVisualStyleBackColor = true;
            this.btnRestartPC.Click += new System.EventHandler(this.btnRestartPC_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(15, 59);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 35);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update ECS";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(926, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(737, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(183, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(24, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(665, 355);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Check
            // 
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            this.Check.Width = 48;
            // 
            // btnKillRadmin
            // 
            this.btnKillRadmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKillRadmin.Location = new System.Drawing.Point(103, 98);
            this.btnKillRadmin.Name = "btnKillRadmin";
            this.btnKillRadmin.Size = new System.Drawing.Size(84, 35);
            this.btnKillRadmin.TabIndex = 1;
            this.btnKillRadmin.Text = "Kill Radmin";
            this.btnKillRadmin.UseVisualStyleBackColor = true;
            this.btnKillRadmin.Click += new System.EventHandler(this.btnKillRadmin_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTransfer.Location = new System.Drawing.Point(15, 59);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(84, 35);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "Transfer File";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnViewOnly
            // 
            this.btnViewOnly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewOnly.Location = new System.Drawing.Point(103, 21);
            this.btnViewOnly.Name = "btnViewOnly";
            this.btnViewOnly.Size = new System.Drawing.Size(84, 34);
            this.btnViewOnly.TabIndex = 1;
            this.btnViewOnly.Text = "View Only";
            this.btnViewOnly.UseVisualStyleBackColor = true;
            this.btnViewOnly.Click += new System.EventHandler(this.btnViewOnly_Click);
            // 
            // btnFullControl
            // 
            this.btnFullControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFullControl.Location = new System.Drawing.Point(15, 21);
            this.btnFullControl.Name = "btnFullControl";
            this.btnFullControl.Size = new System.Drawing.Size(84, 34);
            this.btnFullControl.TabIndex = 0;
            this.btnFullControl.Text = "Full Control";
            this.btnFullControl.UseVisualStyleBackColor = true;
            this.btnFullControl.Click += new System.EventHandler(this.btnFullControl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFullControl);
            this.groupBox1.Controls.Add(this.btnKillRadmin);
            this.groupBox1.Controls.Add(this.btnTransfer);
            this.groupBox1.Controls.Add(this.btnViewOnly);
            this.groupBox1.Controls.Add(this.btnExplorer);
            this.groupBox1.Controls.Add(this.btnRemoteDesktop);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(24, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 148);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radmin Control";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUpdateSolution
            // 
            this.btnUpdateSolution.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateSolution.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateSolution.Location = new System.Drawing.Point(103, 98);
            this.btnUpdateSolution.Name = "btnUpdateSolution";
            this.btnUpdateSolution.Size = new System.Drawing.Size(84, 35);
            this.btnUpdateSolution.TabIndex = 4;
            this.btnUpdateSolution.Text = "Update Status";
            this.btnUpdateSolution.UseVisualStyleBackColor = false;
            this.btnUpdateSolution.Click += new System.EventHandler(this.btnUpdateSolution_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackup.Location = new System.Drawing.Point(103, 20);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(83, 35);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup ECS";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnpingAll
            // 
            this.btnpingAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnpingAll.Location = new System.Drawing.Point(104, 59);
            this.btnpingAll.Name = "btnpingAll";
            this.btnpingAll.Size = new System.Drawing.Size(83, 35);
            this.btnpingAll.TabIndex = 2;
            this.btnpingAll.Text = "Ping All";
            this.btnpingAll.UseVisualStyleBackColor = true;
            this.btnpingAll.Click += new System.EventHandler(this.btnpingAll_Click_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnerrLog
            // 
            this.btnerrLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnerrLog.Location = new System.Drawing.Point(103, 59);
            this.btnerrLog.Name = "btnerrLog";
            this.btnerrLog.Size = new System.Drawing.Size(83, 35);
            this.btnerrLog.TabIndex = 2;
            this.btnerrLog.Text = "Log Counter";
            this.btnerrLog.UseVisualStyleBackColor = true;
            this.btnerrLog.Click += new System.EventHandler(this.btnerrLog_Click);
            // 
            // btnfindCSR
            // 
            this.btnfindCSR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnfindCSR.Location = new System.Drawing.Point(103, 98);
            this.btnfindCSR.Name = "btnfindCSR";
            this.btnfindCSR.Size = new System.Drawing.Size(84, 35);
            this.btnfindCSR.TabIndex = 1;
            this.btnfindCSR.Text = "CSR/UREQ";
            this.btnfindCSR.UseVisualStyleBackColor = true;
            this.btnfindCSR.Click += new System.EventHandler(this.btnfindCSR_Click);
            // 
            // btnexportExcel
            // 
            this.btnexportExcel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnexportExcel.Location = new System.Drawing.Point(16, 98);
            this.btnexportExcel.Name = "btnexportExcel";
            this.btnexportExcel.Size = new System.Drawing.Size(83, 35);
            this.btnexportExcel.TabIndex = 0;
            this.btnexportExcel.Text = "Export Excel";
            this.btnexportExcel.UseVisualStyleBackColor = true;
            this.btnexportExcel.Click += new System.EventHandler(this.btnexportExcel_Click);
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(17, 20);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(319, 113);
            this.txtError.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtError);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(720, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(354, 148);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Enter history";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtStatusHis);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(720, 425);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(355, 193);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "History";
            // 
            // txtStatusHis
            // 
            this.txtStatusHis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtStatusHis.Location = new System.Drawing.Point(17, 23);
            this.txtStatusHis.Multiline = true;
            this.txtStatusHis.Name = "txtStatusHis";
            this.txtStatusHis.ReadOnly = true;
            this.txtStatusHis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusHis.Size = new System.Drawing.Size(320, 153);
            this.txtStatusHis.TabIndex = 10;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtSolution);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Location = new System.Drawing.Point(720, 252);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(354, 156);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Enter solution";
            // 
            // txtSolution
            // 
            this.txtSolution.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSolution.Location = new System.Drawing.Point(17, 19);
            this.txtSolution.Multiline = true;
            this.txtSolution.Name = "txtSolution";
            this.txtSolution.Size = new System.Drawing.Size(319, 119);
            this.txtSolution.TabIndex = 10;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(994, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateSolution);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnerrLog);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(255, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 148);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPingt);
            this.groupBox3.Controls.Add(this.btnBackup);
            this.groupBox3.Controls.Add(this.btnfindCSR);
            this.groupBox3.Controls.Add(this.btnpingAll);
            this.groupBox3.Controls.Add(this.btnexportExcel);
            this.groupBox3.Controls.Add(this.btnRestartPC);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(486, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 148);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extension";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(37, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "E: Equipment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(291, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "C: Control";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(525, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "S: System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1099, 640);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECS Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExplorer;
        private System.Windows.Forms.Button btnRemoteDesktop;
        private System.Windows.Forms.Button btnPingt;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRestartPC;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKillRadmin;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnViewOnly;
        private System.Windows.Forms.Button btnFullControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnpingAll;
        private System.Windows.Forms.Button btnexportExcel;
        private System.Windows.Forms.Button btnfindCSR;
        private System.Windows.Forms.Button btnerrLog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdateSolution;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtSolution;
        private System.Windows.Forms.TextBox txtStatusHis;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

