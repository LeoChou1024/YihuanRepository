using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git教學
{
    internal class LoginUI
    {
        public static void ExcuteLogin()
        {
            string? ID, password;

            Console.WriteLine("輸入帳號");
            ID = Console.ReadLine();

            Console.WriteLine("輸入密碼");
            password = Console.ReadLine();

            foreach (var user in UserData.userDatas)
            {
                if (user.ID == ID && user.Password == password)
                {
                    Console.WriteLine("登入成功");
                    return;
                }
            }

            Console.WriteLine("登入失敗");

        }


    }
}
