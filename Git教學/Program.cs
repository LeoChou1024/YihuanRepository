﻿// See https://aka.ms/new-console-template for more information

using Git教學;
using Git教學.Service;

Console.WriteLine("Hello, World!");

LoginUI.ExcuteLogin();

Console.WriteLine("請輸入註冊帳號：");
string account = Console.ReadLine();
Console.WriteLine("請輸入註冊密碼：");
string password = Console.ReadLine();
Console.WriteLine("請輸入註冊姓名：");
string name = Console.ReadLine();

// 修復登入功能完成

RegisterService service = new RegisterService();
bool isSuccess = service.Register(account, password, name);
if (isSuccess)
    Console.WriteLine("註冊成功！");
else
    Console.WriteLine("註冊失敗！");
