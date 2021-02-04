
namespace CrearOtroRegistro
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.idNumerico = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.FechadateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxClaveConfirm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.Button();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.textBoxAlias = new System.Windows.Forms.TextBox();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.idNumerico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idNumerico
            // 
            this.idNumerico.Location = new System.Drawing.Point(96, 73);
            this.idNumerico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idNumerico.Name = "idNumerico";
            this.idNumerico.Size = new System.Drawing.Size(64, 23);
            this.idNumerico.TabIndex = 44;
            
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Fecha";
            // 
            // FechadateTimePicker1
            // 
            this.FechadateTimePicker1.CustomFormat = " ";
            this.FechadateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker1.Location = new System.Drawing.Point(365, 137);
            this.FechadateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechadateTimePicker1.Name = "FechadateTimePicker1";
            this.FechadateTimePicker1.Size = new System.Drawing.Size(128, 23);
            this.FechadateTimePicker1.TabIndex = 42;
            this.FechadateTimePicker1.ValueChanged += new System.EventHandler(this.FechadateTimePicker1_ValueChanged_1);
            // 
            // textBoxClaveConfirm
            // 
            this.textBoxClaveConfirm.Location = new System.Drawing.Point(365, 218);
            this.textBoxClaveConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClaveConfirm.Name = "textBoxClaveConfirm";
            this.textBoxClaveConfirm.PasswordChar = '*';
            this.textBoxClaveConfirm.Size = new System.Drawing.Size(151, 23);
            this.textBoxClaveConfirm.TabIndex = 41;
            
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Confirmar Clave";
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminar.Location = new System.Drawing.Point(418, 272);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 65);
            this.Eliminar.TabIndex = 39;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.EliminarButton_Click_1);
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Items.AddRange(new object[] {
            "Adiministrador",
            "Estudiante",
            "Maestro",
            "Ciudadano",
            "Conserje",
            "Pasante"});
            this.comboBoxRol.Location = new System.Drawing.Point(519, 137);
            this.comboBoxRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(119, 23);
            this.comboBoxRol.TabIndex = 38;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(364, 175);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(274, 23);
            this.textBoxEmail.TabIndex = 37;
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Buscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.Location = new System.Drawing.Point(166, 63);
            this.Buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(37, 33);
            this.Buscar.TabIndex = 36;
            this.Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.BuscarButton_Click_1);
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(96, 218);
            this.textBoxClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(128, 23);
            this.textBoxClave.TabIndex = 35;
            
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(96, 175);
            this.textBoxNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(225, 23);
            this.textBoxNombres.TabIndex = 34;
            // 
            // textBoxAlias
            // 
            this.textBoxAlias.Location = new System.Drawing.Point(96, 134);
            this.textBoxAlias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAlias.Name = "textBoxAlias";
            this.textBoxAlias.Size = new System.Drawing.Size(134, 23);
            this.textBoxAlias.TabIndex = 33;
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Location = new System.Drawing.Point(578, 97);
            this.checkBoxActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(60, 19);
            this.checkBoxActivo.TabIndex = 32;
            this.checkBoxActivo.Text = "Activo";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Roll";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Clave ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Alias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Usuario ID";
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Guardar.Image")));
            this.Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardar.Location = new System.Drawing.Point(276, 272);
            this.Guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(78, 65);
            this.Guardar.TabIndex = 24;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.GuardarButton_Click_1);
            // 
            // Nuevo
            // 
            this.Nuevo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Nuevo.Image")));
            this.Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevo.Location = new System.Drawing.Point(138, 272);
            this.Nuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(74, 65);
            this.Nuevo.TabIndex = 23;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.NuevoButton_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 354);
            this.Controls.Add(this.idNumerico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FechadateTimePicker1);
            this.Controls.Add(this.textBoxClaveConfirm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBoxNombres);
            this.Controls.Add(this.textBoxAlias);
            this.Controls.Add(this.checkBoxActivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevo);
            this.Name = "Registro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.idNumerico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.NumericUpDown idNumerico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker1;
        private System.Windows.Forms.TextBox textBoxClaveConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.ComboBox comboBoxRol;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.TextBox textBoxAlias;
        private System.Windows.Forms.CheckBox checkBoxActivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}