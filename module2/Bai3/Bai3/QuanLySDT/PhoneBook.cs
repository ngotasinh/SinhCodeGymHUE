using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bai3.QuanLySDT
{
    public class PhoneBook : Phone
    {
        private string name;
        private string phone;
        public ArrayList PhoneList = new ArrayList();

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }

        public override void InsertPhone(string name, string phone)
        {
            if(PhoneList != null && UserIsExited(name))
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if(phoneItem.Name == name)
                    {
                        if(phoneItem.PhoneNumber != phone)
                        {
                            phoneItem.PhoneNumber += ":" + phone;
                        }
                    }

                }
            }
            
            else
            {
                ////Cach 1:
                /*var newItem = new NewItem()
                {
                    Name = name,
                    PhoneNumber = phone
                };
                PhoneList.Add(newItem);*/

                ////Cach 2:
                
                PhoneList.Add(new PhoneItem()
                {
                    Name = name,
                    PhoneNumber = phone
                });
            }
        }

        public override void RemovePhone(string name)
        {
            if(PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name )
                    {
                        PhoneList.Remove(phoneItem);
                        break;
                    }
                }
            }
            
        }

        public override void SearchPhone(string name)
        {
            if( PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        Console.WriteLine("Phonenumber {0} is {1}", phoneItem.Name, phoneItem.PhoneNumber);
                        break;
                        
                    }
                }              
            }
            
        }

        public override void sort()
        {
            PhoneList.Sort(new sortPhone());
        }
        

        public override void UpdatePhone(string name, string newphone)
        {
            foreach (PhoneItem phoneItem in PhoneList)
            {
                if(phoneItem.Name == name)
                {
                    phoneItem.PhoneNumber = newphone;
                }
            }
        }

        private bool UserIsExited(string userName)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == userName)
                        return true;

                }
            }
            return false;
        }
        public class sortPhone : IComparer
        {
            int IComparer.Compare(Object a, Object b)
            {
                PhoneItem a1 = a as PhoneItem;
                PhoneItem b1 = b as PhoneItem;
                return (string.Compare(a1.Name, b1.Name, false));
            }
        }
    }
}
