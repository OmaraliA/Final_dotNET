using System;
using System.Collections.Generic;
namespace final.Models
{

    public interface IProjectsManagerssss
   {
     IEnumerable<Detail> GetAll();
     
   }
    public class DetailManager : IProjectsManagerssss
    {
        
        private readonly IProjectsRepository4 _projectsRepository;
 
     public DetailManager(IProjectsRepository4 projectsRepository)
       {
         _projectsRepository = projectsRepository;
       }
        public IEnumerable<Detail> GetAll()
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