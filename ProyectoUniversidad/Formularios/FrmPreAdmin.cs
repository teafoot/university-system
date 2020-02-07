using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libreria.Formularios
{
    public partial class FrmPreAdmin : Form
    {
        public FrmPreAdmin()
        {
            InitializeComponent();
        }

        private void pcbVerEstudiante_Click(object sender, EventArgs e)
        {
            FrmPostAdmin f1 = new FrmPostAdmin();
            f1.verNotas = 0;
            f1.Show();
            this.Close();
        }

        private void pcbVerNotas_Click(object sender, EventArgs e)
        {
            FrmPostAdmin f1 = new FrmPostAdmin();
            f1.verNotas = 1;
            f1.Show();
            this.Close();
        }

        private void pcbAtras_Click(object sender, EventArgs e)
        {
            FrmBienvenida f1 = new FrmBienvenida();
            f1.Show();
            this.Close();
        }
    }
}
