using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccsessLayer.Abstract;
using HotelProject.DataAccsessLayer.Concrete;
using HotelProject.DataAccsessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
namespace HotelProject.DataAccsessLayer.EntityFramework
{
    public class EFTestimonialDal:GenericRepository<Testimonial>,ITestimonialDal
    {
        public EFTestimonialDal(Context context) : base(context) 
        {
            
        }
    }
}
