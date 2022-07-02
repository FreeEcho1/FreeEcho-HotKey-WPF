namespace FreeEcho.FEHotKeyWPF;

/// <summary>
/// ホットキー処理
/// </summary>
public static class HotKeyProcessing
{
    /// <summary>
    /// ホットキーを登録
    /// </summary>
    /// <param name="hwnd">ウィンドウハンドル</param>
    /// <param name="hotKeyInformation">ホットキー情報</param>
    /// <param name="id">ホットキーの識別子 (0x0000～0xBFFF)</param>
    /// <returns>結果 (登録に失敗「false」/登録に成功「true」)</returns>
    public static bool RegisterHotKey(
        System.IntPtr hwnd,
        HotKeyInformation hotKeyInformation,
        int id
        )
    {
        return RegisterHotKey(hwnd, hotKeyInformation.Alt, hotKeyInformation.Ctrl, hotKeyInformation.Shift, hotKeyInformation.Windows, hotKeyInformation.KeyCharacter, id);
    }

    /// <summary>
    /// ホットキーを登録
    /// </summary>
    /// <param name="hwnd">ウィンドウハンドル</param>
    /// <param name="alt">Alt</param>
    /// <param name="ctrl">Ctrl</param>
    /// <param name="shift">Shift</param>
    /// <param name="windows">Windows</param>
    /// <param name="vk">仮想キーコード (文字)</param>
    /// <param name="id">ホットキーの識別子 (0x0000～0xBFFF)</param>
    /// <returns>結果 (登録に失敗「false」/登録に成功「true」)</returns>
    public static bool RegisterHotKey(
        System.IntPtr hwnd,
        bool alt,
        bool ctrl,
        bool shift,
        bool windows,
        int vk,
        int id
        )
    {
        int modKey = 0;

        if (alt)
        {
            modKey |= 0x0001;       // MOD_ALT
        }
        if (ctrl)
        {
            modKey |= 0x0002;       // MOD_CONTROL
        }
        if (shift)
        {
            modKey |= 0x0004;     // MOD_SHIFT
        }
        if (windows)
        {
            modKey |= 0x0008;     // MOD_WIN
        }

        return NativeMethods.RegisterHotKey(hwnd, id, modKey, vk) != 0;
    }

    /// <summary>
    /// 定義したホットキーを破棄
    /// </summary>
    /// <param name="hwnd">ウィンドウハンドル</param>
    /// <param name="id">ホットキーの識別子</param>
    /// <returns>結果 (破棄に失敗「false」/破棄に成功「true」)</returns>
    public static bool UnregisterHotKey(
        System.IntPtr hwnd,
        int id
        )
    {
        return NativeMethods.UnregisterHotKey(hwnd, id) != 0;
    }
}
