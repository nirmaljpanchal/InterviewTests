using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public partial class GraduationTracker
    {
        public Tuple<bool, STANDING> HasGraduated(IDiploma diploma, IStudent student)
        {
            var credits = 0;
            var average = 0;
            var totalCredit = 0;

            for (int i = 0; i < diploma.Requirements.Length; i++)
            {
                for (int j = 0; j < student.Courses.Length; j++)
                {
                    var requirement = diploma.Requirements[i];

                    for (int k = 0; k < requirement.Courses.Length; k++)
                    {
                        if (requirement.Courses[k].Id == student.Courses[j].Id)
                        {
                            average += student.Courses[j].Mark;
                            totalCredit += requirement.Credits;
                            if (student.Courses[j].Mark >= requirement.MinimumMark)
                            {
                                credits += requirement.Credits;
                            }
                        }
                    }
                }
            }

            average = average / student.Courses.Length;

            if (average < 50)
                return new Tuple<bool, STANDING>(false, STANDING.Remedial);
            else if (average < 80 && credits==totalCredit)
                return new Tuple<bool, STANDING>(true, STANDING.Average);
            else if (average < 95 && credits == totalCredit)
                return new Tuple<bool, STANDING>(true, STANDING.SumaCumLaude);
            else if (average >= 95 && credits == totalCredit)
                return new Tuple<bool, STANDING>(true, STANDING.MagnaCumLaude);
            else
                return new Tuple<bool, STANDING>(false, STANDING.Remedial);
        }
    }
}
