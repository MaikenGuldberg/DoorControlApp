namespace DoorControlApp
{
    public interface IEntryNotification
    {
        void NotifyEntryGranted();
        void NotifyEntryDenied();
    }
}