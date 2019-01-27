using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using Multilang.Shared.Vm;

namespace Multilang.Shared
{
    public static class SharedStartup
    {
        public static void Init()
        {
            SimpleIoc.Default.Register<MainVm>();
        }
    }
}
