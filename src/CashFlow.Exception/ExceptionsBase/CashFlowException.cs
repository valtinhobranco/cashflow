namespace CashFlow.Exception.ExceptionsBase;

public abstract class CashFlowException : SystemException
{
    protected CashFlowException(string mensage) : base(mensage)
    {
        
    }

    public abstract int StatusCode { get; }

    public abstract List<string> GetErros();

}
