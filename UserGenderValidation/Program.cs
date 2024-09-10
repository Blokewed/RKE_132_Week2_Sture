Console.WriteLine("Please select your gender (m/f):");

char userGender = char.Parse(Console.ReadLine());
Console.WriteLine("Please, enter your name:");

string userName = Console.ReadLine();


if (userGender == 'm') 
{
    Console.WriteLine($"Welcome, Mr {userName}!");
}

else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms {userName}!");
}

else
{
    Console.WriteLine($"Welcome {userName}");
}
