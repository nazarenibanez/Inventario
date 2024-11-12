namespace WinFormAlmacen11
{
    partial class frnAlmacenAE
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
            gBox1 = new GroupBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label5 = new Label();
            cbolCategoria = new ComboBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            gBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gBox1
            // 
            gBox1.Controls.Add(txtPrecio);
            gBox1.Controls.Add(txtCantidad);
            gBox1.Controls.Add(txtNombre);
            gBox1.Controls.Add(txtCodigo);
            gBox1.Controls.Add(label4);
            gBox1.Controls.Add(label3);
            gBox1.Controls.Add(label2);
            gBox1.Controls.Add(label1);
            gBox1.Location = new Point(28, 12);
            gBox1.Name = "gBox1";
            gBox1.Size = new Size(433, 201);
            gBox1.TabIndex = 3;
            gBox1.TabStop = false;
            gBox1.Text = "Inventario";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(156, 152);
            txtPrecio.MaximumSize = new Size(223, 23);
            txtPrecio.MinimumSize = new Size(223, 23);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(223, 23);
            txtPrecio.TabIndex = 7;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(156, 114);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(223, 23);
            txtCantidad.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(156, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(223, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(156, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(223, 23);
            txtCodigo.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 155);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio del producto :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 114);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de Stock :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 73);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre del producto: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo de barra :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 246);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 4;
            label5.Text = "Categoria :";
            // 
            // cbolCategoria
            // 
            cbolCategoria.FormattingEnabled = true;
            cbolCategoria.Location = new Point(120, 246);
            cbolCategoria.Name = "cbolCategoria";
            cbolCategoria.Size = new Size(211, 23);
            cbolCategoria.TabIndex = 5;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(50, 319);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(150, 79);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(311, 319);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 79);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frnAlmacenAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 426);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(cbolCategoria);
            Controls.Add(label5);
            Controls.Add(gBox1);
            MaximumSize = new Size(523, 465);
            MinimumSize = new Size(523, 465);
            Name = "frnAlmacenAE";
            Text = "frnAlmacenAE";
            Load += frnAlmacenAE_Load;
            gBox1.ResumeLayout(false);
            gBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gBox1;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label5;
        private ComboBox cbolCategoria;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}