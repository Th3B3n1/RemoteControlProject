internal class HIFI : IDevice
{
    private bool poweredOn = false;
    private int channel = 0;
    private int volume = 0;
    public void PowerOn()
    {
        if (!this.poweredOn)
        {
            this.poweredOn = true;
            Console.WriteLine("The HIFI is powered on.");
        }
        else
        {
            Console.WriteLine("The HIFI is already powered on.");
        }
    }
    public void PowerOff()
    {
        if (this.poweredOn)
        {
            this.poweredOn = false;
            Console.WriteLine("The HIFI is powered off.");
        }
        else
        {
            Console.WriteLine("The HIFI is already powered off.");
        }
    }
    public void ChangeChannel(int channel)
    {
        if (channel > 0)
        {
            this.channel = channel;
            Console.WriteLine("Current channel: " + this.channel);
        }
    }
    public void VolumeUp()
    {
        if (this.volume < 100)
        {
            this.volume += 1;
            Console.WriteLine("Current volume: " + this.volume);
        }
        else
        {
            Console.WriteLine("The volume is already the biggest possible.");
        }
    }
    public void VolumeDown()
    {
        if (this.volume > 0)
        {
            this.volume--;
            Console.WriteLine("Current volume: " + this.volume);
        }
        else
        {
            Console.WriteLine("The volume is already the lowest possible.");
        }
    }
}