using System;
using System.Collections.Generic;

//串接UserRepository新增使用者 （處理層)
public class RegisterService
{
    private  readonly UserRepository repo;
    
    public RegisterService(UserRepository repo)=>this.repo=repo;
    
    public void CreateUser(User user)=>repo.Add(user);
}