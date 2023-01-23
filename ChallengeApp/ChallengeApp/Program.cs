

var name = "Ewa";
var sex = "Female";
var age = 52;

if (sex == "Female" && age < 30);
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
if (name == "Ewa" && age == 33);
{
    Console.WriteLine("Ewa, lat 33");
}
if (sex != "Female" && age < 18);
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
if (sex != "Female" && age == 52);
{
    Console.WriteLine("To potencjalnie może być Krzysztof");
}