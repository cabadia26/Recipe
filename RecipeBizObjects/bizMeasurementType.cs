using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBizObjects
{
    public class bizMeasurementType : bizObject<bizMeasurementType>
    {
        
        string measurementnameval = "";
        List<bizRecipe> lstrecipe = new List<bizRecipe>();
        public bizMeasurementType()
        {

        }
        public int MeasurementTypeId
        {
            get => this.PrimaryKeyValue;
            set => this.PrimaryKeyValue = value;
        }

        [Required]
        [Display(Name = "MeasurementName")]
        public string MeasurementName
        {
            get
            {
                return measurementnameval;

            }
            set
            {
                measurementnameval = value;
                InvokePropertyChanged();
            }
        }
      
        public List<bizRecipe> RecipeList(bool refresh)
        {
            if (refresh == true || lstrecipe == null)
            {
                lstrecipe = bizRecipe.GetList("MeasurementName", this.MeasurementName);
            }
            return lstrecipe;
        }
    }
}


