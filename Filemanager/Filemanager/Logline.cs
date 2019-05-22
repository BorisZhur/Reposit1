using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filemanager
{
    public class Logline
    {
        public string fromuser, touser, note;
        public int state;
        public DateTime date;

        public string State
        {
            get
            {
                switch (state)
                {
                    case 1:
                        return "Sent for verification";
                    case 2:
                        return "Sent for rework";
                    case 3:
                        return "Finished document";
                    default:
                        return "Worked";
                }
            }
            set
            {
                switch (value)
                {
                    case "Sent for verification":
                        this.state = 1;
                        break;
                    case "Sent for rework":
                        this.state = 2;
                        break;
                    case "Finished document":
                        this.state = 3;
                        break;
                    default:
                        this.state = 0;
                        break;
                }
            }
        }
        //reading logs
        public Logline(string str)
        {
            this.state = int.Parse(str[0].ToString());
            int i = 5;
            while (str.Substring(i,4)!=" -- ")
            {
                this.fromuser += str[i];
                i++;
            }
            i += 4;
            while (str.Substring(i,4)!=" -- ")
            {
                this.touser += str[i];
                i++;
            }
            i += 4;
            this.date = Convert.ToDateTime(str.Substring(i, 19));
            i += 22;
            while (i!=str.Length)
            {
                this.note += str[i];
                i++;
            }
        }
    }
}