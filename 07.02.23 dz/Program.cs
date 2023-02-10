using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02._23_dz
{
    internal class Program
    {
        internal class WebSite
        {
            string name;
            string url;
            string description;
            string ip;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Url
            {
                get { return url; }
                set { url = value; }
            }
            public string Description
            {
                get { return description; }
                set { description = value; }
            }
            public string Ip
            {
                get { return ip; }
                set { ip = value; }
            }
            public WebSite() { }
            public WebSite(string name, string url, string description, string ip)
            {
                Name = name;
                Url = url;
                Description = description;
                Ip = ip;
            }
            public void PrintWebSiteInfo()
            {
                Console.WriteLine($"Name: {Name}\nUrl: {Url}\nDescription: {Description}\nIp: {Ip}");
            }
            public void InputWebSiteInfo()
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Url: ");
                url = Console.ReadLine();
                Console.WriteLine("Description: ");
                description = Console.ReadLine();
                Console.WriteLine("Ip: ");
                ip = Console.ReadLine();
            }
        }
        internal class Magazine
        {
            string name;
            string foundyear;
            string description;
            string phone;
            string email;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Foundyear
            {
                get { return foundyear; }
                set { foundyear = value; }
            }
            public string Description
            {
                get { return description; }
                set { description = value; }
            }
            public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }
            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public Magazine() { }
            public Magazine(string name, string foundyear, string description, string phone, string email)
            {
                Name = name;
                Foundyear = foundyear;
                Description = description;
                Phone = phone;
                Email = email;
            }
            public void PrintMagazineInfo()
            {
                Console.WriteLine($"Name: {Name}\nFoundyear: {Foundyear}\nDescription: {Description}\nPhone: {Phone}\nEmail: {Email}");
            }
            public void InputMagazineInfo()
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Foundyear: ");
                foundyear = Console.ReadLine();
                Console.WriteLine("Description: ");
                description = Console.ReadLine();
                Console.WriteLine("Phone: ");
                phone = Console.ReadLine();
                Console.WriteLine("Email:");
                email = Console.ReadLine();
            }
        }
        internal class Shop
        {
            string name;
            string address;
            string description;
            string phone;
            string email;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Address
            {
                get { return address; }
                set { address = value; }
            }
            public string Description
            {
                get { return description; }
                set { description = value; }
            }
            public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }
            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public Shop() { }
            public Shop(string name, string address, string description, string phone, string email)
            {
                Name = name;
                Address = address;
                Description = description;
                Phone = phone;
                Email = email;
            }
            public void PrintShopInfo()
            {
                Console.WriteLine($"Name: {Name}\nAddress: {Address}\nDescription: {Description}\nPhone: {Phone}\nEmail: {Email}");
            }
            public void InputShopInfo()
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Foundyear: ");
                address = Console.ReadLine();
                Console.WriteLine("Description: ");
                description = Console.ReadLine();
                Console.WriteLine("Phone: ");
                phone = Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            WebSite webSite = new WebSite();
            Magazine magazine = new Magazine();
            Shop shop = new Shop();

            webSite.InputWebSiteInfo();
            webSite.PrintWebSiteInfo();

            magazine.InputMagazineInfo();
            magazine.PrintMagazineInfo();

            shop.InputShopInfo();
            shop.PrintShopInfo();
        }
    }
}
