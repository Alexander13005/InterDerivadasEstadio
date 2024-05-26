class Estadio
{
    static void asientos(int entradas)
    {
        Random a = new Random();
        int num = a.Next(0, 2); int num1 = a.Next(0, 2); int num2 = a.Next(0, 2); int num3 = a.Next(0, 2); int num4 = a.Next(0, 2); int num5 = a.Next(0, 2);
        int[,] asientos = new int[5, 10];
        int f = 100, c = 100, ent1 = 0;
        asientos[0, 0] = num; num = a.Next(0, 2); asientos[0, 1] = num; num = a.Next(0, 2); asientos[0, 2] = num; num = a.Next(0, 2); asientos[0, 3] = num; num = a.Next(0, 2); asientos[0, 4] = num; num = a.Next(0, 2); asientos[0, 5] = num; num = a.Next(0, 2); asientos[0, 6] = num; num = a.Next(0, 2); asientos[0, 7] = num; num = a.Next(0, 2); asientos[0, 8] = num; num = a.Next(0, 2); asientos[0, 9] = num; num = a.Next(0, 2);
        asientos[1, 0] = num; num = a.Next(0, 2); asientos[1, 1] = num; num = a.Next(0, 2); asientos[1, 2] = num; num = a.Next(0, 2); asientos[1, 3] = num; num = a.Next(0, 2); asientos[1, 4] = num; num = a.Next(0, 2); asientos[1, 5] = num; num = a.Next(0, 2); asientos[1, 6] = num; num = a.Next(0, 2); asientos[1, 7] = num; num = a.Next(0, 2); asientos[1, 8] = num; num = a.Next(0, 2); asientos[1, 9] = num; num = a.Next(0, 2);
        asientos[2, 0] = num; num = a.Next(0, 2); asientos[2, 1] = num; num = a.Next(0, 2); asientos[2, 2] = num; num = a.Next(0, 2); asientos[2, 3] = num; num = a.Next(0, 2); asientos[2, 4] = num; num = a.Next(0, 2); asientos[2, 5] = num; num = a.Next(0, 2); asientos[2, 6] = num; num = a.Next(0, 2); asientos[2, 7] = num; num = a.Next(0, 2); asientos[2, 8] = num; num = a.Next(0, 2); asientos[2, 9] = num; num = a.Next(0, 2);
        asientos[3, 0] = num; num = a.Next(0, 2); asientos[3, 1] = num; num = a.Next(0, 2); asientos[3, 2] = num; num = a.Next(0, 2); asientos[3, 3] = num; num = a.Next(0, 2); asientos[3, 4] = num; num = a.Next(0, 2); asientos[3, 5] = num; num = a.Next(0, 2); asientos[3, 6] = num; num = a.Next(0, 2); asientos[3, 7] = num; num = a.Next(0, 2); asientos[3, 8] = num; num = a.Next(0, 2); asientos[3, 9] = num; num = a.Next(0, 2);
        asientos[4, 0] = num; num = a.Next(0, 2); asientos[4, 1] = num; num = a.Next(0, 2); asientos[4, 2] = num; num = a.Next(0, 2); asientos[4, 3] = num; num = a.Next(0, 2); asientos[4, 4] = num; num = a.Next(0, 2); asientos[4, 5] = num; num = a.Next(0, 2); asientos[4, 6] = num; num = a.Next(0, 2); asientos[4, 7] = num; num = a.Next(0, 2); asientos[4, 8] = num; num = a.Next(0, 2); asientos[4, 9] = num; num = a.Next(0, 2);
        while (ent1 != entradas)
        {
            Console.WriteLine("Esta es la disponibilidad de los asientos"); Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   0 1 2 3 4 5 6 7 8 9 \n");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("0"); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" " + " " + asientos[0, 0] + " " + asientos[0, 1] + " " + asientos[0, 2] + " " + asientos[0, 3] + " " + asientos[0, 4] + " " + asientos[0, 5] + " " + asientos[0, 6] + " " + asientos[0, 7] + " " + asientos[0, 8] + " " + asientos[0, 9]); Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("1"); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" " + " " + asientos[1, 0] + " " + asientos[1, 1] + " " + asientos[1, 2] + " " + asientos[1, 3] + " " + asientos[1, 4] + " " + asientos[1, 5] + " " + asientos[1, 6] + " " + asientos[1, 7] + " " + asientos[1, 8] + " " + asientos[1, 9]); Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("2"); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" " + " " + asientos[2, 0] + " " + asientos[2, 1] + " " + asientos[2, 2] + " " + asientos[2, 3] + " " + asientos[2, 4] + " " + asientos[2, 5] + " " + asientos[2, 6] + " " + asientos[2, 7] + " " + asientos[2, 8] + " " + asientos[2, 9]); Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("3"); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" " + " " + asientos[3, 0] + " " + asientos[3, 1] + " " + asientos[3, 2] + " " + asientos[3, 3] + " " + asientos[3, 4] + " " + asientos[3, 5] + " " + asientos[3, 6] + " " + asientos[3, 7] + " " + asientos[3, 8] + " " + asientos[3, 9]); Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("4"); Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" " + " " + asientos[4, 0] + " " + asientos[4, 1] + " " + asientos[4, 2] + " " + asientos[4, 3] + " " + asientos[4, 4] + " " + asientos[4, 5] + " " + asientos[4, 6] + " " + asientos[4, 7] + " " + asientos[4, 8] + " " + asientos[4, 9]); Console.WriteLine(" ");
            Console.WriteLine("1 Significa Ocupado, 0 Significa Vacío \n");
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
                Console.WriteLine("Asiento Ocupado \n");
            }
            if (asientos[f, c] == 0)
            {
                Console.WriteLine("Asiento asignado correctamente \n"); asientos[f, c] = 1; ent1++;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   0 1 2 3 4 5 6 7 8 9 \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("0" + " " + " " + asientos[0, 0] + " " + asientos[0, 1] + " " + asientos[0, 2] + " " + asientos[0, 3] + " " + asientos[0, 4] + " " + asientos[0, 5] + " " + asientos[0, 6] + " " + asientos[0, 7] + " " + asientos[0, 8] + " " + asientos[0, 9]); Console.WriteLine(" ");
            Console.WriteLine("1" + " " + " " + asientos[1, 0] + " " + asientos[1, 1] + " " + asientos[1, 2] + " " + asientos[1, 3] + " " + asientos[1, 4] + " " + asientos[1, 5] + " " + asientos[1, 6] + " " + asientos[1, 7] + " " + asientos[1, 8] + " " + asientos[1, 9]); Console.WriteLine(" ");
            Console.WriteLine("2" + " " + " " + asientos[2, 0] + " " + asientos[2, 1] + " " + asientos[2, 2] + " " + asientos[2, 3] + " " + asientos[2, 4] + " " + asientos[2, 5] + " " + asientos[2, 6] + " " + asientos[2, 7] + " " + asientos[2, 8] + " " + asientos[2, 9]); Console.WriteLine(" ");
            Console.WriteLine("3" + " " + " " + asientos[3, 0] + " " + asientos[3, 1] + " " + asientos[3, 2] + " " + asientos[3, 3] + " " + asientos[3, 4] + " " + asientos[3, 5] + " " + asientos[3, 6] + " " + asientos[3, 7] + " " + asientos[3, 8] + " " + asientos[3, 9]); Console.WriteLine(" ");
            Console.WriteLine("4" + " " + " " + asientos[4, 0] + " " + asientos[4, 1] + " " + asientos[4, 2] + " " + asientos[4, 3] + " " + asientos[4, 4] + " " + asientos[4, 5] + " " + asientos[4, 6] + " " + asientos[4, 7] + " " + asientos[4, 8] + " " + asientos[4, 9]); Console.WriteLine(" ");
            f = 100; c = 100;
        }
    }
    static void switchsector(int sector)
    {
        int seccion = 0;
        switch (sector)
        {
            case 5:
                while (seccion >= 51 | seccion <= 36)
                {
                    Console.Write("Ingrese la sección que desea comprar: "); seccion = int.Parse(Console.ReadLine());
                }
                break;
            case 4:
                while (seccion >= 37 | seccion <= 24)
                {
                    Console.Write("Ingrese la sección que desea comprar: "); seccion = int.Parse(Console.ReadLine());
                }
                break;
            case 3:
                while (seccion >= 25 | seccion <= 14)
                {
                    Console.Write("Ingrese la sección que desea comprar: "); seccion = int.Parse(Console.ReadLine());
                }
                break;
            case 2:
                while (seccion >= 15 | seccion <= 6)
                {
                    Console.Write("Ingrese la sección que desea comprar: "); seccion = int.Parse(Console.ReadLine());
                }
                break;
            case 1:
                while (seccion >= 7 | seccion <= 0)
                {
                    Console.Write("Ingrese la sección que desea comprar: "); seccion = int.Parse(Console.ReadLine());
                }
                break;
        }
    }
    static void mostrarasientos()
    {
        Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("    5       4       3       2       1"); Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("*   *   *");
        Console.WriteLine("*  37   *");
        Console.WriteLine("*   *   *   *   *");
        Console.WriteLine("*  38   *  25   *");
        Console.WriteLine("*   *   *   *   *   *   *");
        Console.WriteLine("*  39   *  26   *  15   *");
        Console.WriteLine("*   *   *   *   *   *   *   *   *");
        Console.WriteLine("*  40   *  27   *  16   *   7   *");
        Console.WriteLine("*   *   *   *   *   *   *   *   *   *   *");
        Console.WriteLine("*  41   *  28   *  17   *   8   *   1   *");
        Console.WriteLine("*   *   *   *   *   *   *   *   *   *   *");
        Console.WriteLine("*  42   *  29   *  18   *   9   *   2   *");
        Console.WriteLine("*   *   *   *   *   *   *   *   *   *   *");
        Console.WriteLine("*  43   *  30   *  19   *  10   *   3   *");
        Console.WriteLine("*   *   *   *   *   *   *   *   *   *   *");
        Console.WriteLine("*  44   *  31   *  20   *  11   *   4   *");
        Console.WriteLine("*   *   *   *   *   *   *   *   *   *   *");
        Console.WriteLine("*  45   *  32   *  21   *  12   *   5   *");
        Console.WriteLine("*   *   *   *   *   *   *   *   *   *   *");
        Console.WriteLine("*  46   *  33   *  22   *  13   *   6   *");
        Console.WriteLine("*   *   *   *   *   *   *   *   *   *   *");
        Console.WriteLine("*  47   *  34   *  23   *  14   *");
        Console.WriteLine("*   *   *   *   *   *   *   *   *");
        Console.WriteLine("*  48   *  35   *  24   *");
        Console.WriteLine("*   *   *   *   *   *   *");
        Console.WriteLine("*  49   *  36   *");
        Console.WriteLine("*   *   *   *   *");
        Console.WriteLine("*  50   *");
        Console.WriteLine("*   *   *");
    }
    public static void Main(string[] args)
    {
        string opt = "si";  
        int zona = 0; int sector = 0; int seccion = 0; int  entradas = 0; int contador = 5; int f, c;
        while (opt == "si" && contador != 0)
        {
            Console.WriteLine("Bienvenido al Derivadas Arena \n"); Console.WriteLine("Está comprando entradas para el partido Inter Derivadas vs Integrales FC \n"); Console.WriteLine("Día del partido: Sábado 8 de junio     Hora: 6:00 pm \n");
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
            Console.WriteLine("                   *   *   *   *   *   *   *   *   *   *   *   *   * \n");
            while (zona >= 5 | zona <= 0)
            {
                Console.Write("Ingrese el número de la zona en la que desea comprar los boletos: "); zona = int.Parse(Console.ReadLine()); Console.WriteLine(" ");
            }
            switch (zona)
            {
                case 1:
                    Console.WriteLine("Usted ha escogido la zona 1\n");
                    Console.WriteLine("La lista de precios para esta zona es:\n");
                    Console.WriteLine("Sector 5 ............ $5.00"); Console.WriteLine("Sector 4 ............ $7.50"); Console.WriteLine("Sector 3 ............ $10.00"); Console.WriteLine("Sector 2 ............ $12.50"); Console.WriteLine("Sector 1 ............ $15.00 \n");
                    mostrarasientos();
                    while (sector >= 6 | sector <= 0)
                    {
                        Console.Write("Ingrese el sector que desea comprar: "); sector = int.Parse(Console.ReadLine());
                    }
                    switchsector(sector);
                    while (entradas > contador | entradas <= 0)
                    {
                        Console.Write("¿Cuántas entradas desea comprar? (Máximo " + contador + " entradas) "); entradas = int.Parse(Console.ReadLine()); Console.WriteLine(" ");
                    }
                    contador = contador - entradas;
                    asientos(entradas);
                    Console.WriteLine(" ");
                    pago(zona, sector, entradas);
                    break;
                case 2:
                    Console.WriteLine("Usted ha escogido la zona 2 \n");
                    Console.WriteLine("La lista de precios para esta zona es: \n");
                    Console.WriteLine("Sector 5 ............ $5.00"); Console.WriteLine("Sector 4 ............ $10.00"); Console.WriteLine("Sector 3 ............ $15.00"); Console.WriteLine("Sector 2 ............ $20.00"); Console.WriteLine("Sector 1 ............ $25.00 \n");
                    mostrarasientos();
                    while (sector >= 6 | sector <= 0)
                    {
                        Console.Write("Ingrese el sector que desea comprar: "); sector = int.Parse(Console.ReadLine());
                    }
                    switchsector(sector);
                    while (entradas > contador | entradas <= 0)
                    {
                        Console.Write("¿Cuántas entradas desea comprar? (Máximo " + contador + " entradas) "); entradas = int.Parse(Console.ReadLine()); Console.WriteLine(" ");
                    }
                    contador = contador - entradas;
                    asientos(entradas);
                    Console.WriteLine(" ");
                    pago(zona, sector, entradas);
                    break;
                case 3:
                    Console.WriteLine("Usted ha escogido la zona 3 \n");
                    Console.WriteLine("La lista de precios para esta zona es: \n");
                    Console.WriteLine("Sector 5 ............ $5.00"); Console.WriteLine("Sector 4 ............ $7.50"); Console.WriteLine("Sector 3 ............ $10.00"); Console.WriteLine("Sector 2 ............ $12.50"); Console.WriteLine("Sector 1 ............ $15.00 \n");
                    mostrarasientos();
                    while (sector >= 6 | sector <= 0)
                    {
                        Console.Write("Ingrese el sector que desea comprar: "); sector = int.Parse(Console.ReadLine());
                    }
                    switchsector(sector);
                    while (entradas > contador | entradas <= 0)
                    {
                        Console.Write("¿Cuántas entradas desea comprar? (Máximo " + contador + " entradas) "); entradas = int.Parse(Console.ReadLine()); Console.WriteLine(" ");
                    }
                    contador = contador - entradas;
                    asientos(entradas);
                    Console.WriteLine(" ");
                    pago(zona, sector, entradas);
                    break;
                case 4:
                    Console.WriteLine("Usted ha escogido la zona 4 \n");
                    Console.WriteLine("La lista de precios para esta zona es: \n");
                    Console.WriteLine("Sector 5 ............ $5.00"); Console.WriteLine("Sector 4 ............ $10.00"); Console.WriteLine("Sector 3 ............ $15.00"); Console.WriteLine("Sector 2 ............ $20.00"); Console.WriteLine("Sector 1 ............ $25.00 \n");
                    mostrarasientos();
                    while (sector >= 6 | sector <= 0)
                    {
                        Console.Write("Ingrese el sector que desea comprar: "); sector = int.Parse(Console.ReadLine());
                    }
                    switchsector(sector);
                    while (entradas > contador | entradas <= 0)
                    {
                        Console.Write("¿Cuántas entradas desea comprar? (Máximo " + contador + " entradas) "); entradas = int.Parse(Console.ReadLine()); Console.WriteLine(" ");
                    }
                    contador = contador - entradas;
                    asientos(entradas);
                    Console.WriteLine(" ");
                    pago(zona, sector, entradas);
                    break;
            }
            if (contador != 0)
            {
                Console.Write("¿Desea comprar otra entrada? "); opt = Console.ReadLine();
                if (opt == "si")
                {
                    zona = 0; sector = 0; seccion = 0; entradas = 0;
                }
            }
        }
        Console.WriteLine("Gracias por comprar con nosotros, Disfrute de su partido!)"); Console.ReadKey();
    }
    public static void pago(int zona, int sector, int entradas)
    {
        double pagos = 0;
        if (zona == 1 && sector == 1 || zona == 3 && sector == 1)
        {
            pagos = entradas * 15;
        }
        if (zona == 1 && sector == 2 || zona == 3 && sector == 2)
        {
            pagos = entradas * 12.50;
        }
        if (zona == 1 && sector == 3 || zona == 3 && sector == 3)
        {
            pagos = entradas * 10;
        }
        if (zona == 1 && sector == 4 || zona == 3 && sector == 4)
        {
            pagos = entradas * 7.50;
        }
        if (zona == 1 && sector == 5 || zona == 3 && sector == 5 || zona == 2 && sector == 5 || zona == 4 && sector == 5)
        {
            pagos = entradas * 5;
        }
        if (zona == 2 && sector == 1 || zona == 4 && sector == 1)
        {
            pagos = entradas * 25;
        }
        if (zona == 2 && sector == 2 || zona == 4 && sector == 2)
        {
            pagos = entradas * 20;
        }
        if (zona == 2 && sector == 3 || zona == 4 && sector == 3)
        {
            pagos = entradas * 15;
        }
        if (zona == 2 && sector == 4 || zona == 4 && sector == 4)
        {
            pagos = entradas * 10;
        }
        Console.WriteLine("Usted debe pagar $" + pagos);
        Console.WriteLine("");
    }
}
