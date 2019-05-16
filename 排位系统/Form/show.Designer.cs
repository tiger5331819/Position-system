namespace 排位系统
{
    partial class show
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
            this.SNSearach = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.studentRoundsviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new 排位系统.studentDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.studentname = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.RecordSearch = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成绩DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.轮数DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.擂主DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.挑战者DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结果DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.获胜者DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new 排位系统.studentDataSetTableAdapters.studentTableAdapter();
            this.studentRoundsviewTableAdapter = new 排位系统.studentDataSetTableAdapters.studentRoundsviewTableAdapter();
            this.roundsTableAdapter = new 排位系统.studentDataSetTableAdapters.RoundsTableAdapter();
            this.擂主 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.轮数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.挑战者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结果DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.获胜者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNSearach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRoundsviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.RecordSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SNSearach
            // 
            this.SNSearach.Controls.Add(this.dataGridView3);
            this.SNSearach.Controls.Add(this.groupBox1);
            this.SNSearach.Location = new System.Drawing.Point(4, 22);
            this.SNSearach.Name = "SNSearach";
            this.SNSearach.Size = new System.Drawing.Size(874, 455);
            this.SNSearach.TabIndex = 2;
            this.SNSearach.Text = "轮次成绩查询";
            this.SNSearach.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.擂主,
            this.轮数DataGridViewTextBoxColumn,
            this.挑战者DataGridViewTextBoxColumn,
            this.结果DataGridViewTextBoxColumn,
            this.获胜者DataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.studentRoundsviewBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView3.Location = new System.Drawing.Point(0, 74);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(874, 381);
            this.dataGridView3.TabIndex = 1;
            // 
            // studentRoundsviewBindingSource
            // 
            this.studentRoundsviewBindingSource.DataMember = "studentRoundsview";
            this.studentRoundsviewBindingSource.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "studentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.studentname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(335, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // studentname
            // 
            this.studentname.DataSource = this.studentBindingSource;
            this.studentname.DisplayMember = "姓名";
            this.studentname.FormattingEnabled = true;
            this.studentname.Location = new System.Drawing.Point(104, 32);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(144, 20);
            this.studentname.TabIndex = 3;
            this.studentname.ValueMember = "姓名";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.studentDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // RecordSearch
            // 
            this.RecordSearch.Controls.Add(this.dataGridView2);
            this.RecordSearch.Location = new System.Drawing.Point(4, 22);
            this.RecordSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RecordSearch.Name = "RecordSearch";
            this.RecordSearch.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RecordSearch.Size = new System.Drawing.Size(874, 455);
            this.RecordSearch.TabIndex = 0;
            this.RecordSearch.Text = "学生信息查询";
            this.RecordSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.姓名DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.成绩DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.studentBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(6, 5);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(862, 445);
            this.dataGridView2.TabIndex = 0;
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            this.姓名DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            this.性别DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 成绩DataGridViewTextBoxColumn
            // 
            this.成绩DataGridViewTextBoxColumn.DataPropertyName = "成绩";
            this.成绩DataGridViewTextBoxColumn.HeaderText = "成绩";
            this.成绩DataGridViewTextBoxColumn.Name = "成绩DataGridViewTextBoxColumn";
            this.成绩DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RecordSearch);
            this.tabControl1.Controls.Add(this.SNSearach);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 481);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 455);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "总成绩查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.轮数DataGridViewTextBoxColumn1,
            this.擂主DataGridViewTextBoxColumn,
            this.挑战者DataGridViewTextBoxColumn1,
            this.结果DataGridViewTextBoxColumn1,
            this.获胜者DataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.roundsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(868, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // 轮数DataGridViewTextBoxColumn1
            // 
            this.轮数DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.轮数DataGridViewTextBoxColumn1.DataPropertyName = "轮数";
            this.轮数DataGridViewTextBoxColumn1.HeaderText = "轮数";
            this.轮数DataGridViewTextBoxColumn1.Name = "轮数DataGridViewTextBoxColumn1";
            this.轮数DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 擂主DataGridViewTextBoxColumn
            // 
            this.擂主DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.擂主DataGridViewTextBoxColumn.DataPropertyName = "擂主";
            this.擂主DataGridViewTextBoxColumn.HeaderText = "擂主";
            this.擂主DataGridViewTextBoxColumn.Name = "擂主DataGridViewTextBoxColumn";
            this.擂主DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 挑战者DataGridViewTextBoxColumn1
            // 
            this.挑战者DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.挑战者DataGridViewTextBoxColumn1.DataPropertyName = "挑战者";
            this.挑战者DataGridViewTextBoxColumn1.HeaderText = "挑战者";
            this.挑战者DataGridViewTextBoxColumn1.Name = "挑战者DataGridViewTextBoxColumn1";
            this.挑战者DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 结果DataGridViewTextBoxColumn1
            // 
            this.结果DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.结果DataGridViewTextBoxColumn1.DataPropertyName = "结果";
            this.结果DataGridViewTextBoxColumn1.HeaderText = "结果";
            this.结果DataGridViewTextBoxColumn1.Name = "结果DataGridViewTextBoxColumn1";
            this.结果DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // 获胜者DataGridViewTextBoxColumn1
            // 
            this.获胜者DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.获胜者DataGridViewTextBoxColumn1.DataPropertyName = "获胜者";
            this.获胜者DataGridViewTextBoxColumn1.HeaderText = "获胜者";
            this.获胜者DataGridViewTextBoxColumn1.Name = "获胜者DataGridViewTextBoxColumn1";
            this.获胜者DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // roundsBindingSource
            // 
            this.roundsBindingSource.DataMember = "Rounds";
            this.roundsBindingSource.DataSource = this.studentDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentRoundsviewTableAdapter
            // 
            this.studentRoundsviewTableAdapter.ClearBeforeFill = true;
            // 
            // roundsTableAdapter
            // 
            this.roundsTableAdapter.ClearBeforeFill = true;
            // 
            // 擂主
            // 
            this.擂主.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.擂主.DataPropertyName = "擂主";
            this.擂主.HeaderText = "擂主";
            this.擂主.Name = "擂主";
            this.擂主.ReadOnly = true;
            // 
            // 轮数DataGridViewTextBoxColumn
            // 
            this.轮数DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.轮数DataGridViewTextBoxColumn.DataPropertyName = "轮数";
            this.轮数DataGridViewTextBoxColumn.HeaderText = "轮数";
            this.轮数DataGridViewTextBoxColumn.Name = "轮数DataGridViewTextBoxColumn";
            this.轮数DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 挑战者DataGridViewTextBoxColumn
            // 
            this.挑战者DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.挑战者DataGridViewTextBoxColumn.DataPropertyName = "挑战者";
            this.挑战者DataGridViewTextBoxColumn.HeaderText = "挑战者";
            this.挑战者DataGridViewTextBoxColumn.Name = "挑战者DataGridViewTextBoxColumn";
            this.挑战者DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 结果DataGridViewTextBoxColumn
            // 
            this.结果DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.结果DataGridViewTextBoxColumn.DataPropertyName = "结果";
            this.结果DataGridViewTextBoxColumn.HeaderText = "结果";
            this.结果DataGridViewTextBoxColumn.Name = "结果DataGridViewTextBoxColumn";
            this.结果DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 获胜者DataGridViewTextBoxColumn
            // 
            this.获胜者DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.获胜者DataGridViewTextBoxColumn.DataPropertyName = "获胜者";
            this.获胜者DataGridViewTextBoxColumn.HeaderText = "获胜者";
            this.获胜者DataGridViewTextBoxColumn.Name = "获胜者DataGridViewTextBoxColumn";
            this.获胜者DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 481);
            this.Controls.Add(this.tabControl1);
            this.Name = "show";
            this.Text = "结果查询";
            this.Load += new System.EventHandler(this.Show_Load);
            this.SNSearach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentRoundsviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.RecordSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private studentDataSet studentDataSet;
        private System.Windows.Forms.TabPage SNSearach;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox studentname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage RecordSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private studentDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.BindingSource studentRoundsviewBindingSource;
        private studentDataSetTableAdapters.studentRoundsviewTableAdapter studentRoundsviewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource roundsBindingSource;
        private studentDataSetTableAdapters.RoundsTableAdapter roundsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成绩DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 轮数DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 擂主DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 挑战者DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结果DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 获胜者DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 擂主;
        private System.Windows.Forms.DataGridViewTextBoxColumn 轮数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 挑战者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结果DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 获胜者DataGridViewTextBoxColumn;
    }
}