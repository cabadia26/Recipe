using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using RecipeBizObjects;
using System.Data;

namespace RecipeWeb.Controllers
{
    public class RecipeController : Controller
    {
        public ActionResult Index()
        {
            List<bizRecipe> lst = bizRecipe.GetAll();
            return View(lst);
        }
        [EnableCors("Policy1")]
        public ActionResult APIRecipeList()
        {
            List<bizRecipe> lst = bizRecipe.GetAll();
            return Json(lst);
        }

        [EnableCors("Policy1")]
        public ActionResult APICuisineList()
        {
            List<bizCuisine> lst = bizCuisine.GetAll();
            return Json(lst);
        }
        public ActionResult Detail(string id)
        {
            bizRecipe r = bizRecipe.Get("Code", id);
            return View(r);
        }
        public ActionResult Recipe(string id)
        {
            bizRecipe r = bizRecipe.Get("Code", id);
            return View(r);
        }
        public ActionResult Edit(string id)
        {
            bizRecipe r;
            if (string.IsNullOrEmpty(id))
            {
                r = new();
            }
            else
            {
                r = bizRecipe.Get("Code", id);
            }

            return View(r);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(bizRecipe recipeobj)
        {
            try
            {
                recipeobj.Save();
                return RedirectToAction(nameof(Index));
            }
            catch (CPUFramework.CPUException ex)
            {
                ViewBag.ErrorMessage = ex.FriendlyMessage;
                return View(recipeobj);
            }
        }
        public ActionResult Delete(string id)
        {
            bizRecipe r = bizRecipe.Get("Code", id);

            return View(r);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(bizRecipe recipe)
        {
            try
            {
                recipe.Delete();
                return RedirectToAction(nameof(Index));
            }
            catch (CPUFramework.CPUException ex)
            {
                recipe = bizRecipe.Get(recipe.RecipeId);
                ViewBag.ErrorMessage = ex.FriendlyMessage;
                return View(recipe);
            }
        }
    }
}
