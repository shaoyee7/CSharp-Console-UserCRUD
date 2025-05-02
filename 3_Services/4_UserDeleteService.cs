using System;
using System.Collections.Generic;

//串接UserRepository 修改使用者資料 （處理層)
public class DeleteService
{
    private readonly UserRepository repo;
    public DeleteService(UserRepository repo)=>this.repo=repo;

    public User Remove(User user)
    {
        while(true)
        {
            if(user != null)
            {
                Console.WriteLine("是否確定刪除,確定請打yes,取消請打no");
                var answer = Console.ReadLine();
                if(answer.ToLower() == "yes")
                {
                    repo.Delete(user);
                    return user;
                }
                else if(answer.ToLower() == "no")
                {
                    return null;
                }
            }
        }
    }
}