using System;

//使用者選單畫面
public static class MenuView
{
    public static void Menu(MenuController controller)
    {
        while(true)
        {
            ConsoleHelper.ClearScreen();
            Console.WriteLine("============使用者管理系統==============");
            Console.WriteLine("選單:\n按1=新增使用者\n按2=目前使用者列表\n按3=修改使用者\n按4=刪除使用者");
            Console.WriteLine("=========================================");
            Console.WriteLine("請選擇功能");
            var choice=Console.ReadLine();

            controller.Menu(choice);
        }
    }
}