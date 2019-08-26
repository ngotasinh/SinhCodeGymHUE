using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.QLNguoiDung.User
{
    public interface IUserPro
    {
        int ID { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        int this[int index] { get;set; }
    }
}
