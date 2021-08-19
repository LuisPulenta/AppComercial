using CADAppComercial.DSAppComercialTableAdapters;

namespace CADAppComercial
{
    public class CADProductosAInventariar
    {
        private static ProductosAInventariarTableAdapter adaptador = new ProductosAInventariarTableAdapter();

        public static DSAppComercial.ProductosAInventariarDataTable ProductosAInventariarByIDBodega(int IDBodega)
        {
            return adaptador.ProductosAInventariarByIDBodega(IDBodega);
        }

        public static DSAppComercial.ProductosAInventariarDataTable ProductosAInventariarByIDBodegaAndIDDepartamento(int IDBodega,int IDDepartamento)
        {
            return adaptador.ProductosAInventariarByIDBodegaAndIDDepartamento(IDBodega, IDDepartamento);
        }
    }
}