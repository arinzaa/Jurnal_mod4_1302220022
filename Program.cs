namespace Jurnal_mod4_1302220022
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KodeBuah.getKodeBuah(KodeBuah.getBuah.Apel));
        }
    }

    class KodeBuah
    {
        public enum getBuah
        {
            Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, kelapa, Jagung
        }
        public static string getKodeBuah(getBuah inputan)
        {
            string[] kodebuah = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
            return kodebuah[(int)inputan];
        }
    }

}