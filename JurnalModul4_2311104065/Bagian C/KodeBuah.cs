using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalModul4_2311104065.Bagian_C
{
    public class KodeBuah
    {
        private static Dictionary<string, string> tabelKodeBuah = new Dictionary<string, string>()
    {
        { "Apel", "A00" }, { "Aprikot", "B00" }, { "Alpukat", "C00" },
        { "Pisang", "D00" }, { "Paprika", "E00" }, { "Blackberry", "F00" },
        { "Ceri", "H00" }, { "Kelapa", "I00" }, { "Jagung", "J00" }
    };

        public static string getKodeBuah(string namaBuah)
        {
            return tabelKodeBuah.ContainsKey(namaBuah) ? tabelKodeBuah[namaBuah] : "Kode tidak ditemukan";
        }
    }
}

 