using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Security.Cryptography;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

delegate void SetTextCallback(object text);
delegate void SetTextCallbackType(object text, object type = null);
delegate void SetTextCallbackListBox(ListBox obj, object text);
delegate void SetTextCallbackListBoxClear(ListBox obj);
delegate void SetTextCallbackListBoxEdit(ListBox obj, int id, object text);
delegate void SetTextCallbackListBoxReplace(int id, object text);
delegate void SetTextCallbackTextBox(TextBox obj, object text);
delegate void SetTextCallbackListBoxCombo(ComboBox obj, object text);
delegate void SetTextCallbackListBoxComboAdd(ComboBox obj, int num, object text);
delegate void SetTextCallbackListBoxComboBool(ComboBox obj, bool value);
delegate void SetTextCallbackListBoxChkBool(CheckBox obj, bool value);
delegate void SetTextCallbackComboBoxClear(ComboBox obj);
delegate void SetTextCallbackButton(Button obj, bool value);
delegate void SetTextCallbackLabel(Label obj, object text);

namespace RYL2Admin
{
    public interface pw01 { void send(ListBox obj, object _temp); }
    public interface pw02 { void send(ComboBox obj, object _temp); }
    public interface pw03 { void send(ComboBox obj, int num, object _temp); }
    public interface pw04 { void send(ComboBox obj, bool _temp); }
    public interface pw05 { void send(Button obj, bool _temp); }
    public interface pw06 { void send(ListBox obj, int id, object _temp); }
    public interface pw07 { void send(int id, object _temp); }
    public interface pw08 { void send(object _temp); }
    public interface pw09 { void send(ListBox obj); }
    public interface pw10 { void send(ComboBox obj); }
    public interface pw11 { void send(TextBox obj, object _temp); }
    public interface pw12 { void send(Label obj, object _temp); }
    class Msg : pw01, pw02, pw03, pw04, pw05, pw06, pw07, pw08, pw09, pw10, pw11, pw12
    {
        public void send(int id, object _temp)
        {
            try
            {
                if (Program.Gamed.lstLog.InvokeRequired)
                {
                    SetTextCallbackListBoxReplace d = new SetTextCallbackListBoxReplace(send);
                    Program.Gamed.Invoke(d, new object[] { id, _temp });
                }
                else
                {
                    Program.Gamed.lstLog.Items.RemoveAt(id);
                    Program.Gamed.lstLog.Items.Insert(id, _temp);
                }
            }
            catch { }
        }
        public void send(object _temp)
        {
            try
            {
                if (Program.Gamed.lstLog.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(send);
                    Program.Gamed.Invoke(d, new object[] { _temp });
                }
                else
                {
                    Program.Gamed.lstLog.Items.Insert(0, _temp);
                }
            }
            catch { }
        }
        public void send(ListBox obj, int id, object _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBoxEdit d = new SetTextCallbackListBoxEdit(send);
                    Program.Gamed.Invoke(d, new object[] { obj, id, _temp });
                }
                else
                {
                    obj.Items.RemoveAt(id);
                    obj.Items.Insert(id, _temp);
                }
            }
            catch { }
        }
        public void send(ListBox obj)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBoxClear d = new SetTextCallbackListBoxClear(send);
                    Program.Gamed.Invoke(d, new object[] { obj });
                }
                else
                {
                    obj.Items.Clear();
                }
            }
            catch { }
        }
        public void send(ComboBox obj)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackComboBoxClear d = new SetTextCallbackComboBoxClear(send);
                    Program.Gamed.Invoke(d, new object[] { obj });
                }
                else
                {
                    obj.Items.Clear();
                }
            }
            catch { }
        }
        public void send(ListBox obj, object _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBox d = new SetTextCallbackListBox(send);
                    Program.Gamed.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Items.Insert(0, _temp);
                }
            }
            catch { }
        }
        public void send(ComboBox obj, object _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBoxCombo d = new SetTextCallbackListBoxCombo(send);
                    Program.Gamed.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Items.Insert(0, _temp);
                }
            }
            catch { }
        }
        public void send(ComboBox obj, int num, object _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBoxComboAdd d = new SetTextCallbackListBoxComboAdd(send);
                    Program.Gamed.Invoke(d, new object[] { obj, num, _temp });
                }
                else
                {
                    obj.Items.Insert(num, _temp);
                }
            }
            catch { }
        }
        public void send(ComboBox obj, bool _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBoxComboBool d = new SetTextCallbackListBoxComboBool(send);
                    Program.Gamed.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Enabled = _temp;
                }
            }
            catch { }
        }
        public void send(CheckBox obj, bool _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackListBoxChkBool d = new SetTextCallbackListBoxChkBool(send);
                    Program.Gamed.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Checked = _temp;
                }
            }
            catch { }
        }
        public void send(Button obj, bool _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackButton d = new SetTextCallbackButton(send);
                    Program.Gamed.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Enabled = _temp;
                }
            }
            catch { }
        }
        public void send(TextBox obj, object _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackTextBox d = new SetTextCallbackTextBox(send);
                    Program.Gamed.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Text = (string)_temp;
                }
            }
            catch { }
        }
        public void send(Label obj, object _temp)
        {
            try
            {
                if (obj.InvokeRequired)
                {
                    SetTextCallbackLabel d = new SetTextCallbackLabel(send);
                    Program.Gamed.Invoke(d, new object[] { obj, _temp });
                }
                else
                {
                    obj.Text = (string)_temp;
                }
            }
            catch { }
        }

        //for DNS Aera
        public void sendMsg(object _temp)
        {
            try
            {
                if (Program.Gamed.lstLogError.InvokeRequired)
                {
                    SetTextCallbackType d = new SetTextCallbackType(sendMsg);
                    Program.Gamed.Invoke(d, new object[] { _temp, null });
                }
                else
                {
                    sendMsg(_temp, null);
                }
            }
            catch { }
        }
        public void sendMsg(object _temp, object type = null)
        {
            try
            {
                if (Program.Gamed.lstLogError.InvokeRequired)
                {
                    SetTextCallbackType d = new SetTextCallbackType(sendMsg);
                    Program.Gamed.Invoke(d, new object[] { _temp, type });
                }
                else
                {
                    if (type.ToString() == "mDNSstatus")
                        Program.Gamed.lstLogError.Items.Insert(0, _temp);
                }
            }
            catch { }
        }
    }
}
