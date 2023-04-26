using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment4
{
    /// <summary>
    /// Class defining an array of recipes (Recipe objects) and performs operations on the list like e.g. adding, removing, editing recipes.
    /// </summary>
    /// <remarks>
    /// Class calls methods of the Recipe class when performing operations on a single object.
    /// </remarks>
    internal class RecipeManager
    {
        //instance variables
        private int numOfElements = 0; //num of elements with values
        const int maxNumOfElements = 200; //maximum number of elements(recipes) to be stored in an array
        const int maxNumOfIngredients = 50;

        private Recipe[] recipeList; //array of recipes instance variable declaration

        /// <summary>
        /// Provide access to all recipes.
        /// </summary>
        /// <returns></returns>
        public Recipe[] GetAllRecipes() { return recipeList; }


        /// <summary>
        /// Constructor
        /// </summary>
        public RecipeManager(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements]; //creates a new array object with length equal to maximum number of elements
            

        }

        /// <summary>
        /// Add Recipe object(with it's fields)into array of recipes
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool Add(Recipe recipe)
        {
            bool ok = false;
            //find the first vacant position
            int index = FindVacantPosition();

            //check so the array is not full
            if (numOfElements < recipeList.Length)
            {
                if (index != -1)
                {

                    recipeList[index] = recipe; //add recipe to the recipeList array

                    numOfElements++; //increment the elements count by one every time new recipe added

                    ok = true;
                }
            }
            return ok;
        }

        /// <summary>
        /// Find vacant position in an array
        /// </summary>
        /// <returns>integer index</returns>
        private int FindVacantPosition()
        {
            int index = -1; //not found
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] == null) //if empty
                {
                    index = i; //empty position found
                    break; //cancel iterations
                }
            }
            return index; //will -1 if not found
        }

        ///<summary>
        ///Delete element
        /// </summary>
        /// <param name="index"></param>
        public void DeleteElement(int index)
        {
            if (CheckIndex(index))
            {
                recipeList[index] = null; //set the value to null
                numOfElements--; //decrement the count of elements in the array
                MoveElementsOneStepLeft(index); //remove the empty spot left behind

            }

        }

        ///<summary>
        ///Check whether index exists = is 0 - recipeList.Length
        ///</summary>
        private bool CheckIndex(int index)
        {
            bool ok = false;
            if ((index >= 0) && (index < recipeList.Length))
            {
                ok = true;
            }
            return ok;
        }

        ///<summary>
        ///Move elements to the left to remove empty spots
        ///</summary>
        ///<param name="index"></param>
        private void MoveElementsOneStepLeft(int index)
        {
            for (int i = index; i < recipeList.Length - 2; i++)
            {
                recipeList[i] = recipeList[i + 1]; //move one step to left
            }

            recipeList[recipeList.Length - 1] = null; //empty last place
        }

        /// <summary>
        /// Retrieve an item (recipe) at a certain index
        /// </summary>
        /// <param name="index"></param>
        /// <returns>item(recipe)on certain index</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public Recipe GetRecipeAt(int index)
        {
            if (index < 0 || index > recipeList.Length) //if the index out of bounds (equal or greater than the length of the array = maxNumOfElements = 200) or less than zero
            {
               
                throw new IndexOutOfRangeException(); //throw error 

            }
            else
            {

                return recipeList[index]; //otherwise return the item on the index

            }

        }

        /// <summary>
        /// Change an existing value at a certain index with new value.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newValue"></param>
        /// <returns>bool ok</returns>
        public bool ChangeElement(int index, Recipe newValue)
        {
            bool ok = false;

            //validate index
            if (CheckIndex(index))
            {

                recipeList[index] = newValue; //the old value is overwritten
                ok = true;

            }

            return ok;
        }
    }



}
