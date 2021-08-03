namespace AppComercial
{
    public class DetalleCompra
    {
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public float Cantidad { get; set; }
        public float PorcentajeIVA { get; set; }
        public float PorcentajeDescuento { get; set; }

        public decimal valorBruto { get { return  Costo * (decimal) Cantidad; } }
        public decimal valorIVA { get { return valorBruto * (decimal) PorcentajeIVA; } }
        public decimal valorDescuento { get { return valorBruto * (decimal)PorcentajeDescuento; } }
        public decimal valorNeto { get { return valorBruto + valorIVA - valorDescuento; } }
    }
}