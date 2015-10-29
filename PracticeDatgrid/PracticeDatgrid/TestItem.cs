using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDatgrid
{
    public class TestItem
    {
        public string TxtBox01 { get; set; }
        public string TxtBox02 { get; set; }
        public string TxtBox03 { get; set; }
        public string TxtBox04 { get; set; }
        public string TxtBox05 { get; set; }
        public bool IsActive { get; set; }
        public TestItem()
        {
            IsActive = false;
        }
    }
}
