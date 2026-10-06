class Module
{
    int Id {get;set;}
    string Intitule {get;set;}
    int Credits {get;set;}
    ICollection<Inscription> Inscriptions = [];
}