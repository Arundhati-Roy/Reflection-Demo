using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Reflection
{
    public class CustomerInfo
    {
        public CustomerInfo()
        {
            this.Id = -1;
            this.FullName = string.Empty;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public CustomerInfo(int id,string name)
        { 
            this.Id = id;
            this.FullName = name;
        }
        public void PrintID()
        {
            Console.WriteLine("ID is:{0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name is:{0}", this.FullName);
        }
    }
}
