using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace libCptBq
{
    public class Compte
    {
        private  int numero;
        private string nom;
        private double solde;
        private double decouvertAutorise;

        public Compte()
        {
            numero = 0;
            nom = "";
            solde = 0;
            decouvertAutorise = 0;
        }
        public Compte(int numero, string nom, double solde, double decouvertAutorise)
        {
            this.numero = numero;
            this.nom = nom; 
            this.solde = solde; 
            this.decouvertAutorise = decouvertAutorise;
        }

        public int getNumero()
        {
            return numero;
        }

        public string getNom()
        {
            return nom;
        }

        public double getSolde() 
        {
            return solde;
        }

        public double getDecouvertAutorise()
        {
            return decouvertAutorise;
        }

        public override string ToString()
        {
            return $"Compte numéro : ,{numero}, Nom:{nom}, Solde ;{solde}, Decouvert : {decouvertAutorise}]";
        }

         public double crediter(double montant)
        {
            solde += montant;
            return solde;
        }

        public bool debiter(double montant )
        {
            bool flag = true;
            {
                if (solde - montant >= decouvertAutorise)
                {
                    solde -=montant;
                    return flag;
                }
                return false;
            }

          

        }
        public bool transferer(double montant,Compte b)
        {
            bool flag = true;
            {
                if ( solde -montant >= decouvertAutorise)
                {
                    b.crediter(montant);
                    this.debiter(montant);
                    return flag;
                }
                return false;
            }
        }
        public bool Superieur(Compte b)
        {
            bool flag = false;
            if(this.solde >  b.solde)
            {
                flag = true;
            }
            return flag;
        }













    }

}