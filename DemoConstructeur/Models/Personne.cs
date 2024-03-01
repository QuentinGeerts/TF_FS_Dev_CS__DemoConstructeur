namespace DemoConstructeur.Models;

public class Personne : IDisposable
{
    // Remplacé le constructeur par défaut PAR le constructeur vide
    public Personne()
    {
        Console.WriteLine("Création d'une personne");
    }

    // Surcharge
    public Personne (double height)
    {
        Height = height;
    }

    // Surcharge
    public Personne (string name)
    {
        LastName = name;
    }

    // Surcharge de constructeur
    public Personne(string lastName, string firstName, DateTime birthDate)
        : this()
    {
        LastName = lastName;
        FirstName = firstName;
        BirthDate = birthDate;
    }

    public Personne(string lastName, string firstName, DateTime birthDate, double height)
        : this (lastName, firstName, birthDate)
    {
        //LastName = lastName;
        //FirstName = firstName;
        //BirthDate = birthDate;
        Height = height;
    }

    public string LastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public double Height { get; set; }


    // Destructeur
    // Méthode appelée lors du nettoyage de l'objet (en mémoire)
    ~Personne() 
    {
        Console.WriteLine("Nettoyage de l'objet");
    }

    public void Dispose()
    {
        // Nettoyage...
        // Logs...
        throw new NotImplementedException();
    }
}
