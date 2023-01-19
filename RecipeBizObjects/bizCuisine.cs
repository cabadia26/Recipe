using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBizObjects
{
    public class bizCuisine : bizObject<bizCuisine>
    {

        string cuisinenameval = "";
        List<bizRecipe> lstrecipe = new List<bizRecipe>();
        public bizCuisine()
        {

        }
        public int CuisineId
        {
            get => this.PrimaryKeyValue;
            set => this.PrimaryKeyValue = value;
        }

        [Required]
        [Display(Name = "CuisineName")]
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

        public List<bizRecipe> RecipeList(bool refresh)
        {
            if (refresh == true || lstrecipe == null)
            {
                lstrecipe = bizRecipe.GetList("CuisineName", this.CuisineName);
            }
            return lstrecipe;
        }
    }
}
