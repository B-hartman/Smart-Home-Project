
namespace SmartHome.Domain.Devices.Light
{
    internal class LightOnState : IDeviceState
    {
        public string Name { get; }

        public IReadOnlyList<Transition> AvailableActions { get; }

        public LightOnState(IReadOnlyList<Transition> transitions)
        {
            Name = "LightOnState";
            AvailableActions = transitions;
        }

        public TransitionResult Execute(DeviceAction action, IDeviceContext context)
        {
            Transition transition = AvailableActions.FirstOrDefault(t => t.Action == action);
            TransitionResult result 
            return result;
        }

        TransitionResult IDeviceState.Execute(DeviceAction action, IDeviceContext context)
        {
            throw new NotImplementedException();
        }
    }
}
