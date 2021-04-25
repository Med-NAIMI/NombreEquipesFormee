using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormerUneEquipe
{
    class Program
    {
        static void Main(string[] args)
        {
            string continu = "oui"; //controler la saisie
            int i = 1;//numerotation des joueurs
            List<int> S = new List<int>();//la liste contenant les notes de joueurs
            int input;//variable intermédiaire pour la saisie
            while (continu=="oui")//la saisie se termine lorsque l utilisateur entre une valeur d'autre que "oui"
            {
                Console.WriteLine("entrez la note du joueur n° "+i);
                input = Convert.ToInt32(Console.ReadLine());
                S.Add(input);

                Console.WriteLine("entrez oui pour continuer la saisie des notes");
                continu= Console.ReadLine();
                i++;
            }

            //la saisie du nbr de joueurs au minimum par équipe
            int M;
            Console.WriteLine("entrez le nbr minimale de joueurs formant une equipe ");
            M = Convert.ToInt32(Console.ReadLine());

            //la saisie de la note minimale incluse requise pour sélectionner un joueur
            int L;
            Console.WriteLine("entrez la note minimale de joueurs acceptés");
            L = Convert.ToInt32(Console.ReadLine());

            //la saisie de la note maximale incluse requise pour sélectionner un joueur
            int U;
            Console.WriteLine("entrez la note maximale de joueurs acceptés");
            U = Convert.ToInt32(Console.ReadLine());

            int nbrEquipe=Traitement.nbrEqupuipeForme(S, M, L, U);
            Console.WriteLine("le nbr d'equipes est: "+nbrEquipe);

            Console.Read();
            Console.ReadKey();
            string c = Console.ReadLine();//pour conserver l'affichage
        }
    }
}
