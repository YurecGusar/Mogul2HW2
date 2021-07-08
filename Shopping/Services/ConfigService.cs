using System;

namespace Shopping
{
    public class ConfigService
    {
        private Config _config;
        public ConfigService()
        {
            Init();
        }

        public CartConfig CartConfig => _config.Num;
        private void Init()
        {
            _config = new Config
            {
                Num = new CartConfig
                {
                    Size = 10
                }
            };
        }
    }
}
