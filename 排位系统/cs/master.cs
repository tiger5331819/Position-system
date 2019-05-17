using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 排位系统
{
    public class Player
    {
        public ClassStudent challenger1;
        public ClassStudent challenger2;
        public Player()
        {
        }
    }
    public class Master
    {
        public List<ClassStudent> students = new List<ClassStudent>();
        public Dictionary<int,Player> playerList = new Dictionary<int, Player>();
        public int rounds=1;
        public int numbers
        {
            get { return playerList.Count; }
        }
        public int studentnum
        {
            get { return students.Count; }
        }
        public Master()
        {
        }
        public void addstudents(int flag)
        {
            for(int i=1;i<=flag;i++)
            {
                students.Add(new ClassStudent(i));
            }
        }
        public bool addplay(int number,string c1,string c2)
        {
            Player player = new Player();
            player.challenger1 = students.Find(x => x.message.name == c1);
            player.challenger2 = students.Find(x => x.message.name == c2);
            playerList.Add(number, player);
            if (!player.challenger1.addchallenger(player.challenger2.message.name, player.challenger2)){ MessageBox.Show("1"); return false; }
            if (!player.challenger2.addchallenger(player.challenger1.message.name, player.challenger1)) { MessageBox.Show("2"); return false; }
            return true;
        }
        public bool addplaynull(int number,string c1)
        {
            Player player = new Player();
            player.challenger1 = students.Find(x => x.message.name == c1);
            player.challenger2 = new ClassStudent();
            students.Add(player.challenger2);
            playerList.Add(number, player);
            if (!player.challenger1.addchallenger(player.challenger2.message.name, player.challenger2)) { MessageBox.Show("1"); return false; }
            if (!player.challenger2.addchallenger(player.challenger1.message.name, player.challenger1)) { MessageBox.Show("2"); return false; }
            return true;
        }
        public void saveplaylist()
        {
            using (testEntities db = new testEntities())
            {
                for(int i=1;i<=playerList.Count;i++)
                {
                    challengerList challenger = new challengerList();
                    challenger.rounds = rounds;
                    challenger.count = i;
                    Player player = playerList[i];
                    challenger.challenger1 = player.challenger1.message.name;
                    challenger.challenger2 = player.challenger2.message.name;
                    db.challengerList.Add(challenger);
                }
                db.SaveChanges();
            }
        }
        public void nextround()
        {
            rounds++;
            students.Sort((ClassStudent s1,ClassStudent s2)=>s2.message.records.CompareTo(s1.message.records));
            int flag = students.Count;
            ClassStudent[] ss=new ClassStudent[flag];
            students.CopyTo(ss);
            int number = 1;
            playerList = new Dictionary<int, Player>();
            for(int i=0;i<flag;i++)
            {
                if(ss[i]!=null)
                {
                    for(int j=i+1;j<flag;j++)
                    if(ss[j]!=null)
                    {
                            if (ss[i].addchallenger(ss[j].message.name, ss[j]))
                            {
                                ss[j].addchallenger(ss[i].message.name, ss[i]);
                                Player player = new Player();
                                player.challenger1 = ss[i];
                                player.challenger2 = ss[j];
                                playerList.Add(number, player);
                                number++;
                                ss[i] = null;
                                ss[j] = null;
                                break;
                            }
                    }
                }
            }
        }
        //int sortlist(ClassStudent s1,ClassStudent s2)
        //{
        //    if (s1.message.records > s2.message.records) 
        //    {
        //        return 1;
        //    }
        //    else if (s1.message.records < s2.message.records)
        //    {
        //        return -1;
        //    }
        //    return 0;
        //}
    }
}
