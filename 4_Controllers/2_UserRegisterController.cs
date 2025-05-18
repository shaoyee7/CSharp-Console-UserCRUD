using System;
using Role.Models;

//新增 RegisterController 新增控制器（串接RegisterService 新增使用者資料、驗證輸入）
public class RegisterController
{
    
    private  readonly RegisterService service;
    
    public RegisterController(RegisterService service)=>this.service=service;
    
    public void CreateUser()
    {
        var user=new User();//依序新增屬性,若輸入型別錯誤才不會拋出例外

        user.Name=ConsoleHelper.CheckMessage("請輸入姓名");

        user.Age=ConsoleHelper.CheckNumber("請輸入年齡");

        user.School=ConsoleHelper.CheckMessage("請輸入校名");

        user.Grade=ConsoleHelper.CheckNumber("請輸入年級");

        user.Mail=ConsoleHelper.CheckMail("請輸入信箱");

        user.Password=ConsoleHelper.CheckMessage("請輸入密碼");

        service.CreateUser(user);
    }
}
