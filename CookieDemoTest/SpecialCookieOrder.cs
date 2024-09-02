using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieDemoTest
{
    public class SpecialCookieOrder : CookieOrder
    {
        public string SpecialDescription { get; set; }

        protected override void CalculatePrice()
        {
            base.CalculatePrice(); // Calculate base price

            if (Price <= 40m)
                price += 10m; // Special handling fee for orders up to $40
            else
                price += 8m;  // Special handling fee for orders over $40
        }
    }
}
