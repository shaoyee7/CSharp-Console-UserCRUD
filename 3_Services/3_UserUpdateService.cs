using System;
using System.Collections.Generic;

//串接UserRepository 修改使用者資料 （處理層)
public class UpDateService
{
    private readonly UserRepository repo;
    public UpDateService(UserRepository repo)=>this.repo=repo;
    
    public User Update(User user)
    {
        while(true)
        {
            if(user != null)
            {
                Console.WriteLine("請輸入要修改的資料,如：name,age,school,grade,mail,或按Q鍵返回主選單");
                string target=Console.ReadLine();
                if(target.ToUpper() == "Q")
                {
                    return user;
                }
                else if(target !="name" && target !="age" && target !="school" && target !="grade" && target !="mail")
                {
                    Console.WriteLine("輸入格式錯誤,請重新輸入");
                    continue;
                }

                switch(target.ToLower())
                {
                    case "name":
                    user.Name=ConsoleHelper.CheckMessage("請輸入新的名字");
                    break;

                    case "age":
                    user.Age=ConsoleHelper.CheckNumber("請輸入新的年齡");
                    break;

                    case "school":
                    user.School=ConsoleHelper.CheckMessage("請輸入新的學校");
                    break;

                    case "grade":
                    user.Grade=ConsoleHelper.CheckNumber("請輸入新的年級");
                    break;

                    case "mail":
                    user.Mail=ConsoleHelper.CheckMail("請輸入新的信箱");
                    break;
                }
            }
        }
    }
}