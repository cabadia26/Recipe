using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBizObjects
{
    public class bizRecipeIngredient : bizObject<bizRecipeIngredient>
    {
        decimal quantityval = 0;
        int seqval = 0;
        string ingredientnameval = "";

        List<bizRecipe> lstrecipe = new List<bizRecipe>();
        public bizRecipeIngredient()
        {

        }
        public int RecipeIngredientId
        {
            get => this.PrimaryKeyValue;
            set => this.PrimaryKeyValue = value;
        }
        
        public int RecipeId { get => this.PrimaryKeyValue; set => this.PrimaryKeyValue = value; }

        public int IngredientId { get => this.PrimaryKeyValue; set => this.PrimaryKeyValue = value; }

        public int MeasurementTypeId { get => this.PrimaryKeyValue; set => this.PrimaryKeyValue = value; }

        [Required]
        [Display(Name = "Quantity")]
        public decimal Quantity
        {
            get
            {
                return quantityval;

            }
            set
            {
                quantityval = value;
                InvokePropertyChanged();
            }
        }
        [Required]
        [Display(Name = "Sequence")]
        public int Seq
        {
            get
            {
                return seqval;

            }
            set
            {
                seqval = value;
                InvokePropertyChanged();
            }
        }
        [Required]
        [Display(Name = "Ingredient Name")]
        public string IngredientName
        {
            get
            {
                return ingredientnameval;

            }
            set
            {
                ingredientnameval = value;
                InvokePropertyChanged();
            }
        }
    }
}
