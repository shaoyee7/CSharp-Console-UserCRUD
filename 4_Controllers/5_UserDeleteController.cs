using System;
using Role.Models;

//新增DeleteController刪除控制器（驗證輸入，串接 DeleteService 刪除使用者資料）
public class DeleteController
{
    private readonly UserRepository repo;
    private readonly DeleteService service;
    public DeleteController(UserRepository repo,DeleteService service)
    {
        this.service=service;
        this.repo=repo;
    }

    public User Delete()
    {
        var user=ConsoleHelper.CheckMailExist("請輸入要刪除的帳號email",repo);
        if(user != null)
        {
            return service.Remove(user);
        }
        else
        {
            return null;
        }
    }
}