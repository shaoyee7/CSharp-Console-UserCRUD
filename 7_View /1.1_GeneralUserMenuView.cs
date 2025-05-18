using System;
using Menu.Views;
using Role.Models;
using MenuView.Controller;

namespace Menu.Views
{
    public class GeneralUserMenuView:IMenuView
    {
        public void ShowMenu(IMenuViewController iMenuViewController)
        {
            while(true)
            {
                ConsoleHelper.ClearScreen();
                Console.WriteLine("=============一般會員系統===============");
                Console.WriteLine($"選單:\n按1=新增帳號\n按2=修改基本資料\n按3=刪除帳號");
                Console.WriteLine("=========================================");
                Console.WriteLine("請選擇功能");
                var choice=Console.ReadLine();

                iMenuViewController.Menu(choice);
            }
        }
    }
}