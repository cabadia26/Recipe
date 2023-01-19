using CPUFramework;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecipeBizObjects
{
    public class bizRecipe : bizObject<bizRecipe>
    {
        string recipenameval = "";
        int cuisineval = 0;
        int createdbyuseridval = 0;
        int caloriesval = 0;
        int ingredientsval = 0;
        int stepsval = 0;
        int numval =0;
        string statusnameval = "";
        string firstnameval = "";
        string lastnameval = "";
        string cuisinenameval = "";
        DateTime draftdate;
        DateTime? publisheddate;
        DateTime? archiveddate;
        string codeval = "";
        
        List<bizRecipeIngredient> lstingredients = new List<bizRecipeIngredient>();
        List<bizSteps> lststeps = new List<bizSteps>();
        public bizRecipe()
        {
            this.DynamParamForUpdate.Output(this, x => x.RecipeName);
            this.DynamParamForUpdate.Output(this, x=> x.Code);
            this.DynamParamForUpdate.Output(this, x => x.Num);
        }
        public static List<bizRecipe> Search(string criteria)
        {
            DynamicParameters dp = new DynamicParameters();
            dp.Add("SearchCriteria", criteria);
            return GetAllFromSproc("RecipeSearch", dp);

        }
        public int RecipeId { get => this.PrimaryKeyValue; set => this.PrimaryKeyValue = value; }
       
        [Display(Name = "Status Name:")]
        public string StatusName
        {
            get
            {
                return statusnameval;
            }
            set
            {
                statusnameval = value;
                InvokePropertyChanged();
            }
        }
   
        [Display(Name = "Archived Date:")]
        public DateTime? ArchivedDate
        {
            get
            {
                return archiveddate;
            }
            set { archiveddate = value; InvokePropertyChanged(); }
        }
        
        [Display(Name = "Published Date:")]
        public DateTime? PublishedDate
        {
            get
            {
                return publisheddate;
            }
            set { publisheddate = value; InvokePropertyChanged(); }
        }
        [Required]
        [Display(Name = "Draft Date:")]
        public DateTime DraftDate
        {
            get
            {
                return draftdate;
            }

            set
            {
                draftdate = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name = "Calories:")]
        public int Calories
        {
            get
            {
                return caloriesval;
            }
            set
            {
                caloriesval = value;

                InvokePropertyChanged();
            }
        }
        [Required]
        [Display(Name = "Recipe Name:")]
        public string RecipeName
        {
            get
            {
                return recipenameval;
            }

            set
            {
                recipenameval = value;
                InvokePropertyChanged();
            }
        }
        [Required]
        [Display(Name = "First Name:")]
        public string FirstName
        {
            get
            {
                return firstnameval;
            }

            set
            {
                firstnameval = value;
                InvokePropertyChanged();
            }
        }
        [Required]
        [Display(Name = "Last Name:")]
        public string LastName
        {
            get
            {
                return lastnameval;
            }

            set
            {
                lastnameval = value;
                InvokePropertyChanged();
            }
        }
        [Display(Name = "Cuisine Name:")]
        public string CuisineName
        {
            get
            {
                return cuisinenameval;
            }

            set
            {
                cuisinenameval = value;
                InvokePropertyChanged();
            }
        }
        [Required]
        [Display(Name = "Cuisine Name")]
        public int CuisineId
        {
            get
            {
                return cuisineval;
            }

            set
            {
                cuisineval = value;
                InvokePropertyChanged();
            }
        }
        [Required]
        [Display(Name = "User Name")]
        public int CreatedByUserId
        {
            get
            {
                return createdbyuseridval;
            }

            set
            {
                createdbyuseridval = value;
                InvokePropertyChanged();
            }
        }
        public int Num
        {
            get
            {
                return numval;
            }
            set
            {
                numval = value;
                InvokePropertyChanged();
            }
        }
        public string Code
        {
            get
            {
                return codeval;
            }

            set
            {
                codeval = value;
                InvokePropertyChanged();
            }
        }

        public string FullDescription() { return this.Num + " " + this.RecipeName; }

        public List<bizRecipeIngredient> IngredientsList(bool refresh)
        {
            if (refresh == true || lstingredients == null)
            {
                lstingredients = bizRecipeIngredient.GetList("RecipeId", RecipeId);
            }
            return lstingredients;
        }
        public List<bizSteps> StepsList(bool refresh)
        {
            if (refresh == true || lststeps == null)
            {
                lststeps = bizSteps.GetList("RecipeId", this.RecipeId);
            }
            return lststeps;
        }
        //public List<bizRecipe> RecipeList(bool refresh)
        //{
        //    if (refresh == true || lstrecipe == null)
        //    {
        //        lstrecipe = this.sear;
        //    }
        //    return lstrecipe;
        //}
        public List<bizCreatedByUser> UserList()
        {
            return bizCreatedByUser.GetAll();
        }
        public List<bizIngredient> IngredientsList()
        {
            return bizIngredient.GetAll();
        }
       
        public List<bizCuisine> CuisineList()
        {
            return bizCuisine.GetAll();
        }
    }
}

