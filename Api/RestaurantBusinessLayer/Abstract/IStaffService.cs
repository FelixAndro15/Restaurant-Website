using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantEntityLayer.Concrete;

namespace RestaurantBusinessLayer.Abstract
{
    public interface IStaffService:IGenericService<Staff>
    {
        int TGetStaffCount();
        List<Staff> TLast4Staff();
    }
}
