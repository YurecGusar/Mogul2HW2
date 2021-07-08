using System;

namespace Shopping.Services
{
    public class OrderService
    {
        private Cart _cart = Cart.Instance;
        private OrderInfo _orderInfo = new OrderInfo();
        private EmailService _emailService = new EmailService();
        private SmsService _smsService = new SmsService();

        public OrderService()
        {
            _orderInfo.OrderId = 132;
        }

        public void GetOrder(User user)
        {
            _emailService.SendEmail(user.Mail);
            _smsService.SendSms(user.Phone);
            _orderInfo.OrderSunm = 0;
            for (var i = 0; i < _cart.NumberOfProduct; i++)
            {
                _orderInfo.OrderSunm += _cart.Product[i].Cost;
            }

            _cart = null;

            Console.WriteLine($"Заказ №{_orderInfo.OrderId}, сумма: {_orderInfo.OrderSunm} грн");
        }
    }
}
