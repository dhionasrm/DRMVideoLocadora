using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRMVideoLocadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if ((e.Button == toolStripSplitButton1))
            {
                Button botao = (Button)sender;
                Form_Edit_DB form = new Form_Edit_DB();
                form.MdiParent = this;
                form.Show();
            } else if ((e.Button == toolStripSplitButton2))
            {
                Form_V_tapes form = new Form_V_tapes();
                form.MdiParent = this;
                form.Show();
            } else if ((e.Button == toolStripSplitButton3))
            {
                Form_S_M form = new Form_S_M();
                form.MdiParent = this;
                form.Show();
            } else if ((e.Button == toolStripSplitButton5))
            {
                Form_Add form = new Form_Add();
                form.MdiParent = this;
                form.Show();
            } else if ((e.Button == toolStripSplitButton6))
            {
                Form_Add_M form = new Form_Add_M();
                form.MdiParent = this;
                form.Show();
            } else if ((e.Button == toolStripSplitButton8))
            {
                Form_Rent form = new Form_Rent();
                form.MdiParent = this;
                form.Show();
            } else if ((e.Button == toolStripButton1))
            {
                this.Close();
            } else if ((e.Button == toolStripButton2))
            {
                MessageBox.Show("Software de video locadora criado por Macoratti e migrado para o C# por Dhionas Ribeiro Magalhães", "Locadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
