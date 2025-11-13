evvel:
Console.Write("Ilk deyeri daxil et: ");
double n=Convert.ToInt32(Console.ReadLine());
Console.Write("Ikinci deyeri daxil et: ");
double m=Convert.ToInt32(Console.ReadLine());
sehv:
Console.Write("Emeliyat sec: ");
string secim=Console.ReadLine();
switch (secim)
{
    case "+":
        Operations(Toplama);
        break;
        case "-":
        Operations(Cixma);
        break;
        case "*":
        Operations(Vurma);
        break;
        case "/":
        Operations(Bolme);
        break;
        default:
        Console.Write("Secim dogru deyil yeniden ceht et: ");
        goto sehv;
}
goto evvel;

double Toplama(double x,double y)
{
    return (x + y);
}
double Cixma(double x,double y)
{
    return (x - y);
}
double Vurma(double x,double y)
{
    return (x * y);
}
double Bolme(double x,double y)
{
    if (y != 0)
    {
    return (x / y);
    }
    return 1;
}
void Operations(MathOperation operation)
{
    double netice = operation(n, m);
    Console.WriteLine($"Netice: {netice}.");
}
delegate double MathOperation(double x,double y);



