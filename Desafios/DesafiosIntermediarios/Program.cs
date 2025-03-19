// string[] line1 = Console.ReadLine().Split(" ");
// string[] line2 = Console.ReadLine().Split(" ");


string[] line1 = {"20"};
string[] line2 = {"10", "10"};

int finalExpediente = int.Parse(line1[0]);

int presente1 = int.Parse(line2[0]);
int presente2 = int.Parse(line2[1]);

int totalNecessario = presente1 + presente2;

if (totalNecessario > finalExpediente)
{
    Console.WriteLine("Deixa para amanha!");
}
else
{
    Console.WriteLine("Farei Hoje!");
}




#pragma warning disable CS8321 // Local function is declared but never used
static void Desafio1()
{
    int dias = 30;

    var anos = dias / 365;
    dias = dias % 365;


    var meses = dias / 30;
    dias = dias % 30;

    Console.WriteLine($"{anos} ano(s)");
    Console.WriteLine($"{meses} mes(es)");
    Console.WriteLine($"{dias} dia(s)");
}

static void Desafio2()
{
    // var timeInSeconds = int.Parse(Console.ReadLine());

    int timeInSeconds = 556;

    var hours = timeInSeconds / 3600;
    timeInSeconds = timeInSeconds % 3600;

    var minutes = timeInSeconds / 60;
    timeInSeconds = timeInSeconds % 60;

    Console.WriteLine($"{hours}:{minutes}:{timeInSeconds}");
}
#pragma warning restore CS8321 // Local function is declared but never used