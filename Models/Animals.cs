using System;
using Avalonia.Controls.Shapes;
using Avalonia.Controls;

namespace Projet_ecosysteme.Models
{
    public class Animals
    {
        // Positions de l'animal
        public double XPosition { get; set; }
        public double YPosition { get; set; }

        //Vitesse de l'animal
        public double XSpeed { get; set; }
        public double YSpeed { get; set; }

        //Forme de l'animal
        public Rectangle AnimalShape { get; set; }
        private Random _random = new Random();

        //Constructeur 
        public Animals(int initialX, int initialY, Rectangle animalShape)
        {
            XPosition = initialX;
            YPosition = initialY;
            AnimalShape = animalShape;

            XSpeed = _random.NextDouble() * 2 - 1;
            YSpeed = _random.NextDouble() * 2 - 1;

            Canvas.SetLeft(AnimalShape, XPosition);
            Canvas.SetTop(AnimalShape, YPosition);
        }

        public void Move(double canvasWidth, double canvasHeight)
        {
            // La position est mise à jour en fonction de la vitesse 
            XPosition += XSpeed;
            YPosition += YSpeed;

            // Permet de gérer les bords de la fenêtre pour éviter que l'animal ne sorte
            // Dans mon cas il rebondit, mais je peux changer la logique pour faire en sorte qu'il réapparait de l'autre côté
            if (XPosition <= 0 || XPosition >= canvasWidth - AnimalShape.Width)
            {
                XSpeed = -XSpeed;
                XPosition = Math.Clamp(XPosition, 0, canvasWidth - AnimalShape.Width);
            }

            if (YPosition <= 0 || YPosition >= canvasHeight - AnimalShape.Height)
            {
                YSpeed = -YSpeed;
                YPosition = Math.Clamp(YPosition, 0, canvasHeight - AnimalShape.Height);
            }

            Canvas.SetLeft(AnimalShape, XPosition);
            Canvas.SetTop(AnimalShape, YPosition);
        }
    }
}
