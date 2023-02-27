using DataAcessLayer;
using DataAcessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CrudController : Controller
    {
        CrudRepo repository;
        public CrudController()
        {
            repository = new CrudRepo();
        }

        [HttpGet]
        public JsonResult getUsers()
        {
            List<User> users = new List<User>();
            try
            {
                users = repository.GetUserList();
            }
            catch (Exception)
            {

                users = null;
            }
            return Json(users);
        }

        [HttpPost]
        public JsonResult register(User objs)
        {
            bool status = false;
            string msg = "";
            try
            {
                status = repository.Insert(objs);
                if(status)
                {
                    msg = "User Added Successfully";
                }
                else
                {
                    msg = "error Occured while Entering";
                }
            }
            catch (Exception ex)
            {

                status=false;
                msg = ex.Message;

            }
            return Json(msg);
        }

        [HttpPut]
        public JsonResult update(Models.Users1 userObj)
        {
            bool status;
            string msg;
            try
            {
                User obj = new User();
                obj.Id = userObj.Id;
                obj.Name = userObj.Name;
                obj.Age = userObj.Age;
                obj.Email = userObj.Email;
                obj.Gender = userObj.Gender;
                status = repository.Update(obj.Id, obj.Name, obj.Age,obj.Email,obj.Gender);  
                if(status) {

                    msg = "Updated Successfully";
                
                }
                else
                {
                    msg = "not updated";
                }
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            
            return Json(msg);
        }

        [HttpDelete]
        public JsonResult Delete(int id)
        {
            bool status = false;
            string msg = "";
            try
            {
                status = repository.Delete(id);
                if(status )
                {
                    msg = "Deleted Successfully";
                }
                else
                {
                    msg = "not deleted";
                }
            }
            catch (Exception ex)
            {

                msg = ex.Message;
            }
            return Json(msg);
        }

    }
}
