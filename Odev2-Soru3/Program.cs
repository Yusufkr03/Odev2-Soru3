// See https://aka.ms/new-console-template for more information
const string nick = "admin";
const string password = "Admin_32453@";
string nick1;
string password1;

Console.WriteLine("Kullanıcı adını giriniz");
nick1 = Console.ReadLine();
Console.WriteLine("Şifreyi Giriniz");
password1 = Console.ReadLine();
if (nick1 == nick && password1 == password)
{
    Console.WriteLine("Giriş başarılı");
}
else
{
    Console.WriteLine("giriş başarısız");
}
Console.ReadKey();
