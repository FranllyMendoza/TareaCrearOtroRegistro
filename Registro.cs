using CrearOtroRegistro.DAL;
using CrearOtroRegistro.BLL;
using CrearOtroRegistro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CrearOtroRegistro
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            idNumerico.Value = 0;
            NombrestextBox.Clear();
            AliastextBox.Clear();
            ClaveConfirmtextBox.Clear();
            EmailtextBox.Clear();
            errorProvider1.Clear();
            FechadateTimePicker1.CustomFormat = " ";
            ClavetextBox.Clear();
            ActivocheckBox.Checked = false;
            RolcomboBox.Text = "Seleccionar";
        }

        private void LlenaCampo(Usuarios usuarios)
        {
            idNumerico.Value = usuarios.UsuarioId;
            NombrestextBox.Text = usuarios.Nombres;
            EmailtextBox.Text = usuarios.Email;
            AliastextBox.Text = usuarios.Alias;
            RolcomboBox.Text = usuarios.DescripcionRol;
            ClavetextBox.Text = usuarios.Clave;
            FechadateTimePicker1.Value = usuarios.FechaIngreso;
            ActivocheckBox.Checked = usuarios.Activo;
            ClaveConfirmtextBox.Text = usuarios.Clave;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = (int)idNumerico.Value;
            usuarios.Clave = ClavetextBox.Text;
            usuarios.Email = EmailtextBox.Text;
            usuarios.Nombres = NombrestextBox.Text;
            usuarios.FechaIngreso = FechadateTimePicker1.Value;
            usuarios.Alias = AliastextBox.Text;
            usuarios.DescripcionRol = RolcomboBox.Text;
            usuarios.Activo = ActivocheckBox.Checked;

            return usuarios;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuarios = UsuariosBLL.Buscar((int)idNumerico.Value);

            return (usuarios != null);
        }
        
        private bool Validar()
        {
            bool paso = true;
            if (NombrestextBox.Text == string.Empty)
            {
                errorProvider1.SetError(NombrestextBox, "El campo nombre no puede estar vacio");
                NombrestextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                errorProvider1.SetError(EmailtextBox, "El Email no puede estar vacio");
                EmailtextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(AliastextBox.Text))
            {
                errorProvider1.SetError(AliastextBox, "El campo Alias no puede estar vacio");
                AliastextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(RolcomboBox.Text))
            {
                errorProvider1.SetError(RolcomboBox, "Debe agregar un rol especifico");
                RolcomboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ClavetextBox.Text))
            {
                errorProvider1.SetError(ClavetextBox, "Debe asignar una clave a su usuario");
                ClavetextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ClaveConfirmtextBox.Text))
            {
                errorProvider1.SetError(ClaveConfirmtextBox, "Debe confirmar la clave");
                ClaveConfirmtextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(FechadateTimePicker1.Text))
            {
                errorProvider1.SetError(FechadateTimePicker1, "Debe agregar una fecha de registro");
                FechadateTimePicker1.Focus();
                paso = false;
            }
            if (ClavetextBox.Text != ClaveConfirmtextBox.Text)
            {
                errorProvider1.SetError(ClaveConfirmtextBox, "La contraseña debe ser igual para ambos casos!");
                paso = false;
            }
            return paso;
        }


       
        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            int id;
            int.TryParse(idNumerico.Text, out id);

            Limpiar();

            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider1.SetError(idNumerico, "No se puede eliminar ");
        }


        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            Usuarios usuarios;
            bool paso = false;

            if (!Validar())
                return;

            usuarios = LlenaClase();

            if (!(UsuariosBLL.Existe((int)idNumerico.Value)))
            {
                if (!ExisteEnLaBaseDeDatos())
                    paso = UsuariosBLL.Guardar(usuarios);
                else
                {
                    MessageBox.Show("Este usuario ya existe!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar, este usuario ya existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }



        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            int id;
            Usuarios usuario = new Usuarios();
            int.TryParse(idNumerico.Text, out id);

            Limpiar();

            usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {
                MessageBox.Show("Persona Encotrada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCampo(usuario);
            }
            else
            {
                MessageBox.Show("Persona no Encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FechadateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            FechadateTimePicker1.CustomFormat = "dd / MM / yyyy";
        }



    }


}
