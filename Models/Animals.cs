namespace Projet_ecosysteme.Models

/* Un animal doit pouvoir être capable de : 
        - Se déplacer 
        - Chasser 
        - Se nourrir 
        - Se reproduire 
        - Mourir (ça rentre dans la gestion de points de vie j'imagine*/

/* Il faut aussi leur permettre de gérer l'espace, il faut qu'ils puissent être en mesure de détecter si ils sont à proximité d'une femelle, d'une proie, de nourriture, ... */

{
    public class Animals
    {
        /* Définition des propriétés, des varaibles*/
        public string Name { get; set; }
        public int LifePoints{ get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }

        public void Move()
        {
            
        }

        public void Eat()
        {

        }

        public void ToReproduce()
        {

        }

        public void Hunt(){

        }

        public void Die(){

        }

    }
}
