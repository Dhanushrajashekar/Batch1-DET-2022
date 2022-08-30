namespace Myclasslib_Client
{
        public class Class1
        {
            public interface ICar
            {
                int GetPrice(string name);
            }

            class Honda : ICar
            {

                public int GetPrice(string name)
                {
                    if (name == "Santro")
                        return 400000;
                    else if (name == "X7")
                        return 180000;
                    else
                        return 100000;
                }
            }

        }
    }

