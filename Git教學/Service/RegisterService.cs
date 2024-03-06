namespace Git教學.Service;

public class RegisterService
{
    private RegisterModel model = null;
    public RegisterService()
    {
        model = new RegisterModel();
    }
    
    public bool Register(string Account,string Password,string UserName)
    {
        if (!CheckAccountExist(Account))
            return false;
        model.Account = Account;
        model.Password = Password;
        model.UserName = UserName;
        return true;
    }

    private bool CheckAccountExist(string Account)
    {
        return true;
    }
}