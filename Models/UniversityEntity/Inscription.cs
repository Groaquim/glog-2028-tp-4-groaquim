class Inscription
{
    int Id {get;set;}
    DateOnly Date {get;set;}
    public required Etudiant Etudiant {get;set;}
    public required Module Module {get;set;}
    Note Note {get;set;} 
}