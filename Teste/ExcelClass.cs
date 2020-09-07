using ExcelDna.Integration;

namespace Dev
{
    public class ExcelClass
    {
        [ExcelFunction(Description = "My first .NET function")]
        public string sayHello(string name)
        {
            return "Hello" + name;
        }
    }
}