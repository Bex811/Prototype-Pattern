namespace Prototype_Pattern.Examples
{
    // Definde the Prototype Interface
    public interface IPrototype<T>
    {
        T ShallowClone();
        T DeepClone();
    }

    //Build class to have reference object for demonstration purpose
    public class Recipe
    {
        public string Instructions { get; set; }

        public Recipe(string instructions)
        {
            Instructions = instructions;
        }
    }

    // Build class that implements the interface

    public class Bread : IPrototype<Bread>
    {
        public required string Type { get; set; }
        public required string Topping { get; set; }
        public int BakingTime { get; set; }

        public required Recipe Recipe { get; set; }

        public Bread ShallowClone()
        {
            // Buildin .net Method for producing shallow copies
            return (Bread)this.MemberwiseClone();
        }

        public Bread DeepClone()
        {
            return new Bread
            {
                Type = Type,
                Topping = Topping,
                BakingTime = BakingTime,
                Recipe = new Recipe(Recipe.Instructions)
            };
        }
    }

    public class Program
    {
        public static void Main()
        {
            var original = new Bread
            {
                Type = "Whole Grain",
                Topping = "Seeds",
                BakingTime = 40,
                Recipe = new Recipe("Bake at 200°C")
            };

            var shallow = original.ShallowClone();
            shallow.Recipe.Instructions = "Bake at 220°C";
            var deep = original.DeepClone();
            deep.Recipe.Instructions = "Bake at 180°C";

            //You will see that the original instruction adapts from the shallow copy
            //While the deep copy is independent
            Console.WriteLine(original.Recipe.Instructions);
            Console.WriteLine(shallow.Recipe.Instructions);
            Console.WriteLine(deep.Recipe.Instructions);

        }
    }
}
