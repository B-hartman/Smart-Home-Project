using SmartHome.Domain.Devices.Light;

namespace SmartHome.Domain.Devices
{
    internal class TransitionFactory
    {
        private readonly Dictionary<string, Func<IDeviceState>> _registry =
        new(StringComparer.OrdinalIgnoreCase)
        {
            ["LightOnState"] = () => new LightOnState(),
            ["LightOffState"] = () => new LightOffState()

        };
    }
}
