using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace MyStorageSite.Models
{
    public class IndexModel:PageModel
    {
        public string SomeMsg { get; set; }
        public void OnPost()
        {
            SomeMsg = "Hello from razor " + DateTime.Now;
        }
    }
}
