using System;

namespace Progile.KeysymHelper
{
    class Program
    {
        static void Main(string[] args)
        {

            // welcome to the most akward hello world ever ;)

            char[] HelloWorld = new char[12]
                {
                    KeysymMapper.GetPrintableCharacter(KeySym.H)
                    ,KeysymMapper.GetPrintableCharacter(KeySym.e)
                    , KeysymMapper.GetPrintableCharacter(KeySym.l)
                    , KeysymMapper.GetPrintableCharacter(KeySym.l)
                    , KeysymMapper.GetPrintableCharacter(KeySym.o)
                    , KeysymMapper.GetPrintableCharacter(KeySym.Space)
                    , KeysymMapper.GetPrintableCharacter(KeySym.W)
                    , KeysymMapper.GetPrintableCharacter(KeySym.o)
                    , KeysymMapper.GetPrintableCharacter(KeySym.r)
                    , KeysymMapper.GetPrintableCharacter(KeySym.l)
                    , KeysymMapper.GetPrintableCharacter(KeySym.d)
                    , KeysymMapper.GetPrintableCharacter(KeySym.Exclamationmark)
                };

            Console.WriteLine(new string(HelloWorld));

            Console.ReadLine();
        }
    }
}
