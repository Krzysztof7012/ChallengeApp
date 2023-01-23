

var name = "Ewa";
var sex = "Female";
var age = 33;

if (sex == "Female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
if (sex != "Female" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Pełnoletni mężczyzna");
}
if (sex != "Female" && age == 52)
{
    Console.WriteLine("To potencjalnie może być Krzysztof");
}
else if (sex == "Female" && age < 52)
{
    Console.WriteLine("To z pewnością nie jest Krzysztof");
}