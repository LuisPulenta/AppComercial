using CADAppComercial.DSAppComercialTableAdapters;
using System;

namespace CADAppComercial
{
    public class CADTraslado
    {
        private static TrasladoTableAdapter adaptador = new TrasladoTableAdapter();

        public static int TrasladoInsertTraslado(
            DateTime Fecha,
            int IDBodegaOrigen,
            int IDBodegaDestino)
        {
            return (int)adaptador.TrasladoInsertTraslado(Fecha, IDBodegaOrigen, IDBodegaDestino);
        }
    }
}