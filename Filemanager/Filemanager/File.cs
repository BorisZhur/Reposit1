using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filemanager
{
    public class File
    {
        public System.DateTime date;
        public string pathtofile, pathtosign, pathtolog, note, name, filehashfromsig, loghashfromsig, touser, fromuser;
        public int state;
        public List<Logline> logs;
        public bool goodfile = false;

        public string State
        {
            get
            {
                switch (this.state)
                {
                    case -2:
                        return "No ES";
                    case -1:
                        return "Non valid ES";
                    case 1:
                        return "To verify";
                    case 2:
                        return "To rework";
                    case 3:
                        return "Completed";
                    default:
                        return "In work";
                }
            }
            set
            {
                switch (value)
                {
                    case "No ES":
                        this.state = -2;
                        break;
                    case "Non valid ES":
                        this.state = -1;
                        break;
                    case "In work":
                        this.state = 0;
                        break;
                    case "To verify":
                        this.state = 1;
                        break;
                    case "To rework":
                        this.state = 2;
                        break;
                    case "Completed":
                        this.state = 3;
                        break;
                }
            }
        }
        //get from file
        public File(string dir)
        {
            this.pathtofile = dir;
            
            while (dir[dir.Length-1]!='.')
            {
                dir = dir.Remove(dir.Length - 1);
            }
            this.pathtosign = dir + "sig";
            this.pathtolog = dir + "log";
            dir = dir.Remove(dir.Length - 1);
            
            while (dir[dir.Length-1]!='\\')
            {
                this.name += dir[dir.Length - 1];
                dir = dir.Remove(dir.Length - 1);
            }
            this.name = new string(this.name.ToCharArray().Reverse().ToArray());

            if (this.IsSigExist())
            {
                string strfromsig = System.Text.Encoding.UTF8.GetString(Cryptfunc.RSADecrypt(System.IO.File.ReadAllBytes(this.pathtosign)));
                int i = 0;
                if (strfromsig.Contains(" -- "))
                {
                    while (strfromsig.Substring(i, 4) != " -- ")
                    {
                        this.filehashfromsig += strfromsig[i];
                        i++;
                    }
                    this.loghashfromsig = strfromsig.Remove(0, i + 4);
                }
            }

            this.goodfile = this.IsFileValid() && this.IsLogValid();
            if (this.goodfile)
            {
                string[] sep = { "\r\n" };
                string str1 = System.Text.Encoding.UTF8.GetString(Cryptfunc.AESDecrypt(System.IO.File.ReadAllBytes(this.pathtolog)));
                string[] str = str1.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                logs = new List<Logline>();
                foreach (string s in str)
                {
                    this.logs.Add(new Logline(s));
                }

                int lastlog = logs.Count - 1;
                this.date = logs[lastlog].date;
                this.note = logs[lastlog].note;
                this.touser = logs[lastlog].touser;
                this.fromuser = logs[lastlog].fromuser;
                this.state = logs[lastlog].state;
            }
        }
        //new file
        public File(string pathtofolder, string name, string touser, string state, string fromuser, string note)
        {
            string path = pathtofolder + "\\" + name + '.';
            this.pathtofile = path + "docx";
            this.pathtolog = path + "log";
            this.pathtosign = path + "sig";
            this.State = state;
            this.touser = touser;
            this.fromuser = fromuser;
            this.note = note;
            this.date = DateTime.Now;
        }

        public bool IsLogsExist()
        {
            if (System.IO.File.Exists(this.pathtolog))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSigExist()
        {
            if (System.IO.File.Exists(this.pathtosign))
            {
                return true;
            }
            {
                return false;
            }
        }

        public bool IsFileValid()
        {
            if (this.IsSigExist())
            {
                string filehash = Cryptfunc.GetHash(Cryptfunc.AESDecrypt(System.IO.File.ReadAllBytes(this.pathtofile)));
                if (this.filehashfromsig == filehash)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool IsLogValid()
        {
            if (this.IsSigExist() && this.IsLogsExist())
            {
                string filehash = Cryptfunc.GetHash(Cryptfunc.AESDecrypt(System.IO.File.ReadAllBytes(this.pathtolog)));
                if (this.loghashfromsig == filehash)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}