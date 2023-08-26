using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsaChapter1_1_2.Entities
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public float AverageScore { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}; Student #: {StudentNumber}; AverageScore: {AverageScore}";
        }
    }
}
