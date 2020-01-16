using System;
using System.Collections.Generic;

namespace ShallowAndDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> generatedIds = new List<int>();
            DataManager manager = new DataManager();


            //Here we add 5 instances of Recipes
            Recipe firstStew = new Recipe(manager.GenerateId(generatedIds), "Meat Stew", 
                new List<string>() { "onion", "carrot", "potato", "meat", "water", "salt", "pepper" });

            generatedIds.Add(firstStew.Id);
            Console.WriteLine(firstStew.Id+"; "+firstStew.Name+"; The ingredients:");
            firstStew.PrintIngredients(firstStew.Ingredients);
            Console.WriteLine();
            

            Recipe secondStew = new Recipe(manager.GenerateId(generatedIds), "Mushroom Stew", 
                new List<string>() { "onion", "mushroom", "meat", "water", "salt", "pepper" });

            generatedIds.Add(secondStew.Id);
            Console.WriteLine(secondStew.Id + "; " + secondStew.Name + "; The ingredients:");
            secondStew.PrintIngredients(secondStew.Ingredients);
            Console.WriteLine();


            Recipe omelet = new Recipe(manager.GenerateId(generatedIds), "Omelet", 
                new List<string>() {"oil", "onion", "eggs", "salt", "pepper" });

            generatedIds.Add(omelet.Id);
            Console.WriteLine(omelet.Id + "; " + omelet.Name + "; The ingredients:");
            omelet.PrintIngredients(omelet.Ingredients);
            Console.WriteLine();


            Recipe cheeseSticks = new Recipe(manager.GenerateId(generatedIds), "Cheese Sticks", 
                new List<string>() { "oil","onion", "cheese", "bun crum", "salt", "pepper" });

            generatedIds.Add(cheeseSticks.Id);
            Console.WriteLine(cheeseSticks.Id + "; " + cheeseSticks.Name + "; The ingredients:");
            cheeseSticks.PrintIngredients(cheeseSticks.Ingredients);
            Console.WriteLine();


            Recipe bologneseSpaghetti = new Recipe(manager.GenerateId(generatedIds), "Bolognese Spaghetti", 
                new List<string>() { "onion","meat","oil", "salt", "pepper","paste","tomatoes"});

            generatedIds.Add(bologneseSpaghetti.Id);
            Console.WriteLine(bologneseSpaghetti.Id + "; " + bologneseSpaghetti.Name + "; The ingredients:");
            bologneseSpaghetti.PrintIngredients(bologneseSpaghetti.Ingredients);
            Console.WriteLine();




            //Here comes the 3 clones and their printings too
            Recipe firstCloned = firstStew.Clone(firstStew, generatedIds);
            firstCloned.Name = "Stone Soup";
            firstCloned.Ingredients =new List<string>{"water","salt","pepper","stones" };
            Console.WriteLine(firstCloned.Id + "; " + firstCloned.Name + "; The ingredients:");
            firstCloned.PrintIngredients(firstCloned.Ingredients);
            Console.WriteLine();

            Recipe secondCloned = omelet.Clone(omelet, generatedIds);
            secondCloned.Name = "Roasted Onion";
            secondCloned.Ingredients.Remove("eggs");
            Console.WriteLine(secondCloned.Id + "; " + secondCloned.Name + "; The ingredients:");
            secondCloned.PrintIngredients(secondCloned.Ingredients);
            Console.WriteLine();

            Recipe thirdCloned = bologneseSpaghetti.Clone(bologneseSpaghetti, generatedIds);
            thirdCloned.Name = "Carbonara";
            thirdCloned.Ingredients.Insert(thirdCloned.Ingredients.IndexOf("tomatoes"),"cream");
            thirdCloned.Ingredients.Remove("tomatoes");
            Console.WriteLine(thirdCloned.Id + "; " + thirdCloned.Name + "; The ingredients:");
            thirdCloned.PrintIngredients(thirdCloned.Ingredients);
            Console.WriteLine();

            
            //to compare the datas cause of the copies
            Console.WriteLine(bologneseSpaghetti.Id + "; " + bologneseSpaghetti.Name + "; The ingredients:");
            bologneseSpaghetti.PrintIngredients(bologneseSpaghetti.Ingredients);
            Console.WriteLine();

        }
    }
}
