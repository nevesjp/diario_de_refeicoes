using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diario_de_refeicoes
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistroRefeicao f = new FrmRegistroRefeicao();
            f.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelatorio f = new FrmRelatorio();
            f.Show();
        }

        private void registrarRefeiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroRefeicao f = new FrmRegistroRefeicao();
            f.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorio f = new FrmRelatorio();
            f.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
