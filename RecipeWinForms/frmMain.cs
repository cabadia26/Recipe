using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUFramework;
using RecipeBizObjects;

namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            DataUtility.SetSQLExpressConnectionString("RecipeDB");

            btnNewRecipe.Click += BtnNewRecipe_Click;

            BindForm();
            gRecipeList.CellDoubleClick += gRecipeList_CellDoubleClick;
        }

        public void CreateNewRecipe()
        {
            frmRecipeDetails f = new frmRecipeDetails();
            f.ShowForm(0);
        }
        private void BindForm()
        {
           gRecipeSummary.DataSource = DataService.GetRecipeSummary();
           gRecipeList.DataSource = DataService.GetRecipeList();
           

            this.FormatGrid(gRecipeSummary);
            this.FormatGrid(gRecipeList, "RecipeId");
           
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
        private void gRecipeList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            int id = (int)gRecipeList.Rows[e.RowIndex].Cells["RecipeId"].Value;
            frmRecipeDetails f = new frmRecipeDetails();
            f.ShowForm(id);
        }
        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            CreateNewRecipe();
        }

    }
}
//