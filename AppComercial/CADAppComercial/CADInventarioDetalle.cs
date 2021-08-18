using CADAppComercial.DSAppComercialTableAdapters;

namespace CADAppComercial
{
    public class CADInventarioDetalle
    {
        private static InventarioDetalleTableAdapter adaptador = new InventarioDetalleTableAdapter();

        public static void InventarioDetalleInsertInventarioDetalle(
            int IDInventario, 
            int IDProducto, 
            string Descripcion, 
            double Stock,
            double Conteo1,
            double Conteo2,
            double Conteo3,
            double Ajuste,
            int IDKardex)
        {
            adaptador.InventarioDetalleInsertInventarioDetalle(IDInventario, IDProducto, Descripcion, Stock, Conteo1, Conteo2, Conteo3, Ajuste, IDKardex);
        }
    }
}