namespace FreeEcho.FEHotKeyWPF;

/// <summary>
/// ホットキー情報
/// </summary>
public class HotKeyInformation
{
    /// <summary>
    /// Ctrl
    /// </summary>
    public bool Ctrl
    {
        get;
        set;
    } = false;
    /// <summary>
    /// Shift
    /// </summary>
    public bool Shift
    {
        get;
        set;
    } = false;
    /// <summary>
    /// Alt
    /// </summary>
    public bool Alt
    {
        get;
        set;
    } = false;
    /// <summary>
    /// Windows
    /// </summary>
    public bool Windows
    {
        get;
        set;
    } = false;
    /// <summary>
    /// 数字及び文字
    /// </summary>
    public int KeyCharacter
    {
        get;
        set;
    } = 0;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public HotKeyInformation()
    {
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="hotKeyInformation">ホットキー情報</param>
    public HotKeyInformation(
        HotKeyInformation hotKeyInformation
        )
    {
        Copy(hotKeyInformation);
    }

    /// <summary>
    /// コピー
    /// </summary>
    /// <param name="hotKeyInformation">ホットキー情報</param>
    public void Copy(
        HotKeyInformation hotKeyInformation
        )
    {
        if (hotKeyInformation != null)
        {
            Alt = hotKeyInformation.Alt;
            Ctrl = hotKeyInformation.Ctrl;
            Shift = hotKeyInformation.Shift;
            Windows = hotKeyInformation.Windows;
            KeyCharacter = hotKeyInformation.KeyCharacter;
        }
    }
}
