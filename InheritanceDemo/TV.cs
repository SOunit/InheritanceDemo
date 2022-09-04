namespace InheritanceDemo
{
    internal class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {
        }

        public void WatchTV()
        {
            if (IsOn)
            {
                System.Console.WriteLine("on");
            }
            else
            {
                System.Console.WriteLine("off");
            }
        }
    }
}
