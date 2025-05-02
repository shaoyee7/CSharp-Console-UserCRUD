using System;

//注入各層控制器使選單能導向
public class MenuController
{   
    private RegisterController register;
    private ReadController read;
    private UpdateController update;
    private DeleteController delete;
    

    public MenuController(RegisterController register,ReadController read,UpdateController update,DeleteController delete)
    {
        this.register=register;
        this.read=read;
        this.update=update;
        this.delete=delete;
    }
    public void Menu(string choice)
    {
        switch(choice)
        {
            case "1":
            RegisterView.ShowCreateUserTitle(register);
            break;

            case "2":
            ReadView.ShowReadUserTitle(read);
            break;

            case "3":
            UpdateView.ShowUpdateUserTitle(update);
            break;

            case "4":
            DeleteView.ShowDeleteUserTitle(delete);
            break;

            default:
            Console.WriteLine("請重新輸入有效選項");
            Console.ReadKey();
            break;
        }
    }
}