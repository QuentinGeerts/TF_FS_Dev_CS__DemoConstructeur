using DemoConstructeur.Models;
using System.Data.SqlClient;

Personne p1 = new Personne(); // Constructeur vide
p1.LastName = "Geerts";
p1.FirstName = "Quentin";
p1.BirthDate = DateTime.Now;

Personne p2 = new Personne() // Constructeur vide
{
    LastName = "Geerts",
    FirstName = "Quentin",
    BirthDate = DateTime.Now
};

Personne p3 = new Personne("Geerts", "Quentin", DateTime.Now);
p3.Height = 1.80;


Personne p4 = new Personne("Geerts", "Quentin", DateTime.Now, 1.80);


Stagiaire s1 = new Stagiaire(); // Constructeur par défault
Stagiaire s2 = new Stagiaire()
{
    Matricule = "S001",
    BirthDate = DateTime.Now, 
    FirstName = "Quentin", 
    LastName = "Geerts"
};

Stagiaire s3 = new Stagiaire("S002", "Geerts", "Quentin", DateTime.Now);
Stagiaire s4 = new Stagiaire("S003", "Geerts", "Quentin", DateTime.Now, 1.80);



// Interface IDisposable => Dispose()
// Permet de rendre éligible au nettoyage une fois l'accolade de fin atteint
using (SqlConnection sql = new SqlConnection()) 
{

} // Appelé la méthode Dispose()