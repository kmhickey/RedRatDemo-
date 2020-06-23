using System;
using System.Windows.Forms;
using System.Text;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

using RedRat.IR;
using RedRat.USB;
using RedRat.Util;
using RedRat.RedRat3;
using RedRat.RedRat3.USB;

using System.Collections.Generic;
using System.Drawing;

namespace RedRat.TestRemote 
{
    public partial class NewRemote : System.Windows.Forms.Form 
    {
        Dictionary<string, IRButton> irButtons; 

        protected bool changed = false; // Has state changed?

        // The actual RedRat3 we're using...
        protected IRedRat3 redRat3;

        // Registry info. for config file
        //protected const string testRemoteKey = "Software\\RedRat\\TestRemote";
        //protected const string configFileKeyName = "ConfigFile";
        //protected RegistryKeyValue configFileRK;

        string irButtonsConfigFolder = @"D:\Redrat Remotes config files";

        string irButtonsConfigFileName = "NewRemote.xml";

        string irButtonsConfigFile = string.Empty;

        public NewRemote() 
        {
            try 
            {
                InitializeComponent();

                int borderWidth = 2;

                AddABorder(panel1, borderWidth);
                AddABorder(panel2, borderWidth);

                // Find RedRat3s.
                OpenRedRat3();

                #region irButtons config file name
                //                StringBuilder ourXMLFilename = new StringBuilder();

                //                //ourXMLFilename.Append(Environment.CommandLine);
                //                //ourXMLFilename.Remove(0, 1);
                //                ////ourXMLFilename.Remove(ourXMLFilename.Length - 5, 4);
                //                ////ourXMLFilename.Append("XML");
                //                //ourXMLFilename.Replace(".exe\"", ".XML");

                //                ourXMLFilename.Append(@"D:\Redrat Remotes config files"
                ////  + @"\System.Diagnostics.Process.GetCurrentProcess().ProcessName
                //+ @"\Aptremote.xml");

                irButtonsConfigFile 
                    = Path.Combine(irButtonsConfigFolder, irButtonsConfigFileName);
                #endregion

                irButtons = GetAllirButtons(this, new Dictionary<string, IRButton>());

                AdjustIRButtons();

                try
                {
                    OpenFile(irButtonsConfigFile);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                #region register stuff commented out
                //// Load default state
                //configFileRK = new RegistryKeyValue(RegistryKeyValue.CURRENT_USER, testRemoteKey,
                //  configFileKeyName, "", true);

                //if (!((string)configFileRK.Value).Equals("")) {
                //  try {
                //    OpenFile((string)configFileRK.Value);
                //  } catch (Exception ex) {
                //    MessageBox.Show(ex.Message, "Error",
                //      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //  }
                //}
                #endregion
            }

            catch (Exception ex) 
            {
                // Catch-all handler.
                string msg = "Error occured in application: " 
                            + ex.Message + "\n" + ex.StackTrace;
                MessageBox.Show(msg, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Populate IRButtons Dictionary
        private Dictionary<string, IRButton> 
                GetAllirButtons(Control container, 
                                Dictionary<string, IRButton> dict)
        {
            IRButton irb;

            foreach (Control c in container.Controls)
            {
                if (c is IRButton)
                {
                    irb = c as IRButton;

                    irb.Info.BtnName  = c.Name;
                    irb.Info.IRPacket = null;
                    irb.Info.Text     = string.Empty;

                    dict.Add(c.Name, irb);
                }

                if (c.Controls.Count > 0)
                {
                    dict = GetAllirButtons(c, dict);
                }
            }

            return dict;
        }
        #endregion

        private void AdjustIRButtons()
        {
            IRButton irb;

            foreach (KeyValuePair<string, IRButton> entry in irButtons)
            {
                irb = entry.Value;

                irb.MouseClick -= button_Click;
                irb.MouseClick += button_Click;

                irb.MouseDown -= button_MouseDown;
                irb.MouseDown += button_MouseDown;

                irb.BackColor = Color.FromArgb(0, 192, 192);
            }
        }

        /// <summary>
        /// Opens the first RedRat3 found.
        /// </summary>
        protected void OpenRedRat3() 
        {
            try 
            {
                // Find the no. of RR3s connected.
                LocationInfo[] devices = RedRat3USBImpl.FindRedRat3s();

                if (devices.Length > 0) 
                {
                  // Just take the first device found.
                  redRat3 = (IRedRat3)devices[0].GetRedRat();  
                } 
                else 
                {
                  MessageBox.Show("No RedRat3 devices found.", "TestRemote Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } 
            
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        public bool Changed {
          get { return changed; }
          set { changed = value; }
        }

        public IRedRat3 RedRat3 {
          get { return redRat3; }
        }

        private void button_Click(object sender, System.EventArgs e) 
        {
            // Output the signal...
            if (sender is IRButton) 
            {
                IRPacket irPacket = ((IRButton)sender).Info.IRPacket;

                if (irPacket is ModulatedSignal) 
                {
                    if (redRat3 != null) 
                    {
                        try 
                        {
                            // Send the ModulatedSignal object to the RR3
                            redRat3.OutputModulatedSignal((ModulatedSignal)irPacket);
                        } 
                        
                        catch (Exception ex) 
                        {
                            MessageBox.Show(ex.Message, 
                                "Error", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void button_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) 
        {
            // If right click, popup button properties dialog.
            if (e.Button == MouseButtons.Right) 
            {
                if (sender is IRButton) 
                {
                    ButtonPropertiesDialog dlg 
                        = new ButtonPropertiesDialog((IRButton)sender, this);
                    
                    dlg.ShowDialog();
                }
            }
        }

        private void exitMenuItem_Click(object sender, System.EventArgs e) {
          this.Close();
        }

        private void saveMenuItem_Click(object sender, System.EventArgs e) {
          SaveFile();
        }

        private void openMenuItem_Click(object sender, System.EventArgs e) {
          // Read state from XML file.
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
          openFileDialog.RestoreDirectory = true ;

          if (openFileDialog.ShowDialog() == DialogResult.OK) {
            OpenFile(openFileDialog.FileName);
          }
        }

        /// <summary>
        /// Loads program state from file.
        /// </summary>
        /// <param name="fileName"></param>
        protected void OpenFile(string fileName) 
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ButtonInfo[]));
            FileInfo fileInfo = new FileInfo(fileName);
            FileStream fs = null;
          
            try 
            {
                fs = new FileStream(fileInfo.FullName, FileMode.Open);

                ButtonInfo[] infoArr = null;

                infoArr = (ButtonInfo[])serializer.Deserialize(fs);

                foreach (ButtonInfo bi in infoArr)
                {
                    if (irButtons.ContainsKey(bi.BtnName))
                    {
                        irButtons[bi.BtnName].Info = bi;
                        irButtons[bi.BtnName].Text = bi.Text;
                    }
                }

                #region Store file name in registry - commented out
                //configFileRK.Value = fileInfo.FullName;
                #endregion

                changed = false;
            }

            catch (Exception ex) 
            {
                 // Catch-all handler.
                string msg = "Error occured in application: "
                            + ex.Message + "\n" + ex.StackTrace;
                MessageBox.Show(msg, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            } 
            
            finally 
            {
                if (fs != null) 
                {
                    fs.Close();
                }
            }
        }

        private void TestRemote_Closing(object sender, 
            System.ComponentModel.CancelEventArgs e) 
        {
            if (changed) 
            {
                DialogResult result 
                    = MessageBox.Show(this, 
                                "Configuration changed - do you want to save?", 
                                        "Configuration Changed",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question, 
                                        MessageBoxDefaultButton.Button1, 
                                        MessageBoxOptions.RightAlign);

                if (result == DialogResult.Yes) 
                {
                  SaveFile();
                }
            }
        }

        protected void SaveFile() 
        {
            // Save to XML file
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = irButtonsConfigFolder;
            saveFileDialog.FileName = irButtonsConfigFileName;
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) 
            {
                ButtonInfo[] infoArr = new ButtonInfo[irButtons.Count];

                int ctr = 0;

                foreach (KeyValuePair<string, IRButton> entry in irButtons)
                {
                    infoArr[ctr] = entry.Value.Info;

                    ctr++;
                }

                // == Save the data in an XML file ==
                FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                XmlSerializer ser = new XmlSerializer(typeof(ButtonInfo[]));
                TextWriter writer = new StreamWriter(fileInfo.FullName);

                ser.Serialize(writer, infoArr);

                writer.Close();

                // Store file name in registry
                //configFileRK.Value = fileInfo.FullName;
            }
        }

        #region About and About RedRat 
        /// <summary>
        /// Put up "About" box.
        /// </summary>
        private void aboutMenuItem_Click(object sender, System.EventArgs e) {
          // All info. obtained from the AssemblyInfo.cs file.
          StringBuilder versionInfo = new StringBuilder();
          // Get version info.
          Assembly assembly = Assembly.GetExecutingAssembly();

          // Title
          AssemblyTitleAttribute[] ata = (AssemblyTitleAttribute[])assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), true);
          if (ata.Length>0) {
            // Take the first one. Do we ever have more???
            versionInfo.Append(ata[0].Title + " - ");
          }

          // Description
          AssemblyDescriptionAttribute[] ada = (AssemblyDescriptionAttribute[])assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), true);
          if (ada.Length>0) {
            // Take the first one. Do we ever have more???
            versionInfo.Append(ada[0].Description + "\n");
          }

          // Version
          Version version = assembly.GetName().Version;
          versionInfo.Append("Version: " + version.Major + "." + version.Minor);

          MessageBox.Show(versionInfo.ToString(), "About TestRemote", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Put up a dialog box to show information about RedRat3.
        /// </summary>
        private void rr3InfoMenuItem_Click(object sender, System.EventArgs e) 
        {
            // Obtain and display info about the RR3.
            string msg = null;
            if (redRat3 == null) {
                msg = "No RedRat3 connected.";
            } 
            else 
            {
                // Obtain information from RR3 to display....
                USBDeviceInfo devInfo = (USBDeviceInfo)redRat3.DeviceInformation;
                
                StringBuilder sb = new StringBuilder();
                sb.Append(devInfo.ToString() + "\n");
                sb.Append("Hardware Version: " + devInfo.ProductName + "." + devInfo.ProductVersion + "\n");
                sb.Append("Firmware Version: " + redRat3.FirmwareVersion);
                sb.Append("\nSerial Number: " + devInfo.SerialNo);
                sb.Append("\nLocation: " + redRat3.LocationInformation);
                
                msg = sb.ToString();
            }

            MessageBox.Show(msg, 
                "RedRat3 Info.", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);    
        }
        #endregion

        #region AddABorder
        private void AddABorder(GroupBox gb, int bwidth)
        {
            Panel panel1 = new Panel();

            panel1.Location
                = new Point(gb.Location.X - bwidth,
                            gb.Location.Y - bwidth);

            panel1.Size
                = new System.Drawing.Size(gb.Size.Width + (2 * bwidth),
                                          gb.Size.Height + (2 * bwidth));

            panel1.BackColor = Color.Black;

            panel1.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(panel1);
        }


        private void AddABorder(ListBox lb, int bwidth)
        {
            Panel panel1 = new Panel();

            panel1.Location
                = new Point(lb.Location.X - bwidth,
                            lb.Location.Y - bwidth);

            panel1.Size
                = new System.Drawing.Size(lb.Size.Width + (2 * bwidth),
                                          lb.Size.Height + (2 * bwidth));

            panel1.BackColor = Color.Black;

            panel1.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(panel1);
        }

        private void AddABorder(Panel pn, int bwidth)
        {
            Panel panel1 = new Panel();

            panel1.Location
                = new Point(pn.Location.X - bwidth,
                            pn.Location.Y - bwidth);

            panel1.Size
                = new System.Drawing.Size(pn.Size.Width + (2 * bwidth),
                                          pn.Size.Height + (2 * bwidth));

            panel1.BackColor = Color.Black;

            panel1.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(panel1);
        }
        #endregion
    }
}
