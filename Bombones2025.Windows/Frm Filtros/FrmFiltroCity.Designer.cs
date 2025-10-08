namespace Bombones2025.Windows.Frm_Filtros
{
    partial class FrmFiltroCity
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
            CboProvEstados = new ComboBox();
            label3 = new Label();
            CboPaises = new ComboBox();
            label2 = new Label();
            BtnCancelar = new Button();
            BtnOK = new Button();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            CboCiudad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // CboProvEstados
            // 
            CboProvEstados.DropDownStyle = ComboBoxStyle.DropDownList;
            CboProvEstados.FormattingEnabled = true;
            CboProvEstados.Location = new Point(118, 82);
            CboProvEstados.Name = "CboProvEstados";
            CboProvEstados.Size = new Size(342, 23);
            CboProvEstados.TabIndex = 1;
            CboProvEstados.SelectedIndexChanged += CboProvEstados_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 85);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 27;
            label3.Text = "Prov/Estado:";
            // 
            // CboPaises
            // 
            CboPaises.DropDownStyle = ComboBoxStyle.DropDownList;
            CboPaises.FormattingEnabled = true;
            CboPaises.Location = new Point(118, 39);
            CboPaises.Name = "CboPaises";
            CboPaises.Size = new Size(342, 23);
            CboPaises.TabIndex = 0;
            CboPaises.SelectedIndexChanged += CboPaises_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 40);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 28;
            label2.Text = "País:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Image = Properties.Resources.Cancelar;
            BtnCancelar.Location = new Point(385, 176);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 52);
            BtnCancelar.TabIndex = 4;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click_1;
            // 
            // BtnOK
            // 
            BtnOK.Image = Properties.Resources.Aceptar1;
            BtnOK.Location = new Point(41, 176);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(75, 52);
            BtnOK.TabIndex = 3;
            BtnOK.Text = "OK";
            BtnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 126);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 27;
            label1.Text = "Ciudad:";
            // 
            // CboCiudad
            // 
            CboCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
            CboCiudad.FormattingEnabled = true;
            CboCiudad.Location = new Point(118, 123);
            CboCiudad.Name = "CboCiudad";
            CboCiudad.Size = new Size(342, 23);
            CboCiudad.TabIndex = 2;
            CboCiudad.SelectedIndexChanged += CboCiudad_SelectedIndexChanged;
            // 
            // FrmFiltroCity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 241);
            Controls.Add(CboCiudad);
            Controls.Add(label1);
            Controls.Add(CboProvEstados);
            Controls.Add(label3);
            Controls.Add(CboPaises);
            Controls.Add(label2);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOK);
            Name = "FrmFiltroCity";
            Text = "FrmFiltroCity";
            Load += FrmFiltroCity_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CboProvEstados;
        private Label label3;
        private ComboBox CboPaises;
        private Label label2;
        private Button BtnCancelar;
        private Button BtnOK;
        private ErrorProvider errorProvider1;
        private ComboBox CboCiudad;
        private Label label1;
    }
}