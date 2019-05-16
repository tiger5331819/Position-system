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
    public partial class show : Form
    {
        public show()
        {
            InitializeComponent();
        }

        private void Show_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet.Rounds”中。您可以根据需要移动或删除它。
            this.roundsTableAdapter.Fill(this.studentDataSet.Rounds);
            // TODO: 这行代码将数据加载到表“studentDataSet.studentRoundsview”中。您可以根据需要移动或删除它。
            this.studentRoundsviewTableAdapter.Fill(this.studentDataSet.studentRoundsview);
            // TODO: 这行代码将数据加载到表“studentDataSet.student”中。您可以根据需要移动或删除它。
            this.studentTableAdapter.Fill(this.studentDataSet.student);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string filter = "";

            BindingSource bs = new BindingSource();
            bs = dataGridView3.DataSource as BindingSource;
            //拼接查询条件
            filter += "(擂主='"+studentname.Text+"'or 挑战者='"+studentname.Text+"')";//"(年='" + date.Year + "' and 月 = '" + date.Month + "'and 日 ='" + date.Day + "')";
            bs.Filter = filter;
            dataGridView3.DataSource = bs;
        }
    }
}
