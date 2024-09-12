using Castle.DynamicProxy;

namespace Core.Utilities.Interceptors;

public abstract class MethodInterception : MethodInterceptionBaseAttribute
{
    protected virtual void OnBefore(IInvocation invocation) { } // Metod çalışmadan önce
    protected virtual void OnAfter(IInvocation invocation) { }  // Metod çalıştıktan sonra
    protected virtual void OnException(IInvocation invocation, System.Exception e) { } // Exception aldığında
    protected virtual void OnSuccess(IInvocation invocation) { } // İşlem başarılı olarak gerçekleştiğinde
    public override void Intercept(IInvocation invocation)
    {
        var isSuccess = true;
        OnBefore(invocation);
        try
        {
            invocation.Proceed();
        }
        catch (Exception e)
        {
            isSuccess = false;
            OnException(invocation, e);
            throw;
        }
        finally
        {
            if (isSuccess)
            {
                OnSuccess(invocation);
            }
        }
        OnAfter(invocation);
    }
}
