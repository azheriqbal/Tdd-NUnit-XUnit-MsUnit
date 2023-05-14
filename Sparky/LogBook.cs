using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public interface ILogBook
    {
        public void Message(string message);
    }
    public class LogBook : ILogBook
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class FakerLogBook : ILogBook
    {
        public void Message(string message)
        {
        }
    }
}
