namespace Assignment4
{
    partial class IngredientsForm
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
            this.lblNumIngredients = new System.Windows.Forms.Label();
            this.lblCurrNumber = new System.Windows.Forms.Label();
            this.grpIngredient = new System.Windows.Forms.GroupBox();
            this.txtNameIngredient = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.grpIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumIngredients
            // 
            this.lblNumIngredients.AutoSize = true;
            this.lblNumIngredients.Location = new System.Drawing.Point(25, 20);
            this.lblNumIngredients.Name = "lblNumIngredients";
            this.lblNumIngredients.Size = new System.Drawing.Size(111, 13);
            this.lblNumIngredients.TabIndex = 0;
            this.lblNumIngredients.Text = "Number of Ingredients";
            // 
            // lblCurrNumber
            // 
            this.lblCurrNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrNumber.Location = new System.Drawing.Point(386, 20);
            this.lblCurrNumber.Name = "lblCurrNumber";
            this.lblCurrNumber.Size = new System.Drawing.Size(46, 23);
            this.lblCurrNumber.TabIndex = 1;
            // 
            // grpIngredient
            // 
            this.grpIngredient.Controls.Add(this.lstIngredients);
            this.grpIngredient.Controls.Add(this.btnDelete);
            this.grpIngredient.Controls.Add(this.btnEdit);
            this.grpIngredient.Controls.Add(this.btnAdd);
            this.grpIngredient.Controls.Add(this.txtNameIngredient);
            this.grpIngredient.Location = new System.Drawing.Point(28, 46);
            this.grpIngredient.Name = "grpIngredient";
            this.grpIngredient.Size = new System.Drawing.Size(404, 427);
            this.grpIngredient.TabIndex = 2;
            this.grpIngredient.TabStop = false;
            this.grpIngredient.Text = "Ingredient";
            // 
            // txtNameIngredient
            // 
            this.txtNameIngredient.Location = new System.Drawing.Point(8, 31);
            this.txtNameIngredient.Name = "txtNameIngredient";
            this.txtNameIngredient.Size = new System.Drawing.Size(260, 20);
            this.txtNameIngredient.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(304, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(304, 78);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(304, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(79, 491);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(8, 78);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(260, 329);
            this.lstIngredients.TabIndex = 5;
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 535);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpIngredient);
            this.Controls.Add(this.lblCurrNumber);
            this.Controls.Add(this.lblNumIngredients);
            this.Name = "IngredientsForm";
            this.Text = "IngredientsForm";
            this.grpIngredient.ResumeLayout(false);
            this.grpIngredient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumIngredients;
        private System.Windows.Forms.Label lblCurrNumber;
        private System.Windows.Forms.GroupBox grpIngredient;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNameIngredient;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstIngredients;
    }
}