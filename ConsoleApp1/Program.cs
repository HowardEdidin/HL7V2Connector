using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HL7V2Parser;

namespace ConsoleApp1
{
    using System.Xml;

    class Program
    {
        static void Main()
        {
            const string input = "MSH|^~\\&|OAZIS||BIZTALK||20140318115439||ADT^A25|09568240|P|2.3||||||ASCII\r\nEVN|A25|20140318115439||||201403182330\r\nPID|1||3410131027|34101315545^^^^NN|Vanhubulcke^Victor^^ww^Meneer|Vermeersch^Marten|19341015|M|||Pereboomstraat 15^^STADEN^^8880^BE^H||01/56 65 99^^PH~0494/71 66 14ei^^CP||NL|M||80398500^^^^VN|0000000000|34101315545||||||BE||||N\r\nPD1||||003809^MATTELIN^GUY||||||||N\r\nPV1|1|O|5551^001^01^WIL|NULL|||003809^MATTELIN^GUY||000573^Bourgeois^Karel|1851|||||||000573^Bourgeois^Karel|0|80398500^^^^VN|3^20140318||||||||||||||||1|1||D|||||201403180830|201403181140";

            var parser = new HL7V2Parser.Parser();

            var result = parser.Parse(input);

            if (result.Root != null) Console.WriteLine(result.Root.Value);

            Console.ReadKey();

            var  document = (result).ToXmlDocument();

           Console.WriteLine(document.InnerXml);

   



        }
    }
}
