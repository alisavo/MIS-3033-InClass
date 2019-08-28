using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Class1
    {
        public double HardDriveSize { get; set; }
       public double CPUSpeed { get; set; }
        public int CPUCores { get; set; }
        public string Brand { get; set; }
        public bool IsOverClocked { get; set; }

        public Computer()
        {
            this.HardDriveSize = 0;
            this.CPUSpeed = 0;
            this.CPUCores = 0;
            this.IsOverClocked = false;
            this.Brand = "dell";

        }
    }
}
