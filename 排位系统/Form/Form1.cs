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
    public partial class Form1 : Form
    {
        public static Form1 form;
        public Master master;
        public Form1()
        {
            InitializeComponent();
            form = this;
            master = new Master();
            challenger1radio.Text = "胜";
            challenger2radio.Text = "胜";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form student = new studentmessage();
            student.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form show = new show();
            show.ShowDialog();
        }
        public void start()
        {
            number.Text = master.rounds.ToString();
            for(int i=1;i<=master.numbers;i++)
            {
                comboBox1.Items.Add(i.ToString());
            }

            this.challengerListTableAdapter.Fill(this.studentDataSet.challengerList);
            string filter = "";
            BindingSource bs = new BindingSource();
            bs = dataGridView1.DataSource as BindingSource;
            //拼接查询条件
            filter += "(轮数='"+number.Text+"')";//"(年='" + date.Year + "' and 月 = '" + date.Month + "'and 日 ='" + date.Day + "')";
            bs.Filter = filter;
            dataGridView1.DataSource = bs;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if(button2.Text=="比赛开始")
            {
                Form play = new play();
                play.ShowDialog();
                button2.Text = "比赛结束";
            }
            else if(button2.Text=="比赛结束")
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet.challengerList”中。您可以根据需要移动或删除它。
            

        }
        Player player;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            player = master.playerList[Convert.ToInt32(comboBox1.Text)];
            challenger1.Text = player.challenger1.message.name;
            challenger1radio.Text = challenger1.Text + "胜";
            challenger2.Text = player.challenger2.message.name;
            challenger2radio.Text = challenger2.Text + "胜";
            button5.Enabled = true;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if(challenger1radio.Checked==true)
            {
                using (testEntities db = new testEntities())
                {
                    Rounds rounds = new Rounds();
                    rounds.rounds1 = master.rounds;
                    rounds.challenger1 = challenger1.Text;
                    rounds.challenger2 = challenger2.Text;
                    rounds.result = challenger1.Text + "+2";
                    rounds.winner = challenger1.Text;
                    player.challenger1.saverecords(2);
                    db.Rounds.Add(rounds);
                    db.SaveChanges();
                }
                MessageBox.Show("结果保存成功！");
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                challenger1radio.Checked = false;
                button5.Enabled = false;
            }else if(challenger2radio.Checked == true)
            {
                using (testEntities db = new testEntities())
                {
                    Rounds rounds = new Rounds();
                    rounds.rounds1 = master.rounds;
                    rounds.challenger1 = challenger1.Text;
                    rounds.challenger2 = challenger2.Text;
                    rounds.result = challenger2.Text + "+2";
                    player.challenger2.saverecords(2);
                    rounds.winner = challenger2.Text;
                    db.Rounds.Add(rounds);
                    db.SaveChanges();
                }
                MessageBox.Show("结果保存成功！");
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                challenger2radio.Checked = false;
                button5.Enabled = false;
            }else
            {
                using (testEntities db = new testEntities())
                {
                    Rounds rounds = new Rounds();
                    rounds.rounds1 = master.rounds;
                    rounds.challenger1 = challenger1.Text;
                    rounds.challenger2 = challenger2.Text;
                    rounds.result = "平局";
                    rounds.winner = "无";
                    db.Rounds.Add(rounds);
                    db.SaveChanges();
                }
                MessageBox.Show("结果保存成功！");
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                challenger1radio.Checked = false;
                button5.Enabled = false;
            }
            if (comboBox1.Items.Count == 0)
            {
                button3.Enabled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            master.nextround();
            master.saveplaylist();
            start();
        }
    }
}
