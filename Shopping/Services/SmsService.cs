using System;
namespace Shopping
{
    public class SmsService
    {
        public void SendSms(string phone)
        {
            if (phone != string.Empty)
            {
                Console.WriteLine($"Номер заказа был отправлен на номер {phone}");
            }
            else
            {
                Console.WriteLine("При отправке сообщения произошла ошибка");
            }
        }
    }
}
