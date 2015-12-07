namespace Stream.IoC.Facade
{
    public interface IObjectResolvable
    {
        T Get<T>();
    }
}