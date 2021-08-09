using CADAppComercial.DSAppComercialTableAdapters;
using System;

namespace CADAppComercial
{
    public class CADVenta
    {
        private static VentaTableAdapter adaptador = new VentaTableAdapter();

        public static int VentaInsertVenta(
            DateTime Fecha,
            int IDCliente,
            int IDBodega)
        {
            return (int)adaptador.VentaInsertVenta(Fecha, IDCliente, IDBodega);
        }

        //public static bool ProveedorTieneCompras(int IDProveedor)
        //{
        //    if (adaptador.ProveedorTieneCompras(IDProveedor) == null)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}