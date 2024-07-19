// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

SingleNumber singleNumber = new SingleNumber();
while (true)
{
    singleNumber.click();
    Thread.Sleep(10000);
}
Console.ReadLine(); 

internal class SingleNumber
{
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtions, uint dwExtraInfo);
    private const uint leftD = 0x02;
    private const uint leftU = 0x04;
    public void click()
    {
        mouse_event(leftD, 0, 0, 0, 0);
        mouse_event(leftU, 0, 0, 0, 0);
    }
}
