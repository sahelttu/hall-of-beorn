﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Models.Products
{
    public class ReturnToMirkwoodNightmareProduct : Product
    {
        public ReturnToMirkwoodNightmareProduct()
            : base("Return to Mirkwood Nightmare Deck", "MEN09", ImageType.Jpg, new DateTime(2014, 4, 16))
        {
            AddCardSet(CardSet.ReturnToMirkwoodNightmare);
        }
    }
}