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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        

        private void Entrar_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String senha = txtSenha.Text;

            if (usuario == "Texugo" || usuario == "Truta" && senha == "123")
            {
                this.Hide();
                Welcome w = new Welcome();
                w.texto(usuario);
                w.Show();
            }

        }

        private void btnCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Cadastro c = new Cadastro();
            c.Show();
        }
    }
}
