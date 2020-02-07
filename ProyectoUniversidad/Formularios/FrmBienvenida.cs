using libreria.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libreria
{
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }
                    
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cbxTipoUsuario.Text=="Administrador")
            {
                try
                {
                    int x = MetodoAutenticar.Admin(txtNombreUsuario.Text, txtPasswordUsuario.Text);
                    if (x > 0)
                    {
                        FrmPreAdmin f1 = new FrmPreAdmin();
                        this.Hide();
                        f1.Show();
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                }
            } 
            else if (cbxTipoUsuario.Text=="Estudiante")
            {
                try
                {
                    int x = MetodoAutenticar.Estudiante(txtNombreUsuario.Text, txtPasswordUsuario.Text);
                    if (x > 0)
                    {
                        int login = Convert.ToInt32(txtNombreUsuario.Text);
                        FrmPreEstudiante f1 = new FrmPreEstudiante(login);
                        f1.Show();
                        this.Hide();
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
