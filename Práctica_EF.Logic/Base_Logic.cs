using Práctica_EF.Data;

namespace Práctica_EF.Logic
{
    public class Base_Logic
    {
        protected readonly NortwindContext context;

        public Base_Logic()
        {
            context = new NortwindContext();
        }
    }
}