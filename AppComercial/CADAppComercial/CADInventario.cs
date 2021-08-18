using CADAppComercial.DSAppComercialTableAdapters;
using System;

namespace CADAppComercial
{
    public class CADInventario
    {
        private static InventarioTableAdapter adaptador = new InventarioTableAdapter();

        public static int InventarioInsertInventario(
            DateTime Fecha,
            int IDBodega)
        {
            return (int)adaptador.InventarioInsertInventario(Fecha, 1, IDBodega);
        }
    }
}