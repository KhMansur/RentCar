using RentCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    public static class ServiceClient
    {
        //EntityForClient entity = new EntityForClient();

        static public List<Mijoz> Pagging(int PerPage, int currentPage)
        {

            List<Mijoz> list = new List<Mijoz>();
            //list = entity.GetAll();

            var result = list.Skip((currentPage - 1)*PerPage). Take(PerPage).ToList();
            return result;
        }
       // static public List<Mijoz> Search(string str)
       // {
           // List<Mijoz> list = new List<Mijoz>();
            //list = entity.GetAll();
            var result = list.Where().Take(str).ToList();
            return result;
        }
        static public List<Mijoz> Sort()
        {
            List<Mijoz> list = new List<Mijoz>();
            //list = entity.GetAll();
            var result = list.OrderBy(x => x.Ismi).ToList();
            return result;
        }
    }
}
