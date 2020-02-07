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
    public partial class FrmPostAdmin : Form
    {
        public int verNotas=0;
        public FrmPostAdmin()
        {
            
            InitializeComponent();
        }

        private void FrmPostAdmin_Load(object sender, EventArgs e)
        {
            if (verNotas == 1)
            {
                tabPgMod.Text = "Ingresar Notas";
                tabCtrl.TabPages.Remove(tabPgIngresar);
                tabCtrl.TabPages.Remove(tabPgDel);
                tabCtrl.TabPages.Remove(tabPgAdminIn);
                tabCtrl.TabPages.Remove(tabPgAdminMod);
                tabCtrl.TabPages.Remove(tabPgAdminDel);
                gbxestudiantemod.Visible = false;
                gbxuniversidadmod.Visible = false;
                btnmod.Visible = false;
                gbxnotasmod.SetBounds(316,45,400,313);
                tabCtrl.SelectedTab =tabPgMod;
            }
            else if (verNotas==0)
            {
                tabPgMod.Text = "Modificar Estudiante";
                gbxnotasmod.Visible = false;
            }
            //mostrar lo universal
            //carrera
            cbxcarreraingresar.DataSource = MetodoCarrera.ObtenerCarreras();
            cbxcarreraingresar.DisplayMember = "NombreCarrera";
            cbxcarreraingresar.ValueMember = "IdCarrera";
            CBXcarreramod.DataSource = MetodoCarrera.ObtenerCarreras();
            CBXcarreramod.DisplayMember = "NombreCarrera";
            CBXcarreramod.ValueMember = "IdCarrera";
            cbxuniversidadcarreramod.DataSource = MetodoCarrera.ObtenerCarreras();
            cbxuniversidadcarreramod.DisplayMember = "NombreCarrera";
            cbxuniversidadcarreramod.ValueMember = "IdCarrera";
            CBXcarreradel.DataSource = MetodoCarrera.ObtenerCarreras();
            CBXcarreradel.DisplayMember = "NombreCarrera";
            CBXcarreradel.ValueMember = "IdCarrera";
            //sede
            cbxsedeingresar.DataSource = MetodoSede.ObtenerSedes();
            cbxsedeingresar.DisplayMember = "NombreSede";
            cbxsedeingresar.ValueMember = "IdSede";
            CBXsedemod.DataSource = MetodoSede.ObtenerSedes();
            CBXsedemod.DisplayMember = "NombreSede";
            CBXsedemod.ValueMember = "IdSede";
            cbxuniversidadsedemod.DataSource = MetodoSede.ObtenerSedes();
            cbxuniversidadsedemod.DisplayMember = "NombreSede";
            cbxuniversidadsedemod.ValueMember = "IdSede";
            CBXsededel.DataSource = MetodoSede.ObtenerSedes();
            CBXsededel.DisplayMember = "NombreSede";
            CBXsededel.ValueMember = "IdSede";
            //pago
            cbxpagoingresar.DataSource = MetodoPago.ObtenerPagos();
            cbxpagoingresar.DisplayMember = "NombrePago";
            cbxpagoingresar.ValueMember = "IdPago";
            cbxpagomod.DataSource = MetodoPago.ObtenerPagos();
            cbxpagomod.DisplayMember = "NombrePago";
            cbxpagomod.ValueMember = "IdPago";
            //gestion
            cbxgestioningresar.DataSource = MetodoGestion.ObtenerGestiones();
            cbxgestioningresar.DisplayMember = "NombreGestion";
            cbxgestioningresar.ValueMember = "IdGestion";
            cbxgestionmod.DataSource = MetodoGestion.ObtenerGestiones();
            cbxgestionmod.DisplayMember = "NombreGestion";
            cbxgestionmod.ValueMember = "IdGestion";
            //sexo
            cbxsexoingresar.DataSource = MetodoSexo.ObtenerSexos();
            cbxsexoingresar.DisplayMember = "NombreSexo";
            cbxsexoingresar.ValueMember = "IdSexo";
            cbxsexomod.DataSource = MetodoSexo.ObtenerSexos();
            cbxsexomod.DisplayMember = "NombreSexo";
            cbxsexomod.ValueMember = "IdSexo";
            //
            //semestre
            cbxsemestremod.DataSource = MetodoSemestre.ObtenerSemestres();
            cbxsemestremod.DisplayMember = "NombreSemestre";
            cbxsemestremod.ValueMember = "IdSemestre";
            //
            //notas
            cbxprimerparcialmod.DataSource = MetodoNota.ObtenerPrimerParcial();
            cbxprimerparcialmod.DisplayMember = "PrimerParcial";
            cbxprimerparcialmod.ValueMember = "PrimerParcial";
            cbxsegundoparcialmod.DataSource = MetodoNota.ObtenerSegundoParcial();
            cbxsegundoparcialmod.DisplayMember = "SegundoParcial";
            cbxsegundoparcialmod.ValueMember = "SegundoParcial";
            cbxevaluacionproyectomod.DataSource = MetodoNota.ObtenerEvaluacionProyecto();
            cbxevaluacionproyectomod.DisplayMember = "EvaluacionProyecto";
            cbxevaluacionproyectomod.ValueMember = "EvaluacionProyecto";
            cbxexamenfinalmod.DataSource = MetodoNota.ObtenerExamenFinal();
            cbxexamenfinalmod.DisplayMember = "ExamenFinal";
            cbxexamenfinalmod.ValueMember = "ExamenFinal";
            cbxsegundoturnomod.DataSource = MetodoNota.ObtenerSegundoTurno();
            cbxsegundoturnomod.DisplayMember = "SegundoTurno";
            cbxsegundoturnomod.ValueMember = "SegundoTurno";
            //
            //
            gbxestudiantemod.Enabled = false;
            gbxuniversidadmod.Enabled = false;
            gbxnotasmod.Enabled=false;
            txtcarnetidentidadmod.Enabled = false;
            txtcodigoestudiantemod.Enabled = false;
            cbxgestionmod.Enabled = false;
            txtnotafinalmod.Enabled = false;
            lsbseleccionestudiantemod.Enabled = false;
            lsbseleccionestudiantedel.Enabled = false;
            btndel.Enabled = false;

            btnDelAdmin.Enabled = false;
            txtLoginAdminMod.Enabled = false;
            lsbSeleccioneAdminMod.Enabled = false;
            gbxModificarAdministrador.Enabled = false;
            lsbSeleccionAdminDel.Enabled = false; ////
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int x, y, z;
            try
            {
                int carnetidentidad = Convert.ToInt32(txtcarnetidentidadingresar.Text);
                int sede = Convert.ToInt32(cbxsedeingresar.SelectedValue);
                int carrera = Convert.ToInt32(cbxcarreraingresar.SelectedValue);
                x= MetodosUniversidad.IngresarNota(carnetidentidad, sede, carrera);
                //
                Estudiante a = new Estudiante();
                a.Nombre = txtnombreingresar.Text;
                a.Apellidopaterno = txtapellidopaternoingresar.Text;
                a.Apellidomaterno = txtapellidomaternoingresar.Text;
                a.Sexo = Convert.ToInt32(cbxsexoingresar.SelectedValue);
                a.Carnetidentidad = Convert.ToInt32(txtcarnetidentidadingresar.Text);
                a.Fechanacimiento = DTPfechanacimientoingresar.Value;
                a.Paisnacimiento = txtpaisnacimientoingresar.Text;
                a.Direccion = txtdireccioningresar.Text;
                a.Telefono = Convert.ToInt32(txttelefonoingresar.Text);
                a.Email = txtemailingresar.Text;
                y = MetodosEstudiante.Ingresar(a);
                //
                Universidad b = new Universidad();
                b.Codigoestudiante = Convert.ToInt32(txtcarnetidentidadingresar.Text);
                b.Passwordestudiante = txtcarnetidentidadingresar.Text;
                b.Carrera = Convert.ToInt32(cbxcarreraingresar.SelectedValue);
                b.Sede = Convert.ToInt32(cbxsedeingresar.SelectedValue);
                b.Pago = Convert.ToInt32(cbxpagoingresar.SelectedValue);
                b.Gestion = Convert.ToInt32(cbxgestioningresar.SelectedValue);
                //chkbox no tiene metodos: datasource,valuemember,displaymember
                if (chklegalizadabachilleringresar.Checked == true)
                {
                    b.Legalizadabachiller = 1;
                }
                else
                {
                    b.Legalizadabachiller = 0;
                }
                if (chkfotocopialibretaingresar.Checked == true)
                {
                    b.Fotocopialibreta = 1;
                }
                else
                {
                    b.Fotocopialibreta = 0;
                }
                if (chkcertificadonacimientoingresar.Checked == true)
                {
                    b.Certificadonacimiento = 1;
                }
                else
                {
                    b.Certificadonacimiento = 0;
                }
                if (chkfotocopiacarnetidentidadingresar.Checked == true)
                {
                    b.Fotocopiacarnetidentidad = 1;
                }
                else
                {
                    b.Fotocopiacarnetidentidad = 0;
                }
                if (chkfotografiasfondoazulingresar.Checked == true)
                {
                    b.Fotografiasfondoazul = 1;
                }
                else
                {
                    b.Fotografiasfondoazul = 0;
                }
                z = MetodosUniversidad.Ingresar(b);
                if (x > 0 && y > 0 && z > 0)
                {
                    MessageBox.Show("Estudiante ingresado!");
                }
                else
                {
                    MessageBox.Show("ERROR ingresar al estudiante");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void btnbuscarmod_Click(object sender, EventArgs e) // mostrar
        {
            lsbseleccionestudiantemod.Enabled = true;
            int sedemod = Convert.ToInt32(CBXsedemod.SelectedValue);
            int carreramod = Convert.ToInt32(CBXcarreramod.SelectedValue);
            lsbseleccionestudiantemod.DataSource=MetodosEstudiante.ObtenerEstudiantes(sedemod, carreramod);
            lsbseleccionestudiantemod.DisplayMember = "Nombre";
            lsbseleccionestudiantemod.ValueMember = "CarnetIdentidad";
        }
        private void lsbseleccionestudiantemod_MouseClick(object sender, MouseEventArgs e)
        {
            Estudiante a = new Estudiante();
            a = MetodosEstudiante.CargarEstudiante(Convert.ToInt32(lsbseleccionestudiantemod.SelectedValue));
            if (a != null)
            {
                try
                {
                    gbxestudiantemod.Enabled = true;
                    txtnombremod.Text = a.Nombre;
                    txtapellidopaternomod.Text = a.Apellidopaterno;
                    txtapellidomaternomod.Text = a.Apellidomaterno;
                    cbxsexomod.SelectedValue = a.Sexo; // selectedvalue(valuemember is 1 or 2)<-(1 or 2) // both match
                    txtcarnetidentidadmod.Text = a.Carnetidentidad.ToString();
                    DTPfechanacimientomod.Value = a.Fechanacimiento;
                    txtpaisnacimientomod.Text = a.Paisnacimiento;
                    txtdireccionmod.Text = a.Direccion;
                    txttelefonomod.Text = a.Telefono.ToString();
                    txtemailmod.Text = a.Email;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            Universidad b = new Universidad();
            b = MetodosUniversidad.Cargar(Convert.ToInt32(lsbseleccionestudiantemod.SelectedValue)); // Ci==Ce
            if (b != null)
            {
                try
                {
                    gbxuniversidadmod.Enabled = true;
                    gbxnotasmod.Enabled = true;
                    txtcodigoestudiantemod.Text = b.Codigoestudiante.ToString();
                    txtpasswordestudiantemod.Text = b.Passwordestudiante;
                    cbxuniversidadcarreramod.SelectedValue = b.Carrera;// selectedvalue(valuemember are ints)<-(ints) // both match
                    cbxuniversidadsedemod.SelectedValue = b.Sede; // selectedvalue(valuemember are ints)<-(ints) // both match
                    cbxpagomod.SelectedValue = b.Pago; // selectedvalue(valuemember are ints)<-(ints) // both match
                    cbxgestionmod.SelectedValue = b.Gestion; // selectedvalue(valuemember are ints)<-(ints) // both match
                    chklegalizadabachillermod.Checked = Convert.ToBoolean(b.Legalizadabachiller); // 1==true, 0==false
                    chkfotocopialibretamod.Checked = Convert.ToBoolean(b.Fotocopialibreta);
                    chkcertificadonacimientomod.Checked = Convert.ToBoolean(b.Certificadonacimiento);
                    chkfotocopiacarnetidentidadmod.Checked = Convert.ToBoolean(b.Fotocopiacarnetidentidad);
                    chkfotografiasfondoazulmod.Checked = Convert.ToBoolean(b.Fotografiasfondoazul);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        // Auto-update
        private void btnobtenermaterias_Click(object sender, EventArgs e) // selectedvalue una sola vez acepta
        {
            int carrera = Convert.ToInt32(cbxuniversidadcarreramod.SelectedValue);
            int semestre = Convert.ToInt32(cbxsemestremod.SelectedValue);
            cbxmateriamod.DataSource = MetodoMateria.ObtenerMaterias(carrera,semestre);
            cbxmateriamod.DisplayMember = "NombreMateria";
            cbxmateriamod.ValueMember = "IdMateria";
        }
        private void btnobtenernotas_Click(object sender, EventArgs e) // selectedvalue una sola vez acepta
        {
            Nota b = new Nota();
            int carnetidentidad = Convert.ToInt32(lsbseleccionestudiantemod.SelectedValue); // Ci==Ce
            int semestre = Convert.ToInt32(cbxsemestremod.SelectedValue);
            int materia = Convert.ToInt32(cbxmateriamod.SelectedValue);
            b = MetodosUniversidad.CargarNota(carnetidentidad, semestre, materia);
            if (b != null)
            {
                try
                {
                    cbxprimerparcialmod.SelectedValue = b.Primerparcial;
                    cbxsegundoparcialmod.SelectedValue = b.Segundoparcial;
                    cbxevaluacionproyectomod.SelectedValue = b.Evaluacionproyecto;
                    cbxexamenfinalmod.SelectedValue = b.Examenfinal;
                    cbxsegundoturnomod.SelectedValue = b.Segundoturno;
                    txtnotafinalmod.Text = b.Notafinal.ToString();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        private void btningresarnota_Click(object sender, EventArgs e) // selected value una vez solo acepta
        {
            try
            {
                Nota a = new Nota();
                a.Codigoestudiante = Convert.ToInt32(txtcarnetidentidadmod.Text);//
                a.Semestre = Convert.ToInt32(cbxsemestremod.SelectedValue);
                a.Materia = Convert.ToInt32(cbxmateriamod.SelectedValue);
                a.Primerparcial = Convert.ToInt32(cbxprimerparcialmod.SelectedValue);
                a.Segundoparcial = Convert.ToInt32(cbxsegundoparcialmod.SelectedValue);
                a.Evaluacionproyecto = Convert.ToInt32(cbxevaluacionproyectomod.SelectedValue);
                a.Examenfinal = Convert.ToInt32(cbxexamenfinalmod.SelectedValue);
                a.Segundoturno = Convert.ToInt32(cbxsegundoturnomod.SelectedValue);
                int x = MetodosUniversidad.ModificarNota(a);
                if (x > 0)
                {
                    MessageBox.Show("Nota ingresado/modificado exitosamente!");
                    txtnotafinalmod.Text = a.Notafinal.ToString();
                }
                else
                {
                    MessageBox.Show("ERROR!!!!");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }
        // Auto-update
        private void btnmod_Click(object sender, EventArgs e)
        {
            int x, y;
            try
            {
                Estudiante a = new Estudiante();
                a.Nombre = txtnombremod.Text;
                a.Apellidopaterno = txtapellidopaternomod.Text;
                a.Apellidomaterno = txtapellidomaternomod.Text;
                a.Sexo = Convert.ToInt32(cbxsexomod.SelectedValue);
                a.Carnetidentidad = Convert.ToInt32(txtcarnetidentidadmod.Text); 
                a.Fechanacimiento = DTPfechanacimientomod.Value;
                a.Paisnacimiento = txtpaisnacimientomod.Text;
                a.Direccion = txtdireccionmod.Text;
                a.Telefono = Convert.ToInt32(txttelefonomod.Text);
                a.Email = txtemailmod.Text;
                x = MetodosEstudiante.Modificar(a);
                //
                Universidad b = new Universidad();
                b.Codigoestudiante=Convert.ToInt32(txtcarnetidentidadmod.Text);//
                b.Passwordestudiante = txtpasswordestudiantemod.Text;
                b.Carrera = Convert.ToInt32(cbxuniversidadcarreramod.SelectedValue);
                b.Sede=Convert.ToInt32(cbxuniversidadsedemod.SelectedValue);
                b.Pago = Convert.ToInt32(cbxpagomod.SelectedValue);
                b.Gestion = Convert.ToInt32(cbxgestionmod.SelectedValue);
                if (chklegalizadabachillermod.Checked == true)
                {
                    b.Legalizadabachiller = 1;
                }
                else
                {
                    b.Legalizadabachiller = 0;
                }
                if (chkfotocopialibretamod.Checked == true)
                {
                    b.Fotocopialibreta = 1;
                }
                else
                {
                    b.Fotocopialibreta = 0;
                }
                if (chkcertificadonacimientomod.Checked == true)
                {
                    b.Certificadonacimiento = 1;
                }
                else
                {
                    b.Certificadonacimiento = 0;
                }
                if (chkfotocopiacarnetidentidadmod.Checked == true)
                {
                    b.Fotocopiacarnetidentidad = 1;
                }
                else
                {
                    b.Fotocopiacarnetidentidad = 0;
                }
                if (chkfotografiasfondoazulmod.Checked == true)
                {
                    b.Fotografiasfondoazul = 1;
                }
                else
                {
                    b.Fotografiasfondoazul = 0;
                }
                y = MetodosUniversidad.Modificar(b);
                if (x > 0 && y > 0)
                {
                    MessageBox.Show("Dato estudiante y/o dato universidad modificado con EXITO!!!!");
                }
                else
                {
                    MessageBox.Show("ERROR!!!!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            btnbuscarmod_Click(sender,e);
        }

        private void btnbuscardel_Click(object sender, EventArgs e)
        {
            lsbseleccionestudiantedel.Enabled = true;
            btndel.Enabled = true;
            int sede = Convert.ToInt32(CBXsededel.SelectedValue);
            int carrera = Convert.ToInt32(CBXcarreradel.SelectedValue);
            lsbseleccionestudiantedel.DataSource = MetodosEstudiante.ObtenerEstudiantes(sede, carrera);
            lsbseleccionestudiantedel.DisplayMember = "Nombre";
            lsbseleccionestudiantedel.ValueMember = "CarnetIdentidad"; 
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar al estudiante?", "UNIFRANZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int x = MetodosEstudiante.Eliminar(Convert.ToInt32(lsbseleccionestudiantedel.SelectedValue));
                if (x > 0)
                {
                    MessageBox.Show("Estudiante Eliminado Correctamente", "UNIFRANZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else //x==0
                {
                    MessageBox.Show("Error al Eliminar", "UNIFRANZ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Eliminacion Cancelada", "UNIFRANZ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            btnbuscardel_Click(sender, e);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmBienvenida f1 = new FrmBienvenida();
            f1.Show();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPreAdmin f1 = new FrmPreAdmin();
            f1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdminIngresar_Click(object sender, EventArgs e)
        {
            string login = txtAdminLogin.Text;
            string password = txtAdminPassword.Text;
            Administrador a = new Administrador();
            a.Login = login;
            a.Password = password;
            int x = MetodoAdministrador.Ingresar(a);
            if (x > 0)
            {
                MessageBox.Show("Administrador ingresado con EXITO!!!!");
            }
        }

        private void btnRefreshAdminMod_Click(object sender, EventArgs e)
        {
            lsbSeleccioneAdminMod.Enabled = true; 
            lsbSeleccioneAdminMod.DataSource = MetodoAdministrador.ObtenerAdministradores();
            lsbSeleccioneAdminMod.DisplayMember = "Login";
            lsbSeleccioneAdminMod.ValueMember = "Login";            
        }

        private void lsbSeleccioneAdminMod_MouseClick(object sender, MouseEventArgs e)
        {
            Administrador a = new Administrador();
            a = MetodoAdministrador.CargarAdministrador(lsbSeleccioneAdminMod.SelectedValue.ToString());
            if (a != null)
            {
                try
                {
                    gbxModificarAdministrador.Enabled = true;
                    txtLoginAdminMod.Text = a.Login;
                    txtPasswordAdminMod.Text = a.Password;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnModAdmin_Click(object sender, EventArgs e)
        {
            Administrador a = new Administrador();
            a.Login = txtLoginAdminMod.Text;
            a.Password = txtPasswordAdminMod.Text;
            int x = MetodoAdministrador.Modificar(a);
            if (x>0)
            {
                MessageBox.Show("Datos Administrador modificado con EXITO!!!!");
            }
            btnRefreshAdminMod_Click(sender, e);
        }

        private void btnRefreshAdminDel_Click(object sender, EventArgs e)
        {
            lsbSeleccionAdminDel.Enabled = true;
            btnDelAdmin.Enabled = true;
            lsbSeleccionAdminDel.DataSource = MetodoAdministrador.ObtenerAdministradores();
            lsbSeleccionAdminDel.DisplayMember = "Login";
            lsbSeleccionAdminDel.ValueMember = "Login";
        }

        private void btnDelAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta seguro que desea eliminar al administrador?", "UNIFRANZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int x = MetodoAdministrador.Eliminar(lsbSeleccionAdminDel.SelectedValue.ToString());
                    if (x > 0)
                    {
                        MessageBox.Show("Administrador Eliminado Correctamente", "UNIFRANZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else //x==0
                    {
                        MessageBox.Show("Error al Eliminar", "UNIFRANZ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Eliminacion Cancelada", "UNIFRANZ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error al Eliminar", "UNIFRANZ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnRefreshAdminDel_Click(sender, e);
        }

        private void pcbBtnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPreAdmin f1 = new FrmPreAdmin();
            f1.Show();
        }
    }
}
