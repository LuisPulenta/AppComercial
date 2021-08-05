using CADAppComercial.DSAppComercialTableAdapters;
using System;

namespace CADAppComercial
{
    public class CADKardex
    {
        public int IDKardex { get; set; }
        public int IDBodega { get; set; }
        public int IDProducto { get; set; }
        public DateTime Fecha { get; set; }
        public string Documento { get; set; }
        public float Entrada { get; set; }
        public float Salida { get; set; }
        public float Saldo { get; set; }
        public decimal UltimoCosto { get; set; }
        public decimal CostoPromedio { get; set; }

        private static KardexTableAdapter adaptador = new KardexTableAdapter();

        public static CADKardex KardexUltimoKardex(int IDBodega,int IDProducto)
        {
            CADKardex miKardex = null;
            DSAppComercial.KardexDataTable miTabla = adaptador.KardexUltimoKardex(IDBodega, IDProducto);
            if (miTabla.Rows.Count == 0)
            {
                return miKardex;
            }
            else
            {
                DSAppComercial.KardexRow miRegistro = (DSAppComercial.KardexRow)miTabla.Rows[0];
                miKardex = new CADKardex();
                miKardex.IDKardex = miRegistro.IDKardex;
                miKardex.IDBodega = miRegistro.IDBodega;
                miKardex.IDProducto = miRegistro.IDProducto;
                miKardex.Fecha = miRegistro.Fecha;
                miKardex.Documento = miRegistro.Documento;
                miKardex.Entrada = (float) miRegistro.Entrada;
                miKardex.Salida = (float) miRegistro.Salida;
                miKardex.Saldo = (float) miRegistro.Saldo;
                miKardex.UltimoCosto = miRegistro.UltimoCosto;
                miKardex.CostoPromedio = miRegistro.CostoPromedio;
                return miKardex;
            }
        }

        public static int KardexInsertKardex(
           int IDBodega,
           int IDProducto,
           DateTime Fecha,
           string Documento,
           float Entrada,
           float Salida,
           float Saldo,
           decimal UltimoCosto,
           decimal CostoPromedio)
        {
            return (int) adaptador.KardexInsertKardex(IDBodega, IDProducto, Fecha, Documento, Entrada, Salida, Saldo, UltimoCosto, CostoPromedio);
        }
    }
}