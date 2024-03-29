﻿using CADAppComercial.DSAppComercialTableAdapters;

namespace CADAppComercial
{
    public class CADIVA
    {
        public int IDIVA { get; set; }
        public string Descripcion { get; set; }
        public float Tarifa { get; set; }

        private static IVATableAdapter adaptador = new IVATableAdapter();

        public static CADIVA IVAGetIVAByIDIVA(int IDIVA)
        {
            CADIVA miIVA = null;
            DSAppComercial.IVADataTable miTabla = adaptador.IVAGetIVAByIDIVA(IDIVA);
            if (miTabla.Rows.Count == 0)
            {
                return miIVA;
            }
            else
            {
                DSAppComercial.IVARow miRegistro = (DSAppComercial.IVARow)miTabla.Rows[0];
                miIVA = new CADIVA();
                miIVA.Descripcion = miRegistro.Descripcion;
                miIVA.IDIVA = miRegistro.IDIVA;
                miIVA.Tarifa = (float) miRegistro.Tarifa;
                return miIVA;
            }
        }
    }
}