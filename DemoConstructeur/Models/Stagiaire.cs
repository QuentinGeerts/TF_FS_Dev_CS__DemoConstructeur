namespace DemoConstructeur.Models;

public class Stagiaire : Personne
{
    // Constructeur vide (remplace le constructeur par défaut)
    public Stagiaire()
    {
        Console.WriteLine("Création d'un stagiaire");
    }

    public Stagiaire(string matricule, string lastName, string firstName, DateTime birthDate)
        : this (matricule, lastName, firstName, birthDate, 0)
    {
        //Matricule = matricule;
        //LastName = lastName;
        //FirstName = firstName;
        //BirthDate = birthDate;
    }

    public Stagiaire(string matricule, string lastName, string firstName, DateTime birthDate, double height)
        : base (firstName, lastName, birthDate, height)
    {
        Matricule = matricule;
        //LastName = lastName;
        //FirstName = firstName;
        //BirthDate = birthDate;
        //Height = height;
    }

    public string Matricule { get; set; } = string.Empty;
}
