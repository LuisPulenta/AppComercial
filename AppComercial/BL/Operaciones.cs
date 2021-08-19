using CADAppComercial;
using System;
using System.Collections.Generic;

namespace BL
{
    public class Operaciones
    {
        public static int GrabarCompra(int IDBodega, int IDProveedor, DateTime fecha, List<DetalleCompra> misDetalles)
        {
            //Grabamos la Cabecera de la Compra
            int IDCompra = CADCompra.CompraInsertCompra(
                fecha,
                IDProveedor,
                IDBodega);

            //Grabamos el Detalle de la Compra
            foreach (DetalleCompra midetalle in misDetalles)
            {
                //Actualizamos la Tabla BodegaProducto
                CADBodegaProducto miBodegaProducto = CADBodegaProducto.BodegaProductoGetBodegaProductoByIDBodegaAndIDProducto(IDBodega, midetalle.IDProducto);

                if (miBodegaProducto == null)
                {
                    CADBodegaProducto.BodegaProductoUpdate(IDBodega, midetalle.IDProducto, 1, 1, 1, 1);

                }
                CADBodegaProducto.BodegaProductoActualizaStock(midetalle.Cantidad, IDBodega, midetalle.IDProducto);

                //Actualizamos el Kardex
                CADKardex miKardex = CADKardex.KardexUltimoKardex(IDBodega, midetalle.IDProducto);

                int IDKardex;
                float nuevoSaldo;
                decimal nuevoCostoPromedio;
                decimal nuevoUltimoCosto;

                if (miKardex == null)
                {
                    nuevoSaldo = midetalle.Cantidad;
                    nuevoCostoPromedio = midetalle.valorNeto / (decimal)midetalle.Cantidad;
                    nuevoUltimoCosto = nuevoCostoPromedio;
                }
                else
                {
                    nuevoSaldo = miKardex.Saldo + midetalle.Cantidad;
                    nuevoCostoPromedio = (miKardex.CostoPromedio * (decimal)miKardex.Saldo
                        + midetalle.valorNeto) / (decimal)nuevoSaldo;
                    nuevoUltimoCosto = midetalle.valorNeto / (decimal)midetalle.Cantidad;
                }

                IDKardex = CADKardex.KardexInsertKardex(
                        IDBodega,
                        midetalle.IDProducto,
                        fecha,
                        string.Format("CO-{0}", IDCompra),
                        midetalle.Cantidad,
                        0,
                        nuevoSaldo,
                        nuevoUltimoCosto,
                        nuevoCostoPromedio);

                //Actualizamos CompraDetalle
                CADCompraDetalle.CompraDetalleInsertCompraDetalle(
                    IDCompra,
                    midetalle.IDProducto,
                    midetalle.Descripcion,
                    midetalle.Costo,
                    midetalle.Cantidad,
                    IDKardex, midetalle.PorcentajeIVA,
                    midetalle.PorcentajeDescuento);
            }
            return IDCompra;
        }

        public static int GrabarVenta(int IDBodega, int IDCliente, DateTime fecha, List<DetalleVenta> misDetalles)
        {
            //Grabamos la Cabecera de la Compra
            int IDVenta = CADVenta.VentaInsertVenta(
                fecha,
                IDCliente,
                IDBodega);

            //Grabamos el Detalle de la Compra
            foreach (DetalleVenta midetalle in misDetalles)
            {
                //Actualizamos la Tabla BodegaProducto
                CADBodegaProducto miBodegaProducto = CADBodegaProducto.BodegaProductoGetBodegaProductoByIDBodegaAndIDProducto(IDBodega, midetalle.IDProducto);

                if (miBodegaProducto == null)
                {
                    CADBodegaProducto.BodegaProductoUpdate(IDBodega, midetalle.IDProducto, 1, 1, 1, 1);

                }
                CADBodegaProducto.BodegaProductoActualizaStock(-midetalle.Cantidad, IDBodega, midetalle.IDProducto);

                //Actualizamos el Kardex
                CADKardex miKardex = CADKardex.KardexUltimoKardex(IDBodega, midetalle.IDProducto);

                int IDKardex;
                float nuevoSaldo;
                decimal nuevoCostoPromedio;
                decimal nuevoUltimoCosto;

                if (miKardex == null)
                {
                    nuevoSaldo = -midetalle.Cantidad;
                    nuevoCostoPromedio = 0;
                    nuevoUltimoCosto = 0;
                }
                else
                {
                    nuevoSaldo = miKardex.Saldo - midetalle.Cantidad;
                    nuevoCostoPromedio = miKardex.CostoPromedio;
                    nuevoUltimoCosto = miKardex.UltimoCosto;
                }

                IDKardex = CADKardex.KardexInsertKardex(
                        IDBodega,
                        midetalle.IDProducto,
                        fecha,
                        string.Format("VE-{0}", IDVenta),
                        0,
                        midetalle.Cantidad,
                        nuevoSaldo,
                        nuevoUltimoCosto,
                        nuevoCostoPromedio);

                //Actualizamos VentaDetalle
                CADVentaDetalle.VentaDetalleInsertVentaDetalle(
                    IDVenta,
                    midetalle.IDProducto,
                    midetalle.Descripcion,
                    midetalle.Precio,
                    midetalle.Cantidad,
                    IDKardex, midetalle.PorcentajeIVA,
                    midetalle.PorcentajeDescuento);
            }
            return IDVenta;
        }

        public static int GrabarSalida(int IDBodega, DateTime fecha, int IDConcepto, List<DetalleSalida> misDetalles)
        {
            //Grabamos la Cabecera de la Salida
            int IDSalida = CADSalida.SalidaInsertSalida(
                fecha,
                IDConcepto,
                IDBodega);

            //Grabamos el Detalle de la Salida
            foreach (DetalleSalida midetalle in misDetalles)
            {
                //Actualizamos la Tabla BodegaProducto
                CADBodegaProducto miBodegaProducto = CADBodegaProducto.BodegaProductoGetBodegaProductoByIDBodegaAndIDProducto(IDBodega, midetalle.IDProducto);

                if (miBodegaProducto == null)
                {
                    CADBodegaProducto.BodegaProductoUpdate(IDBodega, midetalle.IDProducto, 1, 1, 1, 1);

                }
                CADBodegaProducto.BodegaProductoActualizaStock(-midetalle.Cantidad, IDBodega, midetalle.IDProducto);

                //Actualizamos el Kardex
                CADKardex miKardex = CADKardex.KardexUltimoKardex(IDBodega, midetalle.IDProducto);

                int IDKardex;
                float nuevoSaldo;
                decimal nuevoCostoPromedio;
                decimal nuevoUltimoCosto;

                if (miKardex == null)
                {
                    nuevoSaldo = -midetalle.Cantidad;
                    nuevoCostoPromedio = 0;
                    nuevoUltimoCosto = 0;
                }
                else
                {
                    nuevoSaldo = miKardex.Saldo - midetalle.Cantidad;
                    nuevoCostoPromedio = miKardex.CostoPromedio;
                    nuevoUltimoCosto = miKardex.UltimoCosto;
                }

                IDKardex = CADKardex.KardexInsertKardex(
                        IDBodega,
                        midetalle.IDProducto,
                        fecha,
                        string.Format("SA-{0}", IDSalida),
                        0,
                        midetalle.Cantidad,
                        nuevoSaldo,
                        nuevoUltimoCosto,
                        nuevoCostoPromedio);

                //Actualizamos SalidaDetalle
                CADSalidaDetalle.SalidaDetalleInsertSalidaDetalle(
                    IDSalida,
                    midetalle.IDProducto,
                    midetalle.Descripcion,
                    midetalle.Cantidad,
                    IDKardex);
            }
            return IDSalida;
        }

        public static int GrabarTraslado(DateTime fecha, int IDBodegaOrigen, int IDBodegaDestino, List<DetalleTraslado> misDetalles)
        {
            //Grabamos la Cabecera del Traslado
            int IDTraslado = CADTraslado.TrasladoInsertTraslado(
                fecha,
                IDBodegaOrigen,
                IDBodegaDestino);

            //Grabamos el Detalle del Traslado
            foreach (DetalleTraslado midetalle in misDetalles)
            {
                //Actualizamos la Tabla BodegaProducto
                CADBodegaProducto miBodegaProductoOrigen = CADBodegaProducto.BodegaProductoGetBodegaProductoByIDBodegaAndIDProducto(IDBodegaOrigen, midetalle.IDProducto);

                if (miBodegaProductoOrigen == null)
                {
                    CADBodegaProducto.BodegaProductoUpdate(IDBodegaOrigen, midetalle.IDProducto, 1, 1, 1, 1);

                }
                CADBodegaProducto.BodegaProductoActualizaStock(-midetalle.Cantidad, IDBodegaOrigen, midetalle.IDProducto);

                CADBodegaProducto miBodegaProductoDestino = CADBodegaProducto.BodegaProductoGetBodegaProductoByIDBodegaAndIDProducto(IDBodegaDestino, midetalle.IDProducto);

                if (miBodegaProductoDestino == null)
                {
                    CADBodegaProducto.BodegaProductoUpdate(IDBodegaDestino, midetalle.IDProducto, 1, 1, 1, 1);

                }
                CADBodegaProducto.BodegaProductoActualizaStock(midetalle.Cantidad, IDBodegaDestino, midetalle.IDProducto);


                //Actualizamos el Kardex
                CADKardex miKardexOrigen = CADKardex.KardexUltimoKardex(IDBodegaOrigen, midetalle.IDProducto);

                int IDKardexOrigen;
                float nuevoSaldoOrigen;
                decimal nuevoCostoPromedioOrigen;
                decimal nuevoUltimoCostoOrigen;

                if (miKardexOrigen == null)
                {
                    nuevoSaldoOrigen = -midetalle.Cantidad;
                    nuevoCostoPromedioOrigen = 0;
                    nuevoUltimoCostoOrigen = 0;
                }
                else
                {
                    nuevoSaldoOrigen = miKardexOrigen.Saldo - midetalle.Cantidad;
                    nuevoCostoPromedioOrigen = miKardexOrigen.CostoPromedio;
                    nuevoUltimoCostoOrigen = miKardexOrigen.UltimoCosto;
                }

                IDKardexOrigen = CADKardex.KardexInsertKardex(
                        IDBodegaOrigen,
                        midetalle.IDProducto,
                        fecha,
                        string.Format("TR-{0}", IDTraslado),
                        0,
                        midetalle.Cantidad,
                        nuevoSaldoOrigen,
                        nuevoUltimoCostoOrigen,
                        nuevoCostoPromedioOrigen);

                CADKardex miKardexDestino = CADKardex.KardexUltimoKardex(IDBodegaDestino, midetalle.IDProducto);

                int IDKardexDestino;
                float nuevoSaldoDestino;
                decimal nuevoCostoPromedioDestino;
                decimal nuevoUltimoCostoDestino;

                if (miKardexDestino == null)
                {
                    nuevoSaldoDestino = midetalle.Cantidad;
                    nuevoCostoPromedioDestino = 0;
                    nuevoUltimoCostoDestino = 0;
                }
                else
                {
                    nuevoSaldoDestino = miKardexDestino.Saldo + midetalle.Cantidad;
                    nuevoCostoPromedioDestino = miKardexDestino.CostoPromedio;
                    nuevoUltimoCostoDestino = miKardexDestino.UltimoCosto;
                }

                IDKardexDestino = CADKardex.KardexInsertKardex(
                        IDBodegaDestino,
                        midetalle.IDProducto,
                        fecha,
                        string.Format("TR-{0}", IDTraslado),
                        midetalle.Cantidad,
                        0,
                        nuevoSaldoDestino,
                        nuevoUltimoCostoDestino,
                        nuevoCostoPromedioDestino);


                //Actualizamos TrasladoDetalle
                CADTrasladoDetalle.TrasladoDetalleInsertTrasladoDetalle(
                    IDTraslado,
                    midetalle.IDProducto,
                    midetalle.Descripcion,
                    midetalle.Cantidad,
                    IDKardexOrigen,
                    IDKardexDestino);
            }
            return IDTraslado;
        }

        public static int GrabarDevolucionCliente(DateTime fecha, int IDBodega, int IDVenta, List<DevolucionClienteDevuelto> misDevueltos)
        {
            //Grabamos la Cabecera de la Devolución
            int IDDevolucion = CADDevolucionCliente.DevolucionClienteInsertDevolucionCliente(fecha, IDVenta);

            //Grabamos el Detalle de la Devolución
            foreach (DevolucionClienteDevuelto midevuelto in misDevueltos)
            {
                //Actualizamos la Tabla BodegaProducto
                CADBodegaProducto miBodegaProducto = CADBodegaProducto.BodegaProductoGetBodegaProductoByIDBodegaAndIDProducto(IDBodega, midevuelto.IDProducto);

                if (miBodegaProducto == null)
                {
                    CADBodegaProducto.BodegaProductoUpdate(IDBodega, midevuelto.IDProducto, 1, 1, 1, 1);

                }
                CADBodegaProducto.BodegaProductoActualizaStock(midevuelto.CantidadADevolver, IDBodega, midevuelto.IDProducto);

                //Actualizamos el Kardex
                CADKardex miKardex = CADKardex.KardexUltimoKardex(IDBodega, midevuelto.IDProducto);

                int IDKardex;
                float nuevoSaldo;
                decimal nuevoCostoPromedio;
                decimal nuevoUltimoCosto;

                if (miKardex == null)
                {
                    nuevoSaldo = midevuelto.CantidadADevolver;
                    nuevoCostoPromedio = midevuelto.Precio;
                    nuevoUltimoCosto = nuevoCostoPromedio;
                }
                else
                {
                    nuevoSaldo = miKardex.Saldo + midevuelto.CantidadADevolver;
                    if (nuevoSaldo != 0)
                    {
                        nuevoCostoPromedio = (miKardex.CostoPromedio * (decimal)miKardex.Saldo
                        + midevuelto.Precio * (decimal)midevuelto.CantidadADevolver) / (decimal)nuevoSaldo;
                    }
                    else
                    {
                        nuevoCostoPromedio = 0;
                    }
                    nuevoUltimoCosto = (decimal)midevuelto.Precio;
                }

                IDKardex = CADKardex.KardexInsertKardex(
                        IDBodega,
                        midevuelto.IDProducto,
                        fecha,
                        string.Format("DC-{0}", IDDevolucion),
                        midevuelto.CantidadADevolver,
                        0,
                        nuevoSaldo,
                        nuevoUltimoCosto,
                        nuevoCostoPromedio);

                //Actualizamos DevolcuionCompraDetalle
                CADDevolucionClienteDetalle.DevolucionClienteDetalleInsertDevolucionClienteDetalle(
                    IDDevolucion,
                    midevuelto.IDProducto,
                    midevuelto.Descripcion,
                    midevuelto.Precio,
                    midevuelto.CantidadADevolver,
                    IDKardex,
                    midevuelto.PorcentajeIVA,
                    midevuelto.PorcentajeDescuento)
                    ;
            }
            return IDDevolucion;
        }

        public static int GrabarDevolucionProveedor(DateTime fecha, int IDBodega, int IDCompra, List<DevolucionProveedorDevuelto> misDevueltos)
        {
            //Grabamos la Cabecera de la Devolución
            int IDDevolucion = CADDevolucionProveedor.DevolucionProveedorInsertDevolucionProveedor(fecha, IDCompra);

            //Grabamos el Detalle de la Devolución
            foreach (DevolucionProveedorDevuelto midevuelto in misDevueltos)
            {
                //Actualizamos la Tabla BodegaProducto
                CADBodegaProducto miBodegaProducto = CADBodegaProducto.BodegaProductoGetBodegaProductoByIDBodegaAndIDProducto(IDBodega, midevuelto.IDProducto);

                if (miBodegaProducto == null)
                {
                    CADBodegaProducto.BodegaProductoUpdate(IDBodega, midevuelto.IDProducto, 1, 1, 1, 1);

                }
                CADBodegaProducto.BodegaProductoActualizaStock(-midevuelto.CantidadADevolver, IDBodega, midevuelto.IDProducto);

                //Actualizamos el Kardex
                CADKardex miKardex = CADKardex.KardexUltimoKardex(IDBodega, midevuelto.IDProducto);

                int IDKardex;
                float nuevoSaldo;
                decimal nuevoCostoPromedio;
                decimal nuevoUltimoCosto;

                if (miKardex == null)
                {
                    nuevoSaldo = -midevuelto.CantidadADevolver;
                    nuevoCostoPromedio = midevuelto.Costo;
                    nuevoUltimoCosto = nuevoCostoPromedio;
                }
                else
                {
                    nuevoSaldo = miKardex.Saldo - midevuelto.CantidadADevolver;
                    if (nuevoSaldo != 0)
                    {
                        nuevoCostoPromedio = (miKardex.CostoPromedio * (decimal)miKardex.Saldo
                        + midevuelto.Costo * (decimal)midevuelto.CantidadADevolver) / (decimal)nuevoSaldo;
                    }
                    else
                    {
                        nuevoCostoPromedio = 0;
                    }
                    nuevoUltimoCosto = (decimal)midevuelto.Costo;
                }

                IDKardex = CADKardex.KardexInsertKardex(
                        IDBodega,
                        midevuelto.IDProducto,
                        fecha,
                        string.Format("DP-{0}", IDDevolucion),
                        0,
                        midevuelto.CantidadADevolver,
                        nuevoSaldo,
                        nuevoUltimoCosto,
                        nuevoCostoPromedio);

                //Actualizamos DevolucionCompraDetalle
                CADDevolucionProveedorDetalle.DevolucionProveedorDetalleInsertDevolucionProveedorDetalle(
                    IDDevolucion,
                    midevuelto.IDProducto,
                    midevuelto.Descripcion,
                    midevuelto.Costo,
                    midevuelto.CantidadADevolver,
                    IDKardex,
                    midevuelto.PorcentajeIVA,
                    midevuelto.PorcentajeDescuento)
                    ;
            }
            return IDDevolucion;
        }
    }
}
