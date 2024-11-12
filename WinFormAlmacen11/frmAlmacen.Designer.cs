namespace WinFormAlmacen11
{
    partial class frmAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlmacen));
            panel1 = new Panel();
            txtcantidad = new TextBox();
            txtcantidaddeinventario = new Label();
            toolStrip1 = new ToolStrip();
            tsbAgregar = new ToolStripButton();
            tsbEliminar = new ToolStripButton();
            tsbCambiar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbBuscar = new ToolStripButton();
            tsbFiltrar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            panel2 = new Panel();
            dvgdatos = new DataGridView();
            ColCodigodebarra = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColCategorio = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgdatos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtcantidad);
            panel1.Controls.Add(txtcantidaddeinventario);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(152, 41);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(100, 23);
            txtcantidad.TabIndex = 1;
            // 
            // txtcantidaddeinventario
            // 
            txtcantidaddeinventario.AutoSize = true;
            txtcantidaddeinventario.Location = new Point(12, 44);
            txtcantidaddeinventario.Name = "txtcantidaddeinventario";
            txtcantidaddeinventario.Size = new Size(134, 15);
            txtcantidaddeinventario.TabIndex = 0;
            txtcantidaddeinventario.Text = "cantidad del inventario :";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAgregar, tsbEliminar, tsbCambiar, toolStripSeparator1, tsbBuscar, tsbFiltrar, toolStripSeparator2, toolStripSeparator3, tsbActualizar, toolStripSeparator4, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 38);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // tsbAgregar
            // 
            tsbAgregar.Image = (Image)resources.GetObject("tsbAgregar.Image");
            tsbAgregar.ImageTransparentColor = Color.Magenta;
            tsbAgregar.Name = "tsbAgregar";
            tsbAgregar.Size = new Size(53, 35);
            tsbAgregar.Text = "Agregar";
            tsbAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbAgregar.Click += tsbAgregar_Click;
            // 
            // tsbEliminar
            // 
            tsbEliminar.Image = (Image)resources.GetObject("tsbEliminar.Image");
            tsbEliminar.ImageTransparentColor = Color.Magenta;
            tsbEliminar.Name = "tsbEliminar";
            tsbEliminar.Size = new Size(54, 35);
            tsbEliminar.Text = "Eliminar";
            tsbEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEliminar.Click += tsbEliminar_Click;
            // 
            // tsbCambiar
            // 
            tsbCambiar.Image = (Image)resources.GetObject("tsbCambiar.Image");
            tsbCambiar.ImageTransparentColor = Color.Magenta;
            tsbCambiar.Name = "tsbCambiar";
            tsbCambiar.Size = new Size(108, 35);
            tsbCambiar.Text = "Cambiar producto";
            tsbCambiar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbCambiar.Click += tsbCambiar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // tsbBuscar
            // 
            tsbBuscar.Image = (Image)resources.GetObject("tsbBuscar.Image");
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(98, 35);
            tsbBuscar.Text = "Buscar producto";
            tsbBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(38, 35);
            tsbFiltrar.Text = "Fltrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 38);
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 35);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 38);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = (Image)resources.GetObject("tsbSalir.Image");
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(33, 35);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dvgdatos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 312);
            panel2.TabIndex = 2;
            // 
            // dvgdatos
            // 
            dvgdatos.AllowUserToAddRows = false;
            dvgdatos.AllowUserToDeleteRows = false;
            dvgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgdatos.Columns.AddRange(new DataGridViewColumn[] { ColCodigodebarra, ColNombre, ColCantidad, ColPrecio, ColCategorio });
            dvgdatos.Dock = DockStyle.Fill;
            dvgdatos.Location = new Point(0, 0);
            dvgdatos.Name = "dvgdatos";
            dvgdatos.ReadOnly = true;
            dvgdatos.Size = new Size(800, 312);
            dvgdatos.TabIndex = 0;
            dvgdatos.CellContentClick += dvgdatos_CellContentClick;
            // 
            // ColCodigodebarra
            // 
            ColCodigodebarra.HeaderText = "codigo de barra";
            ColCodigodebarra.Name = "ColCodigodebarra";
            ColCodigodebarra.ReadOnly = true;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre del producto";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            // 
            // ColCantidad
            // 
            ColCantidad.HeaderText = "Cantidad en stock";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio del producto";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            // 
            // ColCategorio
            // 
            ColCategorio.HeaderText = "Categoria";
            ColCategorio.Name = "ColCategorio";
            ColCategorio.ReadOnly = true;
            // 
            // frmAlmacen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "frmAlmacen";
            Text = "frmAlmacen";
            Load += frmAlmacen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgdatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label txtcantidaddeinventario;
        private TextBox txtcantidad;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbAgregar;
        private ToolStripButton tsbEliminar;
        private ToolStripButton tsbCambiar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbBuscar;
        private ToolStripButton tsbFiltrar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private Panel panel2;
        private DataGridView dvgdatos;
        private DataGridViewTextBoxColumn ColCodigodebarra;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColCategorio;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton tsbSalir;
    }
}