using System.Collections.Generic;
using System;

List<string> randomOrd = new List<string>() { "bananakak", "kyckling", "rulltårta", "atmosfäriskttryck" };
bool playing = true;

Random generator = new Random();
int RandomWord()
{
    return generator.Next(0, 2);
}

Console.WriteLine(randomOrd[RandomWord()]);
Console.WriteLine("Press any button to continue.");
Console.ReadLine();
Console.Clear();


while (playing == true)
{
    Dictionary<string, int> djurbanken = new();
    string answer = "placeholder";

    Console.WriteLine("Do you want to add a animal to the dictionary? yes/no");
    answer = Console.ReadLine().ToLower();

    if (answer == "yes")
    {
        Console.WriteLine("Type what animal you'd like to add.");

        string animalAnswer = Console.ReadLine().ToLower();

        Console.WriteLine("Now what is the maximum age of that animal in years?");

        string age = Console.ReadLine().ToLower();

        int animalAge;
        int.TryParse(age, out animalAge);

        djurbanken.Add(animalAnswer, animalAge);

        Console.WriteLine($"Dictionary now includes:");
        foreach (KeyValuePair<string, int> animal in djurbanken)
        {
            Console.WriteLine(animal.Key + " : " + animal.Value);
        }
    }
    Console.WriteLine("Press enter to continue.");
    Console.ReadLine();
    Console.Clear();



    Console.WriteLine("Do you want to continue playing? yes/no");

    string play = "placeholder";
    play = Console.ReadLine().ToLower();

    if (play == "no")
    {
        playing = false;
    }
    Console.Clear();
}