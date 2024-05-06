namespace WebApplication1.Models;

class Wolf : Animal
{
    string breed{get; set; }
    string habitat{get; set; }

    public Wolf(sring Breed,string Habitat) : base Animal
    {    
        
    }

    string Info() 
    {
        return Animal.Info() + breed + habitat;
    }
}