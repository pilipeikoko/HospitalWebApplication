using Microsoft.AspNetCore.Mvc.Rendering;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class SearchPatientsViewModel
    {
        public IPagedList pagedList { get; set; }
        public List<Patient> Patients { get; set; }
        public SelectList Types { get; set; }
        public Type Type { get; set; }

        public int PageSize { get; set; }

        public int PageNumber { get; set; }
        
    }
}
