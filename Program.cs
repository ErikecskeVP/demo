//Páros számok összege
Console.Write("Az intervallum also vegpontja:");
int elso = int.Parse(Console.ReadLine());
Console.Write("Az intervallum felso vegpontja:");
int utolso=int.Parse(Console.ReadLine());

int paros_osszeg = 0;

for (int j = elso; j <= utolso; j++)
{
    if (j % 2 == 0)
    {
        paros_osszeg+=j;
    }

}

Console.WriteLine($"\nA(z) [{elso},{utolso}] intervallumba eso paros szamok osszege: {paros_osszeg}");



//Príma nyereményjáték
Console.Write("Adj meg egy egész számot: ");
int szam = int.Parse(Console.ReadLine());

int osztok = 0;

for (int i = 1; i <= szam; i++)
{
    if   (szam%i==0){
        osztok++;
    }
    if (szam % i == szam)
    {
        osztok++;
    }
}

if (osztok == 2)
{
    Console.WriteLine("\tGratulalok, nyertel!");
}
else
{
    Console.WriteLine("\tSajnos nem nyert!");
}

