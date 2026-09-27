using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Models
{
    public class AppSettings
    {
        public string SampleConfig { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
    }
    public class ConnectionStrings
    {
        public string LocalDB { get; set; }
    }
}
