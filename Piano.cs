using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace PianoKeyboard
{
    public class Piano
    {
        void playKeyboard(ConsoleKeyInfo keyInfo)
        {
            // Check if any modifier keys (Shift, Ctrl, Alt) were pressed
            bool shift = (keyInfo.Modifiers & ConsoleModifiers.Shift) != 0;
            bool ctrl = (keyInfo.Modifiers & ConsoleModifiers.Control) != 0;
            bool alt = (keyInfo.Modifiers & ConsoleModifiers.Alt) != 0;

            //bool numLock = Control.IsKeyLocked(Keys.NumLock);

            Console.WriteLine("Key: {0}, Shift: {1}, Ctrl: {2}, Alt: {3}, NumLock {4}",
                    keyInfo.Key, shift, ctrl, alt, numLock);
        }

        void loopKeyboard()
        {
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            do
            {
                if (Console.KeyAvailable)
                {
                    // Read the key that was pressed
                    keyInfo = Console.ReadKey(true);

                    // Print the key and modifier keys that were pressed
                    playKeyboard(keyInfo);
                }
            }
            while (keyInfo.Key != ConsoleKey.Escape);
        }

        void drawPiano()
        {
            Console.WriteLine("----------------------------|-----------------------------|--------------------------------");
            Console.WriteLine("    1   2       4   5   6   |   8   9       '   ¡   DEL   |     INS   INI       BLO /   *  ");
            Console.WriteLine("TAB | Q | W | E | R | T | Y | U | I | O | P | ` | + | ENT | SUP | FIN | AVP | 7 | 8 | 9 | +");
            Console.WriteLine("----------------------------|-----------------------------|--------------------------------");
        }

        public void start()
        {
            drawPiano();
            loopKeyboard();
        }
    }
}
