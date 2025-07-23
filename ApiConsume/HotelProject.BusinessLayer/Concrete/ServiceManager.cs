using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccsessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _servicesDal;

        public ServiceManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public List<Service> GTetList()
        {
            return _servicesDal.GetList();
        }

        public void TDelete(Service t)
        {
            _servicesDal.Delete(t);
        }

        public Service TGetById(int id)
        {
            return _servicesDal.GetById(id);
        }

        public void TInsert(Service t)
        {
            _servicesDal.Insert(t);
        }

        public void TUpdate(Service t)
        {
           _servicesDal.Update(t);
        }
    }
}
