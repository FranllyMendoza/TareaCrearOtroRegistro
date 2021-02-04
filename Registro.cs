﻿using CrearOtroRegistro.DAL;
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
            textBoxNombres.Text = string.Empty;
            textBoxAlias.Text = string.Empty;
            textBoxClaveConfirm.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            errorProvider1.Clear();
            dateTimePicker1.CustomFormat = " ";
            textBoxClave.Clear();
            checkBoxActivo.Checked = false;
            comboBoxRol.Text = "Seleccionar";
        }

        private void LlenaCampo(Usuarios usuarios)
        {
            idNumerico.Value = usuarios.UsuarioId;
            textBoxNombres.Text = usuarios.Nombres;
            textBoxEmail.Text = usuarios.Email;
            textBoxAlias.Text = usuarios.Alias;
            comboBoxRol.Text = usuarios.DescripcionRol;
            textBoxClave.Text = usuarios.Clave;
            dateTimePicker1.Value = usuarios.FechaIngreso;
            checkBoxActivo.Checked = usuarios.Activo;
            textBoxClaveConfirm.Text = usuarios.Clave;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = (int)idNumerico.Value;
            usuarios.Clave = textBoxClave.Text;
            usuarios.Email = textBoxEmail.Text;
            usuarios.Nombres = textBoxNombres.Text;
            usuarios.FechaIngreso = dateTimePicker1.Value;
            usuarios.Alias = textBoxAlias.Text;
            usuarios.DescripcionRol = comboBoxRol.Text;
            usuarios.Activo = checkBoxActivo.Checked;

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
            if (textBoxNombres.Text == string.Empty)
            {
                errorProvider1.SetError(textBoxNombres, "El campo nombre no puede estar vacio");
                textBoxNombres.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                errorProvider1.SetError(textBoxEmail, "El Email no puede estar vacio");
                textBoxEmail.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxAlias.Text))
            {
                errorProvider1.SetError(textBoxAlias, "El campo Alias no puede estar vacio");
                textBoxAlias.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(comboBoxRol.Text))
            {
                errorProvider1.SetError(comboBoxRol, "Debe agregar un rol especifico");
                comboBoxRol.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxClave.Text))
            {
                errorProvider1.SetError(textBoxClave, "Debe asignar una clave a su usuario");
                textBoxClave.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(textBoxClaveConfirm.Text))
            {
                errorProvider1.SetError(textBoxClaveConfirm, "Debe confirmar la clave");
                textBoxClaveConfirm.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                errorProvider1.SetError(dateTimePicker1, "Debe agregar una fecha de registro");
                dateTimePicker1.Focus();
                paso = false;
            }
            if (textBoxClave.Text != textBoxClaveConfirm.Text && textBoxClaveConfirm.Text != textBoxClave.Text)
            {
                MessageBox.Show("La contraseña debe ser igual para ambos casos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paso = false;
            }
            return paso;
        }


        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void idNumerico_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Editar_Click_1(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            bool paso = false;

            if (!Validar())
                return;
            usuarios = LlenaClase();

            if ((int)idNumerico.Value == 0)
                paso = UsuariosBLL.Guardar(usuarios);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar... El usuario no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Desea guardar los cambios?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        Limpiar();
                    }
                    else if (result == DialogResult.No)
                    {
                        Limpiar();

                        return;
                    }
                }
                paso = UsuariosBLL.Modificar(usuarios);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminar_Click_1(object sender, EventArgs e)
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

        private void Guardar_Click_1(object sender, EventArgs e)
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

        private void Nuevo_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscar_Click_1(object sender, EventArgs e)
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

        private void textBoxClave_TextChanged_1(object sender, EventArgs e)
        {
              
        }

        private void textBoxClaveConfirm_TextChanged_1(object sender, EventArgs e)
        {
             
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd / MM / yyyy";
        }
    }
}
