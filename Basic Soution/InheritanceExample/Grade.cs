using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancGradeOfStudent :StudentMarks
    {
        public String Grade {  get; set; }

        public char CalculateGrade()
        {
            
            if (Average > 89)
            {
                return 'A';
            }
            if (Average > 79)
            {
                return 'B';
            }
            if (Average > 69)
            {
                return 'C';
            }
            if (Average > 59)
            {
                return 'D';
            }
            return 'E';
        }
    }  }

