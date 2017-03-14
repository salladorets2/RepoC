using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prgTchLB1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sql11156565DataSet.Reserve". При необходимости она может быть перемещена или удалена.
            this.reserveTableAdapter.Fill(this.sql11156565DataSet.Reserve);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sql11156565DataSet.Vanues". При необходимости она может быть перемещена или удалена.
            this.vanuesTableAdapter.Fill(this.sql11156565DataSet.Vanues);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sql11156565DataSet.Reserve". При необходимости она может быть перемещена или удалена.
            this.reserveTableAdapter.Fill(this.sql11156565DataSet.Reserve);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sql11156565DataSet.Vanues". При необходимости она может быть перемещена или удалена.
            this.vanuesTableAdapter.Fill(this.sql11156565DataSet.Vanues);

        }

        private void вызодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void eventsVanuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSwitch.SwitchTo2(this, new Form1());
        }

        private void vanuesReservCustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSwitch.SwitchTo2(this, new Form2());
        }

        private void reservesCustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSwitch.SwitchTo2(this, new Res_Cust());
        }

        private void vanuesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vanuesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sql11156565DataSet);

        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.ShowDialog();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, "lb3.chm", HelpNavigator.TopicId, "20");
        }
        private void Navig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, "lb3.chm", HelpNavigator.TopicId, "32");
        }
        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, "lb3.chm", HelpNavigator.TopicId, "35");
        }
        private void parentTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, "lb3.chm", HelpNavigator.TopicId, "34");
        }
        private void Child_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Help.ShowHelp(this, "lb3.chm", HelpNavigator.TopicId, "36");
        }

        private void помощьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "lb3.chm");
        }
    }
}
