
namespace SmartHome.Domain.Devices.Light
{
    internal class LightContext : IDeviceContext
    {
        IDeviceState state;
        IReadOnlyList<Transition> transitions;

        LightContext(IDeviceState state)
        {
            this.state = state;
            transitions = new List<Transition>();
        }

        IReadOnlyList<Transition> IDeviceContext.AvailableActions()
        {
            return transitions;
        }

        TransitionResult IDeviceContext.Execute(DeviceAction action)
        {
            return state.Execute(action,this);
        }

        void IDeviceContext.SetState(IDeviceState state)
        {
            this.state = state;
        }
    }
}
