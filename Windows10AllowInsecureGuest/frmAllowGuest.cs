using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.AccessControl;

namespace Windows10AllowInsecureGuest
{
    public partial class frmAllowGuest : Form
    {
        protected bool loaded = false;

        public frmAllowGuest()
        {
            InitializeComponent();
        }

        public int getAllowGuestSetting()
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation\\Parameters", RegistryKeyPermissionCheck.Default, RegistryRights.ReadKey);
                if (key != null)
                {
                    Object o = key.GetValue("AllowInsecureGuestAuth");
                    if (o != null)
                    {
                        return o.ToString() == "1" ? 1 : 0;
                    }
                    else
                    {
                        MessageBox.Show("Could not load registry value", "Error");
                    }
                }
                else
                {
                   MessageBox.Show("Could not load registry key", "Error");
                }
                return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public void setAllowGuestSetting( int setting )
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation\\Parameters", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.SetValue);
                if (key != null)
                {
                    key.SetValue("AllowInsecureGuestAuth", setting, RegistryValueKind.DWord);
                    key.Close();
                }
                else
                {
                    MessageBox.Show("Could not load registry key", "Error");
                }
            }
            catch (System.UnauthorizedAccessException ex)
            {
                MessageBox.Show("This application needs to run as administrator", "Error " + setting);
            }
            catch (System.Security.SecurityException ex)
            {
                MessageBox.Show("This application needs to run as administrator", "Error " + setting);
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show("Failed!", "Error " + setting);
            }
        }

        private void radbtnControlStateOn_CheckedChanged(object sender, EventArgs e)
        {
            if (this.loaded && radbtnControlStateOn.Checked) 
                this.setAllowGuestSetting(1);
        }

        private void radbtnControlStateOff_CheckedChanged(object sender, EventArgs e)
        {
            if (this.loaded && radbtnControlStateOff.Checked)
                this.setAllowGuestSetting(0);
        }

        private void frmAllowGuest_Load(object sender, EventArgs e)
        {
            this.loaded = false;
            if (this.getAllowGuestSetting()==1)
            {
                radbtnControlStateOn.Checked = true;
                radbtnControlStateOff.Checked = false;
            }
            else
            {
                radbtnControlStateOn.Checked = false;
                radbtnControlStateOff.Checked = true;
            }
            this.loaded = true;
        }

    }
}