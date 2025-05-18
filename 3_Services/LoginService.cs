using System;
using Role.Models;

public class LoginService
{
    private readonly UserRepository repo;
    public LoginService(UserRepository repo)=>this.repo=repo;

    public User logincheck(string inputemail,string inputpassword)
    {
        var accountresult = repo.FindByMail(inputemail);
        if(accountresult != null && accountresult.Password==inputpassword)
        {
            return accountresult;
        }
        else
        {
            return null;
        }
    }
}