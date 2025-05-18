using System;
using Role.Models;
using System.Collections.Generic;

//儲存使用者及管理資料 （資料儲存層）
public class UserRepository
{
    private List <User> users=new List<User>();//清單
    private int _CurrentMaxId=0;
    public void Add(User user)
    {
        user.Id = ++ _CurrentMaxId;
        user.CreateAt=DateTime.Now;
        users.Add(user);//新增
    }
    public List <User> GetAll()=>users;//讀取
    public User FindByMail(string Mail)=>users.Find(u=>u.Mail==Mail);//修改
    public void Delete(User user)=>users.Remove(user);//刪除
}