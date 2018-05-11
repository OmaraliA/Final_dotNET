using System;
using System.Collections.Generic;
namespace final.Models
{

    public interface IProjectsManagersst
   {
     IEnumerable<Report> GetAll();
     
   }
    public class ReportManager : IProjectsManagersst
    {
        
        private readonly IProjectsRepository5 _projectsRepository;
 
     public ReportManager(IProjectsRepository5 projectsRepository)
       {
         _projectsRepository = projectsRepository;
       }
        public IEnumerable<Report> GetAll()
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