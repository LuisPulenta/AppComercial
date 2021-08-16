using CADAppComercial.DSAppComercialTableAdapters;
using System;

namespace CADAppComercial
{
    public class CADDevolucionProveedor
    {
        private static DevolucionProveedorTableAdapter adaptador = new DevolucionProveedorTableAdapter();

        public static int DevolucionProveedorInsertDevolucionProveedor(
            DateTime Fecha,
            int IDCompra)
        {
            return (int)adaptador.DevolucionProveedorInsertDevolucionProveedor(Fecha, IDCompra);
        }
    }
}