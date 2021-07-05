using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progile.KeysymHelper
{
    public static class KeysymMapper
    {
        private static readonly string _keyMappingFile = Path.Combine(Path.GetDirectoryName(typeof(KeysymMapper).Assembly.Location), "Maps", "vncmap.dat");

        private static Dictionary<KeySym, Keys> _keySymToKeyMapping;
        private static Dictionary<KeySym, char> _keySymToPrintableCharMapping;

        public static bool IsReady { get; private set; }


        static KeysymMapper()
        {
            IsReady = LoadKeyMapping();
        }

        public static char GetPrintableCharacter(KeySym keySym) => _keySymToPrintableCharMapping[keySym];

        public static Keys GetKey(KeySym keySym) => _keySymToKeyMapping[keySym];

        private static bool LoadKeyMapping()
        {
            if (!File.Exists(_keyMappingFile))
                return false;

            var content = File.ReadAllLines(_keyMappingFile);

            _keySymToKeyMapping = new Dictionary<KeySym, Keys>(content.Length);
            _keySymToPrintableCharMapping = new Dictionary<KeySym, char>(content.Length);

            KeySym keySym = KeySym.VoidSymbol;
            foreach (var line in content)
            {
                // 0 = VK_Code
                // 1 = Unicode Char Value
                // 2 = KeySym
                var rawData = line.Split(';');

                keySym = (KeySym)uint.Parse(rawData[2]);

                // keysym -> keys mapping
                if (!string.IsNullOrEmpty(rawData[0]))
                    _keySymToKeyMapping.Add(keySym, (Keys)int.Parse(rawData[0]));
                else
                    _keySymToKeyMapping.Add(keySym, (Keys)0);

                // keysym -> char mapping
                if (!string.IsNullOrEmpty(rawData[1]))
                    _keySymToPrintableCharMapping.Add(keySym, (char)int.Parse(rawData[1]));
                else
                    _keySymToPrintableCharMapping.Add(keySym, (char)0);
            }

            return true;
        }
    }
}
