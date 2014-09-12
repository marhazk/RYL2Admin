using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml;
using System.Text.RegularExpressions;
using System.Net;
using System.Diagnostics;

namespace RYL2Admin
{
    class DNSAera
    {

        public string randnum = "";
        public Thread webClient;
        public DateTime CurrTime;
        public string ip = "127.0.0.1";
        public string oldip = "192.168.1.5";
        public FileRead oldipdb = new FileRead("OldIPDB.txt");
        public ProcessDB process = new ProcessDB();
        public string GameINI = "C:\\Windows\\DemonSetup.ini";
        public DNSAera()
        {
        }

        public void webClientProgress()
        {
            while (true)
            {
                try
                {
                    Thread current = Thread.CurrentThread;
                    Thread.Sleep(1000); //5 secs paused
                    CurrTime = DateTime.Now;
                    randnum = CurrTime.Year.ToString() + CurrTime.Month.ToString() + CurrTime.Day.ToString() + CurrTime.Hour.ToString() + CurrTime.Minute.ToString() + CurrTime.Second.ToString();
                    //Program.msg.send(Program.Gamed.mDNSnum, "ID: " + randnum.ToString());
                    if (true)
                    {
                        try
                        {
                            Program.msg.send(Program.Gamed.mNStatus, "Updating");
                        }
                        catch { }
                        string strURL = "http://pub.haztech.com.my/?updateip=" + randnum;

                        FileRead.TryToDelete("dns.log");
                        WebClient client = new WebClient();
                        try
                        {
                            client.DownloadFile(@"" + strURL, "dns.log");
                            //Program.msg.send("Downloaded DNS.log");
                        }
                        catch
                        {
                        }
                        client.Dispose();
                        FileStream file = File.Open("dns.log", FileMode.Open, FileAccess.Read, FileShare.None);
                        StreamReader r2 = new StreamReader(file);
                        string t;
                        Program.msg.send(Program.Gamed.mNStatus, "No updated found... Using default ip");

                        while ((t = r2.ReadLine()) != null)
                        {
                            Program.msg.send(Program.Gamed.mNStatus, "Updating...");
                            if (!t.Equals(ip))
                            {
                                Program.msg.send(Program.Gamed.mNStatus, "Registering the IP...");
                                ip = t;

                                //Change NIC ip
                                try
                                {

                                    Process p = new Process();
                                    p.StartInfo.FileName = "C:\\windows\\system32\\netsh.exe";
                                    p.StartInfo.Arguments = "interface ip set address LOCALNET static " + ip + " 255.255.255.0";
                                    p.StartInfo.UseShellExecute = false;
                                    p.StartInfo.CreateNoWindow = true;
                                    p.StartInfo.RedirectStandardOutput = true;
                                    p.Start();
                                    p.WaitForExit(30000);
                                    //Program.msg.send(Program.Gamed.mNStatus, p.StandardOutput.ReadToEnd());
                                    Program.msg.send(Program.Gamed.mLStatus, "updated");
                                }

                                catch (Exception ex)
                                {
                                    Program.msg.send(Program.Gamed.mLStatus, ex.Message);
                                }
                                try
                                {

                                    Program.msg.send(Program.Gamed.mGStatus, "Updating IP in DemonSetup.ini...");

                                    INI.WriteIniValue("AuthServer", "DBAgentAddr", ip, GameINI);
                                    INI.WriteIniValue("DBAgentServer", "PatchAddress", ip, GameINI);
                                    INI.WriteIniValue("DBAgentServer", "LoginServerAddr", ip, GameINI);
                                    INI.WriteIniValue("DBAgentServer", "UIDServerAddr", ip, GameINI);
                                    INI.WriteIniValue("UIDServer", "HanUnitedBillingAddr", ip, GameINI);
                                    INI.WriteIniValue("ChatServer", "DBAgentAddress", ip, GameINI);
                                    INI.WriteIniValue("Zone_1200", "DBAgentServerAddr", ip, GameINI);
                                    INI.WriteIniValue("Zone_1200", "LogServerAddr", ip, GameINI);
                                    INI.WriteIniValue("Zone_1200", "ChatServerAddr", ip, GameINI);
                                    INI.WriteIniValue("Zone_1600", "DBAgentServerAddr", ip, GameINI);
                                    INI.WriteIniValue("Zone_1600", "LogServerAddr", ip, GameINI);
                                    INI.WriteIniValue("Zone_1600", "ChatServerAddr", ip, GameINI);
                                    INI.WriteIniValue("Zone_0800", "DBAgentServerAddr", ip, GameINI);
                                    INI.WriteIniValue("Zone_0800", "LogServerAddr", ip, GameINI);
                                    INI.WriteIniValue("Zone_0800", "ChatServerAddr", ip, GameINI);
                                    INI.WriteIniValue("Zone_1400", "DBAgentServerAddr", ip, GameINI);
                                    INI.WriteIniValue("Zone_1400", "LogServerAddr", ip, GameINI);
                                    INI.WriteIniValue("Zone_1400", "ChatServerAddr", ip, GameINI);
                                    Program.msg.send(Program.Gamed.mGStatus, ip);
                                    process.Kill("RylLoginServer", "Restarting RYL Server if possible...");
                                }
                                catch
                                {
                                    Program.msg.send(Program.Gamed.mGStatus, "Failed to update IP...");
                                }

                            }
                            else
                            {
                                //Program.msg.send(Program.Gamed.mDNSmsg2, "No Updates...");
                            }
                        }

                        oldip = ip;
                        bool newoldip = true;
                        Program.msg.send(Program.Gamed.lstIP);
                        foreach (String oldiplist in oldipdb.DB)
                        {
                            Program.msg.send(Program.Gamed.lstIP, oldiplist);
                        }

                        foreach (String chkoldip in Program.Gamed.lstIP.Items)
                        {
                            if (chkoldip.Equals(oldip))
                            {
                                newoldip = false;
                            }
                        }
                        if (newoldip)
                        {
                            Program.msg.send(Program.Gamed.lstIP, oldip);
                            oldipdb.DB.Add(oldip);
                            oldipdb.Update();
                        }
                        //string strFilePath = "local.xml";

                        file.Dispose();
                        //TcpClient client = new TcpClient("www.perfectworld.my", 80);
                        //NetworkStream stream = client.GetStream();
                        //byte[] send = Encoding.ASCII.GetBytes("GET /?updateip=" + randnum + " HTTP/1.0 \r\n\r\n");
                        //stream.Write(send, 0, send.Length);
                        //byte[] bytes = new byte[client.ReceiveBufferSize];
                        //int count = stream.Read(bytes, 0, (int)client.ReceiveBufferSize);
                        //String data = Encoding.ASCII.GetString(bytes);
                        //char[] unused = { (char)data[count] };
                        //txtStatus.Text = (data.TrimEnd(unused)).ToString();
                        //stream.Close();
                        //client.Close();

                        Program.msg.send(Program.Gamed.mNStatus, "IP : " + ip);
                    }
                }
                catch (Exception e)
                {
                    //
                    try
                    {
                        Program.msg.send(Program.Gamed.mNStatus, "ERROR: " + e.ToString());
                        Program.msg.send(Program.Gamed.mNStatus, "ID: " + randnum.ToString());
                        Program.msg.send(Program.Gamed.mNStatus, "Synced...");
                    }
                    catch { }
                }
            }
        }
        public void start()
        {
            startProgress();
        }
        public void Abort()
        {
            webClient.Abort();
        }
        public void startProgress()
        {
            try
            {
                webClient.Abort();
            }
            catch
            {
            }
            randnum = "";
            webClient = new Thread(new ThreadStart(webClientProgress));
            webClient.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                webClient.Abort();
            }
            catch
            {
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                webClient.Abort();
            }
            catch
            {
            }
        }

        //Disposing the existing data
        public void DisposeAll()
        {
            webClient.Abort();

        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                DisposeAll();
            }
            // free native resources
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
