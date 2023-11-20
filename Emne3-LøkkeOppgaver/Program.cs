//Oppgave 1
Console.WriteLine("Oppgave 1:\n");
void forLoop()
{

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Terje er kul");
    }
}
forLoop();


Console.WriteLine();
Console.WriteLine("...................................................\n");


//Oppgave 2
Console.WriteLine("Oppgave 2:\n");
void forEachLoop()
{
    string array = "Hei på deg";

    foreach (char letter in array)
    {
        Console.WriteLine(letter);
    }
}
forEachLoop();


Console.WriteLine();
Console.WriteLine("...................................................\n");


//Oppgave 3
Console.WriteLine("Oppgave 3:\n");
void whileLoop()
{
    int i = 0;

    while (i < 10)
    {
        Console.WriteLine("Runde nr: " + i);
        i++;
    }
}
whileLoop();