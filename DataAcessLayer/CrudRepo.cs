using DataAcessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class CrudRepo
    {
        CrudContext context;
        public CrudRepo()
        {
             context = new CrudContext();
        }
       public bool Insert(User userObj)
        {
            bool status = false;
            try
            {
                User obj = new User();
                obj.Name = userObj.Name;
                obj.Email = userObj.Email;
                obj.Phone = userObj.Phone;
                obj.Age = userObj.Age;
                obj.Gender = userObj.Gender;

                context.Users.Add(obj);
                context.SaveChanges();

                status = true;
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                status = false;

          
            }
            return status;
        }

        public List<User> GetUserList()
        {
            List<User> list = null;
            try
            {
                list = (from data in context.Users select data).ToList();
            }
            catch (Exception)
            {

                list = null;
            }
            return list;
        }
        
        public bool Update(int id, String name, int Age, string email,string gender)
        {
            bool status = false;
            try
            {

                User? users = context.Users.Find(id);
                if(users != null)
                {
                    users.Name = name;
                    users.Age = Age;
                    users.Email = email;
                    users.Gender = gender;
                    context.Users.Update(users);
                    context.SaveChanges();
                    status = true;

                }
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                status = false;
            }
            return status;

        }

        public bool Delete(int id)
        {
            bool status = false;
            try
            {
                User data = context.Users.Find(id);
                if (data != null)
                {
                    context.Users.Remove(data);
                    context.SaveChanges();
                    status = true;
                }
               
            }
            catch (Exception)
            {
                status = false;
                
            }
            return status;
        }

    }

   

}
