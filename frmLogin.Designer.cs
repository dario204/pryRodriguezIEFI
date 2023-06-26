namespace pryRodriguezIEFI
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.mcrRegistro = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboLugarNacimiento = new System.Windows.Forms.ComboBox();
            this.lblLugarNacimiento = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.mcrSexo = new System.Windows.Forms.GroupBox();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTrebol = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.Button();
            this.mcrRegistro.SuspendLayout();
            this.mcrSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcrRegistro
            // 
            this.mcrRegistro.Controls.Add(this.txtPuntaje);
            this.mcrRegistro.Controls.Add(this.txtEdad);
            this.mcrRegistro.Controls.Add(this.txtApellido);
            this.mcrRegistro.Controls.Add(this.txtNombre);
            this.mcrRegistro.Controls.Add(this.cboLugarNacimiento);
            this.mcrRegistro.Controls.Add(this.lblLugarNacimiento);
            this.mcrRegistro.Controls.Add(this.lblPuntaje);
            this.mcrRegistro.Controls.Add(this.mcrSexo);
            this.mcrRegistro.Controls.Add(this.lblEdad);
            this.mcrRegistro.Controls.Add(this.lblApellido);
            this.mcrRegistro.Controls.Add(this.lblNombre);
            this.mcrRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcrRegistro.ForeColor = System.Drawing.Color.Maroon;
            this.mcrRegistro.Location = new System.Drawing.Point(16, 82);
            this.mcrRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.mcrRegistro.Name = "mcrRegistro";
            this.mcrRegistro.Padding = new System.Windows.Forms.Padding(4);
            this.mcrRegistro.Size = new System.Drawing.Size(391, 488);
            this.mcrRegistro.TabIndex = 0;
            this.mcrRegistro.TabStop = false;
            this.mcrRegistro.Text = "Registro de usuario";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(201, 126);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(165, 29);
            this.txtApellido.TabIndex = 15;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(201, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 29);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cboLugarNacimiento
            // 
            this.cboLugarNacimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLugarNacimiento.Enabled = false;
            this.cboLugarNacimiento.FormattingEnabled = true;
            this.cboLugarNacimiento.Items.AddRange(new object[] {
            "jj"});
            this.cboLugarNacimiento.Location = new System.Drawing.Point(201, 263);
            this.cboLugarNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.cboLugarNacimiento.Name = "cboLugarNacimiento";
            this.cboLugarNacimiento.Size = new System.Drawing.Size(165, 32);
            this.cboLugarNacimiento.TabIndex = 13;
            this.cboLugarNacimiento.SelectedIndexChanged += new System.EventHandler(this.cboLugarNacimiento_SelectedIndexChanged);
            // 
            // lblLugarNacimiento
            // 
            this.lblLugarNacimiento.AutoSize = true;
            this.lblLugarNacimiento.Location = new System.Drawing.Point(9, 266);
            this.lblLugarNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLugarNacimiento.Name = "lblLugarNacimiento";
            this.lblLugarNacimiento.Size = new System.Drawing.Size(185, 24);
            this.lblLugarNacimiento.TabIndex = 12;
            this.lblLugarNacimiento.Text = "Lugar de Nacimiento";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(9, 339);
            this.lblPuntaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(73, 24);
            this.lblPuntaje.TabIndex = 8;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // mcrSexo
            // 
            this.mcrSexo.Controls.Add(this.rbFemenino);
            this.mcrSexo.Controls.Add(this.rbMasculino);
            this.mcrSexo.ForeColor = System.Drawing.Color.Maroon;
            this.mcrSexo.Location = new System.Drawing.Point(13, 388);
            this.mcrSexo.Margin = new System.Windows.Forms.Padding(4);
            this.mcrSexo.Name = "mcrSexo";
            this.mcrSexo.Padding = new System.Windows.Forms.Padding(4);
            this.mcrSexo.Size = new System.Drawing.Size(368, 85);
            this.mcrSexo.TabIndex = 7;
            this.mcrSexo.TabStop = false;
            this.mcrSexo.Text = "Sexo";
            this.mcrSexo.Enter += new System.EventHandler(this.mcrSexo_Enter);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Enabled = false;
            this.rbFemenino.Location = new System.Drawing.Point(179, 44);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(4);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(118, 28);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            this.rbFemenino.CheckedChanged += new System.EventHandler(this.rbFemenino_CheckedChanged);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Enabled = false;
            this.rbMasculino.Location = new System.Drawing.Point(9, 44);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(4);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(117, 28);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(9, 198);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(55, 24);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(9, 126);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(79, 24);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 53);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTrebol
            // 
            this.lblTrebol.AutoSize = true;
            this.lblTrebol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrebol.ForeColor = System.Drawing.Color.Blue;
            this.lblTrebol.Location = new System.Drawing.Point(163, 9);
            this.lblTrebol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrebol.Name = "lblTrebol";
            this.lblTrebol.Size = new System.Drawing.Size(244, 39);
            this.lblTrebol.TabIndex = 1;
            this.lblTrebol.Text = "Club el Trebol";
            // 
            // btnRegistar
            // 
            this.btnRegistar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRegistar.Enabled = false;
            this.btnRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRegistar.Location = new System.Drawing.Point(420, 123);
            this.btnRegistar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(124, 49);
            this.btnRegistar.TabIndex = 2;
            this.btnRegistar.Text = "Registrar";
            this.btnRegistar.UseVisualStyleBackColor = false;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSalir.Location = new System.Drawing.Point(420, 341);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 44);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLimpiar.Location = new System.Drawing.Point(420, 236);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 44);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(201, 198);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(165, 29);
            this.txtEdad.TabIndex = 16;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Enabled = false;
            this.txtPuntaje.Location = new System.Drawing.Point(201, 339);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(165, 29);
            this.txtPuntaje.TabIndex = 17;
            this.txtPuntaje.TextChanged += new System.EventHandler(this.txtPuntaje_TextChanged);
            this.txtPuntaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuntaje_KeyPress);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtBuscar.Location = new System.Drawing.Point(420, 437);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(124, 44);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.UseVisualStyleBackColor = false;
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(572, 575);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.lblTrebol);
            this.Controls.Add(this.mcrRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.mcrRegistro.ResumeLayout(false);
            this.mcrRegistro.PerformLayout();
            this.mcrSexo.ResumeLayout(false);
            this.mcrSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mcrRegistro;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.GroupBox mcrSexo;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTrebol;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboLugarNacimiento;
        private System.Windows.Forms.Label lblLugarNacimiento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button txtBuscar;
    }
}

