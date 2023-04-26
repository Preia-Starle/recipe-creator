namespace Assignment4
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAddRecipe = new System.Windows.Forms.GroupBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbFoodCategory = new System.Windows.Forms.ComboBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblNameRecipe = new System.Windows.Forms.Label();
            this.lstRecipe = new System.Windows.Forms.ListBox();
            this.btnEditBegin = new System.Windows.Forms.Button();
            this.btnEditFinish = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblListRecipe = new System.Windows.Forms.Label();
            this.lblListCategory = new System.Windows.Forms.Label();
            this.lblListNumIngredients = new System.Windows.Forms.Label();
            this.lblSeeIntsructions = new System.Windows.Forms.Label();
            this.grpAddRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddRecipe
            // 
            this.grpAddRecipe.Controls.Add(this.btnAddRecipe);
            this.grpAddRecipe.Controls.Add(this.btnAddIngredient);
            this.grpAddRecipe.Controls.Add(this.txtDescription);
            this.grpAddRecipe.Controls.Add(this.lblCategory);
            this.grpAddRecipe.Controls.Add(this.cmbFoodCategory);
            this.grpAddRecipe.Controls.Add(this.txtRecipeName);
            this.grpAddRecipe.Controls.Add(this.lblNameRecipe);
            this.grpAddRecipe.Location = new System.Drawing.Point(24, 12);
            this.grpAddRecipe.Name = "grpAddRecipe";
            this.grpAddRecipe.Size = new System.Drawing.Size(346, 426);
            this.grpAddRecipe.TabIndex = 0;
            this.grpAddRecipe.TabStop = false;
            this.grpAddRecipe.Text = "Add new recipe";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(27, 368);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(297, 23);
            this.btnAddRecipe.TabIndex = 6;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(230, 75);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(94, 23);
            this.btnAddIngredient.TabIndex = 5;
            this.btnAddIngredient.Text = "Add Ingredients";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(27, 130);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(297, 218);
            this.txtDescription.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 83);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
            // 
            // cmbFoodCategory
            // 
            this.cmbFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFoodCategory.FormattingEnabled = true;
            this.cmbFoodCategory.Location = new System.Drawing.Point(93, 77);
            this.cmbFoodCategory.Name = "cmbFoodCategory";
            this.cmbFoodCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbFoodCategory.TabIndex = 2;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(93, 31);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(231, 20);
            this.txtRecipeName.TabIndex = 1;
            // 
            // lblNameRecipe
            // 
            this.lblNameRecipe.AutoSize = true;
            this.lblNameRecipe.Location = new System.Drawing.Point(6, 38);
            this.lblNameRecipe.Name = "lblNameRecipe";
            this.lblNameRecipe.Size = new System.Drawing.Size(79, 13);
            this.lblNameRecipe.TabIndex = 0;
            this.lblNameRecipe.Text = "Name of recipe";
            // 
            // lstRecipe
            // 
            this.lstRecipe.FormattingEnabled = true;
            this.lstRecipe.Location = new System.Drawing.Point(389, 50);
            this.lstRecipe.Name = "lstRecipe";
            this.lstRecipe.Size = new System.Drawing.Size(399, 316);
            this.lstRecipe.TabIndex = 1;
            // 
            // btnEditBegin
            // 
            this.btnEditBegin.Location = new System.Drawing.Point(389, 380);
            this.btnEditBegin.Name = "btnEditBegin";
            this.btnEditBegin.Size = new System.Drawing.Size(94, 23);
            this.btnEditBegin.TabIndex = 6;
            this.btnEditBegin.Text = "Edit-Begin";
            this.btnEditBegin.UseVisualStyleBackColor = true;
            this.btnEditBegin.Click += new System.EventHandler(this.btnEditBegin_Click);
            // 
            // btnEditFinish
            // 
            this.btnEditFinish.Location = new System.Drawing.Point(489, 380);
            this.btnEditFinish.Name = "btnEditFinish";
            this.btnEditFinish.Size = new System.Drawing.Size(94, 23);
            this.btnEditFinish.TabIndex = 7;
            this.btnEditFinish.Text = "Edit-Finish";
            this.btnEditFinish.UseVisualStyleBackColor = true;
            this.btnEditFinish.Click += new System.EventHandler(this.btnEditFinish_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(594, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(694, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Selection";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblListRecipe
            // 
            this.lblListRecipe.AutoSize = true;
            this.lblListRecipe.Location = new System.Drawing.Point(397, 21);
            this.lblListRecipe.Name = "lblListRecipe";
            this.lblListRecipe.Size = new System.Drawing.Size(35, 13);
            this.lblListRecipe.TabIndex = 10;
            this.lblListRecipe.Text = "Name";
            // 
            // lblListCategory
            // 
            this.lblListCategory.AutoSize = true;
            this.lblListCategory.Location = new System.Drawing.Point(635, 21);
            this.lblListCategory.Name = "lblListCategory";
            this.lblListCategory.Size = new System.Drawing.Size(49, 13);
            this.lblListCategory.TabIndex = 11;
            this.lblListCategory.Text = "Category";
            // 
            // lblListNumIngredients
            // 
            this.lblListNumIngredients.Location = new System.Drawing.Point(727, 12);
            this.lblListNumIngredients.Name = "lblListNumIngredients";
            this.lblListNumIngredients.Size = new System.Drawing.Size(61, 38);
            this.lblListNumIngredients.TabIndex = 12;
            this.lblListNumIngredients.Text = "No. of Ingredients";
            // 
            // lblSeeIntsructions
            // 
            this.lblSeeIntsructions.Location = new System.Drawing.Point(386, 415);
            this.lblSeeIntsructions.Name = "lblSeeIntsructions";
            this.lblSeeIntsructions.Size = new System.Drawing.Size(402, 23);
            this.lblSeeIntsructions.TabIndex = 13;
            this.lblSeeIntsructions.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSeeIntsructions);
            this.Controls.Add(this.lblListNumIngredients);
            this.Controls.Add(this.lblListCategory);
            this.Controls.Add(this.lblListRecipe);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditFinish);
            this.Controls.Add(this.btnEditBegin);
            this.Controls.Add(this.lstRecipe);
            this.Controls.Add(this.grpAddRecipe);
            this.Name = "MainForm";
            this.Text = "APU Recipe Book";
            this.grpAddRecipe.ResumeLayout(false);
            this.grpAddRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddRecipe;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbFoodCategory;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label lblNameRecipe;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.ListBox lstRecipe;
        private System.Windows.Forms.Button btnEditBegin;
        private System.Windows.Forms.Button btnEditFinish;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblListRecipe;
        private System.Windows.Forms.Label lblListCategory;
        private System.Windows.Forms.Label lblListNumIngredients;
        private System.Windows.Forms.Label lblSeeIntsructions;
    }
}

