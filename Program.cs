using System;
using Role.Models;
using Menu.Views;
using MenuView.Controller;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        UserRepository repo = new UserRepository();

        // 建立各服務
        RegisterService registerService = new RegisterService(repo);
        ReadService readService = new ReadService(repo);
        UpDateService updateService = new UpDateService(repo);
        DeleteService deleteService = new DeleteService(repo);

        // 建立各控制器（注入 service）
        RegisterController reg = new RegisterController(registerService);
        ReadController rea = new ReadController(readService);
        UpdateController upd = new UpdateController(updateService, repo);
        DeleteController del = new DeleteController(repo, deleteService);

        LoginService loginService = new LoginService(repo);
        LoginController loginController = new LoginController(loginService);

        IMenuViewController controller=null;
        IMenuView view=null;

        var loginView = new LoginView(view, controller, reg);
        var user = loginView.Login(loginController);

        if (user == null)
        {
            ConsoleHelper.CheckError("登入失敗，結束程式。");
            return;
        }

        if(user.Role == UserRole.Admin)
        {
            view = new AdminMenuView();
            controller = new MenuController(reg, rea, upd, del);
        }
        else
        {
            view = new GeneralUserMenuView();
            controller = new GeneralMenuController(reg, upd, del);
        }
        view.ShowMenu(controller);
    }
}
