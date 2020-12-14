using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponWithOCP
{
    class CouponWithPercentage : Coupon
    {
        public double discPercentage = 0;

        public CouponWithPercentage(double discPercentage)
        {
            this.discPercentage = discPercentage;
        }
        public override double calculate(double originalPrice)
        {
            return (100 - discPercentage) * originalPrice / 100;
        }
    }
}
