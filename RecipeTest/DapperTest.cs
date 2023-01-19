using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeBizObjects;
using NUnit.Framework;
using Dapper;
using CPUFramework;
using System.Data;

namespace RecipeTest
{
    internal class DapperTest2
    {
        int totalrec = 0;
        int maxrecid = 0;
        int maxcreatedbyuserid = 0;
        int maxrecnum = 0;


        string connstring = "";
        string newrecipename = "";
        string maxrecname = "";

        [SetUp]
        public void Setup()
        {
            connstring = DataUtility.SetSQLExpressConnectionString("RecipeDB");

            DataTable dt = SQLUtility.GetDataTable(connstring, "select total = count(*) from recipe r");
            totalrec = (int)dt.Rows[0]["total"];
            dt = SQLUtility.GetDataTable(connstring, "select top 1 r.RecipeId, r.Num from recipe r order by r.RecipeId desc");
            maxrecid = (int)dt.Rows[0]["RecipeId"];
            maxrecnum = (int)dt.Rows[0]["Num"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 * from CreatedByUser c order by c.CreatedByUserId desc");
            maxcreatedbyuserid = (int)dt.Rows[0]["CreatedByUserId"];
        }
        //load by primarykey
        private bizRecipe LoadRecipe(int Id)
        {
            bizRecipe r = bizRecipe.Get(Id);
            return r;
        }

        //load list
        private List<bizRecipe> LoadListRecipe()
        {
            return bizRecipe.GetAll();
        }
        //insert new
        private bizRecipe InsertNewRecipe()
        {
            Random rnd= new Random();
            newrecipename = "testnewrecipe " + rnd.Next(1,1000).ToString();
            bizRecipe r = new bizRecipe();
            r.CuisineId = 1;
            r.RecipeName = newrecipename;
            r.DraftDate = DateTime.Now.AddDays(-20);
            r.ArchivedDate = DateTime.Now.AddDays(-17);
            r.PublishedDate = DateTime.Now.AddDays(-18);
            r.Calories = 40;
            r.CreatedByUserId = 1;


            DynamicParameters dp = new DynamicParameters(r);
            dp.Output<bizRecipe>(r, x => x.RecipeId);

            r.Save();

            return r;
        }
        //Delete
        private int DeleteRecipe(int Id = 0)
        {
            bizRecipe r;
            if (Id == 0)
            {
                r = this.InsertNewRecipe();
            }
            else
            {
                r = LoadRecipe(Id);
            }
            Id = r.RecipeId;

            r.Delete();

            return Id;
        }
        //update
      
        private void ChangeNumCalories()
        {
            bizRecipe r =this.LoadRecipe(maxrecid);
            r.Calories += 20;
            r.Save();
        }
        private void ChangeRecipeName(bizRecipe r)
        {
            //bizRecipe r = this.LoadRecipe(maxrecid);
            r.RecipeName = newrecipename;
            r.Save();
        }

        [Test]
        public void TestLoadRecipe()
        {
            bizRecipe r = this.LoadRecipe(maxrecid);
            TestContext.WriteLine("Expected RecipeName = " + r.RecipeName);
            Assert.IsTrue(r.RecipeId == maxrecid);
        }
        [Test]
        public void TestLoadByNum()
        {
            bizRecipe r = bizRecipe.Get("Num", maxrecnum);
            TestContext.WriteLine(r.FullDescription);
            Assert.IsTrue(r.RecipeId == maxrecid);
        }
        [Test]
        public void TestInsertNewRecipe()
        {
            bizRecipe r = this.InsertNewRecipe();
            TestContext.WriteLine("Expected RecipeId > " + (maxrecid) + " Value = " + r.RecipeId);
            TestContext.WriteLine("Expected Recipe = " + newrecipename);
            TestContext.WriteLine("Expected Code not blank. Code = " + r.Code);
            Assert.IsTrue(r.RecipeName == newrecipename && r.RecipeId > maxrecid && string.IsNullOrEmpty(r.Code) == false);
        }
        [Test]
        public void TestUpdateRecipe()
        {
            bizRecipe r = this.LoadRecipe(maxrecid);
            //set the newrecipename here so that you can assert
            newrecipename = "New name" + r.RecipeName;
            this.ChangeRecipeName(r);
            r = this.LoadRecipe(maxrecid);
           // TestContext.WriteLine("Original" + recipename + " " + statusname + " " + "Current" + " " + r.RecipeName + " " + r.StatusName);
            Assert.IsTrue(r.RecipeName == newrecipename);
        }
        [Test]
        public void TestDeleteNewRecipe()
        {
            int id = this.DeleteRecipe();
            bizRecipe r = this.LoadRecipe(id);
            Assert.IsTrue(r.RecipeId == 0);
        }

        [Test]
        public void TestChangeCalories()
        {
             CPUException? ex = Assert.Throws<CPUException>(() => this.ChangeNumCalories());
             TestContext.WriteLine(ex?.Message);
        }

        [Test]
        public void TestDeleteRecipeWithingred()
        {
            // load up recipe that's related to a recipeingredient record
            // try deleting it
            // you should get an error
            // assert is checking that it's an error
        }
        [Test]
        public void TestSearchRecipe()
        {
            List<bizRecipe> lst = bizRecipe.Search("Beef");
            TestContext.WriteLine("Beef");
            Assert.IsTrue(lst.Any());
        }
    }
}
//