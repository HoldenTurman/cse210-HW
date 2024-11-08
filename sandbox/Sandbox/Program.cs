using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World!");

        Costume nurse = new();
        nurse.headWear = "face mask";
        nurse.gloves = "nitrile gloves";
        nurse.shoes = "orthopedic sneakers";
        nurse.upperGarment = "scrubs";
        nurse.lowerGarment = "scrubs";
        nurse.accessory = "stethoscope";

        Costume detective = new();
        detective.headWear = "fedora";
        detective.gloves = "leather";
        detective.shoes = "loafers";
        detective.upperGarment = "trenchcoat";
        detective.lowerGarment = "slacks";
        detective.accessory = "magnifying glass";

        Costume rancher = new();
        rancher.headWear = "cowboy hat";
        rancher.gloves = "work";
        rancher.shoes = "boots";
        rancher.upperGarment = "fancy vest";
        rancher.lowerGarment = "jeans";
        rancher.accessory = "lasso";

        nurse.ShowWardrobe();
        detective.ShowWardrobe();
        rancher.ShowWardrobe();
    }
}