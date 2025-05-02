using System;
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

        // 建立主控制器
        MenuController con = new MenuController(reg, rea, upd, del);

        // 啟動選單（傳參數注入）
        MenuView.Menu(con);
    }
}
