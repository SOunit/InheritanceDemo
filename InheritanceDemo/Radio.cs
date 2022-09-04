namespace InheritanceDemo
{
    internal class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
        }

        public void ListenRadio()
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
