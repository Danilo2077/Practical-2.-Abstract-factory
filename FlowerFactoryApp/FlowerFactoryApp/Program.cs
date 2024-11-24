using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FlowerFactoryLibrary1;

class Program
{
    static void Main()
    {
        // Створення фабрик
        FlowerFactory indoorFactory = new IndoorFlowerFactory();
        FlowerFactory gardenFactory = new GardenFlowerFactory();
        FlowerFactory wildFactory = new WildFlowerFactory();

        // Створення квітів за допомогою фабрик
        Flower indoorFlower = indoorFactory.CreateFlower();
        Flower gardenFlower = gardenFactory.CreateFlower();
        Flower wildFlower = wildFactory.CreateFlower();

        // Виведення типу квіток
        indoorFlower.ShowType();
        gardenFlower.ShowType();
        wildFlower.ShowType();
    }
}
