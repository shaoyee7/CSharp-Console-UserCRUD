using System;

//刪除使用者畫面層
public class DeleteView
{
    public static void ShowDeleteUserTitle(DeleteController controller)
    {
        Console.WriteLine("======刪除使用者======");
        var deletedUser=controller.Delete();
        if(deletedUser != null)
        {
            ConsoleHelper.SuccessMessage("✅使用者刪除成功");
        }
        else
        {
            ConsoleHelper.CheckError("‼️未找到使用者或刪除失敗");
        }
    }
}