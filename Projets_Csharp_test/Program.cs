// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!"); //comme le console.log()

int num1 = 0; int num2 = 0;

// Afficher le titre en tant qu'application de calculatrice de la console C#.
Console.WriteLine("console Calculatrice de C#");
Console.WriteLine("---------------------------");


// Demandez à l'utilisateur de taper le premier nombre.
Console.WriteLine("Tapez un nombre (1), puis appuyez sur Entrée");
num1 = Convert.ToInt32(Console.ReadLine()); //console.readline sert à lire la ligne de caractères suivante.

// Demandez à l'utilisateur de taper le deuxième nombre.
Console.WriteLine("Tapez un nombre (2), puis appuyez sur Entrée");
num2 = Convert.ToInt32(Console.ReadLine()); 

// Demande à l'utilisateur de choisir une option.
Console.WriteLine("\"Choisissez une option dans la liste suivante :\"");
Console.WriteLine("\ta - Ajouter");
Console.WriteLine("\ts - Soustraire");
Console.WriteLine("\tm - Multiplier");
Console.WriteLine("\td - Diviser");
Console.Write("Votre choix ? ");

// Utilisez une instruction switch pour faire le calcul.


// Demandez à l'utilisateur d'entrer un diviseur non nul jusqu'à ce qu'il le fasse.
while (num2 == 0)
{
    Console.WriteLine("Entrez un diviseur non nul :");
    num2 = Convert.ToInt32(Console.ReadLine());
}

switch (Console.ReadLine())
{

    case "a":
        Console.WriteLine($"Ton résultat: {num1} + {num2} = " + (num1 + num2));
        break;

    case "b":
        Console.WriteLine($"Ton résultat: {num1} _ {num2} = " + (num1 - num2));
        break;

    case "c":
        Console.WriteLine($"Ton résultat: {num1} * {num2} = " + (num1 * num2));
        break;

    case "d":
        Console.WriteLine($"Ton résultat: {num1} / {num2} = " + (num1 / num2));
        break;
}

// Attendre que l'utilisateur réponde avant de fermer.

Console.Write("Appuyez sur n'importe quelle touche pour fermer l'application de la console Calculatrice...");
Console.ReadKey(); //fermer la console
