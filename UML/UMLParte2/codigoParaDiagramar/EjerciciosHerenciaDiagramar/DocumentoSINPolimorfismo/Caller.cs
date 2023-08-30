namespace DocumentoSINPolimorfismo;

enum TipoDocumento
{
    Factura,
    NotaCredito
}

public class Caller
{
    public double CalcularPrecioFinal(Documento documento)
    {
        double total = 0;
        if (documento.Tipo == TipoDocumento.Factura)
        {
            total = total + documento.TotalBaseFactura() + documento.CalcularIVAFactura();
        }
        else if (documento.Tipo == TipoDocumento.NotaCredito)
        {
            total = total + documento.TotalBaseCredito() + documento.CalcularIVACredito();
        }
        return total;
    }
}