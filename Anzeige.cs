namespace BinaerUhr
{
    internal class Anzeige
    {
        public void ZeitAktualisieren(object sender, ZeitEventArgs e)
        {
            Console.SetCursorPosition(0, 0);
            string ziffern = e.Zeit.ToString("HHmmss");
            string[] spalten = new string[6];

            for (int i = 0; i < 6; i++)
            {
                int ziffer = ziffern[i] - '0';
                spalten[i] = ZifferZuBinaer(ziffer);
            }

            for (int zeile = 0; zeile < 4; zeile++)
            {
                for (int spalte = 0; spalte < 6; spalte++)
                {
                    char bit = spalten[spalte][zeile];
                    Console.Write(bit == '1' ? "\u25FC " : "\u25FB ");
                }
                
                Console.WriteLine("");

            }

            Console.WriteLine(e.Zeit.ToString("\nHH:mm:ss"));
            Console.WriteLine("\nPress Esc to exit");

        }

        private string ZifferZuBinaer(int ziffer)
        {
            return Convert.ToString(ziffer, 2).PadLeft(4, '0');
        }
    }
}