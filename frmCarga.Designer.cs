namespace pryRodriguezIEFI
{
    partial class frmCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarga));
            this.lblTrebol = new System.Windows.Forms.Label();
            this.lblCodPaises = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mcrNuevoPais = new System.Windows.Forms.GroupBox();
            this.lblAgregarPais = new System.Windows.Forms.Label();
            this.txtCodPais = new System.Windows.Forms.TextBox();
            this.txtAgregarPais = new System.Windows.Forms.TextBox();
            this.mcrNuevoPais.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrebol
            // 
            this.lblTrebol.AutoSize = true;
            this.lblTrebol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrebol.ForeColor = System.Drawing.Color.Blue;
            this.lblTrebol.Location = new System.Drawing.Point(165, 9);
            this.lblTrebol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrebol.Name = "lblTrebol";
            this.lblTrebol.Size = new System.Drawing.Size(244, 39);
            this.lblTrebol.TabIndex = 2;
            this.lblTrebol.Text = "Club el Trebol";
            // 
            // lblCodPaises
            // 
            this.lblCodPaises.AutoSize = true;
            this.lblCodPaises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPaises.ForeColor = System.Drawing.Color.Red;
            this.lblCodPaises.Location = new System.Drawing.Point(7, 51);
            this.lblCodPaises.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodPaises.Name = "lblCodPaises";
            this.lblCodPaises.Size = new System.Drawing.Size(141, 20);
            this.lblCodPaises.TabIndex = 3;
            this.lblCodPaises.Text = "Codigo del País";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCargar.Location = new System.Drawing.Point(436, 127);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(125, 41);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Maroon;
            this.btnSalir.Location = new System.Drawing.Point(436, 231);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 46);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mcrNuevoPais
            // 
            this.mcrNuevoPais.Controls.Add(this.txtAgregarPais);
            this.mcrNuevoPais.Controls.Add(this.txtCodPais);
            this.mcrNuevoPais.Controls.Add(this.lblAgregarPais);
            this.mcrNuevoPais.Controls.Add(this.lblCodPaises);
            this.mcrNuevoPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcrNuevoPais.ForeColor = System.Drawing.Color.Blue;
            this.mcrNuevoPais.Location = new System.Drawing.Point(41, 97);
            this.mcrNuevoPais.Name = "mcrNuevoPais";
            this.mcrNuevoPais.Size = new System.Drawing.Size(378, 199);
            this.mcrNuevoPais.TabIndex = 8;
            this.mcrNuevoPais.TabStop = false;
            this.mcrNuevoPais.Text = "Agregar Nuevo País";
            // 
            // lblAgregarPais
            // 
            this.lblAgregarPais.AutoSize = true;
            this.lblAgregarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarPais.ForeColor = System.Drawing.Color.Red;
            this.lblAgregarPais.Location = new System.Drawing.Point(7, 134);
            this.lblAgregarPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarPais.Name = "lblAgregarPais";
            this.lblAgregarPais.Size = new System.Drawing.Size(148, 20);
            this.lblAgregarPais.TabIndex = 4;
            this.lblAgregarPais.Text = "Nombre del País";
            // 
            // txtCodPais
            // 
            this.txtCodPais.Location = new System.Drawing.Point(175, 48);
            this.txtCodPais.Name = "txtCodPais";
            this.txtCodPais.Size = new System.Drawing.Size(137, 27);
            this.txtCodPais.TabIndex = 5;
            this.txtCodPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodPais_KeyPress);
            // 
            // txtAgregarPais
            // 
            this.txtAgregarPais.Location = new System.Drawing.Point(175, 131);
            this.txtAgregarPais.Name = "txtAgregarPais";
            this.txtAgregarPais.Size = new System.Drawing.Size(137, 27);
            this.txtAgregarPais.TabIndex = 6;
            this.txtAgregarPais.TextChanged += new System.EventHandler(this.txtAgregarPais_TextChanged);
            this.txtAgregarPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgregarPais_KeyPress);
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(585, 320);
            this.Controls.Add(this.mcrNuevoPais);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblTrebol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCarga";
            this.Text = "Carga de Paises";
            this.Load += new System.EventHandler(this.frmCarga_Load);
            this.mcrNuevoPais.ResumeLayout(false);
            this.mcrNuevoPais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrebol;
        private System.Windows.Forms.Label lblCodPaises;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox mcrNuevoPais;
        private System.Windows.Forms.TextBox txtAgregarPais;
        private System.Windows.Forms.TextBox txtCodPais;
        private System.Windows.Forms.Label lblAgregarPais;
    }
}