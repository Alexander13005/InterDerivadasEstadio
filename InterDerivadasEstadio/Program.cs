class Estadio
{
    static void asientos()
    {
        Random a = new Random();
        int num = a.Next(0, 2); int num1 = a.Next(0, 2); int num2 = a.Next(0, 2); int num3 = a.Next(0, 2); int num4 = a.Next(0, 2); int num5 = a.Next(0, 2);
        int[,] asientos = new int[5, 10];
        int f = 100, c = 100;
        asientos[0, 0] = num; num = a.Next(0, 2); asientos[0, 1] = num; num = a.Next(0, 2); asientos[0, 2] = num; num = a.Next(0, 2); asientos[0, 3] = num; num = a.Next(0, 2); asientos[0, 4] = num; num = a.Next(0, 2); asientos[0, 5] = num; num = a.Next(0, 2); asientos[0, 6] = num; num = a.Next(0, 2); asientos[0, 7] = num; num = a.Next(0, 2); asientos[0, 8] = num; num = a.Next(0, 2); asientos[0, 9] = num; num = a.Next(0, 2);
        asientos[1, 0] = num; num = a.Next(0, 2); asientos[1, 1] = num; num = a.Next(0, 2); asientos[1, 2] = num; num = a.Next(0, 2); asientos[1, 3] = num; num = a.Next(0, 2); asientos[1, 4] = num; num = a.Next(0, 2); asientos[1, 5] = num; num = a.Next(0, 2); asientos[1, 6] = num; num = a.Next(0, 2); asientos[1, 7] = num; num = a.Next(0, 2); asientos[1, 8] = num; num = a.Next(0, 2); asientos[1, 9] = num; num = a.Next(0, 2);
        asientos[2, 0] = num; num = a.Next(0, 2); asientos[2, 1] = num; num = a.Next(0, 2); asientos[2, 2] = num; num = a.Next(0, 2); asientos[2, 3] = num; num = a.Next(0, 2); asientos[2, 4] = num; num = a.Next(0, 2); asientos[2, 5] = num; num = a.Next(0, 2); asientos[2, 6] = num; num = a.Next(0, 2); asientos[2, 7] = num; num = a.Next(0, 2); asientos[2, 8] = num; num = a.Next(0, 2); asientos[2, 9] = num; num = a.Next(0, 2);
        asientos[3, 0] = num; num = a.Next(0, 2); asientos[3, 1] = num; num = a.Next(0, 2); asientos[3, 2] = num; num = a.Next(0, 2); asientos[3, 3] = num; num = a.Next(0, 2); asientos[3, 4] = num; num = a.Next(0, 2); asientos[3, 5] = num; num = a.Next(0, 2); asientos[3, 6] = num; num = a.Next(0, 2); asientos[3, 7] = num; num = a.Next(0, 2); asientos[3, 8] = num; num = a.Next(0, 2); asientos[3, 9] = num; num = a.Next(0, 2);
        asientos[4, 0] = num; num = a.Next(0, 2); asientos[4, 1] = num; num = a.Next(0, 2); asientos[4, 2] = num; num = a.Next(0, 2); asientos[4, 3] = num; num = a.Next(0, 2); asientos[4, 4] = num; num = a.Next(0, 2); asientos[4, 5] = num; num = a.Next(0, 2); asientos[4, 6] = num; num = a.Next(0, 2); asientos[4, 7] = num; num = a.Next(0, 2); asientos[4, 8] = num; num = a.Next(0, 2); asientos[4, 9] = num; num = a.Next(0, 2);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   0 1 2 3 4 5 6 7 8 9"); Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("0" + " " + " " + asientos[0, 0] + " " + asientos[0, 1] + " " + asientos[0, 2] + " " + asientos[0, 3] + " " + asientos[0, 4] + " " + asientos[0, 5] + " " + asientos[0, 6] + " " + asientos[0, 7] + " " + asientos[0, 8] + " " + asientos[0, 9]); Console.WriteLine(" ");
        Console.WriteLine("1" + " " + " " + asientos[1, 0] + " " + asientos[1, 1] + " " + asientos[1, 2] + " " + asientos[1, 3] + " " + asientos[1, 4] + " " + asientos[1, 5] + " " + asientos[1, 6] + " " + asientos[1, 7] + " " + asientos[1, 8] + " " + asientos[1, 9]); Console.WriteLine(" ");
        Console.WriteLine("2" + " " + " " + asientos[2, 0] + " " + asientos[2, 1] + " " + asientos[2, 2] + " " + asientos[2, 3] + " " + asientos[2, 4] + " " + asientos[2, 5] + " " + asientos[2, 6] + " " + asientos[2, 7] + " " + asientos[2, 8] + " " + asientos[2, 9]); Console.WriteLine(" ");
        Console.WriteLine("3" + " " + " " + asientos[3, 0] + " " + asientos[3, 1] + " " + asientos[3, 2] + " " + asientos[3, 3] + " " + asientos[3, 4] + " " + asientos[3, 5] + " " + asientos[3, 6] + " " + asientos[3, 7] + " " + asientos[3, 8] + " " + asientos[3, 9]); Console.WriteLine(" ");
        Console.WriteLine("4" + " " + " " + asientos[4, 0] + " " + asientos[4, 1] + " " + asientos[4, 2] + " " + asientos[4, 3] + " " + asientos[4, 4] + " " + asientos[4, 5] + " " + asientos[4, 6] + " " + asientos[4, 7] + " " + asientos[4, 8] + " " + asientos[4, 9]); Console.WriteLine(" ");
        Console.WriteLine("1 Significa Ocupado, 0 Significa Vacío"); Console.WriteLine(" ");
        while (f >= 5 | f <= -1)
        {
            Console.Write("Ingrese el número de fila que desea comprar "); f = int.Parse(Console.ReadLine()); Console.WriteLine(" ");
        }
        while (c >= 10 | c <= -1)
        {
            Console.Write("Ingrese el número de columna que desea comprar "); c = int.Parse(Console.ReadLine()); Console.WriteLine(" ");
        }
        if (asientos[f, c] == 1)
        {
            Console.WriteLine("Asiento Ocupado"); Console.WriteLine(" ");
        }
        if (asientos[f, c] == 0)
        {
            Console.WriteLine("Asiento asignado correctamente"); Console.WriteLine(" "); asientos[f, c] = 1;
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   0 1 2 3 4 5 6 7 8 9"); Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("0" + " " + " " + asientos[0, 0] + " " + asientos[0, 1] + " " + asientos[0, 2] + " " + asientos[0, 3] + " " + asientos[0, 4] + " " + asientos[0, 5] + " " + asientos[0, 6] + " " + asientos[0, 7] + " " + asientos[0, 8] + " " + asientos[0, 9]); Console.WriteLine(" ");
        Console.WriteLine("1" + " " + " " + asientos[1, 0] + " " + asientos[1, 1] + " " + asientos[1, 2] + " " + asientos[1, 3] + " " + asientos[1, 4] + " " + asientos[1, 5] + " " + asientos[1, 6] + " " + asientos[1, 7] + " " + asientos[1, 8] + " " + asientos[1, 9]); Console.WriteLine(" ");
        Console.WriteLine("2" + " " + " " + asientos[2, 0] + " " + asientos[2, 1] + " " + asientos[2, 2] + " " + asientos[2, 3] + " " + asientos[2, 4] + " " + asientos[2, 5] + " " + asientos[2, 6] + " " + asientos[2, 7] + " " + asientos[2, 8] + " " + asientos[2, 9]); Console.WriteLine(" ");
        Console.WriteLine("3" + " " + " " + asientos[3, 0] + " " + asientos[3, 1] + " " + asientos[3, 2] + " " + asientos[3, 3] + " " + asientos[3, 4] + " " + asientos[3, 5] + " " + asientos[3, 6] + " " + asientos[3, 7] + " " + asientos[3, 8] + " " + asientos[3, 9]); Console.WriteLine(" ");
        Console.WriteLine("4" + " " + " " + asientos[4, 0] + " " + asientos[4, 1] + " " + asientos[4, 2] + " " + asientos[4, 3] + " " + asientos[4, 4] + " " + asientos[4, 5] + " " + asientos[4, 6] + " " + asientos[4, 7] + " " + asientos[4, 8] + " " + asientos[4, 9]); Console.WriteLine(" ");
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al Derivadas Arena"); Console.WriteLine(" "); Console.WriteLine("Está comprando entradas para el partido Inter Derivadas vs Integrales FC"); Console.WriteLine(" ");
        Console.WriteLine("                   *   *   *   *   *   *   *   *   *   *   *   *   *");
        Console.WriteLine("               *  *                                             *      *");
        Console.WriteLine("            *      *                                           *          *");
        Console.WriteLine("         *          *                    2                    *              *");
        Console.WriteLine("       *             *                                       *                 *");
        Console.WriteLine("     *                *                                     *                    *");
        Console.Write("   *"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("                   *   *   *   *   *   *   *   *   *   *"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("                       *");
        Console.WriteLine("  *                                                                                 *");
        Console.Write(" *"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("                     *                                   *"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("                          *");
        Console.WriteLine("*                                                                                     *");
        Console.Write("*"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("                      *                                   *"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("                          *");
        Console.WriteLine("*        1                                                                3           *");
        Console.Write("*"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("                      *                                   *"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("                          *");
        Console.WriteLine("*                                                                                     *");
        Console.Write(" *"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("                     *                                   *"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("                         *");
        Console.Write("  *"); Console.ForegroundColor = ConsoleColor.Green; Console.Write("                    *   *   *   *   *   *   *   *   *   *"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("                       *");
        Console.WriteLine("     *                *                                     *                    *");
        Console.WriteLine("       *             *                                       *                 *");
        Console.WriteLine("         *          *                    4                    *              *");
        Console.WriteLine("            *      *                                           *          *");
        Console.WriteLine("               *  *                                             *      *");
        Console.WriteLine("                   *   *   *   *   *   *   *   *   *   *   *   *   *"); Console.WriteLine(" ");
    }
}