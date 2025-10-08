namespace Bombones2025.Windows
{
    partial class FrmClientesAE
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            BtnCancelar = new Button();
            BtnOK = new Button();
            label3 = new Label();
            CboProvEstados = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            label4 = new Label();
            cboPais = new ComboBox();
            label1 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            cboCiudad = new ComboBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label7 = new Label();
            txtMail = new TextBox();
            label8 = new Label();
            rbSiAC = new RadioButton();
            rbNoAC = new RadioButton();
            label9 = new Label();
            txtSaldo = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 30);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 21;
            label2.Text = "Nombre:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Image = Properties.Resources.Cancelar;
            BtnCancelar.Location = new Point(416, 390);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 52);
            BtnCancelar.TabIndex = 12;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnOK
            // 
            BtnOK.Image = Properties.Resources.Aceptar1;
            BtnOK.Location = new Point(77, 390);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(75, 52);
            BtnOK.TabIndex = 11;
            BtnOK.Text = "OK";
            BtnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 272);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 21;
            label3.Text = "Prov/Estado:";
            // 
            // CboProvEstados
            // 
            CboProvEstados.DropDownStyle = ComboBoxStyle.DropDownList;
            CboProvEstados.FormattingEnabled = true;
            CboProvEstados.Location = new Point(153, 269);
            CboProvEstados.Name = "CboProvEstados";
            CboProvEstados.Size = new Size(342, 23);
            CboProvEstados.TabIndex = 8;
            CboProvEstados.SelectedIndexChanged += CboProvEstados_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 231);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 21;
            label4.Text = "País:";
            // 
            // cboPais
            // 
            cboPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPais.FormattingEnabled = true;
            cboPais.Location = new Point(151, 228);
            cboPais.Name = "cboPais";
            cboPais.Size = new Size(342, 23);
            cboPais.TabIndex = 7;
            cboPais.SelectedIndexChanged += cboPais_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 350);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 17;
            label1.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(151, 347);
            txtDireccion.MaxLength = 100;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(340, 23);
            txtDireccion.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 312);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 21;
            label5.Text = "Ciudad:";
            // 
            // cboCiudad
            // 
            cboCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCiudad.FormattingEnabled = true;
            cboCiudad.Location = new Point(151, 309);
            cboCiudad.Name = "cboCiudad";
            cboCiudad.Size = new Size(342, 23);
            cboCiudad.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 27);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(340, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(151, 56);
            txtApellido.MaxLength = 100;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(340, 23);
            txtApellido.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 59);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 21;
            label6.Text = "Apellido:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(151, 85);
            txtTelefono.MaxLength = 100;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(340, 23);
            txtTelefono.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 88);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 21;
            label7.Text = "Teléfono:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(153, 114);
            txtMail.MaxLength = 100;
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(340, 23);
            txtMail.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 117);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 21;
            label8.Text = "Mail:";
            // 
            // rbSiAC
            // 
            rbSiAC.AutoSize = true;
            rbSiAC.Location = new Point(151, 152);
            rbSiAC.Name = "rbSiAC";
            rbSiAC.Size = new Size(34, 19);
            rbSiAC.TabIndex = 4;
            rbSiAC.TabStop = true;
            rbSiAC.Text = "Si";
            rbSiAC.UseVisualStyleBackColor = true;
            // 
            // rbNoAC
            // 
            rbNoAC.AutoSize = true;
            rbNoAC.Location = new Point(191, 152);
            rbNoAC.Name = "rbNoAC";
            rbNoAC.Size = new Size(41, 19);
            rbNoAC.TabIndex = 5;
            rbNoAC.TabStop = true;
            rbNoAC.Text = "No";
            rbNoAC.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(77, 152);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 21;
            label9.Text = "Aut C.C";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(153, 182);
            txtSaldo.MaxLength = 100;
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(340, 23);
            txtSaldo.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(77, 185);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 21;
            label10.Text = "Saldo:";
            // 
            // FrmClientesAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 471);
            Controls.Add(rbNoAC);
            Controls.Add(rbSiAC);
            Controls.Add(cboPais);
            Controls.Add(label4);
            Controls.Add(cboCiudad);
            Controls.Add(label5);
            Controls.Add(CboProvEstados);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(BtnCancelar);
            Controls.Add(txtSaldo);
            Controls.Add(BtnOK);
            Controls.Add(txtMail);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtDireccion);
            Controls.Add(label1);
            MinimumSize = new Size(581, 280);
            Name = "FrmClientesAE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClientesAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button BtnCancelar;
        private Button BtnOK;
        private Label label3;
        private ComboBox CboProvEstados;
        private ErrorProvider errorProvider1;
        private ComboBox cboPais;
        private Label label4;
        private ComboBox cboCiudad;
        private Label label5;
        private TextBox txtDireccion;
        private Label label1;
        private RadioButton rbNoAC;
        private RadioButton rbSiAC;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtMail;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label9;
        private Label label10;
        private TextBox txtSaldo;
    }
}