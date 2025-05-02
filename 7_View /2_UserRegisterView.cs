using System;

//新增使用者畫面層
public static class RegisterView
{
    public static void ShowCreateUserTitle(RegisterController controller)
    {
        ConsoleHelper.ClearScreen();
        Console.WriteLine("======新增使用者======");
        controller.CreateUser();
        ConsoleHelper.SuccessMessage("✅新增使用者成功");
    }
}

