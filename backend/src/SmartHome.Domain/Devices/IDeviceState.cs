namespace SmartHome.Domain.Devices
{
    internal interface IDeviceState
    {
        string Name { get; }
        IReadOnlyList<Transition> AvailableActions { get; }
        TransitionResult Execute(DeviceAction action, IDeviceContext context);
    }
}
