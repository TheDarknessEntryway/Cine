using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


          private void filmesmenu_Click(object sender, EventArgs e)
        {
            Filmes filmes = new Filmes();
            filmes.MdiParent = this;
            filmes.Show();
        }

        private void ingressosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingressos ingressos = new Ingressos();
            ingressos.MdiParent = this;
            ingressos.Show();
        }

        private void acessoFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acesso acesso = new Acesso();
            acesso.MdiParent = this;
            acesso.Show();
        }
    }
}
