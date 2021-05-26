using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEF
{
    public partial class FormMain
    {
        private void btn_ReadMemory_Click(object sender, EventArgs e)
        {
            int bytesRead = 0;
            //byte[] buff = new byte[4096];
            IntPtr addr;
            Int32 amount;
            txt_ReadAddress.Text = txt_ReadAddress.Text.Trim();
            txt_ReadAmount.Text = txt_ReadAmount.Text.Trim();

            try
            {
                addr = new IntPtr(Convert.ToInt64(txt_ReadAddress.Text, 16));
            }
            catch
            {
                Log($"Invalid address specified.", txt_Console, LogLevel.Error);
                return;
            }

            try
            {
                amount = Convert.ToInt32(txt_ReadAmount.Text);
            }
            catch
            {
                Log($"Invalid number of bytes to read.", txt_Console, LogLevel.Error);
                return;
            }

            byte[] buff = new byte[amount];

            if(Proc.ReadProcessMemory((int)gProcess.Handle, (IntPtr)addr, buff, buff.Length, ref bytesRead))
            {
                Log($"Reading memory at address {txt_ReadAddress.Text}:", txt_Console, LogLevel.Info);
                txt_Console.AppendText(BitConverter.ToString(buff).Replace("-", " ") + "\r\n");
                return;
            }
            else
            {
                Log($"Failed to read from address {txt_ReadAddress.Text}. Be sure the address is in the currently selected process and that you're not attempting to read too much memory.", txt_Console, LogLevel.Error);
            }
        }
    }
}
