using System;
using Menu.Views;
using Role.Models;
using MenuView.Controller;

public class LoginView
{
    private readonly IMenuView _View;
    private readonly IMenuViewController _menuController;
    private readonly RegisterController register;
    public LoginView(IMenuView View,IMenuViewController menuController,RegisterController register)
    {
        _View=View;
        _menuController = menuController;
        this.register=register;
    }
    public User Login(LoginController loginController)
    {
        ConsoleHelper.ClearScreen();
        Console.WriteLine("===========登入頁面===========");
        Console.WriteLine("註冊帳號請按『 A 』,登入請按『 S 』");
        var input=Console.ReadLine();
        
        if(input?.ToUpper() == "A")
        {
            RegisterView.ShowCreateUserTitle(register);
            return Login(loginController);
        }
        else if(input?.ToUpper() == "S")
        {
            Console.WriteLine("請輸入信箱");
            var inputemail=Console.ReadLine();
            Console.WriteLine("請輸入密碼");
            var inputpassword=Console.ReadLine();

            var user=loginController.Loginswitch(inputemail,inputpassword);
            if(user != null)
            {
                ConsoleHelper.SuccessMessage($"✅登入成功,歡迎{user.Name},您的身份是：{user.Role}");
                return user;
            }
            else if(user == null)
            {
                ConsoleHelper.CheckError("❌ 查無此帳號，請確認信箱與密碼是否正確");
            }
            return null;
        }
        return null;
    }
}