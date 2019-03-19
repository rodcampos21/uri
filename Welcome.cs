using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        public void texto (String nome)
        {
            txtNome.Text = nome;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
