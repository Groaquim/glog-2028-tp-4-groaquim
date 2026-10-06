using System.Data.Common;
using System.Dynamic;

class Etudiant
{
    public required int Id {get;set;}
    string Prenom {get;set;}
    string Nom {get;set;}
    ICollection<Inscription> Inscriptions = [];
}