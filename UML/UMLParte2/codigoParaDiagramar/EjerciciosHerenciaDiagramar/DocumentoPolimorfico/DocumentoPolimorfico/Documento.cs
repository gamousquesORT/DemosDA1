namespace DocumentoPolimorfico;

public abstract class Documento
{
    public virtual double CalcularPrecioFinal()
    {
        return (TotalBase + CalcularIVA());
    } 
    public double TotalBase { set; get; }
    protected abstract double CalcularIVA();

}

public class Factura : Documento 
{
    
    protected override double CalcularIVA()
    {
        //calcula el IVA de la factura
        return 0;
    } 
}

public class Credito : Documento 
{
    protected override double CalcularIVA()
    {
        //calcula el IVA de la Nota de Credito
        return 0;
    } 
} 