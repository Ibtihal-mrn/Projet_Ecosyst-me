using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Threading;
using Projet_ecosysteme.Models;

namespace Projet_ecosysteme;

public partial class MainWindow : Window
{
    private List<Animals> _animals = new List<Animals>(); //Liste pour stocker les animaux
    private Random _random = new Random();

    public MainWindow()
    {
        InitializeComponent();

        // Créer un animal avec une position initiale
        _animals = new List<Animals>();

        //Créer plusieurs animaux à l'aide d'une boucle 
        for (int i = 0; i<20; i++)
        {
            var x = _random.Next(0, (int)MyCanvas.Bounds.Width);
            var y = _random.Next(0, (int)MyCanvas.Bounds.Height);

            //Créer un rectangle pour l'animal
            var rectangle = new Avalonia.Controls.Shapes.Rectangle
            {
                Width = 10,
                Height = 10,
                Fill = new Avalonia.Media.SolidColorBrush(Avalonia.Media.Colors.Black)
            };

            MyCanvas.Children.Add(rectangle);

            //Créer une instance de la classe animals
            var animal = new Animals(x, y, rectangle);
            _animals.Add(animal); //Ajouter l'animal à la liste
        }

        // Déplacer les animaux périodiquement
        var timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(16) };
        timer.Tick += (sender, args) =>
        {
            var canvasWidth = MyCanvas.Bounds.Width;
            var canvasHeight = MyCanvas.Bounds.Height;

            foreach (var animal in _animals)
            {
                animal.Move(canvasWidth, canvasHeight);
            }
        };
        timer.Start();
    }
}
