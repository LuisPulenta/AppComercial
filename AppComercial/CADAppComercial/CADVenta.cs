using CADAppComercial.DSAppComercialTableAdapters;
using System;

namespace CADAppComercial
{
    public class CADVenta
    {
        public int IDVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int IDCliente { get; set; }
        public int IDBodega { get; set; }

        private static VentaTableAdapter adaptador = new VentaTableAdapter();

        public static int VentaInsertVenta(
            DateTime Fecha,
            int IDCliente,
            int IDBodega)
        {
            return (int)adaptador.VentaInsertVenta(Fecha, IDCliente, IDBodega);
        }

        public static CADVenta VentasGetVentaByIDVenta(int IDVenta)
        {
            CADVenta miVenta = null;
            DSAppComercial.VentaDataTable miTabla = adaptador.VentasGetVentaByIDVenta(IDVenta);
            if (miTabla.Rows.Count == 0)
            {
                return miVenta;
            }
            else
            {
                DSAppComercial.VentaRow miRegistro = (DSAppComercial.VentaRow)miTabla.Rows[0];
                miVenta = new CADVenta();
                miVenta.Fecha = miRegistro.Fecha;
                miVenta.IDCliente = miRegistro.IDCliente;
                miVenta.IDBodega = miRegistro.IDBodega;
                miVenta.IDVenta = miRegistro.IDVenta;
                return miVenta;
            }
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