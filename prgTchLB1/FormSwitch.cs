using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prgTchLB1
{
    public static class FormSwitch
    {
        public static void SwitchTo2(Form from, Form to)
        {
            to.Show();
            from.Hide();
        }   
    }
}
