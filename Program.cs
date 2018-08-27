using System;
using System.Collections.Generic;

public class Bug
{
    /*
        You can declare a typed public property, make it read-only,
        and initialize it with a default value all on the same
        line of code in C#. Readonly properties can be set in the
        class' constructors, but not by external code.
    */
    public string Name { get; } = "";
    public string Species { get; } = "";
    public ICollection<string> Predators { get; } = new List<string>();
    public ICollection<string> Prey { get; } = new List<string>();

    // Convert this readonly property to an expression member
    public string FormalName
    {
        get
        {
            return $"{this.Name} the {this.Species}";
        }
    }

    // Class constructor
    public Bug(string name, string species, List<string> predators, List<string> prey)
    {
        this.Name = name;
        this.Species = species;
        this.Predators = predators;
        this.Prey = prey;
    }

    // Convert this method to an expression member
    public string PreyList() => String.Join(", ", this.Prey);


    // Convert this method to an expression member
    public string PredatorList() => String.Join(", ", this.Predators);

    // Convert this to expression method (hint: use a C# ternary)
    public string Eat(string food)
    {
        return this.Prey.Contains(food) ? $"{this.Name} ate the {food}" : $"{this.Name} is still hungry" ;
        if (this.Prey.Contains(food))
        {
            return $"{this.Name} ate the {food}.";
        }
        else
        {
            return $"{this.Name} is still hungry.";
        }
    }

    public class Program
    {
        public static void Main()
        {

            Bug adelaide = new Bug("Adelaide", "Tiger", new List<string>(){"lions", "bears", "people"}, new List<string>(){"antelope", "deer", "apples"});
            System.Console.WriteLine(adelaide.Name);
        }
    }
}