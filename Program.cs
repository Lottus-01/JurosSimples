Console.Clear();


//dados, numeros!
    double Juros;
    double CapitalI;
    double TempoA;
    double TaxadeJ;
    double Montante;
    double TempoD;

Console.WriteLine("Super maquina de calculo de juros!!!");
    Thread.Sleep(2000);
Console.WriteLine("Por favor, insira os dados que você quer:");

    Console.WriteLine();

Console.WriteLine("Taxa de juros [i] (%)..:");
TaxadeJ = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Capital [c] (R$).......:");
CapitalI = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Tempo [t] (meses)......:");
TempoA = Convert.ToDouble(Console.ReadLine());

    TempoD = TempoA / 100;

    Juros = TaxadeJ * CapitalI * TempoD;
    
    Console.WriteLine("processando Juros...");
    Thread.Sleep(2000);


Console.WriteLine($"Taxa de juros x Capital x tempo = {Juros}");

    Montante = Juros + CapitalI;

    Console.WriteLine();

    Console.WriteLine("processando Montante...");
    Thread.Sleep(2000);

Console.WriteLine($"Juros + Capital = {Juros}");
    Thread.Sleep(2000);
Console.WriteLine($"o seu resultado é de {Montante}!!!");

