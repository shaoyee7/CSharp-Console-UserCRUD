using System;
using Role.Models;
using MenuView.Controller;

namespace MenuView.Controller
{
    public class GeneralMenuController:IMenuViewController
    {   
        private RegisterController register;
        private UpdateController update;
        private DeleteController delete;
    

        public GeneralMenuController(RegisterController register,UpdateController update,DeleteController delete)
        {
            this.register=register;
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
                UpdateView.ShowUpdateUserTitle(update);
                break;

                case "3":
                DeleteView.ShowDeleteUserTitle(delete);
                break;

                default:
                Console.WriteLine("請重新輸入有效選項");
                Console.ReadKey();
                break;
            }
        }
    }
}