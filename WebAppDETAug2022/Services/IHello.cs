namespace WebAppDETAug2022.Services
{
    public interface IHello
    {
        string SayHello(string name);
    }

    public class Hello1 : IHello
    {
        public string SayHello(string name)
        {
            return $"Hello {name}, Welcome to ASP .NET CORE";
        }
    }

    public class Hello2 : IHello
    {
        public string SayHello(string name)
        {
            return $"HI Hello {name}, How are you";
        }
    }
}
