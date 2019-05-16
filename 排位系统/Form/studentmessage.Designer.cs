namespace 排位系统
{
    partial class studentmessage
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
            this.StudentLists = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new 排位系统.studentDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.studentTableAdapter = new 排位系统.studentDataSetTableAdapters.studentTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.TextBox();
            this.record = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.studentname = new System.Windows.Forms.TextBox();
            this.studentsex = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.studentid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentLists
            // 
            this.StudentLists.DataSource = this.studentBindingSource;
            this.StudentLists.DisplayMember = "姓名";
            this.StudentLists.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StudentLists.FormattingEnabled = true;
            this.StudentLists.Location = new System.Drawing.Point(148, 26);
            this.StudentLists.Name = "StudentLists";
            this.StudentLists.Size = new System.Drawing.Size(194, 29);
            this.StudentLists.TabIndex = 20;
            this.StudentLists.ValueMember = "ID";
            this.StudentLists.SelectedIndexChanged += new System.EventHandler(this.StudentLists_SelectedIndexChanged);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "studentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "学生名：";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(13, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "成绩：";
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(112, 179);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(140, 29);
            this.sex.TabIndex = 25;
            // 
            // record
            // 
            this.record.Location = new System.Drawing.Point(112, 251);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(140, 29);
            this.record.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 64);
            this.button1.TabIndex = 27;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(427, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "性别：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(427, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "学生名：";
            // 
            // studentname
            // 
            this.studentname.Location = new System.Drawing.Point(566, 26);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(140, 29);
            this.studentname.TabIndex = 31;
            // 
            // studentsex
            // 
            this.studentsex.Location = new System.Drawing.Point(566, 105);
            this.studentsex.Name = "studentsex";
            this.studentsex.Size = new System.Drawing.Size(140, 29);
            this.studentsex.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 64);
            this.button2.TabIndex = 33;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // studentid
            // 
            this.studentid.AutoSize = true;
            this.studentid.Location = new System.Drawing.Point(94, 108);
            this.studentid.Name = "studentid";
            this.studentid.Size = new System.Drawing.Size(0, 19);
            this.studentid.TabIndex = 35;
            // 
            // studentmessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 441);
            this.Controls.Add(this.studentid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.studentsex);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.record);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentLists);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "studentmessage";
            this.Text = "学生信息管理";
            this.Load += new System.EventHandler(this.Studentmessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ComboBox StudentLists;
        private System.Windows.Forms.Label label1;
        private studentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private studentDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox record;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox studentname;
        private System.Windows.Forms.TextBox studentsex;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label studentid;
    }
}