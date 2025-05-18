using System;
using Role.Models; 
using System.Collections.Generic;

//串接UserRepository 得到使用者資料 （處理層)
public class ReadService
{
    private readonly UserRepository repo;
    public ReadService(UserRepository repo)=>this.repo=repo;

    public List <User> GetAllUsers() => repo.GetAll();
}