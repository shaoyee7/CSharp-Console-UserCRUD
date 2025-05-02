User Management System (C# MVC)
**Day 25 of self-study: my first full MVC project.**

A basic console application that allows you to manage users (CRUD) with clear MVC structure.
這是一個 C# MVC 架構的簡易使用者管理系統，使用 List 物件模擬資料儲存，提供以下功能：

##  Features

- Create User 新增使用者
- Read (List All Users) 查詢所有使用者
- Update User 修改使用者
- Delete User  刪除使用者

##  Structure

- Models/User.cs
- Repository: Data storage (currently using `List<User>`)
- Service: Business logic
- Controller: Process control
- View: UI interaction (console)

## Key Technical Highlights

- MVC layered architecture
- Console-based application
- Basic Dependency Injection
- Input validation (including null checks and format validation)
- Clear separation of concerns:(Data layer (Repository),Business logic layer (Service),Controller layer,View layer (Console output))

##  Next Steps

- [ ] Add database (e.g., SQL Server) 串接資料庫
- [ ] Add exception handling module 加入例外處理模組
- [ ] Logging functionality 日誌功能
- [ ] Refactor to use Dictionary for faster lookups（改寫Dictionary儲存加快查找速度）

---

 操作範例（Usage Example）
============使用者管理系統==============
選單:
按1=新增使用者
按2=目前使用者列表
按3=修改使用者
按4=刪除使用者
=========================================
請選擇功能
