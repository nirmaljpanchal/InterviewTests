using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests
    {
        [TestMethod]
        public void TestHasGraduated()
        {
            var tracker = new GraduationTracker();

            IDiploma diploma = Repository.GetDiploma(1);


            // I could have use directly GetStudents but it is private, that's why I used GetStudent() method.
            IStudent[] students = new[]
            {
                Repository.GetStudent(1),
                Repository.GetStudent(2),
                Repository.GetStudent(3),
                Repository.GetStudent(4)
            };

            var graduated = new List<Tuple<bool, STANDING>>();
            foreach(var student in students)
            {
                graduated.Add(tracker.HasGraduated(diploma, student));      
            }
            
            Assert.IsTrue(graduated[0].Item2==STANDING.MagnaCumLaude);
            Assert.IsTrue(graduated[1].Item2==STANDING.SumaCumLaude);
            Assert.IsTrue(graduated[2].Item2==STANDING.Average);
            Assert.IsTrue(graduated[3].Item2==STANDING.Remedial);
        }
    }
}
