using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class ConfigService
    {
        private Config _config;
        public ConfigService()
        {
            Init();
        }

        public NumOfProducts Config => _config.Num;
        private void Init()
        {
            _config = new Config
            {
                Num = new NumOfProducts
                {
                    Size = 10
                }
            };
        }
    }
}
