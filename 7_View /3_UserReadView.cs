using System;
using System.Collections.Generic;

//讀取使用者畫面層
public class ReadView
{
    public static void ShowReadUserTitle(ReadController controller)
    {
        Console.WriteLine("======所有使用者列表=======");
        var users=controller.GetAllView();
        View.UserShowAll(users);
    }
}
public class View
{
    public static void UserShowAll(List <User> users)
    {
        foreach(var user in users)
        {
            Console.WriteLine($"目前的帳號列表：姓名：{user.Name},年齡：{user.Age},學校：{user.School},年級：{user.Grade},信箱：{user.Mail}");
        }
         ConsoleHelper.SuccessMessage("✅已讀取所有使用者");
    }
}
