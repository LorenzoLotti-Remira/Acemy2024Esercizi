//Console.WriteLine("Rectangle area and perimeter calculator.");

//Console.Write("Insert base side length: ");
//string baseSideInput = Console.ReadLine();
//double baseSide = double.Parse(baseSideInput);

//if (baseSide < 0)
//{
//    Console.WriteLine("You inserted an invalid base side. retry");
//    return;
//}

//Console.Write("Insert height side length: ");
//string heightSideInput = Console.ReadLine();
//double heightSide = double.Parse(heightSideInput);


//double p = (baseSide + heightSide) * 2;
//double a = baseSide * heightSide;

//Console.Write("Perimeter: ");
//Console.WriteLine(p);
//Console.Write("Area: ");
//Console.WriteLine(a);


/*
    creare un programma nel quale vengono presi in input due numeri dall'utente,
    dopodiché dire all'utente (tramite Console.Write o WrileLine) quale tra i due è il maggiore
    o se sono uguali
*/

bool isNum1Valid;
double num1;

do
{
    Console.Write("Inserisci il primo numero: ");
    string num1Input = Console.ReadLine();
    isNum1Valid = double.TryParse(num1Input, out num1);
}
while (!isNum1Valid);  

Console.Write("Inserisci il secondo numero: ");
string num2Input = Console.ReadLine();
bool isNum2Valid = double.TryParse(num2Input, out double num2);

if (!isNum2Valid)
{
    Console.WriteLine("Il secondo numero inserito non è valido, ritenta.");
}
else if (num1 > num2)
{
    Console.WriteLine($"Il numero maggiore è: {num1}");
}
else if (num2 > num1)
{
    Console.WriteLine($"Il numero maggiore è: {num2}");
}
else
{
    Console.WriteLine("I due numeri sono uguali.");
}
