using System;
using System.Collections.Generic;
using System.Text;

namespace ShallowAndDeepCopy
{
    class Recipe : Cloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }

        public Recipe(int id,string name, List<string> ingredients)
        {
            Id = id;
            Name = name;
            Ingredients = ingredients;
        }


        public void PrintIngredients(List<string> ingredients)
        {
            for (int count = 0; count < ingredients.Count; count++)
            {
                Console.WriteLine("\t" + ingredients[count]);
            }
        }

        public Recipe Clone(Recipe toClone,List<int> alreadyGeneratedIds)     //this will clone as DeepCopy
        {
            DataManager manager = new DataManager();
            List<string> ingredientsCopy = new List<string>();
            for(int count=0;count<toClone.Ingredients.Count;count++)
            {
                ingredientsCopy.Add(toClone.Ingredients[count]);
            }


            Recipe deepCopyRecipe = new Recipe(manager.GenerateId(alreadyGeneratedIds), toClone.Name, ingredientsCopy);
            return deepCopyRecipe;

            //return (Recipe)toClone.MemberwiseClone();
        }
    }
}
