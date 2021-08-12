using CADAppComercial.DSAppComercialTableAdapters;
using System;

namespace CADAppComercial
{
    public class CADDevolucionCliente
    {
        private static DevolucionClienteTableAdapter adaptador = new DevolucionClienteTableAdapter();

        public static int DevolucionClienteInsertDevolucionCliente(
            DateTime Fecha,
            int IDVenta)
            {
            return (int) adaptador.DevolucionClienteInsertDevolucionCliente(Fecha, IDVenta);
            }
    }
}