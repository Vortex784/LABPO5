using System.Runtime.CompilerServices;
namespace WebApplication3.Services.LAB5
{
    public class SomeClass

    {
       public string Print(string text)
        {
            try
            {
                return text.Length.ToString();
            }
            catch (Exception ex)
            {
                return ex.StackTrace;
            }
        }
    }
}
