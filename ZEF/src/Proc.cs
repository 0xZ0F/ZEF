using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ZEF
{
    public static class Proc
    {
        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(int hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

        public static bool IsValidProcess(Process proc)
        {
            try
            {
                int x = proc.BasePriority;
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }

        // Returns a List<> of modules for a process:
        public static List<ProcessModule> GetModules(Process proc)
        {
            List<ProcessModule> procMods = new List<ProcessModule>();
            try
            {
                foreach(ProcessModule x in proc.Modules)
                {
                    procMods.Add(x);
                }
            }
            catch(Exception)
            {
                return null;
            }
            return procMods;
        }
    }
}
