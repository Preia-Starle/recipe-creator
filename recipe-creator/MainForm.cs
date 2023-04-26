using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.LinkLabel;

namespace Assignment4
{
    /// <summary>
    /// Starting object to provide an interface for inputting and displaying most of the information related to recipes.
    /// </summary>
    public partial class MainForm : Form
    {
        const int maxNumOfElements = 200; //max number of elements in the recipe list
        const int maxNumOfIngredients = 50; //max number of ingredients in the ingredients list

        private RecipeManager recipeMngr = new RecipeManager(maxNumOfElements); //array of recipe objects

        private Recipe currRecipe = new Recipe(maxNumOfIngredients); //current recipe object



        /// <summary>
        /// Constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }



        /// <summary>
        /// Set defaults related to GUI.
        /// </summary>
        public void InitializeGUI()
        {
            cmbFoodCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
            lblSeeIntsructions.Text = "Double click on an item for ingredients and cooking instructions.";
            //assign event handler
            lstRecipe.MouseDoubleClick += new MouseEventHandler(lstRecipe_DoubleClick);
        }

        /// <summary>
        /// Updates GUI with new input.
        /// </summary>
        private void UpdateGUI()
        {
            lstRecipe.Items.Clear();
            foreach (Recipe iteratedRecipe in recipeMngr.GetAllRecipes())
            {
                if (iteratedRecipe != null)
                {
                    lstRecipe.Items.Add(iteratedRecipe.Name.PadRight(55) + iteratedRecipe.Category.ToString().PadRight(35) + iteratedRecipe.CurrentNumberOfIngredients()); //add to listbox to display on GUI
                }

            }
        }


        /// <summary>
        /// Add item into array of items after click on Add Recipe button
        /// </summary>
        /// <remarks>
        /// Performs also dditional operations related to GUI: add item to listbox, clear textboxes after add performed
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            //validate name and description input
            if (txtRecipeName.Text.Length > 0 && txtDescription.Text.Length > 0)
            {
                //validate ingredients input
                if (currRecipe.CurrentNumberOfIngredients() <= 0)
                {

                    MessageBox.Show("No Ingredients provided. Click Add Ingredients button and provide ingredients.", "Error");

                }
                else
                {

                    //get the input from the input fields and save into a variable
                    currRecipe.Name = txtRecipeName.Text;
                    currRecipe.Description = txtDescription.Text;
                    currRecipe.Category = (FoodCategory)cmbFoodCategory.SelectedItem; //get the selected item
                    currRecipe.Ingredients = currRecipe.Ingredients;

                    //add items to the recipes list array
                    recipeMngr.Add(currRecipe);
                    UpdateGUI(); //refresh

                    //clear the textboxes after item saved so they are ready for next input
                    txtRecipeName.Clear();
                    txtDescription.Clear();

                    //create new curr recipe object after finishing each recipe
                    currRecipe = new Recipe(maxNumOfIngredients);
                }
            }
            else
            {
                MessageBox.Show("Provide input. Fields cannot be empty.", "Error");

            }
        }

        /// <summary>
        /// Display a message box with ingredients and description of the selected (double clicked) recipe.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstRecipe_DoubleClick(object sender, MouseEventArgs e)
        {
            //validate index
            if (lstRecipe.SelectedIndex != -1)
            {
                string popupText = string.Empty;
                int indexRecipe = (int)lstRecipe.SelectedIndex; //get the index of the selected element
                Recipe selectedRecipe = recipeMngr.GetRecipeAt(indexRecipe); //get the selected recipe from the recipe array and save in a variable
                popupText = "INGREDIENTS: ";

                string[] ingredients = selectedRecipe.Ingredients;

                //validate
                if (ingredients != null)
                {
                    //ietrate through ingredients and add each item to popupText to be displayed on the GUI
                    foreach (string iteratedIngredient in ingredients)
                    {
                        if (iteratedIngredient != null)
                        {
                            popupText += iteratedIngredient + ", ";
                        }
                    }
                }

                popupText += Environment.NewLine; //add line break
                popupText += selectedRecipe.Description;

                MessageBox.Show(popupText, "Cooking Instructions"); //display output in a message box

            }
        }


        /// <summary>
        /// Delete item after click on delete button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstRecipe.SelectedIndex != -1) //check if the index actually exists
            {
                int selectedIndex = (int)lstRecipe.SelectedIndex; //get the index of the selected item
                recipeMngr.DeleteElement(selectedIndex); //call a delete element method on the index
                UpdateGUI();
            }
        }

        /// <summary>
        /// Generates an ingredient form GUI for user to input ingredients.
        /// Waits for dialog OK from ingredients form. If ok...
        /// Recreates curr Recipe variable and fills with ingredients to be passed to recipe manager to fill with data from main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            //create new ingredients form
            IngredientsForm frm = new IngredientsForm(currRecipe);

            //check if some values already added previously 
            if (currRecipe.Ingredients != null)
            {
                frm.InitializeGUI(); //display the previously inputed values
                DialogResult frmResult = frm.ShowDialog(); //open as a dialog box

                //Manages case where user clicks ok button
                if (frmResult == DialogResult.OK)
                {

                    currRecipe.Ingredients = frm.Recipe.GetAllIngredients();

                    if (currRecipe.CurrentNumberOfIngredients() <= 0)
                    {
                        MessageBox.Show("No ingredients specified.", "Error");
                    }

                }
            }
            else
            {
                //if no values provided previously show empty form
                DialogResult frmResult = frm.ShowDialog(); //open as a dialog box

                //Manages case where user clicks ok button
                if (frmResult == DialogResult.OK)
                {

                    currRecipe.Ingredients = frm.Recipe.GetAllIngredients(); //save provided input

                    if (currRecipe.CurrentNumberOfIngredients() <= 0)
                    {
                        MessageBox.Show("No ingredients specified.", "Error");
                    }

                }

            }
        }

        /// <summary>
        /// Clear selection, cancel editing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //unselect selected
            lstRecipe.ClearSelected();

            //clear textfields
            txtRecipeName.Text = string.Empty;
            txtDescription.Text = string.Empty;

            //enable buttons
            btnEditBegin.Enabled = true;
            btnDelete.Enabled = true;
            btnAddRecipe.Enabled = true;

        }

        /// <summary>
        /// Move elements from selected item to the textboxes to be edited. 
        /// </summary>
        /// <remarks>
        /// Disable some potentially intrusive buttons in the main form while editting. Leave open only Edit Finish to finalise editing or Clear selection to cancel the edit.
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditBegin_Click(object sender, EventArgs e)
        {
            //validate index
            if (lstRecipe.SelectedIndex != -1)
            {
                //1.get the selected recipe
                int indexRecipe = (int)lstRecipe.SelectedIndex; //get the index of the selected recipe
                Recipe selectedRecipe = recipeMngr.GetRecipeAt(indexRecipe); //get the recipe on the selected index and save into variable
                //2.set the status of editing on
                selectedRecipe.EditModeOn = true;
                //3a.move the selected recipe elements to the left input fields to be edited
                txtRecipeName.Text = selectedRecipe.Name;
                txtDescription.Text = selectedRecipe.Description;
                cmbFoodCategory.SelectedItem = selectedRecipe.Category;

                //3b. generate a new ingredients form and copy items inside the listbox
                IngredientsForm editFrm = new IngredientsForm(selectedRecipe);
                editFrm.InitializeGUI();
                DialogResult editFrmResult = editFrm.ShowDialog();

                //manage case where user clicks ok button
                if (editFrmResult == DialogResult.OK)
                {

                    currRecipe.Ingredients = editFrm.Recipe.GetAllIngredients(); //get all ingredients

                    //validate input
                    if (selectedRecipe.CurrentNumberOfIngredients() <= 0 && currRecipe.CurrentNumberOfIngredients() <= 0)
                    {
                        MessageBox.Show("No ingredients specified.", "Error");
                    }

                }
                //4.disable buttons while editting
                btnAddRecipe.Enabled = false;
                btnDelete.Enabled = false;
                btnEditBegin.Enabled = false;
            }
            else
            {

                MessageBox.Show("Please select a recipe to begin editing.", "Error");
            }
        }

        /// <summary>
        /// Replaces selected recipe elements with new values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditFinish_Click(object sender, EventArgs e)
        {
            //validate index
            if (lstRecipe.SelectedIndex != -1)
            {
                int indexRecipe = (int)lstRecipe.SelectedIndex; //get the index of the selected item
                Recipe selectedRecipe = recipeMngr.GetRecipeAt(indexRecipe); //get the recipe on the selected index and save into variable

                //validate editing status (if editting in progress)
                if (selectedRecipe.EditModeOn == true)
                {
                    //validate input
                    if (txtRecipeName.Text.Length > 0 && txtDescription.Text.Length > 0 && currRecipe.CurrentNumberOfIngredients() > 0)
                    {
                        //assign new value
                        currRecipe.Name = txtRecipeName.Text;
                        currRecipe.Description = txtDescription.Text;
                        currRecipe.Category = (FoodCategory)cmbFoodCategory.SelectedItem; //get the selected item
                        currRecipe.Ingredients = currRecipe.Ingredients;

                        recipeMngr.ChangeElement(indexRecipe, currRecipe); //call a method that changes recipe at a certain index and replaces it with a new value
                        lstRecipe.Items.RemoveAt(indexRecipe); //remove the old item from the listbox on the GUI
                        UpdateGUI();

                        //clear the textboxes so it is ready for next input
                        txtRecipeName.Clear();
                        txtDescription.Clear();

                        currRecipe = new Recipe(maxNumOfIngredients);

                        //enable all buttons again
                        btnEditBegin.Enabled = true;
                        btnDelete.Enabled = true;
                        btnAddRecipe.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Please provide input. Name, Description or Ingredients cannot be empty.", "Error");
                    }

                }
                else
                {
                    MessageBox.Show("Please select Edit-Begin first to begin editing.", "Error");
                }
            }
        }
    }
}


