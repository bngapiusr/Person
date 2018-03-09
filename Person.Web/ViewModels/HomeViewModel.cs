using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonDemo.DomainClasses;

namespace PersonDemo.Web.ViewModels
{
    public class HomeViewModel
    {
        public List<PersonInfo> People { get; set; }
        public string Title { get; set; }
    }
}
