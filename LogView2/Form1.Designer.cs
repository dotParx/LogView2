namespace LogView2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterMsg = new System.Windows.Forms.TextBox();
            this.filterDate = new System.Windows.Forms.TextBox();
            this.filterIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.filterUser = new System.Windows.Forms.TextBox();
            this.loadLog = new System.Windows.Forms.Button();
            this.logSelect = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.logView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.logLines = new System.Windows.Forms.ToolStripStatusLabel();
            this.logFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataSet1 = new System.Data.DataSet();
            this.panelLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLeft.Controls.Add(this.treeView1);
            this.panelLeft.Controls.Add(this.groupBox1);
            this.panelLeft.Controls.Add(this.loadLog);
            this.panelLeft.Controls.Add(this.logSelect);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 561);
            this.panelLeft.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(200, 46);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(0, 515);
            this.treeView1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filterMsg);
            this.groupBox1.Controls.Add(this.filterDate);
            this.groupBox1.Controls.Add(this.filterIp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.filterUser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 515);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // filterMsg
            // 
            this.filterMsg.Location = new System.Drawing.Point(43, 145);
            this.filterMsg.Name = "filterMsg";
            this.filterMsg.Size = new System.Drawing.Size(147, 20);
            this.filterMsg.TabIndex = 10;
            // 
            // filterDate
            // 
            this.filterDate.Location = new System.Drawing.Point(43, 104);
            this.filterDate.Name = "filterDate";
            this.filterDate.Size = new System.Drawing.Size(147, 20);
            this.filterDate.TabIndex = 9;
            // 
            // filterIp
            // 
            this.filterIp.Location = new System.Drawing.Point(43, 67);
            this.filterIp.Name = "filterIp";
            this.filterIp.Size = new System.Drawing.Size(147, 20);
            this.filterIp.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Msg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "APPLY FILTERS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterUser
            // 
            this.filterUser.Location = new System.Drawing.Point(43, 29);
            this.filterUser.Name = "filterUser";
            this.filterUser.Size = new System.Drawing.Size(147, 20);
            this.filterUser.TabIndex = 2;
            this.filterUser.TextChanged += new System.EventHandler(this.filterUser_TextChanged);
            // 
            // loadLog
            // 
            this.loadLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadLog.Location = new System.Drawing.Point(0, 23);
            this.loadLog.Name = "loadLog";
            this.loadLog.Size = new System.Drawing.Size(200, 23);
            this.loadLog.TabIndex = 1;
            this.loadLog.Text = "Load Log File";
            this.loadLog.UseVisualStyleBackColor = true;
            this.loadLog.Click += new System.EventHandler(this.loadLog_Click);
            // 
            // logSelect
            // 
            this.logSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.logSelect.Location = new System.Drawing.Point(0, 0);
            this.logSelect.Name = "logSelect";
            this.logSelect.Size = new System.Drawing.Size(200, 23);
            this.logSelect.TabIndex = 0;
            this.logSelect.Text = "Select Log File";
            this.logSelect.UseVisualStyleBackColor = true;
            this.logSelect.Click += new System.EventHandler(this.logSelect_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.logView);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(200, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(984, 561);
            this.panelRight.TabIndex = 1;
            // 
            // logView
            // 
            this.logView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logView.BackgroundColor = System.Drawing.Color.Azure;
            this.logView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logView.Location = new System.Drawing.Point(0, 0);
            this.logView.Name = "logView";
            this.logView.Size = new System.Drawing.Size(984, 561);
            this.logView.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "log|*.log";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logLines,
            this.logFileName});
            this.statusStrip1.Location = new System.Drawing.Point(200, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // logLines
            // 
            this.logLines.Name = "logLines";
            this.logLines.Size = new System.Drawing.Size(46, 17);
            this.logLines.Text = "Lines: 0";
            // 
            // logFileName
            // 
            this.logFileName.Name = "logFileName";
            this.logFileName.Size = new System.Drawing.Size(30, 17);
            this.logFileName.Text = "Log:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Filezilla Log Viewer";
            this.panelLeft.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView logView;
        private System.Windows.Forms.Button logSelect;
        private System.Windows.Forms.Button loadLog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel logLines;
        private System.Windows.Forms.ToolStripStatusLabel logFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterUser;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox filterMsg;
        private System.Windows.Forms.TextBox filterDate;
        private System.Windows.Forms.TextBox filterIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
    }
}

