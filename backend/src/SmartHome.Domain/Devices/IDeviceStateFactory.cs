

using SmartHome.Domain.Devices.Light;

namespace SmartHome.Domain.Devices
{
    internal class DeviceStateFactory
    {
        private readonly Dictionary<string, Func<IDeviceState>> _registry =
        new(StringComparer.OrdinalIgnoreCase)
        {
            ["LightOnState"] = () => new LightOnState(),
            ["LightOffState"] = () => new LightOffState()
            //["LightOnBrightnessState"] = () => new LightOnBrightnessState(),
            //["LightOnColorState"] = () => new LightOnColorState(),

        };
    }
}
