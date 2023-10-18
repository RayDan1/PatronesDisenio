using PuntoVenta;

IPago pago = new PagoEfec();
Ventas venta = new Ventas(pago);
venta.ProcesarPago();