using Inventario;
using repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAlmacen11
{
    public partial class frmAlmacen : Form
    {
        private RepositoriodelInventario? repo;
        private List<Inventariodeproducto> listainventario;
        private int cantidadinventario;
        public frmAlmacen()
        {
            InitializeComponent();
            repo = new RepositoriodelInventario();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            repo.guardadDatos();
            Application.Exit();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            frnAlmacenAE frm = new frnAlmacenAE(repo!) { Text = "nuevo" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Inventariodeproducto? inventario = frm.GetInventario();
            if (inventario is null)
            {
                return;

            }
            repo!.agregar(inventario);
            var r = Construirfila(dvgdatos);
            setearfila(r, inventario);
            agregarfila(r, dvgdatos);
            cantidadinventario = repo!.GetCantidad();
            mostrartotales();
            MessageBox.Show("inventario agregado en la lista!!!", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            
            cantidadinventario = repo!.GetCantidad();
            
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            listainventario = repo!.getinveitario();
            mostarDatosengrilla();
            mostrartotales();
        }

        private void mostrartotales()
        {
            txtcantidad.Text = listainventario.ToString();
        }

        private void mostarDatosengrilla()
        {
            dvgdatos.Rows.Clear();
            foreach (var invent in listainventario!)
            {
                DataGridViewRow r = Construirfila(dvgdatos);
                setearfila(r, invent);
                agregarfila(r, dvgdatos);
            }
        }

        private void agregarfila(DataGridViewRow r, DataGridView dvg)
        {
            dvg.Rows.Add(r);
        }

        private void setearfila(DataGridViewRow r, Inventariodeproducto invent)
        {
            r.Cells[ColCodigodebarra.Index].Value = invent.CodigodeBarra;
            r.Cells[ColNombre.Index].Value = invent.NombredelProducto;
            r.Cells[ColCantidad.Index].Value = invent.CantidaddeStock;
            r.Cells[ColPrecio.Index].Value = invent.PrciodelProducto;
            r.Cells[ColCategorio.Index].Value = invent.categorias;
            r.Tag = invent;
        }

        private DataGridViewRow Construirfila(DataGridView dvg)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dvg);
            return r;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dvgdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dvgdatos.SelectedRows.Count == 0)
            {
                return;
            }
            var select = dvgdatos.SelectedRows[0];
            Inventariodeproducto inventarioEliminar = (Inventariodeproducto)select.Tag;
            DialogResult dr = MessageBox.Show($"¿quieres eliminar este el producto {inventarioEliminar.NombredelProducto}?",
                "confirmar la eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            repo!.borrar(inventarioEliminar);
            quitarfila(select, dvgdatos);
            cantidadinventario = repo!.GetCantidad();
            mostrartotales();
            MessageBox.Show("producto eliminado!!", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quitarfila(DataGridViewRow select, DataGridView dvgdatos)
        {
            dvgdatos.Rows.Remove(select);
        }

        private void tsbCambiar_Click(object sender, EventArgs e)
        {
            if (dvgdatos.SelectedRows.Count == 0) return;
            var selecion = dvgdatos.SelectedRows[0];
            Inventariodeproducto? I = (Inventariodeproducto?)selecion.Tag;
            frnAlmacenAE frm = new frnAlmacenAE(repo!) { Text = "editar las cantidad" };
            frm.setinventario(I);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            I = frm.GetInventario();
            setearfila(selecion, I);
            MessageBox.Show("producto cambiado!!", "mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            while (true)
            {
                string codigostring = Microsoft.VisualBasic.Interaction.InputBox("ingrese el codigo de barra",
                    "buscar pór codigo de barra", "0");
                if (string.IsNullOrEmpty(codigostring))
                {
                    return;
                }
                if (ValidarCodigo(codigostring))
                {
                    bool existe = repo.buscarporcodigo(int.Parse(codigostring));
                    if (existe)
                    {
                        SeleccionarFila(int.Parse(codigostring));
                        return;
                    }
                    else
                    {
                        MessageBox.Show("codigo no encontrado", "mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                }
                else
                {
                    MessageBox.Show("codigo no encontrado", "mensaje",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private bool ValidarCodigo(string codigostring)
        {
            if (codigostring.Length < 10)
            {
                return false;
            }
            if (!int.TryParse(codigostring, out _))
            {
                return false;
            }
            return true;
        }
        public void SeleccionarFila(int codigo)
        {
            dvgdatos.ClearSelection();
            foreach (DataGridViewRow item in dvgdatos.Rows)
            {
                item.Selected = true;
            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            cantidadinventario = repo.GetCantidad();
            RecargarGrilla();
            tsbFiltrar.Enabled = true;
        }
    }
}
