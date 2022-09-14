namespace MyClassLibrary
{
    public class Class1
    {
        internal interface ICarPrice
        {
            int GetPrice(string name);
        }

        class BMW : ICarPrice
        {
            public int GetPrice(string name)
            {
                if (name == "M3 GTR")
                {
                    return 5000000;
                }
                else if (name == "X7")
                {
                    return 90000000;
                }
                else
                {
                    return 1000000;
                }
            }

        }

    }
}