using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filemanager
{
    public class User
    {
        public User(string name, string pass)
        {
            this.name = name;
            this.pass = pass;
        }

        public User(string name, int accesslevel, string pass)
        {
            this.name = name;
            this.accesslevel = accesslevel;
            this.pass = pass;
        }

        public string name;
        public int accesslevel;
        public string pass;

        public string Accesslevel
        {
            get
            {
                switch (this.accesslevel)
                {
                    case 0:
                        return "Leadership";
                    case 1:
                        return "Middle level worker";
                    default:
                        return "Low level worker";
                }
            }
            set
            {
                switch(value)
                {
                    case "Leadership":
                        this.accesslevel = 0;
                        break;
                    case "Middle level worker":
                        this.accesslevel = 1;
                        break;
                    default:
                        this.accesslevel = 2;
                        break;
                }
            }
        }
    }
}