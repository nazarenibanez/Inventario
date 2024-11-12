
using Inventario;

namespace repositorio
{
    public class RepositoriodelInventario
    {
        private readonly char separatorChar = '|';
        private string archivo = "Inventario.txt";
        private string rutainventario=AppDomain.CurrentDomain.BaseDirectory;
        private List<Inventariodeproducto>? invent;
        public RepositoriodelInventario() 
        {
            invent=new List<Inventariodeproducto>();
            LeerDatos();
        }

        private void LeerDatos()
        {
            var rutaArchivo=Path.Combine(rutainventario, archivo);
            if (!File.Exists(rutaArchivo)) return;
            using(var lector=new StreamReader(rutaArchivo)) 
            {
                while(!lector.EndOfStream) 
                {
                string linea = lector.ReadLine()!;
                Inventariodeproducto invet=construirpersona(linea);
                    agregar(invet);
                }
            
            }
        }

        private Inventariodeproducto construirpersona(string linea)
        {
            var camposinvet=linea.Split(separatorChar);
            var codigodebarra = int.Parse(camposinvet[0]);
            var nombredelproducto = camposinvet[1];
            var cantidaddestock = int.Parse(camposinvet[2]);
            var preciodelproducto = int.Parse(camposinvet[3]);
            categorias categorias=(categorias)int.Parse(camposinvet[4]);
            return new Inventariodeproducto
            {
                CodigodeBarra=codigodebarra,
                NombredelProducto=nombredelproducto,
                CantidaddeStock=cantidaddestock,
                PrciodelProducto=preciodelproducto,
                categorias=categorias
            };
        }

        public void agregar(Inventariodeproducto inventario) 
        {
            invent!.Add(inventario);
        }
        public List<Inventariodeproducto>? getinveitario() => invent;
        public int GetCantidad() 
        {
            return invent!.Count;
        }
        public void borrar(Inventariodeproducto inventario) 
        {
            invent!.Remove(inventario);
        }

        public bool buscarporcodigo(int buscarcodigo)
        {
            return invent!.Any(s =>s.CodigodeBarra==buscarcodigo);
        }

        public void guardadDatos()
        {
            var rutaarchivo = Path.Combine(rutainventario, archivo);
            using(var escrito=new StreamWriter(rutaarchivo)) 
            {
             foreach(var inventario in invent!) 
             {
                string linea = construirlinea(inventario);   
                escrito.WriteLine(linea);
             }   
            
            }
        }

        private string construirlinea(Inventariodeproducto inventario)
        {
            return $"{inventario.CodigodeBarra}|{inventario.NombredelProducto}|{inventario.CantidaddeStock}|{inventario.PrciodelProducto}|{inventario.categorias.GetHashCode()}";
        }
    }
}
