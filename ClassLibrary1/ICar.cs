namespace ClassLibrary1
{
    public class Class1
    {
        public interface ICar
        {
            int GetPrice(string name);
        }

        class BMW : ICar
        {
            internal string Name;
            internal string Color;

            public int GetPrice(string name)
            {
                if (name == "M3")
                    return 13000000;
                else if (name == "X7")
                    return 9600000;
                else
                    return 3500000;
            }
        }

    }
}
