namespace babeZeslalBog
{
    internal class Program
    {
        static private bool czyJestBaba(string slowo)
        {
            string baba = "";
            foreach (char c in slowo){
                if (baba.Length % 2 == 0 && c == 'b')
                    baba += c;
                else if(baba.Length % 2 == 1 && c == 'a')
                    baba += c;

                if (baba == "baba")
                    return true;
            }

            return false;
        }
        
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            List<bool> czyBaba = new List<bool>();

            for(int i = 0; i < n; i++){
                czyBaba.Add(czyJestBaba(Console.ReadLine()));
            }

            foreach(bool b in czyBaba)
            {
                Console.WriteLine(b ? "Tak" : "Nie");
            }
        }
    }
}
