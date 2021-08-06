using CADAppComercial.DSAppComercialTableAdapters;
using System;

namespace CADAppComercial
{
    public class CADCompra
    {
        private static CompraTableAdapter adaptador = new CompraTableAdapter();

        public static int CompraInsertCompra(
            DateTime Fecha,
            int IDProveedor,
            int IDBodega)
        {
            return (int) adaptador.CompraInsertCompra(Fecha, IDProveedor, IDBodega);
        }

        public static bool ProveedorTieneCompras(int IDProveedor)
        {
            if(adaptador.ProveedorTieneCompras(IDProveedor)==null)
            {
                return false;
            }
            return true;
        }
    }
}