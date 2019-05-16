namespace 排位系统
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.challenger2radio = new System.Windows.Forms.RadioButton();
            this.challenger1radio = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.challengerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new 排位系统.studentDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.challenger2 = new System.Windows.Forms.Label();
            this.challenger1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.challengerListTableAdapter = new 排位系统.studentDataSetTableAdapters.challengerListTableAdapter();
            this.轮数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.赛场号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.擂主DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.挑战者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "学生信息管理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "比赛开始";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(397, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "下一轮";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(572, 18);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "查看成绩";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.challenger2radio);
            this.groupBox1.Controls.Add(this.challenger1radio);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.challenger2);
            this.groupBox1.Controls.Add(this.challenger1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1242, 369);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "比赛信息";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(65, 233);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 42);
            this.button5.TabIndex = 16;
            this.button5.Text = "保存";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // challenger2radio
            // 
            this.challenger2radio.AutoSize = true;
            this.challenger2radio.Location = new System.Drawing.Point(219, 188);
            this.challenger2radio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.challenger2radio.Name = "challenger2radio";
            this.challenger2radio.Size = new System.Drawing.Size(94, 25);
            this.challenger2radio.TabIndex = 15;
            this.challenger2radio.TabStop = true;
            this.challenger2radio.Text = "挑战者";
            this.challenger2radio.UseVisualStyleBackColor = true;
            // 
            // challenger1radio
            // 
            this.challenger1radio.AutoSize = true;
            this.challenger1radio.Location = new System.Drawing.Point(42, 188);
            this.challenger1radio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.challenger1radio.Name = "challenger1radio";
            this.challenger1radio.Size = new System.Drawing.Size(72, 25);
            this.challenger1radio.TabIndex = 14;
            this.challenger1radio.TabStop = true;
            this.challenger1radio.Text = "擂主";
            this.challenger1radio.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.轮数,
            this.赛场号DataGridViewTextBoxColumn,
            this.擂主DataGridViewTextBoxColumn,
            this.挑战者DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.challengerListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(602, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(628, 356);
            this.dataGridView1.TabIndex = 13;
            // 
            // challengerListBindingSource
            // 
            this.challengerListBindingSource.DataMember = "challengerList";
            this.challengerListBindingSource.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "studentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(435, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "本轮对阵：";
            // 
            // challenger2
            // 
            this.challenger2.AutoSize = true;
            this.challenger2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.challenger2.Location = new System.Drawing.Point(215, 142);
            this.challenger2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.challenger2.Name = "challenger2";
            this.challenger2.Size = new System.Drawing.Size(103, 29);
            this.challenger2.TabIndex = 11;
            this.challenger2.Text = "挑战者";
            // 
            // challenger1
            // 
            this.challenger1.AutoSize = true;
            this.challenger1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.challenger1.Location = new System.Drawing.Point(38, 142);
            this.challenger1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.challenger1.Name = "challenger1";
            this.challenger1.Size = new System.Drawing.Size(73, 29);
            this.challenger1.TabIndex = 10;
            this.challenger1.Text = "擂主";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(134, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "VS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(215, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "挑战者";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(38, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "擂主";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(308, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 29);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "赛场号：";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(106, 38);
            this.number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(22, 21);
            this.number.TabIndex = 1;
            this.number.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "轮数：";
            // 
            // challengerListTableAdapter
            // 
            this.challengerListTableAdapter.ClearBeforeFill = true;
            // 
            // 轮数
            // 
            this.轮数.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.轮数.DataPropertyName = "轮数";
            this.轮数.HeaderText = "轮数";
            this.轮数.Name = "轮数";
            this.轮数.ReadOnly = true;
            // 
            // 赛场号DataGridViewTextBoxColumn
            // 
            this.赛场号DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.赛场号DataGridViewTextBoxColumn.DataPropertyName = "赛场号";
            this.赛场号DataGridViewTextBoxColumn.HeaderText = "赛场号";
            this.赛场号DataGridViewTextBoxColumn.Name = "赛场号DataGridViewTextBoxColumn";
            this.赛场号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 擂主DataGridViewTextBoxColumn
            // 
            this.擂主DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.擂主DataGridViewTextBoxColumn.DataPropertyName = "擂主";
            this.擂主DataGridViewTextBoxColumn.HeaderText = "擂主";
            this.擂主DataGridViewTextBoxColumn.Name = "擂主DataGridViewTextBoxColumn";
            this.擂主DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 挑战者DataGridViewTextBoxColumn
            // 
            this.挑战者DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.挑战者DataGridViewTextBoxColumn.DataPropertyName = "挑战者";
            this.挑战者DataGridViewTextBoxColumn.HeaderText = "挑战者";
            this.挑战者DataGridViewTextBoxColumn.Name = "挑战者DataGridViewTextBoxColumn";
            this.挑战者DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "排位系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.challengerListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label challenger2;
        private System.Windows.Forms.Label challenger1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton challenger2radio;
        private System.Windows.Forms.RadioButton challenger1radio;
        private studentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource challengerListBindingSource;
        private studentDataSetTableAdapters.challengerListTableAdapter challengerListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 轮数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 赛场号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 擂主DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 挑战者DataGridViewTextBoxColumn;
    }
}

