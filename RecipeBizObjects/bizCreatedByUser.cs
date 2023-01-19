using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBizObjects
{
    public class bizCreatedByUser : bizObject<bizCreatedByUser>
    {
        string firstnameval = "";
        string lastnameval = "";
        string createdbyuserpasswordval = "";
        string usernameval = "";
        List<bizRecipe> lstrecipe = new List<bizRecipe>();
        public bizCreatedByUser()
        {

        }
        public int CreatedByUserId
        {
            get => this.PrimaryKeyValue;
            set => this.PrimaryKeyValue = value;
        }
        [Required]
        [Display(Name = "First Name")]
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
        [Display(Name = "Last Name")]
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
        public string CreatedByUserPassword
        {
            get
            {
                return createdbyuserpasswordval;

            }
            set
            {
                createdbyuserpasswordval = value;
                InvokePropertyChanged();
            }
        }
        public string UserName
        {
            get
            {
                return usernameval;

            }
            set
            {
                usernameval = value;
                InvokePropertyChanged();
            }
        }

        public List<bizRecipe> RecipeList(bool refresh)
    {
        if (refresh == true || lstrecipe == null)
        {
            lstrecipe = bizRecipe.GetList("FirstName", this.FirstName);
        }
        return lstrecipe;
    }
}
}
   
