namespace SmartHome.Domain.Devices
{
    internal interface IDeviceContext
    {
        IReadOnlyList<Transition> AvailableActions();
        TransitionResult Execute(DeviceAction action);
        internal void SetState(IDeviceState state);
    }
}
