using DataAcessLayer;
using DataAcessLayer.Models;

CrudRepo obj = new CrudRepo();




User obj1 = new User();
obj1.Name = "Pavithra";
obj1.Email = "Pavithra@gmail.com";
obj1.Phone = 9123437890;
obj1.Age = 22;
obj1.Gender = "F";

bool status = obj.Insert(obj1);
Console.WriteLine(status);



//List<User> lst = null;
//lst = obj.GetUserList();
//foreach (var data in lst)
//{
//    Console.WriteLine(data.Name + " " + data.Email + " " + data.Phone + " " + data.Age + " " + data.Gender);
//}


//User obj1 = new User();
//bool status = obj.Update(1000,"Adi",30);
//Console.WriteLine(status);

//User obj1 = new User();
//bool status = obj.Delete(1005);
//Console.WriteLine(status);



