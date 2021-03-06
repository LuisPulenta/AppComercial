CREATE PROCEDURE InicializarInventario AS

DELETE FROM DevolucionClienteDetalle
DELETE FROM DevolucionCliente
DELETE FROM DevolucionProveedorDetalle
DELETE FROM DevolucionProveedor
DELETE FROM CompraDetalle
DELETE FROM Compra
DELETE FROM InventarioDetalle
DELETE FROM Inventario
DELETE FROM SalidaDetalle
DELETE FROM Salida
DELETE FROM TrasladoDetalle
DELETE FROM Traslado
DELETE FROM VentaDetalle
DELETE FROM Venta
DELETE FROM Kardex

UPDATE BodegaProducto SET Stock = 0

DBCC CHECKIDENT (CompraDetalle, RESEED,0)
DBCC CHECKIDENT (Compra, RESEED,0)
DBCC CHECKIDENT (DevolucionClienteDetalle, RESEED,0)
DBCC CHECKIDENT (DevolucionCliente, RESEED,0)
DBCC CHECKIDENT (DevolucionProveedorDetalle, RESEED,0)
DBCC CHECKIDENT (DevolucionProveedor, RESEED,0)
DBCC CHECKIDENT (InventarioDetalle, RESEED,0)
DBCC CHECKIDENT (Inventario, RESEED,0)
DBCC CHECKIDENT (SalidaDetalle, RESEED,0)
DBCC CHECKIDENT (Salida, RESEED,0)
DBCC CHECKIDENT (TrasladoDetalle, RESEED,0)
DBCC CHECKIDENT (Traslado, RESEED,0)
DBCC CHECKIDENT (VentaDetalle, RESEED,0)
DBCC CHECKIDENT (Venta, RESEED,0)
DBCC CHECKIDENT (Kardex, RESEED,0)
