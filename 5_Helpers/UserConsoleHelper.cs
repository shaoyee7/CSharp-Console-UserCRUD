using System;

public static class ConsoleHelper
{
    public static void ClearScreen()
    {
        Console.Clear();
    }

    public static void SuccessMessage(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine("請按任意鍵返回主選單");
        Console.ReadKey();
    }

    // 驗證字串是否有效 (非空白、非空字串）
    public static string CheckMessage(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("✅輸入正確,已儲存");
                return input;
            }
            else
            {
                Console.WriteLine("‼️請檢查字串不得為空");
            }
        }
    }

    public static int CheckNumber(string prompt)
    {
        while(true)
        {
            Console.WriteLine(prompt);
            var input=Console.ReadLine();
            bool success=int.TryParse(input, out int number );
            if(success)
            {
                Console.WriteLine("✅輸入正確,已儲存");
                return number;
            }
            else
            {
                Console.WriteLine("❌格式輸入錯誤,請重新輸入");
            }
        }
    }
    public static string CheckMail(string prompt)
    {
        while(true)
        {
            Console.WriteLine(prompt);
            var input=Console.ReadLine();
            if(input.Contains("@"))
            {
                Console.WriteLine("✅輸入正確,已儲存");
                return input;
            }
            else
            {
                Console.WriteLine("❌格式輸入錯誤,請重新輸入並檢查mail格式");
            }
        }
    }
    public static User CheckMailExist(string prompt, UserRepository repo)
    {
        while (true) 
        {
            Console.WriteLine(prompt);
            var input = Console.ReadLine();

            if (input.ToUpper() == "Q")
            {
                return null; 
            }
            var user = repo.FindByMail(input);
            if (user != null)
            {
                return user; 
            }
            else
            {
                Console.WriteLine("❌ 查無此mail，請重新輸入，或按Q鍵返回主選單。");
                
            }
        }
    }
    public static void CheckError(string message)
    {
        Console.WriteLine(message);
    }

}