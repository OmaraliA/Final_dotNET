using System;
using System.Collections.Generic;
namespace final.Models
{

    public interface IProjectsManagerss
   {
     IEnumerable<Product> GetAll();
     
   }
    public class ProductManager : IProjectsManagerss
    {
        
        private readonly IProjectsRepository2 _projectsRepository;
 
     public ProductManager(IProjectsRepository2 projectsRepository)
       {
         _projectsRepository = projectsRepository;
       }
        public IEnumerable<Product> GetAll()
        {
             return _projectsRepository.GetAll();
        }
        // public void  OnDelete(int id){
        //   _projectsRepository.
        // }
        // public List<Detail> ReturnDetails(var lsits){

        //     var _list = _projectsRepository.GetAll();
        //     double avg = _list.Average(t => t.mark);
        //     int size = _list.size();
        //     int sum = _list.Sum(x => x.mark);
        //     int maxx = _list.Max(x =>x.Max);
        
        //     Detail newDetail = new Detail(_list,avg,size,sum,maxx);
        //     return newDetail;
             

        // }
    }
}