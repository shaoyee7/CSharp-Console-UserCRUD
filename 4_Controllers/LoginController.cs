using System;
using Role.Models;

public class LoginController
{
    private readonly LoginService service;
    public LoginController(LoginService service)=>this.service=service;

    public User Loginswitch(string inputemail,string inputpassword)
    {
        if(string.IsNullOrWhiteSpace(inputemail))
        {
            Console.WriteLine("❌請檢查帳號不得為空");
            return null;
        }
        else if(string.IsNullOrWhiteSpace(inputpassword))
        {
            Console.WriteLine("❌請檢查密碼不得為空");
            return null;
        }
        else if(!inputemail.Contains("@"))
        {
            Console.WriteLine("❌信箱格式錯誤，請重新輸入");
            return null;
        }
        return service.logincheck(inputemail,inputpassword);
    }
}