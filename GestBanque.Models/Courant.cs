namespace GestBanque.Models;

public class Courant
{
    string Numero
    public double Solde;
    double LigneDeCredit
    Personne Titulaire = new Personne();

    public double getSolde()
    {
        return Solde
    }
    private void SetSolde(double value)
    {
        Solde = value;
    }

    public void Depot(double nombre)
    {
        SetSolde(getSolde() + nombre);
    }

    public void retrait(double nombre)
    {
        if (Solde - nombre > LigneDeCredit) { }
        SetSolde(getSolde() - nombre);
        else { return; }
    }
}


    
// repr�sentant la limite n�gative du compte strictement sup�rieur ou �gale � 0 ? 
