using System;
using console_libs.Tools;

namespace console_libs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/**********************************************************************************************/");
            Console.WriteLine("");
            Console.WriteLine("******** Retornando o Texto contido no atributo \"Description\" ou nome do item do ENUM *********");
            Console.WriteLine("");
            Console.WriteLine($"Texto do atributo \"Description\" do enum \"Enviroment.Homologation\" é {Enumerators.GetDescription(Enviroment.Homologation)}");
            Console.WriteLine("");
            Console.WriteLine($"Texto do atributo \"Description\" do enum \"Enviroment.Production\" é {Enumerators.GetDescription(Enviroment.Production)}");
            Console.WriteLine("");
            Console.WriteLine($"Para o enum \"Enviroment.Development\" foi retornado o nome do item que é {Enumerators.GetDescription(Enviroment.Development)} e não um texto, por que não foi declarado um atributo atributo \"Description\" a ele.");
            Console.WriteLine("");            
            Console.WriteLine("/**********************************************************************************************/");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("/**********************************************************************************************/");
            Console.WriteLine("");
            Console.WriteLine("******** Retornando o item do enum fornecendo o indice e tipo de ENUM *********");
            Console.WriteLine("");
            Console.WriteLine($"Para o indice 1 do tipo \"ProcessingStatus\", retornou o {Enumerators.GetEnum<ProcessingStatus>("1")}");
            Console.WriteLine($"Para o indice 2 do tipo \"Enviroment\", retornou o {Enumerators.GetEnum<Enviroment>("2")}");
        }
    }
}


