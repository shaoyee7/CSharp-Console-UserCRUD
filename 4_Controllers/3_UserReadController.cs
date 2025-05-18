using System;
using Role.Models;
using System.Collections.Generic;

//新增 ReadController 讀取控制器（串接 ReadService 取得所有使用者資料）
public class ReadController
{
    private readonly ReadService service;
    public ReadController(ReadService service)=>this.service=service;

    public List <User> GetAllView()
    {
        return service.GetAllUsers();
    }
}