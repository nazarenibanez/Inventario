namespace Inventario
{
    public class Inventariodeproducto
    {
        public int CodigodeBarra { get; set; }
        public string? NombredelProducto { get; set; }
        public int CantidaddeStock { get; set; }
        public int PrciodelProducto { get; set; }
        public categorias categorias { get; set; }
        public string sinombre() 
        {
            if (!string.IsNullOrEmpty(NombredelProducto)) 
            {
                return $"{NombredelProducto!}";
            }
            return $"{NombredelProducto!}";
        
        }

    }

}
