/* Live coding 1:
 * 
 * 
 * 
 * 
 */

Console.WriteLine("PROGETTO BONUS!!!");

string[] iscritti = { "Luca", "Giovanni", "Paolo" };


// Ciclo for per stampare gli elementi a video

// Questo su C non è più consetito se si vuole stampare al volo un array.
// Console.WriteLine(iscritti);
Console.WriteLine();

Console.WriteLine("La lista degli iscritti al corso è:");

for (int i = 0; i < iscritti.Length; i++)
{
    Console.WriteLine((i + 1) + " - " + iscritti[i]);
}

Console.Write("Inserisci la posizione (indice) dell'iscritto di cui vuoi modifcare il nome: ");
string indexToEditString = Console.ReadLine();
int indexToEdit = int.Parse(indexToEditString);


while (indexToEdit < 0 || indexToEdit >= iscritti.Length)
{
    Console.Write("Mi dispiace, non hai inserito una posizione valida nell'array. Ritenta: ");
    indexToEditString = Console.ReadLine();
    indexToEdit = int.Parse(indexToEditString);
}

// Qui ora siete sicuri che l'indice che vi ha inserito l'utente è valido. Potete proseguire tranuqillamente...
Console.Write("Ok va bene, dimmi con che nome vuoi sostituire l'utente " + iscritti[indexToEdit] + ": ");

string acquiredNewName = Console.ReadLine();

iscritti[indexToEdit] = acquiredNewName;

Console.WriteLine("La lista aggiornata degli iscritti al corso ora è:");

for (int i = 0; i < iscritti.Length; i++)
{
    Console.WriteLine((i + 1) + " - " + iscritti[i]);
}


/*
// TODO: Controllare che la posizione inserita dall'utente esista nell'array...
if (indexToEditInt >= 0 && indexToEditInt < iscritti.Length)
{
    Console.Write("Ok va bene, dimmi con che nome vuoi sostituire l'utente " + iscritti[indexToEditInt] + ": ");

    string acquiredNewName = Console.ReadLine();

    iscritti[indexToEditInt] = acquiredNewName;

    Console.WriteLine("La lista aggiornata degli iscritti al corso ora è:");

    for (int i = 0; i < iscritti.Length; i++)
    {
        Console.WriteLine((i + 1) + " - " + iscritti[i]);
    }
} else
{
    Console.WriteLine("Mi dispiace, non hai inserito una posizione valida nell'array");
}
*/



