using System.Collections.Generic;
using TechJobs.Models;
using System.Linq;
using System.Threading.Tasks;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        
        public BaseViewModel()
        {
            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in System.Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }
        }
            public JobFieldType Column { get; set; } = JobFieldType.All;
            public List<JobFieldType> Columns { get; set; }
            public string Title { get; set; } = "";
    
    }     
    
}       





        





