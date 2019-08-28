using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Bai3.QLUser
{
    public class User : IUser
    {
        private int id;
        private string name;
        private string password;
        public List<int?> phoneList = new List<int?>();

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }

        public string Info()
        {
            if(phoneList == null || phoneList.Count == 0)
            {
                /*return string.Format("Id: {0} Name", name);*/
                return $"ID: {id}\t Name: {name}\t Password: {password}";
            }
            else
            {
                return $"ID: {id}\t Name: {name}\t Password: {password}\t PhoneList: {string.Join(",", phoneList)}";
            }
            
        }
    }
}
