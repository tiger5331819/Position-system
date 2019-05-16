using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 排位系统
{
    public struct Message
    {
        public int ID;
        public string name;
        public string sex;
        public int records;
    }
    public class ClassStudent
    {
        public Message message;
        Dictionary<string, ClassStudent> challenger;
        ClassStudent me;

        public ClassStudent(int SID)
        {
            message = new Message();
            challenger = new Dictionary<string, ClassStudent>();
            me = this;
            using (testEntities db = new testEntities())
            {
                student s= db.student.Where(p => p.ID == SID).FirstOrDefault();
                if (s == null) MessageBox.Show("111");
                message.ID = s.ID;
                message.name = s.name;
                message.sex = s.sex;
                message.records = s.record;
            }
            challenger.Add(message.name, me);
        }
        public bool addchallenger(string name, ClassStudent student)
        {
            if(!this.challenger.ContainsKey(name))
            {
                this.challenger.Add(name, student);
                return true;
            }
            return false;
        }
        public void saverecords(int record)
        {
            message.records += record;
            using (testEntities db = new testEntities())
            {
                student s = db.student.Where(x => x.ID == this.message.ID).FirstOrDefault();
                s.record = message.records;
                db.SaveChanges();
            }
        }
    }
}
