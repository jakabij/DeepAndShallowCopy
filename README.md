Write a program to manage a Recipe list, e.g. model data stored in a recipe with a
Recipe class.
● Recipes should
  ○ have a positive, numeric identifier (ID), which should be unique among recipe
  object (but this doesn’t need to be enforced, try anyway!).
  ○ have a name represented with a string.
  ○ a list of ingredients represented with a list of strings (or array of strings for a little
  extra difficulty).
  ○ override the toString/ToString method to create a string representation of their
  contents.

● The recipe class should implement the Clonable or ICloneable interface so that it has a
clone/Clone method.

● Create a Main/Program class with a main/Main method and create 5 completely different
instances of the Recipe class, by using instantiation with the new operator.

● Print the instances directly (after creation) using System.out.println/Console.WriteLine.

● Then create 3 cloned Recipe.
  ○ Clone 3 existing recipe (choose 3 from the 5 created before).
  ○ Change the ID, name, and ingredients. Add new ingredients to the existing ones
and remove some old ones (be creative).

● After the changes are made print the 5 recipes created before and the 3 cloned ones.

What do you notice?

● The program doesn’t need to be interactive (no need to handle user input). You can
make it interactive however, that’s much more fun!
Depending on how you’ve implemented the class’ clone method (if it creates shallow or deep
copies) making changes on the cloned recipes changes the original elements. In the case of
deep copies, this shouldn’t happen.
