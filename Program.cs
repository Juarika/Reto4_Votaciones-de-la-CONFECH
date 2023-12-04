internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("BIENVENIDO\n");
        Console.Write("Numero de universidades: ");
        int n = Int32.Parse(Console.ReadLine());
        int aceptan = 0;
        int rechazan = 0;
        int empate = 0;
        string universidad = "";
        for(int i = 1; i <= n; i++)
        {
            int uni_ace = 0;
            int uni_rec = 0;
            int uni_bla = 0;
            int uni_nul = 0;
            Console.Write("\nUniversidad: ");
            universidad = Console.ReadLine();
            string voto = "";
            while (voto != "X")
            {
                Console.Write("Voto: ");
                voto = Console.ReadLine().ToUpper();
                switch(voto)
                {
                    case "A":
                        uni_ace++;
                        break;
                    case "B":
                        uni_bla++;
                        break;
                    case "R":
                        uni_rec++;
                        break;
                    case "N":
                        uni_nul++;
                        break;
                    case "X":
                        break;
                }
            }
            Console.WriteLine($"{universidad}: {uni_ace} aceptan, {uni_rec} rechazan, {uni_bla} blancos, {uni_nul} nulos.");
            _ = uni_ace == uni_rec ? empate++ : uni_ace > uni_rec ? aceptan++ : rechazan++;
        }
        Console.WriteLine($"\nUniversidades que aceptan: {aceptan}");
        Console.WriteLine($"Universidades que rechazan: {rechazan}");
        Console.WriteLine($"Universidades con empate: {empate}");
    }
}