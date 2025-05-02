using System;
using System.Collections.Generic;

//儲存使用者及管理資料 （資料儲存層）
public class UserRepository
{
    private List <User> users=new List<User>();//清單
    public void Add(User user)=>users.Add(user);//新增
    public List <User> GetAll()=>users;//讀取
    public User FindByMail(string Mail)=>users.Find(u=>u.Mail==Mail);//修改
    public void Delete(User user)=>users.Remove(user);//刪除
}