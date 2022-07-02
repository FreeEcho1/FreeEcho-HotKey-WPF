namespace FreeEcho.FEHotKeyWPF;

/// <summary>
/// NativeMethods
/// </summary>
internal class NativeMethods
{
    [System.Runtime.InteropServices.DllImport("User32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public extern static int RegisterHotKey(System.IntPtr hWnd, int id, int fsModifiers, int vk);
    [System.Runtime.InteropServices.DllImport("User32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
    public extern static int UnregisterHotKey(System.IntPtr hWnd, int id);
}
