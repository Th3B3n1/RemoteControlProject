internal interface IDevice
{
    void PowerOn();
    void PowerOff();
    void ChangeChannel(int channel);
    void VolumeUp();
    void VolumeDown();
}