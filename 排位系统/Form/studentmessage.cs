using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 排位系统
{
    public partial class studentmessage : Form
    {
        public studentmessage()
        {
            InitializeComponent();
        }

        private void Studentmessage_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet.student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.studentDataSet.student);
            // TODO: 这行代码将数据加载到表“studentDataSet.student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.studentDataSet.student);
            StudentLists.Text = "";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (studentid.Text == "") return;
            using (testEntities db = new testEntities())
            {
                student s = db.student.Where(p => p.name == StudentLists.Text).FirstOrDefault();
                s.sex = sex.Text;
                s.record =Convert.ToInt32(record.Text);
                db.SaveChanges();
            }
            MessageBox.Show("修改成功！");
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if(studentname.Text!="")
            {
                if(studentsex.Text!="")
                {
                    using (testEntities db = new testEntities())
                    {
                        student s = new student();
                        s.name = studentname.Text;
                        s.sex = studentsex.Text;
                        s.record = 0;
                        db.student.Add(s);
                        db.SaveChanges();
                    }
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("性别不能为空！");
                    return;
                }
            }
            else
            {
                MessageBox.Show("名字不能为空！");
                return;
            }
        }
        private void StudentLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (testEntities db = new testEntities())
            {
                student s = db.student.Where(p => p.name == StudentLists.Text).FirstOrDefault();
                studentid.Text = s.ID.ToString();
                sex.Text = s.sex;
                record.Text = s.record.ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt", Encoding.GetEncoding("GB2312")))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    int i = line.IndexOf(" ");
                    string s = line.Substring(0, i);
                    line = line.Remove(0, i);
                    using (testEntities db = new testEntities())
                    {
                        student st = new student();
                        st.name = s;
                        st.sex = line;
                        st.record = 0;
                        db.student.Add(st);
                        db.SaveChanges();
                    }
                }
            }
            MessageBox.Show("批量添加成功！");
        }
    }
}
