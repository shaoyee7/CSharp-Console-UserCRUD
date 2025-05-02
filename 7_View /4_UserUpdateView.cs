using System;

//修改使用者畫面層
public class UpdateView
{
    public static void ShowUpdateUserTitle(UpdateController controller)
    {
        Console.WriteLine("======修改使用者======");
        var updatedUser = controller.CheckUpdate();
        if(updatedUser != null)
        {
            ShowUpdate(updatedUser);
            ConsoleHelper.SuccessMessage("✅使用者修改成功");
        }
        else
        {
            ConsoleHelper.CheckError("‼️未找到使用者或更新失敗");
        }
    }
    public static void ShowUpdate(User user)
    {
        Console.WriteLine("更新後的資料：");
        Console.WriteLine($"姓名：{user.Name}");
        Console.WriteLine($"年齡：{user.Age}");
        Console.WriteLine($"學校：{user.School}");
        Console.WriteLine($"年級：{user.Grade}");
        Console.WriteLine($"信箱：{user.Mail}");
    }
}