using System;
using ProductCatalog.UI_Menu;
namespace ProductCatalog
{
    class Program
    {
        static void Main(string[] args)
        
        {
            bool exit = false;
            Menu m = new Menu();
            while(!exit)
            {
                try
                {
                    m.DisplayMainMenu();
                }
                catch (ApplicationException ae)
                {
                    Console.WriteLine($"Apllication exception: {ae}");
                }
                catch (SystemException se)
                {
                    Console.WriteLine($"System exception: {se}");
                }
                catch
                {
                    Console.WriteLine($"Unexpected exception!");
                }
                finally
                {
                    Console.WriteLine("\n> Program finish *-*!");
                    exit = true;                           
                }
            }

        }
    }
}
