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
            this.lblTrebol = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.cboNombre = new System.Windows.Forms.ComboBox();
            this.cboApellido = new System.Windows.Forms.ComboBox();
            this.cboEdad = new System.Windows.Forms.ComboBox();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mcrSexo = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbPorcentaje = new System.Windows.Forms.MaskedTextBox();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.mtbIngreso = new System.Windows.Forms.MaskedTextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.mcrRegistro.SuspendLayout();
            this.mcrSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcrRegistro
            // 
            this.mcrRegistro.Controls.Add(this.cboPais);
            this.mcrRegistro.Controls.Add(this.lblPais);
            this.mcrRegistro.Controls.Add(this.mtbIngreso);
            this.mcrRegistro.Controls.Add(this.lblIngreso);
            this.mcrRegistro.Controls.Add(this.mtbPorcentaje);
            this.mcrRegistro.Controls.Add(this.label1);
            this.mcrRegistro.Controls.Add(this.mcrSexo);
            this.mcrRegistro.Controls.Add(this.cboEdad);
            this.mcrRegistro.Controls.Add(this.cboApellido);
            this.mcrRegistro.Controls.Add(this.cboNombre);
            this.mcrRegistro.Controls.Add(this.lblEdad);
            this.mcrRegistro.Controls.Add(this.lblApellido);
            this.mcrRegistro.Controls.Add(this.txtNombre);
            this.mcrRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcrRegistro.ForeColor = System.Drawing.Color.Maroon;
            this.mcrRegistro.Location = new System.Drawing.Point(12, 67);
            this.mcrRegistro.Name = "mcrRegistro";
            this.mcrRegistro.Size = new System.Drawing.Size(310, 472);
            this.mcrRegistro.TabIndex = 0;
            this.mcrRegistro.TabStop = false;
            this.mcrRegistro.Text = "Registro de usuario";
            // 
            // lblTrebol
            // 
            this.lblTrebol.AutoSize = true;
            this.lblTrebol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrebol.ForeColor = System.Drawing.Color.Blue;
            this.lblTrebol.Location = new System.Drawing.Point(225, 9);
            this.lblTrebol.Name = "lblTrebol";
            this.lblTrebol.Size = new System.Drawing.Size(196, 31);
            this.lblTrebol.TabIndex = 1;
            this.lblTrebol.Text = "Club el Trebol";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(7, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(62, 18);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(7, 102);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 18);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(7, 161);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(42, 18);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // cboNombre
            // 
            this.cboNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombre.FormattingEnabled = true;
            this.cboNombre.Location = new System.Drawing.Point(109, 40);
            this.cboNombre.Name = "cboNombre";
            this.cboNombre.Size = new System.Drawing.Size(136, 26);
            this.cboNombre.TabIndex = 4;
            // 
            // cboApellido
            // 
            this.cboApellido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApellido.FormattingEnabled = true;
            this.cboApellido.Location = new System.Drawing.Point(109, 94);
            this.cboApellido.Name = "cboApellido";
            this.cboApellido.Size = new System.Drawing.Size(136, 26);
            this.cboApellido.TabIndex = 5;
            // 
            // cboEdad
            // 
            this.cboEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdad.FormattingEnabled = true;
            this.cboEdad.Location = new System.Drawing.Point(109, 153);
            this.cboEdad.Name = "cboEdad";
            this.cboEdad.Size = new System.Drawing.Size(136, 26);
            this.cboEdad.TabIndex = 6;
            // 
            // btnRegistar
            // 
            this.btnRegistar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRegistar.Enabled = false;
            this.btnRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRegistar.Location = new System.Drawing.Point(328, 169);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(93, 40);
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
            this.btnSalir.Location = new System.Drawing.Point(328, 326);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 36);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mcrSexo
            // 
            this.mcrSexo.Controls.Add(this.rbFemenino);
            this.mcrSexo.Controls.Add(this.rbMasculino);
            this.mcrSexo.ForeColor = System.Drawing.Color.Maroon;
            this.mcrSexo.Location = new System.Drawing.Point(10, 393);
            this.mcrSexo.Name = "mcrSexo";
            this.mcrSexo.Size = new System.Drawing.Size(276, 69);
            this.mcrSexo.TabIndex = 7;
            this.mcrSexo.TabStop = false;
            this.mcrSexo.Text = "Sexo";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(7, 36);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(94, 22);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(134, 36);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(92, 22);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Porcentaje";
            // 
            // mtbPorcentaje
            // 
            this.mtbPorcentaje.Location = new System.Drawing.Point(109, 334);
            this.mtbPorcentaje.Mask = "999";
            this.mtbPorcentaje.Name = "mtbPorcentaje";
            this.mtbPorcentaje.Size = new System.Drawing.Size(101, 24);
            this.mtbPorcentaje.TabIndex = 9;
            this.mtbPorcentaje.ValidatingType = typeof(int);
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(7, 277);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(57, 18);
            this.lblIngreso.TabIndex = 10;
            this.lblIngreso.Text = "Ingreso";
            // 
            // mtbIngreso
            // 
            this.mtbIngreso.Location = new System.Drawing.Point(109, 271);
            this.mtbIngreso.Mask = "9999";
            this.mtbIngreso.Name = "mtbIngreso";
            this.mtbIngreso.Size = new System.Drawing.Size(101, 24);
            this.mtbIngreso.TabIndex = 11;
            this.mtbIngreso.ValidatingType = typeof(int);
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(7, 216);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(37, 18);
            this.lblPais.TabIndex = 12;
            this.lblPais.Text = "Pais";
            // 
            // cboPais
            // 
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(109, 216);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(136, 26);
            this.cboPais.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLimpiar.Location = new System.Drawing.Point(328, 249);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 36);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(632, 541);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.lblTrebol);
            this.Controls.Add(this.mcrRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.MaskedTextBox mtbPorcentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox mcrSexo;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.ComboBox cboEdad;
        private System.Windows.Forms.ComboBox cboApellido;
        private System.Windows.Forms.ComboBox cboNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label lblTrebol;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MaskedTextBox mtbIngreso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

