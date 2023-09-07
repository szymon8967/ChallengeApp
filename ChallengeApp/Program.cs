var imie = "Ewa";
char plec = 'k';
var wiek = 33;

if (plec == 'k' && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (imie == "Ewa" && wiek == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (wiek < 18 && plec == 'm')
{ 
    Console.WriteLine("Niepełnoletni Mężczyzna");
}