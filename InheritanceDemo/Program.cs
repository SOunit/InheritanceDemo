namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio(true, "test");
            radio.SwitchOff();
            radio.ListenRadio();

            TV tv = new TV(false, "tv");
            tv.SwitchOn();
            tv.WatchTV();
        }
    }
}
