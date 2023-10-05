using Adapter;

IPago pago = new PagoTransferencia();
Ventas venta = new Ventas(pago);
venta.ProcesarPago();

IPago pago1 = new PagoEfectivo();
Ventas venta1 = new Ventas(pago1);
venta1.ProcesarPago();

IPago pagoTC = new PagoTarjetaCredito("...0123");
Ventas ventaTC = new Ventas(pagoTC);
ventaTC.ProcesarPago();

IPago pagoSal = new PagoBolsaSal();
Ventas ventaSal = new Ventas(pagoSal);
ventaSal.ProcesarPago();

IPago pagoCuerpo = new PagoConCuerpo();
Ventas ventaCuerpo = new Ventas(pagoCuerpo);
ventaCuerpo.ProcesarPago();

IPago pagoTrueque = new Trueque();
Ventas ventaTrueque = new Ventas(pagoTrueque);
ventaTrueque.ProcesarPago();

IPago pagoFiado = new PagoFiado();
Ventas ventaFiado = new Ventas(pagoFiado);
ventaFiado.ProcesarPago(); 