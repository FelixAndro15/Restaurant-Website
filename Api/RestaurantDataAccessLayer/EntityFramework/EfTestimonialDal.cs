using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantDataAccessLayer.Abstract;
using RestaurantDataAccessLayer.Concrete;
using RestaurantDataAccessLayer.Repositories;
using RestaurantEntityLayer.Concrete;

namespace RestaurantDataAccessLayer.EntityFramework
{
    public class EfTestimonialDal:GenericRepository<Testimonial>,ITestimonialDal
    {
        public EfTestimonialDal(Context context): base(context)
        {
                
        }
    }
}
