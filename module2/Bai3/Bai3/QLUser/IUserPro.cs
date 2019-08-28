using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Bai3.QLUser
{
    public interface IUserPro
    {
        int ID { get; set; }
        string Name { get; set; }
        string Password { get; set; }
       /* int? PhoneList { get; set; }*/

    }
}
