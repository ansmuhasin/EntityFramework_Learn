using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            PlutoDBContext plutoDBContext = new PlutoDBContext();
            ObjectResult<GetCourses_Result> GetCourses_Results = plutoDBContext.GetCourses();
            foreach (GetCourses_Result item in GetCourses_Results)
            {
                Console.WriteLine(item.Description);
            }
            Console.ReadLine();
        }
    }
}
