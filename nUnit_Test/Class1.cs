using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using NUnit_JatinVerma;

namespace nUnit_Test_JatinVerma
{
    public class Class1
    {

        [Test]

        public void TriangleTestOutput()
        {
            //arrange
            int firstAngle = 60;
            int secondAngle =60;
            int thirdAngle = 60;

            string expected = "The triangle is valid.";

            //act

            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);


            //assert
            ClassicAssert.AreEqual(expected, actual);
        }
    }
}