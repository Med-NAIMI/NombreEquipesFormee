using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormerUneEquipe
{
    abstract class Traitement
    {
        public static int nbrEqupuipeForme(List<int> S,int M,int L, int U)
        {
            //selectionner les jooeurs qui verifient les conditions requises
            var joueursAccepte = S.Where(p => p >= L && p <= U).ToList();
            int N = M;//le nbr de joueurs pouvant former une equipe
            int nbrEquipe = 0;//le nbr d'equipe qu'onpeu former suivant les criteres données
            while(N<=joueursAccepte.Count)
            {
                //ajouter le nbr de combinaison pour N joeurs dans l'equipe
                nbrEquipe +=factorielle(joueursAccepte.Count)/(factorielle(N)*factorielle(joueursAccepte.Count-N));

                N++;//incrementer le nbr de joueurs par equipe 
            }

            return nbrEquipe;
        }

        private static int factorielle(int n)
        {
            int p = 1;
            for (int i=1; i <= n; i++)
                p*=i;
            return p;
        }
    }
}
