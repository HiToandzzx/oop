﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    internal class Phone: IComparable<Phone>
    {
        string id, name, pic;
        float price;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Pic { get => pic; set => pic = value; }
        public float Price { get => price; set => price = value; }

        // KHOI TAO
        public Phone(string i = "", string n = "", float pri = 0, string p = "")
        {
            id = i; name = n;
            pic = p; price = pri;
        }

        // TINH GIA BAN
        public float Sale()
        {
            if (name.CompareTo("iphone") == 0)// string.Compare(name,"iphone")==0
                return 1.5f * price;
            else
                return 1.3f * price;
        }

        // CAI DAT PHUONG THUC TRONG IComparable
        public int CompareTo(Phone ph)
        {
            if (Sale() < ph.Sale()) return 1;
            else if (Sale() == ph.Sale()) return 0;
            else return -1;
        }
    }
}
