using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBizObjects
{
    public class bizSteps : bizObject<bizSteps>
    {
        int seqval = 0;
        int recipecountval = 0;
        string stepdescval = "";
        public bizSteps()
        {

        }
        public int StepsId
        {
            get => this.PrimaryKeyValue;
            set => this.PrimaryKeyValue = value;
        }

        public int RecipeId { get => this.PrimaryKeyValue; set => this.PrimaryKeyValue = value; }
        public int RecipeCount
        {
            get
            {
                return recipecountval;

            }
            set
            {
                recipecountval = value;
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
        [Display(Name = "StepDesc")]
        public string StepDesc
        {
            get
            {
                return stepdescval;

            }
            set
            {
                stepdescval = value;
                InvokePropertyChanged();
            }
        }
    
    }
}
    


