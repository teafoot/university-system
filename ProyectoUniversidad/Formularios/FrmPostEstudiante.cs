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
    public partial class FrmPostEstudiante : Form
    {
        public static int Login;
        public int verNotas=0;
        public FrmPostEstudiante(int login)
        {
            InitializeComponent();
            Login = login;
        }

        private void FrmPostEstudiante_Load(object sender, EventArgs e)
        {
            if (verNotas==0)
            {
                gbxNotas.Visible = false;
            } else if (verNotas==1)
            {
                gbxestudiantemod.Visible = false;
                gbxuniversidadmod.Visible = false;
                gbxNotas.SetBounds(20,28, 689, 141);
            }
            Estudiante a = new Estudiante();
            a=MetodosEstudiante.CargarEstudiante(Login);
            txtnombre.Text = a.Nombre;
            txtapellidopaterno.Text = a.Apellidopaterno;
            txtapellidomaterno.Text = a.Apellidomaterno;
            //
            cbxsexo.DataSource = MetodoSexo.ObtenerSexos();
            cbxsexo.DisplayMember = "NombreSexo";
            cbxsexo.ValueMember = "IdSexo";
            cbxsexo.SelectedValue = MetodoSexo.CargarSexo(Login);
            cbxsexo.Enabled = false;
            //
            txtcarnetidentidad.Text = a.Carnetidentidad.ToString();
            DTPfechanacimiento.Value = a.Fechanacimiento;
            txtpaisnacimiento.Text = a.Paisnacimiento;
            txtdireccion.Text = a.Direccion;
            txttelefono.Text = a.Telefono.ToString();
            txtemail.Text = a.Email;
            //
            //
            Universidad b = new Universidad();
            b = MetodosUniversidad.Cargar(Login);
            txtcodigoestudiante.Text = b.Codigoestudiante.ToString();
            txtpasswordestudiante.Text = b.Passwordestudiante;
            //
            cbxcarrera.DataSource = MetodoCarrera.ObtenerCarreras();
            cbxcarrera.DisplayMember = "NombreCarrera";
            cbxcarrera.ValueMember = "IdCarrera";
            cbxcarrera.SelectedValue = MetodoCarrera.CargarCarrera(Login);
            cbxcarrera.Enabled = false;
            cbxsede.DataSource=MetodoSede.ObtenerSedes();
            cbxsede.DisplayMember = "NombreSede";
            cbxsede.ValueMember = "IdSede";
            cbxsede.SelectedValue = MetodoSede.CargarSede(Login);
            cbxsede.Enabled = false;
            cbxpago.DataSource = MetodoPago.ObtenerPagos();
            cbxpago.DisplayMember = "NombrePago";
            cbxpago.ValueMember = "IdPago";
            cbxpago.SelectedValue = MetodoPago.CargarPago(Login);
            cbxpago.Enabled = false;
            cbxgestion.DataSource = MetodoGestion.ObtenerGestiones();
            cbxgestion.DisplayMember = "NombreGestion";
            cbxgestion.ValueMember = "IdGestion";
            cbxgestion.SelectedValue = MetodoGestion.CargarGestion(Login);
            cbxgestion.Enabled = false;
            //
            chklegalizadabachiller.Checked=Convert.ToBoolean(b.Legalizadabachiller);
            chkfotocopialibreta.Checked = Convert.ToBoolean(b.Fotocopialibreta);
            chkcertificadonacimiento.Checked = Convert.ToBoolean(b.Certificadonacimiento);
            chkfotocopiacarnetidentidad.Checked = Convert.ToBoolean(b.Fotocopiacarnetidentidad);
            chkfotografiasfondoazul.Checked = Convert.ToBoolean(b.Fotografiasfondoazul);
            //
            //
            codigoestudiante = Convert.ToInt32(txtcodigoestudiante.Text);
            carrera = Convert.ToInt32(cbxcarrera.SelectedValue);
            cbxsemestre.DataSource = MetodoSemestre.ObtenerSemestres();
            cbxsemestre.DisplayMember = "NombreSemestre";
            cbxsemestre.ValueMember ="IdSemestre";
            //
            cbxprimerparcial.DataSource = MetodoNota.ObtenerPrimerParcial();
            cbxprimerparcial.DisplayMember = "PrimerParcial";
            cbxprimerparcial.ValueMember = "PrimerParcial";
            cbxsegundoparcial.DataSource = MetodoNota.ObtenerSegundoParcial();
            cbxsegundoparcial.DisplayMember = "SegundoParcial";
            cbxsegundoparcial.ValueMember = "SegundoParcial";
            cbxevaluacionproyecto.DataSource = MetodoNota.ObtenerEvaluacionProyecto();
            cbxevaluacionproyecto.DisplayMember = "EvaluacionProyecto";
            cbxevaluacionproyecto.ValueMember = "EvaluacionProyecto";
            cbxexamenfinal.DataSource = MetodoNota.ObtenerExamenFinal();
            cbxexamenfinal.DisplayMember = "ExamenFinal";
            cbxexamenfinal.ValueMember = "ExamenFinal";
            cbxsegundoturno.DataSource = MetodoNota.ObtenerSegundoTurno();
            cbxsegundoturno.DisplayMember = "SegundoTurno";
            cbxsegundoturno.ValueMember = "SegundoTurno";
            //
        }
        public static int codigoestudiante,carrera,semestre,materia;

       private void btnmaterias_Click(object sender, EventArgs e)
        {
            semestre = Convert.ToInt32(cbxsemestre.SelectedValue);
            cbxmateria.DataSource = MetodoMateria.ObtenerMaterias(carrera, semestre);
            cbxmateria.DisplayMember = "NombreMateria";
            cbxmateria.ValueMember = "IdMateria";
        }
        private void btnnotas_Click(object sender, EventArgs e)
        {
            materia=Convert.ToInt32(cbxmateria.SelectedValue);
            Nota a = new Nota();
            a=MetodosUniversidad.CargarNota(codigoestudiante, semestre, materia);
            cbxprimerparcial.SelectedValue = a.Primerparcial;
            cbxsegundoparcial.SelectedValue = a.Segundoparcial;
            cbxevaluacionproyecto.SelectedValue = a.Evaluacionproyecto;
            cbxexamenfinal.SelectedValue = a.Examenfinal;
            cbxsegundoturno.SelectedValue = a.Segundoturno;
            txtnotafinal.Text = a.Notafinal.ToString();
        }

        private void pcbBtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPreEstudiante f1 = new FrmPreEstudiante(Login);
            f1.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBienvenida f1 = new FrmBienvenida();
            f1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPreEstudiante f1 = new FrmPreEstudiante(Login);
            f1.Show();
        }

    }
}
