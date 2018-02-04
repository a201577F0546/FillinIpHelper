using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPconfigHelper.Model
{
    public class InternetSetting
    {
        public string name = "<default>";
        public string ipAddress = "0.0.0.0";
        public string subnetMask = "255.255.255.0";
        public string defaultGateway = "0.0.0.0";
        public string preferredDNSserver = "0.0.0.0";
        public string AlternateDNSserver = "0.0.0.0";

    }
}
