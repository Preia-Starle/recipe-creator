using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// Class that handles the part related to the recipe creation and defines a recipe with name, category, ingredients and description.
    /// </summary>
    /// <remarks>
    /// All user input in the form of text is stored in this instance variable.
    /// </remarks>
    internal class Recipe
    {
        //instance variables
        private string name;
        private string description;
        private FoodCategory category;
        private string[] ingredients;

        private bool editModeOn = false; //edit mode status

        const int maxNumOfIngredients = 50;

        int numOfElements = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public Recipe(int maxNumOfIngredients)
        {
            Name = name;
            Description = description;
            Category = category;
            Ingredients = ingredients;
            EditModeOn = false;
        }

        /// <summary>
        /// Provide access to all ingredients.
        /// </summary>
        /// <returns></returns>
        public string[] GetAllIngredients() { return ingredients; }

        ///<summary>
        ///Property that gives read and write access to variable name.
        ///</summary>

        public string Name
        {
            get //read access
            {
                return name;
            }
            set //write access 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value; //changes value of name
                }
            }
        }
        ///<summary>
        ///Property that gives read and write access to variable description.
        ///</summary>
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value; //changes value of name
                }
            }
        }

        ///<summary>
        ///Property that gives read and write access to variable category.
        ///</summary>
        public FoodCategory Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        ///<summary>
        ///Property that gives read and write access to variable ingredients.
        ///</summary>
        public string[] Ingredients
        {
            get
            {
                return ingredients;
            }
            set
            {
                ingredients = value;
            }
        }

        /// <summary>
        /// Property providing read and write access to edit mode status.
        /// </summary>
        public bool EditModeOn
        {
            get
            {
                return editModeOn;
            }
            set
            {
                editModeOn = value;
            }
        }

        /// <summary>
        /// Add ingredient to the ingredients array.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool AddIngredient(string input)
        {
            bool ok = false;
            //create a new ingredients array with a length of max number of ingredients
            ingredients = new string[maxNumOfIngredients];
            //find the first vacant position
            int index = FindVacantPosition();

            //validate index
            if (index != -1)
            {
                ingredients[index] = input; //assign value of input to the found vacant index in the ingredients array
                numOfElements++; //increment the elements count by one every time new recipe added
                ok = true;
            }

            return ok;
        }

        /// <summary>
        /// Find first vacant position in the ingredients array.
        /// </summary>
        /// <returns></returns>
        private int FindVacantPosition()
        {
            int index = -1; //not found
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i] == null) //if empty
                {
                    index = i; //empty position found
                    break; //cancel iterations
                }
            }
            return index; //will -1 if not found
        }

        /// <summary>
        /// Delete item on a certain index.
        /// </summary>
        /// <param name="index"></param>
        public void DeleteIngredientAt(int index)
        {
            if (CheckIndex(index))
            {
                ingredients[index] = null; //set the value to null
                MoveElementsOneStepLeft(index); //get rid of the empty spot left behind

            }
        }

        ///<summary>
        ///Check whether index exists = is 0 - array.Length
        ///</summary>
        private bool CheckIndex(int index)
        {
            bool ok = false;
            if ((index >= 0) && (index < ingredients.Length))
            {
                ok = true;
            }
            return ok;
        }

        /// <summary>
        /// Change an existing value at a certain index with new value.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public bool ChangeIngredientsAt(int index, string newValue)
        {
            bool ok = false;

            //validate index
            if (CheckIndex(index))
            {

                ingredients[index] = newValue; //the old value is overwritten
                ok = true;

            }

            return ok;
        }

        /// <summary>
        /// Get current number of ingredients.
        /// </summary>
        /// <returns>int count = number of ingredients</returns>
        public int CurrentNumberOfIngredients()
        {
            int count = 0;
            if (ingredients != null)
            {
                foreach (string ingredient in ingredients)
                {
                    if (ingredient != null)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// Move elements to the left to remove empty slots.
        /// </summary>
        /// <param name="index"></param>
        private void MoveElementsOneStepLeft(int index)
        {
            for (int i = index; i < ingredients.Length - 2; i++)
            {
                ingredients[i] = ingredients[i + 1]; //move one step to left
            }

            ingredients[ingredients.Length - 1] = null; //empty last place
        }
    }
}
