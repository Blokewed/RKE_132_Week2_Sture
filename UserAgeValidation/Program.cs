Console.WriteLine("Please enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum}.");

if (isAgeNumber)
{
    if (userAgeNum >=13)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram");
    }
}

else
{
    Console.WriteLine("Could not verify your age.");
}



