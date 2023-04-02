int temperatura = 29;

switch (temperatura)
{
    case < 0:
        Console.WriteLine("Está frio para um caralho!");
        break;
    case >= 0 and < 10:
        Console.WriteLine("Está muito frio!");
        break;
    case >= 10 and < 23:
        Console.WriteLine("Frio!");
        break;
    case >= 23 and < 30:
        Console.WriteLine("Tempo bom!");
        break;
    default:
        Console.WriteLine("Está calor!");
        break;
}
