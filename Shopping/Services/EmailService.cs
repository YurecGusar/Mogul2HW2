using System;
namespace Shopping
{
    public class EmailService
    {
        public void SendEmail(string email)
        {
            if (email != string.Empty)
            {
                Console.WriteLine($"Номер заказа был отправлен на почту {email}");
            }
            else
            {
                Console.WriteLine("При отправке сообщения произошла ошибка");
            }
        }
    }
}