using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyec_ADS
{
    class SoporteEmail:MasterMailServer
    {
        public SoporteEmail() {
            senderMail = "soportetecnico.sara@gmail.com";
            password = "tequieromuchosara";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
