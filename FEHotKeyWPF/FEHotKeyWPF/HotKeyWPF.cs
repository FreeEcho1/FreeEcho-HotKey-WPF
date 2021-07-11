namespace FreeEcho
{
    namespace FEHotKeyWPF
    {
        /// <summary>
        /// ホットキー (WPF)
        /// </summary>
        public class HotKeyWPF
        {
            /// <summary>
            /// <para>キーイベント情報からホットキー情報を取得</para>
            /// <para>「PreviewKeyDown」を使用する必要がある。「KeyDown」だと一部キーが機能しない</para>
            /// </summary>
            /// <param name="e">キーイベント</param>
            /// <param name="backspaceErase">Back Spaceは無し (No「false」/Yes「true」)</param>
            /// <returns>ホットキー情報</returns>
            public static HotKeyInformation GetHotKey(
                System.Windows.Input.KeyEventArgs e,
                bool backspaceErase = false
                )
            {
                HotKeyInformation hotKeyInformation = new()
                {
                    Alt = false,
                    Ctrl = false,
                    Shift = false,
                    KeyCharacter = 0
                };

                if (backspaceErase ? (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Back) == false) : true)
                {
                    if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.LeftCtrl) || e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.RightCtrl))
                    {
                        hotKeyInformation.Ctrl = true;
                    }
                    if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.LeftShift) || e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.RightShift))
                    {
                        hotKeyInformation.Shift = true;
                    }
                    if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.LeftAlt) || e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.RightAlt))
                    {
                        hotKeyInformation.Alt = true;
                    }
                    if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.LWin) || e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.RWin))
                    {
                        hotKeyInformation.Windows = true;
                    }

                    if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.A))
                    {
                        hotKeyInformation.KeyCharacter = (int)'A';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.B))
                    {
                        hotKeyInformation.KeyCharacter = (int)'B';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.C))
                    {
                        hotKeyInformation.KeyCharacter = (int)'C';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D))
                    {
                        hotKeyInformation.KeyCharacter = (int)'D';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.E))
                    {
                        hotKeyInformation.KeyCharacter = (int)'E';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F))
                    {
                        hotKeyInformation.KeyCharacter = (int)'F';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.G))
                    {
                        hotKeyInformation.KeyCharacter = (int)'G';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.H))
                    {
                        hotKeyInformation.KeyCharacter = (int)'H';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.I))
                    {
                        hotKeyInformation.KeyCharacter = (int)'I';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.J))
                    {
                        hotKeyInformation.KeyCharacter = (int)'J';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.K))
                    {
                        hotKeyInformation.KeyCharacter = (int)'K';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.L))
                    {
                        hotKeyInformation.KeyCharacter = (int)'L';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.M))
                    {
                        hotKeyInformation.KeyCharacter = (int)'M';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.N))
                    {
                        hotKeyInformation.KeyCharacter = (int)'N';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.O))
                    {
                        hotKeyInformation.KeyCharacter = (int)'O';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.P))
                    {
                        hotKeyInformation.KeyCharacter = (int)'P';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Q))
                    {
                        hotKeyInformation.KeyCharacter = (int)'Q';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.R))
                    {
                        hotKeyInformation.KeyCharacter = (int)'R';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.S))
                    {
                        hotKeyInformation.KeyCharacter = (int)'S';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.T))
                    {
                        hotKeyInformation.KeyCharacter = (int)'T';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.U))
                    {
                        hotKeyInformation.KeyCharacter = (int)'U';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.V))
                    {
                        hotKeyInformation.KeyCharacter = (int)'V';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.W))
                    {
                        hotKeyInformation.KeyCharacter = (int)'W';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.X))
                    {
                        hotKeyInformation.KeyCharacter = (int)'X';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Y))
                    {
                        hotKeyInformation.KeyCharacter = (int)'Y';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Z))
                    {
                        hotKeyInformation.KeyCharacter = (int)'Z';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D0))
                    {
                        hotKeyInformation.KeyCharacter = (int)'0';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D1))
                    {
                        hotKeyInformation.KeyCharacter = (int)'1';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D2))
                    {
                        hotKeyInformation.KeyCharacter = (int)'2';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D3))
                    {
                        hotKeyInformation.KeyCharacter = (int)'3';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D4))
                    {
                        hotKeyInformation.KeyCharacter = (int)'4';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D5))
                    {
                        hotKeyInformation.KeyCharacter = (int)'5';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D6))
                    {
                        hotKeyInformation.KeyCharacter = (int)'6';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D7))
                    {
                        hotKeyInformation.KeyCharacter = (int)'7';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D8))
                    {
                        hotKeyInformation.KeyCharacter = (int)'8';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D9))
                    {
                        hotKeyInformation.KeyCharacter = (int)'9';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Space))
                    {
                        hotKeyInformation.KeyCharacter = (int)' ';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Left))
                    {
                        hotKeyInformation.KeyCharacter = 37;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Up))
                    {
                        hotKeyInformation.KeyCharacter = 38;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Right))
                    {
                        hotKeyInformation.KeyCharacter = 39;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Down))
                    {
                        hotKeyInformation.KeyCharacter = 40;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F1))
                    {
                        hotKeyInformation.KeyCharacter = 112;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F2))
                    {
                        hotKeyInformation.KeyCharacter = 113;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F3))
                    {
                        hotKeyInformation.KeyCharacter = 114;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F4))
                    {
                        hotKeyInformation.KeyCharacter = 115;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F5))
                    {
                        hotKeyInformation.KeyCharacter = 116;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F6))
                    {
                        hotKeyInformation.KeyCharacter = 117;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F7))
                    {
                        hotKeyInformation.KeyCharacter = 118;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F8))
                    {
                        hotKeyInformation.KeyCharacter = 119;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F9))
                    {
                        hotKeyInformation.KeyCharacter = 120;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F10))
                    {
                        hotKeyInformation.KeyCharacter = 121;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F11))
                    {
                        hotKeyInformation.KeyCharacter = 122;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F12))
                    {
                        hotKeyInformation.KeyCharacter = 123;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F13))
                    {
                        hotKeyInformation.KeyCharacter = 124;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F14))
                    {
                        hotKeyInformation.KeyCharacter = 125;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F15))
                    {
                        hotKeyInformation.KeyCharacter = 126;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F16))
                    {
                        hotKeyInformation.KeyCharacter = 127;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F17))
                    {
                        hotKeyInformation.KeyCharacter = 128;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F18))
                    {
                        hotKeyInformation.KeyCharacter = 129;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F19))
                    {
                        hotKeyInformation.KeyCharacter = 130;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F20))
                    {
                        hotKeyInformation.KeyCharacter = 131;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F21))
                    {
                        hotKeyInformation.KeyCharacter = 132;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F22))
                    {
                        hotKeyInformation.KeyCharacter = 133;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F23))
                    {
                        hotKeyInformation.KeyCharacter = 134;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F24))
                    {
                        hotKeyInformation.KeyCharacter = 135;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Tab))
                    {
                        hotKeyInformation.KeyCharacter = 9;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Enter))
                    {
                        hotKeyInformation.KeyCharacter = 13;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.CapsLock))
                    {
                        hotKeyInformation.KeyCharacter = 20;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Escape))
                    {
                        hotKeyInformation.KeyCharacter = 27;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.PageUp))
                    {
                        hotKeyInformation.KeyCharacter = 33;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.PageDown))
                    {
                        hotKeyInformation.KeyCharacter = 34;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.End))
                    {
                        hotKeyInformation.KeyCharacter = 35;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Home))
                    {
                        hotKeyInformation.KeyCharacter = 36;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Delete))
                    {
                        hotKeyInformation.KeyCharacter = 46;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemBackslash))
                    {
                        hotKeyInformation.KeyCharacter = 226;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemCloseBrackets))
                    {
                        hotKeyInformation.KeyCharacter = 221;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemComma))
                    {
                        hotKeyInformation.KeyCharacter = 188;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemMinus))
                    {
                        hotKeyInformation.KeyCharacter = 189;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemOpenBrackets))
                    {
                        hotKeyInformation.KeyCharacter = 219;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemPeriod))
                    {
                        hotKeyInformation.KeyCharacter = 190;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemPlus))
                    {
                        hotKeyInformation.KeyCharacter = 187;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemQuestion))
                    {
                        hotKeyInformation.KeyCharacter = 191;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemQuotes))
                    {
                        hotKeyInformation.KeyCharacter = 222;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemSemicolon))
                    {
                        hotKeyInformation.KeyCharacter = 186;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemTilde))
                    {
                        hotKeyInformation.KeyCharacter = 192;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemPipe))
                    {
                        hotKeyInformation.KeyCharacter = 220;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Back))
                    {
                        hotKeyInformation.KeyCharacter = 8;
                    }
                }

                return (hotKeyInformation);
            }

            /// <summary>
            /// ホットキー情報からホットキーの文字列を取得
            /// </summary>
            /// <param name="hotKeyInformation">ホットキー情報</param>
            /// <returns>ホットキー文字列 (失敗「null」)</returns>
            public static string GetHotKeyString(
                HotKeyInformation hotKeyInformation
                )
            {
                string hotKeyString = "";
                string plus = "";

                if (hotKeyInformation.Ctrl)
                {
                    hotKeyString += plus + "Ctrl";
                    plus = " + ";
                }
                if (hotKeyInformation.Shift)
                {
                    hotKeyString += plus + "Shift";
                    plus = " + ";
                }
                if (hotKeyInformation.Alt)
                {
                    hotKeyString += plus + "Alt";
                    plus = " + ";
                }
                if (hotKeyInformation.Windows)
                {
                    hotKeyString += plus + "Windows";
                    plus = " + ";
                }

                switch (hotKeyInformation.KeyCharacter)
                {
                    case (int)'A':
                        hotKeyString += plus + "A";
                        break;
                    case (int)'B':
                        hotKeyString += plus + "B";
                        break;
                    case (int)'C':
                        hotKeyString += plus + "C";
                        break;
                    case (int)'D':
                        hotKeyString += plus + "D";
                        break;
                    case (int)'E':
                        hotKeyString += plus + "E";
                        break;
                    case (int)'F':
                        hotKeyString += plus + "F";
                        break;
                    case (int)'G':
                        hotKeyString += plus + "G";
                        break;
                    case (int)'H':
                        hotKeyString += plus + "H";
                        break;
                    case (int)'I':
                        hotKeyString += plus + "I";
                        break;
                    case (int)'J':
                        hotKeyString += plus + "J";
                        break;
                    case (int)'K':
                        hotKeyString += plus + "K";
                        break;
                    case (int)'L':
                        hotKeyString += plus + "L";
                        break;
                    case (int)'M':
                        hotKeyString += plus + "M";
                        break;
                    case (int)'N':
                        hotKeyString += plus + "N";
                        break;
                    case (int)'O':
                        hotKeyString += plus + "O";
                        break;
                    case (int)'P':
                        hotKeyString += plus + "P";
                        break;
                    case (int)'Q':
                        hotKeyString += plus + "Q";
                        break;
                    case (int)'R':
                        hotKeyString += plus + "R";
                        break;
                    case (int)'S':
                        hotKeyString += plus + "S";
                        break;
                    case (int)'T':
                        hotKeyString += plus + "T";
                        break;
                    case (int)'U':
                        hotKeyString += plus + "U";
                        break;
                    case (int)'V':
                        hotKeyString += plus + "V";
                        break;
                    case (int)'W':
                        hotKeyString += plus + "W";
                        break;
                    case (int)'X':
                        hotKeyString += plus + "X";
                        break;
                    case (int)'Y':
                        hotKeyString += plus + "Y";
                        break;
                    case (int)'Z':
                        hotKeyString += plus + "Z";
                        break;
                    case (int)'0':
                        hotKeyString += plus + "0";
                        break;
                    case (int)'1':
                        hotKeyString += plus + "1";
                        break;
                    case (int)'2':
                        hotKeyString += plus + "2";
                        break;
                    case (int)'3':
                        hotKeyString += plus + "3";
                        break;
                    case (int)'4':
                        hotKeyString += plus + "4";
                        break;
                    case (int)'5':
                        hotKeyString += plus + "5";
                        break;
                    case (int)'6':
                        hotKeyString += plus + "6";
                        break;
                    case (int)'7':
                        hotKeyString += plus + "7";
                        break;
                    case (int)'8':
                        hotKeyString += plus + "8";
                        break;
                    case (int)'9':
                        hotKeyString += plus + "9";
                        break;
                    case (int)' ':
                        hotKeyString += plus + "Space";
                        break;
                    case 37:
                        hotKeyString += plus + "Left";
                        break;
                    case 38:
                        hotKeyString += plus + "Up";
                        break;
                    case 39:
                        hotKeyString += plus + "Right";
                        break;
                    case 40:
                        hotKeyString += plus + "Down";
                        break;
                    case 112:
                        hotKeyString += plus + "F1";
                        break;
                    case 113:
                        hotKeyString += plus + "F2";
                        break;
                    case 114:
                        hotKeyString += plus + "F3";
                        break;
                    case 115:
                        hotKeyString += plus + "F4";
                        break;
                    case 116:
                        hotKeyString += plus + "F5";
                        break;
                    case 117:
                        hotKeyString += plus + "F6";
                        break;
                    case 118:
                        hotKeyString += plus + "F7";
                        break;
                    case 119:
                        hotKeyString += plus + "F8";
                        break;
                    case 120:
                        hotKeyString += plus + "F9";
                        break;
                    case 121:
                        hotKeyString += plus + "F10";
                        break;
                    case 122:
                        hotKeyString += plus + "F11";
                        break;
                    case 123:
                        hotKeyString += plus + "F12";
                        break;
                    case 124:
                        hotKeyString += plus + "F13";
                        break;
                    case 125:
                        hotKeyString += plus + "F14";
                        break;
                    case 126:
                        hotKeyString += plus + "F15";
                        break;
                    case 127:
                        hotKeyString += plus + "F16";
                        break;
                    case 128:
                        hotKeyString += plus + "F17";
                        break;
                    case 129:
                        hotKeyString += plus + "F18";
                        break;
                    case 130:
                        hotKeyString += plus + "F19";
                        break;
                    case 131:
                        hotKeyString += plus + "F20";
                        break;
                    case 132:
                        hotKeyString += plus + "F21";
                        break;
                    case 133:
                        hotKeyString += plus + "F22";
                        break;
                    case 134:
                        hotKeyString += plus + "F23";
                        break;
                    case 135:
                        hotKeyString += plus + "F24";
                        break;
                    case 9:
                        hotKeyString += plus + "Tab";
                        break;
                    case 13:
                        hotKeyString += plus + "Enter";
                        break;
                    case 20:
                        hotKeyString += plus + "CapsLock";
                        break;
                    case 27:
                        hotKeyString += plus + "Escape";
                        break;
                    case 33:
                        hotKeyString += plus + "PageUp";
                        break;
                    case 34:
                        hotKeyString += plus + "PageDown";
                        break;
                    case 35:
                        hotKeyString += plus + "End";
                        break;
                    case 36:
                        hotKeyString += plus + "Home";
                        break;
                    case 46:
                        hotKeyString += plus + "Delete";
                        break;
                    case 226:
                        hotKeyString += plus + "\\";
                        break;
                    case 221:
                        hotKeyString += plus + "]";
                        break;
                    case 188:
                        hotKeyString += plus + ",";
                        break;
                    case 189:
                        hotKeyString += plus + "-";
                        break;
                    case 219:
                        hotKeyString += plus + "[";
                        break;
                    case 190:
                        hotKeyString += plus + ".";
                        break;
                    case 187:
                        hotKeyString += plus + ";";
                        break;
                    case 191:
                        hotKeyString += plus + "/";
                        break;
                    case 222:
                        hotKeyString += plus + "^";
                        break;
                    case 186:
                        hotKeyString += plus + ":";
                        break;
                    case 192:
                        hotKeyString += plus + "@";
                        break;
                    case 220:
                        hotKeyString += plus + "\\";
                        break;
                    case 8:
                        hotKeyString += plus + "BackSpace";
                        break;
                }

                return (hotKeyString);
            }
        }
    }
}
