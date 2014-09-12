using System;
using System.Diagnostics;

namespace RYL2Admin
{
    class ProcessDB
    {
        public Process[] allProcs = Process.GetProcesses();

        public void Refresh()
        {
            allProcs = Process.GetProcesses();
            Program.msg.send(Program.Gamed.lstProcesses);
            foreach (Process proc in allProcs)
            {
                Program.msg.send(Program.Gamed.lstProcesses, "ID: " + proc.Id + " Name: " + proc.ProcessName);
            }
        }
        public void Start()
        {
            Refresh();
            foreach (Process proc in allProcs)
            {
                ProcessThreadCollection myThreads = proc.Threads;
                //Console.WriteLine("process: {0},  id: {1}", proc.ProcessName, proc.Id);
                foreach (ProcessThread pt in myThreads)
                {
                    /*Console.WriteLine("  thread:  {0}", pt.Id);
                    Console.WriteLine("    started: {0}", pt.StartTime.ToString());
                    Console.WriteLine("    CPU time: {0}", pt.TotalProcessorTime);
                    Console.WriteLine("    priority: {0}", pt.BasePriority);
                    Console.WriteLine("    thread state: {0}", pt.ThreadState.ToString());*/
                }
            }
        }

        public void Kill(string val, string msg = "Restarting targetted app via Name")
        {
            Refresh();
            /*foreach (Process proc in allProcs)
            {
                if (proc.ProcessName.Equals(val))
                {
                    Program.msg.send(msg);
                    proc.Dispose();
                    proc.Kill();
                    break;
                }
            }*/

            Program.msg.send(msg);
            try
            {
                Process[] proc = Process.GetProcessesByName(val);
                proc[0].Kill();
            }
            catch
            {
                Program.msg.send("Failed to restart...");
            }
        }
        public void Kill(int val, string msg = "Restarting targetted app via ID")
        {
            Refresh();
            foreach (Process proc in allProcs)
            {
                if (proc.Id == val)
                {
                    Program.msg.send(msg);
                    proc.Dispose();
                    proc.Kill();
                    break;
                }
            }
        }
    }
}