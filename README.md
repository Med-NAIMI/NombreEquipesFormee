# NombreEquipesFormee
Énoncé :
Vous êtes un entraineur qui essaie d’assembler une équipe à partir d’une liste
des joueurs disponibles. Chaque joueur possède une note de compétence, et
vous devez recruter dans votre équipe au moins un nombre de joueurs qui a
une note dans une certaine range de notes.
Développer une méthode qui prend en paramètre :
∞ Une liste des entiers S, correspondant aux notes des joueurs.
∞ Un entier M, correspondant au nombre minimum des joueurs qui
forment une équipe.
∞ Un entier L, limite Inférieure incluse des notes des joueurs pouvant
intégrer l’équipe.
∞ Un entier U, limite supérieure incluse des notes des joueurs pouvant
intégrer l’équipe.
La méthode doit retourner le nombre total des nombres d’équipes que vous
pouvez former avec les critères donnés.
 Exemple :
Pour :
∞ S = { 12, 4, 6, 13, 5, 10 }.
∞ M = 3.
∞ L = 4.
∞ U = 10.
Dans notre exemple, 4 joueurs répondent aux critères, ce qui vous donne un
ensemble de { 4, 5, 6, 10 }. Il y a 5 équipes possibles avec 3 joueurs ou plus :
{ 4, 5, 6}
{ 4, 6, 10 }
{ 4, 5, 10 }
{ 5, 6, 10 }
{ 4, 5, 6, 10 }
Donc la méthode doit retourner 5.
