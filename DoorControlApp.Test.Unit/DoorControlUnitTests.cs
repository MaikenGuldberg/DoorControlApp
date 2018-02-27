using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NSubstitute;

namespace DoorControlApp.Test.Unit
{
    [TestFixture]
    public class DoorControlUnitTests
    {
        private DoorControl _uut;
        private IDoor _doorFake;
        private IAlarm _alarmFake;
        private IEntryNotification _entryNotificationFake;
        private IUserValidation _userValidationFake;

        [SetUp]

        public void SetUp()
        {
            _doorFake = Substitute.For<IDoor>();
            _alarmFake = Substitute.For<IAlarm>();
            _entryNotificationFake = Substitute.For<IEntryNotification>();
            _userValidationFake = Substitute.For<IUserValidation>();
            _uut = new DoorControl(_doorFake,_alarmFake,_entryNotificationFake,_userValidationFake);
        }

        [Test]

        public void Test_Jenkins_Test()
        {
            
        }
    }
}
