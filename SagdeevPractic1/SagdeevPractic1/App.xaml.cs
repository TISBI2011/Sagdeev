using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SagdeevPractic1.Models;

namespace SagdeevPractic1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static SagdeevPCClassEntities DB = new SagdeevPCClassEntities();
    }
}
