using Inventario;
using repositorio;

namespace WinFormAlmacen11
{
    public partial class frnAlmacenAE : Form
    {
        private Inventariodeproducto? inventario;
        private RepositoriodelInventario? _repo;
        public frnAlmacenAE(RepositoriodelInventario repo)
        {
            InitializeComponent();
            _repo = repo;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (inventario is not null)
            {
                txtCodigo.Text = inventario.CodigodeBarra.ToString();
                txtCodigo.Enabled = false;
                txtNombre.Text = inventario.NombredelProducto;
                txtCantidad.Text = inventario.CantidaddeStock.ToString();
                txtCantidad.Enabled = true;
                txtPrecio.Text = inventario.PrciodelProducto.ToString();
                txtPrecio.Enabled = true;
                cbolCategoria.SelectedItem = inventario.categorias;


            }
        }

        private void frnAlmacenAE_Load(object sender, EventArgs e)
        {
            CargardatoscomboCategorias(ref cbolCategoria);
        }

        private void CargardatoscomboCategorias(ref ComboBox cbol)
        {
            var categoria = Enum.GetValues(typeof(categorias));
            cbol.DataSource = categoria;
            cbol.SelectedIndex = 1;
            cbol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {


            if (validardatos())
            {
                if (inventario is null)
                {
                    inventario = new Inventariodeproducto();
                }
                inventario.CodigodeBarra = int.Parse(txtCodigo.Text);
                inventario.NombredelProducto = txtNombre.Text;
                inventario.CantidaddeStock = int.Parse(txtCantidad.Text);
                inventario.PrciodelProducto = int.Parse(txtPrecio.Text);
                inventario.categorias = (categorias)cbolCategoria.SelectedIndex;
                DialogResult = DialogResult.OK; 
            }



        }

        private bool validardatos()
        {
            bool validado = true;
            errorProvider1.Clear();
            if (!validarelcodigo(txtCodigo.Text))
            {
                validado = false;
                errorProvider1.SetError(txtCodigo, "tiene que ser de 10 numeros");

            }
            else
            {
                if (_repo.getinveitario()!.Any(c => c.CodigodeBarra == int.Parse(txtCodigo.Text)))
                {
                    validado = true;
                    errorProvider1.SetError(txtCodigo, "tiene que ser nuevo no uno ya existente");
                }

            }
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                validado = false;
                errorProvider1.SetError(txtNombre, "necesita un nombre");
            }
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || (cantidad <= 0))
            {
                validado = false;
                errorProvider1.SetError(txtCantidad, "se necesita una cantidad del 1 a 100"); ;
            }
            if(!int.TryParse(txtPrecio.Text,out int precio) || (precio <= 0)) 
            {
                validado = false;
                errorProvider1.SetError(txtPrecio, "se necesita un precio que sea mayor a 0");
            }


            return validado;
        }

        private bool validarelcodigo(string codigotx)
        {
            if (codigotx.Length < 10)
            {
                return false;
            }
            if (!int.TryParse(codigotx, out _))
            {
                return false;
            }
            return true;
        }

        public Inventariodeproducto? GetInventario()
        {
            return inventario;
        }
        public void setinventario(Inventariodeproducto? inven)
        {
            inventario = inven;
        }
    }
}
