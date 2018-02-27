using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DoorControlApp.Test.Unit
{
    [TestFixture]
    public class DoorControlUnitTests
    {
        private DoorControl _uut;

        [SetUp]

        public void SetUp()
        {
            _uut = new DoorControl();
        }
    }
}
