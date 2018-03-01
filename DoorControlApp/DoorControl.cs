using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace DoorControlApp
{
    public class DoorControl
    {
        private IDoor _door;
        private IAlarm _alarm;
        private IEntryNotification _entryNotification;
        private IUserValidation _userValidation;
        private enum DState { Open, Closed}

        private DState _doorState;

        public DoorControl(IDoor door,IAlarm alarm, IEntryNotification entryNotification, IUserValidation userValidation)
        {
            _door = door;
            _alarm = alarm;
            _entryNotification = entryNotification;
            _userValidation = userValidation;
            _doorState = DState.Closed;
        }

        public void RequestEntry(int id)
        {
            if (_userValidation.ValidateEntryRequest(id))
            {
                switch (_doorState)
                {
                    case DState.Closed:
                        _door.Open();
                        _entryNotification.NotifyEntryGranted();
                        break;

                    case DState.Open:
                        break;

                }
            }
            else
            {
                _entryNotification.NotifyEntryDenied();
            }
        }

        public void DoorOpen()
        {
            _doorState = DState.Open;
            _door.Close();
        }

        public void DoorClosed()
        {
            _doorState = DState.Closed;
        }
    }
}
