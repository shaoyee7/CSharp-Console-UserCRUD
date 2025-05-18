using System;
using Role.Models;
using System.Collections.Generic;


//新增 UpdateController 更新控制器（驗證輸入，串接 UpDateService 修改使用者資料）
public class UpdateController
{   
   private readonly UpDateService service;
   private readonly UserRepository repo;
   public UpdateController(UpDateService service,UserRepository repo)
   {
    this.service=service;
    this.repo=repo;
   }
   
   public User CheckUpdate()
    {
        var user=ConsoleHelper.CheckMailExist("請輸入要更新的帳號資料email或按Ｑ鍵離開",repo);
        // 把找到的User傳給Service去更新
        if(user != null)
        {
            return service.Update(user);
        }
        else
        {
            return null;
        }
    }
}