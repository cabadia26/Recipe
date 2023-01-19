using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//CA need help with GetRecipeList 
namespace RecipeBizObjects
{
    public static class DataService
    { 
        public static DataTable GetRecipeSummary()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "RecipeGet");

            cmd.Parameters["@All"].Value = 1;

            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);
        }
        public static DataTable GetCuisineList(bool IncludeBlank = false)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "CuisineGet");
            //cmd.Parameters["@All"].Value = 1;
            //cmd.Parameters["@IncludeBlank"].Value = IncludeBlank;

            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);    
        }

        public static DataTable GetRecipeList()
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "RecipeGet");

            cmd.Parameters["@All"].Value = 1;

            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);
        }
        public static DataTable GetRecipeIngredientList(int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "RecipeIngredientGet");

            cmd.Parameters["@RecipeId"].Value = id;

            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);
        }
        public static DataTable GetRecipeDetail(int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "RecipeDetailGet");
            cmd.Parameters["@RecipeId"].Value=id;
            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);
        }
        public static DataTable GetStepsIngredientsRecipes (int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(DataUtility.ConnectionString, "StepsIngredientsRecipesGet");
            cmd.Parameters["@RecipeId"].Value=id;
            return SQLUtility.GetDataTable(cmd, DataUtility.ConnectionString);
        }

    }
}
//