﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class TheSandsOfHaradProduct : Product
    {
        public TheSandsOfHaradProduct()
            : base("The Sands of Harad", "MEC55", ImageType.Jpg)
        {
            AddCardSet(CardSet.TheSandsOfHarad);
        }
    }
}