using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 排位系统
{
    public partial class play : Form
    {
        public play()
        {
            InitializeComponent();
            
        }
        int number = 1;
        private void Play_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet.student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.studentDataSet.student);
            Number.Text = "1";
            Form1.form.master.addstudents(comboBox1.Items.Count);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text!=""&&comboBox2.Text!="")
            {
                if(!Form1.form.master.addplay(number, comboBox1.Text, comboBox2.Text))return;
                number++;
                Number.Text = number.ToString();
                //comboBox1.Items.Remove(comboBox1.SelectedItem);
                //comboBox2.Items.Remove(comboBox2.SelectedItem);
                comboBox1.Text = "";
                comboBox2.Text = "";
                MessageBox.Show("成功安排！");
            }else
            {
                MessageBox.Show("请选择选手");
            }
        }

        private void Play_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.form.master.saveplaylist();
            Form1.form.start();
        }
    }
}
