namespace WebApplication1.Models;

class Animal
{
    double weight{ get; set;}
    int age{ get; set;}
    double holdCost{ get; set;}

    public Animal(double Weight, int Age, double HoldCost)
    {
        weight = Weight;
        age = Age;
        holdCost = HoldCost;
    }
    public string Info()
    {
        return weight+" " + age+" " + holdCost;
    }
};