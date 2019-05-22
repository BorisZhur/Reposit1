using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Filemanager
{
    public static class Controlfunc
    {
        public static void Makeitvisible(params Control[] o)
        {
            foreach (Control obj in o)
            {
                obj.Visible = true;
            }
        }

        public static void Makeitinvisible(params Control[] o)
        {
            foreach (Control obj in o)
            {
                obj.Visible = false;
            }
        }
    }
}
