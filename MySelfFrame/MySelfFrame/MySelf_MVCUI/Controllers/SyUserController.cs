using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySelfDataModel;
using MySelf_DataBLL;
namespace MySelf_MVCUI.Controllers
{
    public class SyUserController : Controller
    {
        // GET: SyUser

        public ActionResult Index()
        {
            return RedirectToAction("AllList");
        }
        public ActionResult AllList()
        {
            string info = string.Empty;
            List<SyUser> list = new List<SyUser>();
            list = DataBLL.GetAllUser();
            // list.Add(model);
            return View(list);
        }

        public ActionResult AddSyUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSyUser(SyUser model)
        {

            string info = string.Empty;

            bool isOk = DataBLL.AddSyUser(model, out info);
            if (isOk)
            {
                return RedirectToAction("AllList");
            }
            else {
                return Content("添加失败");
            }
        }

        public ActionResult Edit(int? id)
        {
            SyUser model = DataBLL.GetUserById(id);

            return View(model);
        }

        public ActionResult Update(SyUser model)
        {
            string info = string.Empty;
            if (DataBLL.Edit(model))
            {
                return RedirectToAction("Index");
            }
            else {
                return Content("<script>更新失败</script>");
            }
        }

        public ActionResult Delete(int? id)
        {

            if (DataBLL.delete(id))
            {
                return RedirectToAction("Index");
            }
            else {
                return Content("<script>更新失败</script>");
            }

        }

        public ActionResult Details(int? id)
        {
            SyUser model = DataBLL.GetUserById(id);

            return View(model);
        }
    }
}