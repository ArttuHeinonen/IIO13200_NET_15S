using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava7
{
    public class Train
    {
        public string trainType { get; set; }
        public int trainNumber { get; set; }
        public Boolean cancelled { get; set; }
        public Boolean runningCurrently { get; set; }
        public string scheduledTime { get; set; }
    }
}
