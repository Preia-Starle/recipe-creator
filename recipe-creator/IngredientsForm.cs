using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// Class providing interface for inputting ingredients.
    /// </summary>
    internal partial class IngredientsForm : Form
    {
        const int maxNumOfIngredients = 50; //max number of ingredients in th list

        private Recipe recipe;

        /// <summary>
        /// Constructor taking a parameter recipe from the Main Form.
        /// </summary>
        public IngredientsForm(Recipe recipe)
        {
            InitializeComponent();
            Recipe = recipe;

        }

        /// <summary>
        /// Redraw GUI with updated input.
        /// </summary>
        /// <remarks>
        /// Call a method Update GUI that does the redrawing based on the current state.
        /// </remarks>
        public void InitializeGUI()
        {
            UpdateGUI();
        }


        /// <summary>
        /// Updates GUI with new input.
        /// </summary>
        private void UpdateGUI()
        {
            foreach (string iteratedIngredient in Recipe.GetAllIngredients())
            {
                //validate
                if (iteratedIngredient != null)
                {
                    lstIngredients.Items.Add(iteratedIngredient); //add to listbox to display on GUI
                    int currentIngredientCount = lstIngredients.Items.Count;//count ingredients
                    lblCurrNumber.Text = currentIngredientCount.ToString(); //display current number of ingredients
                }
            }
        }

        /// <summary>
        /// Property that gives get and set access to Recipe.
        /// </summary>
        public Recipe Recipe
        {
            get
            {
                return recipe;
            }
            set
            {
                recipe = value;
            }
        }


        /// <summary>
        /// Add inputed ingredient into an ingredients array and updates listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNameIngredient.Text.Length > 0)
            {
                string ingredientsName = txtNameIngredient.Text;
                Recipe.AddIngredient(ingredientsName); //add items to the recipe array
                UpdateGUI();
                txtNameIngredient.Clear();  //clear the textbox after item saved so it is ready for next input
            } else
            {
                MessageBox.Show("Please write in ingredient.", "Erorr");
            }
        }

        /// <summary>
        /// Delete selected ingredient.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedIndex != -1) //validate index (check if the index actually exists)
            {
                int selectedIndex = (int)lstIngredients.SelectedIndex; //get the index of the selected item
                Recipe.DeleteIngredientAt(selectedIndex); //call a delete element method on the index
                lstIngredients.Items.RemoveAt(selectedIndex); //remove the item from the list on the GUI
                int currentIngredientCount = lstIngredients.Items.Count; //count ingredients
                lblCurrNumber.Text = currentIngredientCount.ToString(); //display count on GUI



            }
        }

        /// <summary>
        /// Replace an item on selected position with a new value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstIngredients.SelectedIndex != -1) //validate index (check if the index actually exists)
            {

                int selectedIndex = (int)lstIngredients.SelectedIndex; //get the index of the selected item
                string newValue = txtNameIngredient.Text; //save the new input value into a variable
                //validate input value
                if (newValue.Length > 0)
                {
                    Recipe.ChangeIngredientsAt(selectedIndex, newValue); //call a method that changes ingredient at a certain index and replaces it with a new value
                    lstIngredients.Items.RemoveAt(selectedIndex); //remove the old item from the listbox on the GUI
                    lstIngredients.Items.Insert(selectedIndex, newValue); //insert the new item into the empty index
                    txtNameIngredient.Clear(); //clear the textbox so it is ready for next input
                }
                else
                {
                    MessageBox.Show("No new ingredient provided. Please input a new ingredient.", "Error");
                }
            }
        }

        /// <summary>
        /// Cancel the selection and edit in progress on cancel click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstIngredients.ClearSelected();
            txtNameIngredient.Clear();
        }

        /// <summary>
        /// Save the inputed ingredients data and inform the main form of the result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            string[] ingredientsList = new string[maxNumOfIngredients];
            lstIngredients.Items.CopyTo(ingredientsList, 0);
            Recipe.Ingredients = ingredientsList;
            this.DialogResult = DialogResult.OK; //assign this dialog result to dialog result check in the main form
            this.Close(); //close the form
        }



    }
}
