namespace MultiThreading
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.btnListMailTasks = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mailTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnStartTask = new System.Windows.Forms.Button();
            this.btnStopTask = new System.Windows.Forms.Button();
            this.btnRunTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRunningDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isStartedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.secondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextRunningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLogs
            // 
            this.lbLogs.BackColor = System.Drawing.Color.Silver;
            this.lbLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 20;
            this.lbLogs.Location = new System.Drawing.Point(0, 437);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(1193, 224);
            this.lbLogs.TabIndex = 0;
            // 
            // btnListMailTasks
            // 
            this.btnListMailTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListMailTasks.Location = new System.Drawing.Point(12, 12);
            this.btnListMailTasks.Name = "btnListMailTasks";
            this.btnListMailTasks.Size = new System.Drawing.Size(1169, 54);
            this.btnListMailTasks.TabIndex = 1;
            this.btnListMailTasks.Text = "List Mail Tasks";
            this.btnListMailTasks.UseVisualStyleBackColor = true;
            this.btnListMailTasks.Click += new System.EventHandler(this.btnListMailTasks_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskId,
            this.ProviderType,
            this.isRunningDataGridViewCheckBoxColumn,
            this.isStartedDataGridViewCheckBoxColumn,
            this.secondDataGridViewTextBoxColumn,
            this.nextRunningDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mailTaskBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 188);
            this.dataGridView1.TabIndex = 2;
            // 
            // mailTaskBindingSource
            // 
            this.mailTaskBindingSource.AllowNew = false;
            this.mailTaskBindingSource.DataSource = typeof(MultiThreading.MailTask);
            this.mailTaskBindingSource.CurrentItemChanged += new System.EventHandler(this.mailTaskBindingSource_CurrentItemChanged);
            // 
            // btnStartTask
            // 
            this.btnStartTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartTask.Enabled = false;
            this.btnStartTask.Location = new System.Drawing.Point(6, 16);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(94, 29);
            this.btnStartTask.TabIndex = 3;
            this.btnStartTask.Text = "Start";
            this.btnStartTask.UseVisualStyleBackColor = true;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // btnStopTask
            // 
            this.btnStopTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopTask.Enabled = false;
            this.btnStopTask.Location = new System.Drawing.Point(106, 16);
            this.btnStopTask.Name = "btnStopTask";
            this.btnStopTask.Size = new System.Drawing.Size(94, 29);
            this.btnStopTask.TabIndex = 4;
            this.btnStopTask.Text = "Stop";
            this.btnStopTask.UseVisualStyleBackColor = true;
            this.btnStopTask.Click += new System.EventHandler(this.btnStopTask_Click);
            // 
            // btnRunTask
            // 
            this.btnRunTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunTask.Enabled = false;
            this.btnRunTask.Location = new System.Drawing.Point(1093, 16);
            this.btnRunTask.Name = "btnRunTask";
            this.btnRunTask.Size = new System.Drawing.Size(94, 29);
            this.btnRunTask.TabIndex = 5;
            this.btnRunTask.Text = "Run";
            this.btnRunTask.UseVisualStyleBackColor = true;
            this.btnRunTask.Click += new System.EventHandler(this.btnRunTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRunTask);
            this.groupBox1.Controls.Add(this.btnStopTask);
            this.groupBox1.Controls.Add(this.btnStartTask);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1193, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // TaskId
            // 
            this.TaskId.DataPropertyName = "TaskId";
            this.TaskId.HeaderText = "TaskId";
            this.TaskId.MinimumWidth = 6;
            this.TaskId.Name = "TaskId";
            this.TaskId.ReadOnly = true;
            // 
            // ProviderType
            // 
            this.ProviderType.DataPropertyName = "ProviderType";
            this.ProviderType.HeaderText = "ProviderType";
            this.ProviderType.MinimumWidth = 6;
            this.ProviderType.Name = "ProviderType";
            // 
            // isRunningDataGridViewCheckBoxColumn
            // 
            this.isRunningDataGridViewCheckBoxColumn.DataPropertyName = "IsRunning";
            this.isRunningDataGridViewCheckBoxColumn.HeaderText = "IsRunning";
            this.isRunningDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isRunningDataGridViewCheckBoxColumn.Name = "isRunningDataGridViewCheckBoxColumn";
            this.isRunningDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isStartedDataGridViewCheckBoxColumn
            // 
            this.isStartedDataGridViewCheckBoxColumn.DataPropertyName = "IsStarted";
            this.isStartedDataGridViewCheckBoxColumn.HeaderText = "IsStarted";
            this.isStartedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isStartedDataGridViewCheckBoxColumn.Name = "isStartedDataGridViewCheckBoxColumn";
            this.isStartedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // secondDataGridViewTextBoxColumn
            // 
            this.secondDataGridViewTextBoxColumn.DataPropertyName = "Second";
            this.secondDataGridViewTextBoxColumn.HeaderText = "Second";
            this.secondDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.secondDataGridViewTextBoxColumn.Name = "secondDataGridViewTextBoxColumn";
            this.secondDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextRunningDataGridViewTextBoxColumn
            // 
            this.nextRunningDataGridViewTextBoxColumn.DataPropertyName = "NextRunning";
            this.nextRunningDataGridViewTextBoxColumn.HeaderText = "NextRunning";
            this.nextRunningDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nextRunningDataGridViewTextBoxColumn.Name = "nextRunningDataGridViewTextBoxColumn";
            this.nextRunningDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListMailTasks);
            this.Controls.Add(this.lbLogs);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Courier App";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbLogs;
        private Button btnListMailTasks;
        private DataGridView dataGridView1;
        private BindingSource mailTaskBindingSource;
        private Button btnStartTask;
        private Button btnStopTask;
        private Button btnRunTask;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn TaskId;
        private DataGridViewTextBoxColumn ProviderType;
        private DataGridViewCheckBoxColumn isRunningDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isStartedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nextRunningDataGridViewTextBoxColumn;
    }
}