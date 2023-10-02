using System.Text;
Int64 x;
int isnum3;
int isnum2;
int isnum1;
string cadas = null;
string nome = null;
string idade = null;
string n = null;
string? num1;
string? num2;
string? simb = null;
string? rari;
string? reppi;
string CMDES;
string raio = null;
String? o = null;
String line;
String if2 = null;
bool if1 = true;
bool if3 = true;
bool if4 = true;
bool if5 = true;
bool if6  = true;
bool if7 = true;
bool irCall = true;
bool irCallLet = true;
bool irCallLet1 = true;
bool irCallLet2 = true;
bool irCallLet3 = true;
bool irCallLet4 = false;
bool S_sair = true;
bool inifGame1 = true;
bool inifGame2 = true;
bool isNumeric;
bool isNumeric1;
bool isNumeric2;
bool sistemCom = true;
bool ComInvalido = false;
bool ircomando = false;
bool isnum5 = false;

while (S_sair)
{
    if (sistemCom)
    {
        rari = null;
        if6 = true;
        if7 = true;
        cadas = null;
        line = null;
        nome = null;
        idade = null;
        n = null;
        num1 = null;
        num2 = null;
        simb = null;
        o = null;
        irCall = true;
        irCallLet = true;
        irCallLet1 = true;
        irCallLet2 = true;
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\nSistema:");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("[1] App Cadartrar Pessoa");
        Console.WriteLine("[2] Calculadora");
        Console.WriteLine("[3] Calculadora Pi");
        Console.WriteLine("[4] Game somar");
        Console.WriteLine("[5] CMD");
        Console.WriteLine("[s] Para sair");
        Console.WriteLine("------------------------------------");
        Console.ForegroundColor = ConsoleColor.Yellow;
        n = Console.ReadLine().ToUpper();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("------------------------------------");
    }
    
    switch (n)
    {
        case "1":
        {
            if1 = true;
            if2 = null;
            cadas = null;
            line = null;
            if3 = true;
            if4 = true;
            if5 = true;
            
            while (if5)
            {
                if5 = false;
                Console.WriteLine("Digite: ");
                Console.WriteLine(" [1] para Ver pessoas cadastradas");
                Console.WriteLine(" [2] para Cadastrar pessoa");
                Console.WriteLine(" [s] Para sair");
                Console.ForegroundColor = ConsoleColor.Yellow;
                cadas = Console.ReadLine()!;
                Console.ForegroundColor = ConsoleColor.White;
                if1 = false;
                if3 = true;
                if (cadas != "1" && cadas != "2" && cadas.ToLower() != "s")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRO: numero invalido!");
                    Console.ForegroundColor = ConsoleColor.White;
                    if1 = true;
                }

                if (cadas == "1")
                {
                    Console.WriteLine("Ver pessoa cadatrada:");
                    Console.WriteLine("------------------------------------");
                    try
                    {
                        StreamReader sr = new StreamReader("text.txt");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Lista: ");
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(line);
                            Console.ForegroundColor = ConsoleColor.White;
                            line = sr.ReadLine();
                        }
                        Console.WriteLine("------------------------------------");
                        sr.Close();
                    }
                    catch (Exception e)
                    {
                    }

                    if5 = true;
                    if4 = true;
                }

                while (if4 == true)
                {
                    if4 = false;
                    if (cadas == "2")
                    {
                        Console.WriteLine("Cadastrar pessoa:");
                        Console.WriteLine("------------------------------------");
                        // colocar nome
                        Console.Write("Nome: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        nome = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        // colocar idade
                        Console.Write("Idade: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        idade = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        try
                        {
                            StreamWriter sw = new StreamWriter("text.txt",true, Encoding.ASCII);
                            sw.WriteLine("  " + nome + "   " + idade);
                            sw.Close();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Pessoa cadastrada!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }

                if (cadas.ToLower() == "s")
                {
                    sistemCom = true;
                    if1 = false;
                    if3 = false;
                    if4 = false;
                    if5 = false;
                }
            }
            break;
        }
        case "2":
        {
            do
            {
                while (irCallLet3)
                {
                    irCallLet3 = false;
                    Console.WriteLine("\nCalculadora:");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Digite:\n[1] para somar\n[2] para subtrair\n[3] para dividir\n[4] para multiplicar\n[s] para sair.");
                    Console.WriteLine("------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    simb = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    if (simb.ToLower() == "s")
                    {
                        irCall = false;
                        sistemCom = true;
                    }
                    if (simb.ToLower() != "1" && simb.ToLower() != "2" && simb.ToLower() != "3" && simb.ToLower() != "4" && simb.ToLower() != "s")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Letra invalida!");
                        Console.ForegroundColor = ConsoleColor.White;
                        irCallLet3 = true;
                    }
                }
                
                if (irCall)
                {
                    irCallLet1 = true;
                    do
                    {
                        Console.Write("Primeiro número: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        num1 = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        isNumeric = int.TryParse(num1, out isnum1);
                        if (isNumeric == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nApenas letras são validas!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (isNumeric == false);

                    do
                    {
                        Console.Write("\nSegundo número: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        num2 = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        isNumeric1 = int.TryParse(num2, out isnum2);
                        if (isNumeric1 == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nApenas letras são validas!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (isNumeric1 == false);
                    
                    {
                        switch (simb)
                        {
                            case "1":
                                Console.WriteLine(
                                    $"\nA soma entre {num1} e {num2} é igual a {float.Parse(num1) + float.Parse(num2)}");
                                irCallLet1 = false;
                                break;
                            case "2":
                                Console.WriteLine(
                                    $"\nA subtrair entre {num1} e {num2} é igual a {float.Parse(num2) - float.Parse(num1)}");
                                irCallLet1 = false;
                                break;
                            case "3":
                                Console.WriteLine(
                                    $"\nA dividir entre {num1} e {num2} é igual a {float.Parse(num1) / float.Parse(num2)}");
                                irCallLet1 = false;
                                break;
                            case "4":
                                Console.WriteLine(
                                    $"\nA multiplicar entre {num1} e {num2} é igual a {float.Parse(num1) * float.Parse(num2)}");
                                irCallLet1 = false;
                                break;
                        }

                        while (irCallLet)
                        {
                            irCallLet = false;
                            Console.WriteLine("\nCalcular mas alguma coisa? [s] ou [n]");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            o = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;

                            if (o != "s" && o != "S" && o != "n" && o != "N")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Letra invalida!");
                                Console.ForegroundColor = ConsoleColor.White;
                                irCallLet = true;
                            }
                        }

                        switch (o.ToLower())
                        {
                            case "s":
                                irCallLet = true;
                                irCallLet3 = true;
                                irCallLet4 = true;
                                break;
                            case "n":
                                sistemCom = true;
                                irCall = false;
                                irCallLet = false;
                                irCallLet1 = false;
                                irCallLet3 = false;
                                break;
                        }
                    }
                }
            } while (irCallLet4);
            break;
        }
        case "3":
        {
            do
            {
                irCallLet2 = false;
                Console.WriteLine("\nCalculadora Pi:");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\nDigite:\n[1] para area\n[2] para circuferencia\n[s] para sair.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                rari = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (rari.ToLower() == "s")
                {
                    if6 = false;
                }

                if (if6)
                {
                    do
                    {
                        isnum5 = false;
                        Console.Write("Digite o raio: ");
                        raio = Console.ReadLine();
                        isNumeric2 = int.TryParse(raio, out isnum3);
                        if (isNumeric2 == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nApenas letras são validas!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            isnum5 = true;
                        }

                    } while (isnum5);
                    
                    switch (rari)
                    {
                        case "1":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nA area é: " + Math.Pow(Math.PI * float.Parse(raio), 2));
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case "2":
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nA circuferencia é: " + (2 * Math.PI * float.Parse(raio)));
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case "s" or "S":
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNumero invalido!");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }

                    do
                    {
                        if7 = false;
                        Console.WriteLine("\nVoce vai fazer mas algun calculo? [s] ou [n]");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        reppi = Console.ReadLine().ToUpper();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        switch (reppi)
                        {
                            case "S":
                                irCallLet2 = true;
                                if6 = true;
                                break;
                            case "N":
                                sistemCom = true;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Numero invalido!");
                                Console.ForegroundColor = ConsoleColor.White;
                                if7 = true;
                                break;
                        }
                    } while (if7);
                }
            } while (irCallLet2);
            break;
        }
            case "4": 
            {
                do
                {
                    inifGame1 = false;
                    inifGame2 = false;
                    Console.WriteLine("\nGame soma:");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("[1] Jogar, [s] Sair");
                    string irGame = Console.ReadLine();
                    switch (irGame)
                    {
                        case "1":
                            inifGame1 = true;
                            break;
                        case "s" or "S":
                            inifGame1 = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Número invalido!");
                            Console.ForegroundColor = ConsoleColor.White;
                            inifGame2 = true;
                            break;
                    }
                } while (inifGame2);
                while (inifGame1)
                {
                    Random rand0 = new Random();
                    Random rand1 = new Random();
                    int re0 = rand0.Next(10, 100);
                    int re1 = rand1.Next(10, 100);
                    int ress = re0 + re1;
                    Console.WriteLine($"Quanto é: {re0} + {re1}?");
                    string RessPerCon = Console.ReadLine();
                    Double ressPer = Double.Parse(RessPerCon);
                    if (ress == ressPer)
                    {
                        Console.WriteLine("\nVocê acertou!!!");
                    }
                    else if (ress != ressPer)
                    {
                        Console.WriteLine($"\nVocê errou\nResposta correta: {ress}");
                    }
                    Console.WriteLine("\nVocê quer repetir? [s] ou [n]");
                    string GameRess = Console.ReadLine().ToLower();
                    if (GameRess == "n")
                    {
                        inifGame1 = false;
                        sistemCom = true;
                    }
                    if (GameRess != "n" && GameRess != "s")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Letra invalida!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                break;
            }
            case "5":
            {
                do
                {
                    sistemCom = false;
                    Console.WriteLine("CMD:");
                    Console.WriteLine("------------------------------------");
                    Console.Write("Comando: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    CMDES = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("------------------------------------");

                    if (CMDES.EndsWith("run"))
                    {
                        if (CMDES.StartsWith("appcadastrarpessoa"))
                        {
                            n = "1";
                            ComInvalido = true;
                            sistemCom = false;
                        }
                        
                        if (CMDES.StartsWith("calculadora"))
                        {
                                n = "2";
                                ComInvalido = true;
                                sistemCom = false;
                        }

                        if (CMDES.StartsWith("calculadorapi") && CMDES.EndsWith("run"))
                        {
                                n = "3";
                                ComInvalido = true;
                                sistemCom = false;
                        }

                        if (CMDES.StartsWith("gamesomar") && CMDES.EndsWith("run"))
                        {
                                n = "4";
                                ComInvalido = true;
                                sistemCom = false;
                        }
                    }

                    if (CMDES.StartsWith("console"))
                    {
                        if (CMDES.EndsWith("vermelho"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            ComInvalido = true;
                        }

                        if (CMDES.EndsWith("azul"))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            ComInvalido = true;
                        }

                        if (CMDES.EndsWith("verde"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            ComInvalido = true;
                        }

                        if (CMDES.EndsWith("branco"))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            ComInvalido = true;
                        }
                    }

                    if (CMDES == "sair sistema")
                    {
                        S_sair = false;
                        ComInvalido = true;
                    }

                    if (CMDES == "sair")
                    {
                        ComInvalido = true;
                        sistemCom = true;
                    }

                    if (ComInvalido == false)
                    {
                        ircomando = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Comando invalido!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                } while (ircomando);
                break;
            }
            case "S":
                S_sair = false;
                break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Numero invalido!");
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }
}