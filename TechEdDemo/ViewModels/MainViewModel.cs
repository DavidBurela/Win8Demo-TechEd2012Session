using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechEdDemo.ViewModels
{
    public class MainViewModel
    {
        public string Greeting { get; set; }

        public MainViewModel()
        {
            Greeting = "Hello World! v2";
        }
    }
}
