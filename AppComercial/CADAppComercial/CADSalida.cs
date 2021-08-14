using CADAppComercial.DSAppComercialTableAdapters;
using System;

namespace CADAppComercial
{
    public class CADSalida
    {
        private static SalidaTableAdapter adaptador = new SalidaTableAdapter();

        public static int SalidaInsertSalida(
            DateTime Fecha,
            int IDConcepto,
            int IDBodega)
        {
            return (int)adaptador.SalidaInsertSalida(Fecha, IDConcepto, IDBodega);
        }
    }
}