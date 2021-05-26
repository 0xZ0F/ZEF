using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace ZEF
{
    // Deals with command history.
    public class CommandBuffer
    {
        private byte index = 0;
        private byte selectedIndex = 0;
        private static byte size = 16;
        private string[] cmdBuff = new string[size];

        public void Add(string str)
        {
            if(!string.IsNullOrWhiteSpace(str))
            {
                if(index > size - 1)
                {
                    if(str == cmdBuff[size - 1])
                    {
                        return;
                    }

                    //Copy entire array back one:
                    for(int x = 0; x < size - 1; x++)
                    {
                        cmdBuff[x] = cmdBuff[x + 1];
                    }
                    cmdBuff[size - 1] = str;
                }
                else
                {
                    if(index > 0 && str == cmdBuff[index - 1])
                    {
                        return;
                    }
                    cmdBuff[index] = str;
                    index++;
                }
                selectedIndex = index;
            }
            return;
        }

        public string GetPreviousCommand()
        {
            if(selectedIndex - 1 < 0)
            {
                return cmdBuff[0];
            }
            selectedIndex--;
            return cmdBuff[selectedIndex];
        }

        public string GetNextCommand()
        {
            if(selectedIndex + 1 == size)
            {
                return (cmdBuff[size - 1]);
            }
            else if(selectedIndex + 1 > index)
            {
                Debug.WriteLine(index);
                return (cmdBuff[index]);
            }
            selectedIndex++;
            return cmdBuff[selectedIndex];
        }

        public string GetHistory()
        {
            string tmp = "";
            for(int x = 0; x < index; x++)
            {
                tmp += x+1 + ": " + cmdBuff[x] + "\r\n";
            }
            return tmp;
        }

        public string GetEntryFromHistory(int x)
        {
            if(!string.IsNullOrEmpty(cmdBuff[x]))
            {
                return cmdBuff[x];
            }
            else
            {
                return "";
            }
        }
    }

    [System.ComponentModel.DesignerCategory("")]    // Prevents Form window.
    public partial class FormMain
    {
        CommandBuffer cmdBuffer = new CommandBuffer();

        // Enter Key Up:
        private void txt_CMD_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        // Enter Key Down:
        private void txt_CMD_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string newText = "";
                if(txt_CMD.Text == "h" || txt_CMD.Text == "help")
                {
                    Log("List of commands:\r\n" +
                        "h or help - Get a list of commands and what they do.\r\n" +
                        "c - Clear the output window.\r\n" +
                        "history - View command history.\r\n" +
                        "!<#> - Run previous command in history by its index.\r\n", txt_Console);
                }
                else if(txt_CMD.Text == "c")
                {
                    txt_Console.Text = "";
                }
                else if(txt_CMD.Text == "history")
                {
                    Log($"History:\r\n{cmdBuffer.GetHistory()}", txt_Console, LogLevel.Info);
                }
                else if(txt_CMD.Text.StartsWith("!"))
                {
                    int res = -1;
                    if(Int32.TryParse(txt_CMD.Text.Substring(1), out res))
                    {
                        newText = cmdBuffer.GetEntryFromHistory(res - 1);
                    }
                    else
                    {
                        Log("Index not found in history.", txt_Console, LogLevel.Error);
                    }               
                }
                else
                {
                    Log($"Unknown Command: \"{txt_CMD.Text}\"", txt_Console, LogLevel.Warn);
                }

                if(string.IsNullOrWhiteSpace(newText))
                {
                    cmdBuffer.Add(txt_CMD.Text);
                }
                txt_CMD.Text = newText;
                e.SuppressKeyPress = true;
            }
            else if(e.KeyCode == Keys.Up)
            {
                txt_CMD.Text = cmdBuffer.GetPreviousCommand();
            }
            else if(e.KeyCode == Keys.Down)
            {
                txt_CMD.Text = cmdBuffer.GetNextCommand();
            }
        }
    }
}
