using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git教學
{
    internal class UserData
    {
        public static List<UserDataModel> userDatas = new List<UserDataModel>
        {
            new UserDataModel {ID = "1", Password = "123"},
            new UserDataModel {ID = "2", Password = "456"},
        };
    }
}
