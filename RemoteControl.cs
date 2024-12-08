internal class RemoteControl<T> where T : IDevice
{
    private T device;
    public RemoteControl(T device)
    {
        this.device = device;
    }
    public void PowerOn()
    {
        this.device.PowerOn();
    }
    public void PowerOff()
    {
        this.device.PowerOff();
    }
    public void ChangeChannel(int channel)
    {
        this.device.ChangeChannel(channel);
    }
    public void VolumeUp()
    {
        this.device.VolumeUp();
    }
    public void VolumeDown()
    {
        this.device.VolumeDown();
    }
}