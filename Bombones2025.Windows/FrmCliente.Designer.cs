
namespace Bombones2025.Windows
{
    partial class FrmCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            dgvDatos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colRazonSocial = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colTel = new DataGridViewTextBoxColumn();
            colDir = new DataGridViewTextBoxColumn();
            colCiudad = new DataGridViewTextBoxColumn();
            colAutorizacion = new DataGridViewTextBoxColumn();
            colSaldo = new DataGridViewTextBoxColumn();
            label3 = new Label();
            lblCant = new Label();
            TxtCantidadPaginas = new TextBox();
            CboPaginas = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            BtnUltimo = new Button();
            BtnSiguiente = new Button();
            BtnAnterior = new Button();
            BtnPrimero = new Button();
            TsbNuevo = new ToolStripButton();
            TsbBorrar = new ToolStripButton();
            TsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            TsbImprimir = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            TsbCerrar = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            TsbFiltrar = new ToolStripDropDownButton();
            textoToolStripMenuItem = new ToolStripMenuItem();
            paísToolStripMenuItem = new ToolStripMenuItem();
            provEstadoToolStripMenuItem = new ToolStripMenuItem();
            ciudadToolStripMenuItem = new ToolStripMenuItem();
            estadoCtaCteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 62);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvDatos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(lblCant);
            splitContainer1.Panel2.Controls.Add(TxtCantidadPaginas);
            splitContainer1.Panel2.Controls.Add(CboPaginas);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(BtnUltimo);
            splitContainer1.Panel2.Controls.Add(BtnSiguiente);
            splitContainer1.Panel2.Controls.Add(BtnAnterior);
            splitContainer1.Panel2.Controls.Add(BtnPrimero);
            splitContainer1.Size = new Size(1321, 555);
            splitContainer1.SplitterDistance = 444;
            splitContainer1.TabIndex = 5;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colId, colRazonSocial, colEmail, colTel, colDir, colCiudad, colAutorizacion, colSaldo });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(1321, 444);
            dgvDatos.TabIndex = 2;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colRazonSocial
            // 
            colRazonSocial.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRazonSocial.HeaderText = "Razón Social";
            colRazonSocial.Name = "colRazonSocial";
            colRazonSocial.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colTel
            // 
            colTel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTel.HeaderText = "Telefono";
            colTel.Name = "colTel";
            colTel.ReadOnly = true;
            // 
            // colDir
            // 
            colDir.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDir.HeaderText = "Dirección";
            colDir.Name = "colDir";
            colDir.ReadOnly = true;
            // 
            // colCiudad
            // 
            colCiudad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCiudad.HeaderText = "Ciudad";
            colCiudad.Name = "colCiudad";
            colCiudad.ReadOnly = true;
            // 
            // colAutorizacion
            // 
            colAutorizacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAutorizacion.HeaderText = "Estado Cta Cte";
            colAutorizacion.Name = "colAutorizacion";
            colAutorizacion.ReadOnly = true;
            // 
            // colSaldo
            // 
            colSaldo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSaldo.HeaderText = "Saldo Cta Cte";
            colSaldo.Name = "colSaldo";
            colSaldo.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 83);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 21;
            label3.Text = "Cantidad:";
            // 
            // lblCant
            // 
            lblCant.AutoSize = true;
            lblCant.Location = new Point(103, 83);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(38, 15);
            lblCant.TabIndex = 20;
            lblCant.Text = "label3";
            // 
            // TxtCantidadPaginas
            // 
            TxtCantidadPaginas.Location = new Point(176, 38);
            TxtCantidadPaginas.Name = "TxtCantidadPaginas";
            TxtCantidadPaginas.ReadOnly = true;
            TxtCantidadPaginas.Size = new Size(85, 23);
            TxtCantidadPaginas.TabIndex = 19;
            // 
            // CboPaginas
            // 
            CboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            CboPaginas.FormattingEnabled = true;
            CboPaginas.Location = new Point(73, 38);
            CboPaginas.Name = "CboPaginas";
            CboPaginas.Size = new Size(68, 23);
            CboPaginas.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 41);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 16;
            label2.Text = "de:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 41);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 17;
            label1.Text = "Pág.:";
            // 
            // BtnUltimo
            // 
            BtnUltimo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnUltimo.Image = Properties.Resources.last_24px;
            BtnUltimo.Location = new Point(1212, 33);
            BtnUltimo.Name = "BtnUltimo";
            BtnUltimo.Size = new Size(75, 41);
            BtnUltimo.TabIndex = 12;
            BtnUltimo.UseVisualStyleBackColor = true;
            // 
            // BtnSiguiente
            // 
            BtnSiguiente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSiguiente.Image = Properties.Resources.next_24px;
            BtnSiguiente.Location = new Point(1131, 33);
            BtnSiguiente.Name = "BtnSiguiente";
            BtnSiguiente.Size = new Size(75, 41);
            BtnSiguiente.TabIndex = 13;
            BtnSiguiente.UseVisualStyleBackColor = true;
            // 
            // BtnAnterior
            // 
            BtnAnterior.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAnterior.Image = Properties.Resources.previous_24px;
            BtnAnterior.Location = new Point(1050, 33);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(75, 41);
            BtnAnterior.TabIndex = 14;
            BtnAnterior.UseVisualStyleBackColor = true;
            // 
            // BtnPrimero
            // 
            BtnPrimero.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnPrimero.Image = Properties.Resources.first_24px;
            BtnPrimero.Location = new Point(969, 33);
            BtnPrimero.Name = "BtnPrimero";
            BtnPrimero.Size = new Size(75, 41);
            BtnPrimero.TabIndex = 15;
            BtnPrimero.UseVisualStyleBackColor = true;
            // 
            // TsbNuevo
            // 
            TsbNuevo.Image = Properties.Resources.Nuevo;
            TsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            TsbNuevo.ImageTransparentColor = Color.Magenta;
            TsbNuevo.Name = "TsbNuevo";
            TsbNuevo.Size = new Size(46, 59);
            TsbNuevo.Text = "Nuevo";
            TsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbNuevo.Click += TsbNuevo_Click;
            // 
            // TsbBorrar
            // 
            TsbBorrar.Image = Properties.Resources.Delete;
            TsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbBorrar.ImageTransparentColor = Color.Magenta;
            TsbBorrar.Name = "TsbBorrar";
            TsbBorrar.Size = new Size(44, 59);
            TsbBorrar.Text = "Borrar";
            TsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbBorrar.Click += TsbBorrar_Click;
            // 
            // TsbEditar
            // 
            TsbEditar.Image = Properties.Resources.Edit;
            TsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            TsbEditar.ImageTransparentColor = Color.Magenta;
            TsbEditar.Name = "TsbEditar";
            TsbEditar.Size = new Size(44, 59);
            TsbEditar.Text = "Editar";
            TsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbEditar.Click += TsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 62);
            // 
            // TsbActualizar
            // 
            TsbActualizar.Image = Properties.Resources.Update;
            TsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            TsbActualizar.ImageTransparentColor = Color.Magenta;
            TsbActualizar.Name = "TsbActualizar";
            TsbActualizar.Size = new Size(63, 59);
            TsbActualizar.Text = "Actualizar";
            TsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbActualizar.Click += TsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 62);
            // 
            // TsbImprimir
            // 
            TsbImprimir.Image = Properties.Resources.Print;
            TsbImprimir.ImageScaling = ToolStripItemImageScaling.None;
            TsbImprimir.ImageTransparentColor = Color.Magenta;
            TsbImprimir.Name = "TsbImprimir";
            TsbImprimir.Size = new Size(57, 59);
            TsbImprimir.Text = "Imprimir";
            TsbImprimir.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 62);
            // 
            // TsbCerrar
            // 
            TsbCerrar.Image = Properties.Resources.Close;
            TsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbCerrar.ImageTransparentColor = Color.Magenta;
            TsbCerrar.Name = "TsbCerrar";
            TsbCerrar.Size = new Size(44, 59);
            TsbCerrar.Text = "Cerrar";
            TsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            TsbCerrar.Click += TsbCerrar_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TsbNuevo, TsbBorrar, TsbEditar, toolStripSeparator1, TsbFiltrar, TsbActualizar, toolStripSeparator2, TsbImprimir, toolStripSeparator3, TsbCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1321, 62);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // TsbFiltrar
            // 
            TsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { textoToolStripMenuItem, paísToolStripMenuItem, provEstadoToolStripMenuItem, ciudadToolStripMenuItem, estadoCtaCteToolStripMenuItem });
            TsbFiltrar.Image = Properties.Resources.filter_40px;
            TsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            TsbFiltrar.ImageTransparentColor = Color.Magenta;
            TsbFiltrar.Name = "TsbFiltrar";
            TsbFiltrar.Size = new Size(53, 59);
            TsbFiltrar.Text = "Filtrar";
            TsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // textoToolStripMenuItem
            // 
            textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            textoToolStripMenuItem.Size = new Size(180, 22);
            textoToolStripMenuItem.Text = "Nombre";
            textoToolStripMenuItem.Click += textoToolStripMenuItem_Click;
            // 
            // paísToolStripMenuItem
            // 
            paísToolStripMenuItem.Name = "paísToolStripMenuItem";
            paísToolStripMenuItem.Size = new Size(180, 22);
            paísToolStripMenuItem.Text = "País";
            paísToolStripMenuItem.Click += paísToolStripMenuItem_Click;
            // 
            // provEstadoToolStripMenuItem
            // 
            provEstadoToolStripMenuItem.Name = "provEstadoToolStripMenuItem";
            provEstadoToolStripMenuItem.Size = new Size(180, 22);
            provEstadoToolStripMenuItem.Text = "Prov/Estado";
            provEstadoToolStripMenuItem.Click += provEstadoToolStripMenuItem_Click;
            // 
            // ciudadToolStripMenuItem
            // 
            ciudadToolStripMenuItem.Name = "ciudadToolStripMenuItem";
            ciudadToolStripMenuItem.Size = new Size(180, 22);
            ciudadToolStripMenuItem.Text = "Ciudad";
            ciudadToolStripMenuItem.Click += ciudadToolStripMenuItem_Click;
            // 
            // estadoCtaCteToolStripMenuItem
            // 
            estadoCtaCteToolStripMenuItem.Name = "estadoCtaCteToolStripMenuItem";
            estadoCtaCteToolStripMenuItem.Size = new Size(180, 22);
            estadoCtaCteToolStripMenuItem.Text = "Estado Cta Cte";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 617);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "FrmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            Load += FrmCliente_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }







        #endregion
        private SplitContainer splitContainer1;
        private DataGridView dgvDatos;
        private TextBox TxtCantidadPaginas;
        private ComboBox CboPaginas;
        private Label label2;
        private Label label1;
        private Button BtnUltimo;
        private Button BtnSiguiente;
        private Button BtnAnterior;
        private Button BtnPrimero;
        private ToolStripButton TsbNuevo;
        private ToolStripButton TsbBorrar;
        private ToolStripButton TsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton TsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton TsbImprimir;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton TsbCerrar;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton TsbFiltrar;
        private ToolStripMenuItem textoToolStripMenuItem;
        private ToolStripMenuItem paísToolStripMenuItem;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colRazonSocial;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colTel;
        private DataGridViewTextBoxColumn colDir;
        private DataGridViewTextBoxColumn colCiudad;
        private DataGridViewTextBoxColumn colAutorizacion;
        private DataGridViewTextBoxColumn colSaldo;
        private ToolStripMenuItem provEstadoToolStripMenuItem;
        private ToolStripMenuItem ciudadToolStripMenuItem;
        private ToolStripMenuItem estadoCtaCteToolStripMenuItem;
        private Label label3;
        private Label lblCant;
    }
}