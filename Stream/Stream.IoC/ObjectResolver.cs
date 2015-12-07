using System;
using Stream.IoC.Facade;

namespace Stream.IoC
{
    public class ObjectResolver : IObjectResolvable
    {
        public T Get<T>()
        {
            throw new NotImplementedException();
        }
    }
}