using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
                button2.Text = "比赛开始";
            }
        }
        Player player;
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            player = master.playerList[Convert.ToInt32(comboBox1.Text)];
            challenger1.Text = player.challenger1.message.name;
            challenger1radio.Text = challenger1.Text + "  胜";
            challenger2.Text = player.challenger2.message.name;
            challenger2radio.Text = challenger2.Text + "  胜";
            challenger1radio.Enabled = true;
            challenger2radio.Enabled = true;
            if (challenger2.Text == "") challenger2radio.Enabled = false;
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
                challenger1radio.Enabled = false;
                challenger2radio.Enabled = false;
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
                challenger1radio.Enabled = false;
                challenger2radio.Enabled = false;
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
                    player.challenger1.saverecords(1);
                    player.challenger2.saverecords(1);
                    db.Rounds.Add(rounds);
                    db.SaveChanges();
                }
                MessageBox.Show("结果保存成功！");
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                challenger1radio.Checked = false;
                challenger1radio.Enabled = false;
                challenger2radio.Enabled = false;
                button5.Enabled = false;
            }
            if (comboBox1.Items.Count == 0)
            {
                button3.Enabled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            challenger1.Text = "擂主";
            challenger2.Text = "挑战者";
            challenger1radio.Text= "擂主  胜";
            challenger2radio.Text = "挑战者  胜";
            try
            {
                master.nextround();
                master.saveplaylist();
                start();
            }
            catch (Exception)
            {
                MessageBox.Show("没有下一轮！");
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string sql;
            string filename = DateTime.Now.ToString();
            string ConnectionStr = "Data Source=10.155.198.210;Initial Catalog=test;Persist Security Info=True;User ID=administrator;Password=Win2008+";
            SqlConnection conn = new SqlConnection(ConnectionStr);

            conn.Open();
            sql = "DELETE FROM challengerList WHERE ID<10000"; //查询表
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteScalar();
            sql = "DELETE FROM Rounds WHERE ID<10000"; //查询表
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteScalar();
            sql = "DELETE FROM student WHERE ID<10000"; //查询表
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteScalar();
            sql = "dbcc checkident(student,reseed,0) dbcc checkident(Rounds, reseed,0) dbcc checkident(challengerList, reseed,0)"; //查询表
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteScalar();
            conn.Close();
            MessageBox.Show("数据重置成功！");
        }
        public void WriteExcel(DataSet ds,string s)
        {
                string path = s+".xls";
                StreamWriter sw = new StreamWriter(path, false, Encoding.GetEncoding("gb2312"));
                StringBuilder sb = new StringBuilder();
                for (int k = 0; k < ds.Tables[0].Columns.Count; k++)
                {
                    sb.Append(ds.Tables[0].Columns[k].ColumnName.ToString() + "\t");
                }
                sb.Append(Environment.NewLine);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        sb.Append(ds.Tables[0].Rows[i][j].ToString() + "\t");
                    }
                    sb.Append(Environment.NewLine);//每写一行数据后换行
                }
                sw.Write(sb.ToString());
                sw.Flush();
                sw.Close();//释放资源
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //建立数据库链接
            string sql;
            string filename = DateTime.Now.ToString();
            string ConnectionStr = "Data Source=.;Initial Catalog=test;Persist Security Info=True;User ID=sa;Password=sa";

            //创建DataSet表并且将数据存入表中
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(ConnectionStr);

            conn.Open();
            sql = "SELECT * FROM student"; //查询表
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(ds);
            WriteExcel(ds,"学生成绩");

            ds = new DataSet();
            sql = "SELECT * FROM Rounds"; //查询表
            sda = new SqlDataAdapter(sql, conn);
            sda.Fill(ds);
            WriteExcel(ds, "每轮战况");

            ds = new DataSet();
            sql = "SELECT * FROM challengerList"; //查询表
            sda = new SqlDataAdapter(sql, conn);
            sda.Fill(ds);
            WriteExcel(ds, "对战表");
            conn.Close();
            MessageBox.Show("已经生成指定Excel文件!");
        }
    }
}
