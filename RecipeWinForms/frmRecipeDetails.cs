using RecipeBizObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RecipeWinForms
{
    public partial class frmRecipeDetails : Form
    {
        bizRecipe recipeobj = new bizRecipe();
        public frmRecipeDetails()
        {
            InitializeComponent();
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
        }

        public void ShowForm(int id)
        {
            recipeobj = bizRecipe.Get(id);
          
            lstCuisine.DataSource = DataService.GetCuisineList(true);
            lstCuisine.ValueMember = "CuisineId";
            lstCuisine.DisplayMember = "CuisineName";
            lstCuisine.DataBindings.Add("SelectedValue", recipeobj, "CuisineId");

            txtRecipe.DataBindings.Add("Text", recipeobj, "RecipeName");
            txtCalories.DataBindings.Add("Text", recipeobj, "Calories");
            lblDraft.DataBindings.Add("Text", recipeobj, "DraftDate");
            lblPublished.DataBindings.Add("Text", recipeobj, "PublishedDate");
            lblArchived.DataBindings.Add("Text", recipeobj, "ArchivedDate");
            lblStatus.DataBindings.Add("Text", recipeobj, "StatusName");

            gRecipeIngredientList.DataSource = DataService.GetRecipeIngredientList(id);
            gRecipeSteps.DataSource = DataService.GetStepsIngredientsRecipes(id);
            this.StartPosition = FormStartPosition.CenterScreen;

            int ingredientslistCount = gRecipeIngredientList.Rows.Count - 1;
            txtIngredients.Text = ingredientslistCount.ToString();

            int stepsCount = gRecipeSteps.Rows.Count - 1;
            txtSteps.Text = stepsCount.ToString();

            this.FormatGrid(gRecipeIngredientList);
            this.FormatGrid(gRecipeSteps);

            this.Show();
        }
        private void FormatGrid(DataGridView gridobj, string PrimaryKeyFieldName = "")
        {
            gridobj.ReadOnly = true;
            gridobj.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridobj.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridobj.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridobj.RowHeadersWidth = 25;
            gridobj.AllowUserToAddRows = false;
            if (PrimaryKeyFieldName != "")
            {
                gridobj.Columns[PrimaryKeyFieldName].Visible = false;
            }
        }
        private void Save()
        {
            recipeobj.Save();
        }
        private void Delete()
        {
            recipeobj.Delete();
            this.Close();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {

            this.Save();
        }

        
    }
}
//