﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PureQuantamWinFormsApp
{
    public partial class Form1 : Form
    {
        QWQNG.QNG qng = new QWQNG.QNG();
        private System.ComponentModel.Design.ByteViewer byteviewer;

        public Form1()
        {
            InitializeComponent();

            // Initialize the ByteViewer.
            byteviewer = new ByteViewer();
            byteviewer.Location = new Point(200, 350);
            byteviewer.Size = new Size(300, 300);
            byteviewer.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            byteviewer.SetBytes(new byte[] { });
            this.Controls.Add(byteviewer);

        }

        private void btnShowDeviceId_Click(object sender, EventArgs e)
        {
            try
            {               

                string deviceId = qng.DeviceId;

                Trace.WriteLine("Device Id: {0}", deviceId);

                if (string.IsNullOrEmpty(deviceId))
                {
                    deviceId = "Unable to retrieve Device ID";
                }

                textBoxDeviceId.Text = deviceId;
            }
            catch(Exception ex)
            {
                Trace.TraceError("An error has occured: {0}", ex.Message);
            }
        }

        private void btnRandInt32_Click(object sender, EventArgs e)
        {
            try
            {               

                int rand32 = qng.RandInt32;

                var message = string.Empty;

                Trace.WriteLine("Random Int: {0}", rand32.ToString());

                if (rand32 <= 0)
                {
                    message = "Unable to generate RandInt32";
                }
                else
                {
                    message = rand32.ToString();
                }

                textRand32.Text = message;
            }
            catch (Exception ex)
            {
                Trace.TraceError("An error has occured: {0}", ex.Message);
            }

            
        }

        // Clear the bytes in the byte viewer.
        private void clearBytes(object sender, EventArgs e)
        {
            byteviewer.SetBytes(new byte[] { });
        }

        private void SetBytes(byte[] bytes)
        {
            byteviewer.SetBytes(bytes);
        }

        // Show a file selection dialog and cues the byte viewer to
        // load the data in a selected file.
        private void loadBytesFromFile(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            byteviewer.SetFile(ofd.FileName);
        }
        private void changeByteMode(object sender, EventArgs e)
        {
            System.Windows.Forms.RadioButton rbutton =
                (System.Windows.Forms.RadioButton)sender;

            DisplayMode mode;
            switch (rbutton.Text)
            {
                case "ANSI":
                    mode = DisplayMode.Ansi;
                    break;
                case "Hex":
                    mode = DisplayMode.Hexdump;
                    break;
                case "Unicode":
                    mode = DisplayMode.Unicode;
                    break;
                default:
                    mode = DisplayMode.Auto;
                    break;
            }

            // Sets the display mode.
            byteviewer.SetDisplayMode(mode);
        }
        private void btnRandUniform_Click(object sender, EventArgs e)
        {
            try
            {              

                double randuniform = qng.RandUniform;

                var message = string.Empty;

                Trace.WriteLine("Random Uniform: {0}", randuniform.ToString());

                if (randuniform <= 0)
                {
                    message = "Unable to generate RandUniform";
                }
                else
                {
                    message = randuniform.ToString();
                }

                textBoxRandUniform.Text = message;
            }
            catch (Exception ex)
            {
                Trace.TraceError("An error has occured: {0}", ex.Message);
            }
        }

        private void btnRandNormal_Click(object sender, EventArgs e)
        {
            try
            {
               
                double randNormal = qng.RandNormal;

                var message = string.Empty;

                Trace.WriteLine("Random RandNormal: {0}", randNormal.ToString());

                if (randNormal <= 0)
                {
                    message = "Unable to generate RandNormal";
                }
                else
                {
                    message = randNormal.ToString();
                }

                textBoxRandNormal.Text = message;
            }
            catch (Exception ex)
            {
                Trace.TraceError("An error has occured: {0}", ex.Message);
            }
        }

        private void btnRandBytes_Click(object sender, EventArgs e)
        {
            byte[] randbytes = (byte[])qng.get_RandBytes(10);
            byteviewer.SetBytes(randbytes);
                        
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            qng.Reset();
            
        }

        private void btnRuntimeInfo_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            float[] runtimeInfo = (float[])qng.RuntimeInfo;
            for (int i = 0; i < runtimeInfo.Length; i++)
            {
                var msg = string.Format("{0}: {1} ", i, runtimeInfo[i]);
                builder.AppendLine(msg);
                Trace.WriteLine(msg);
            }

            MessageBox.Show(builder.ToString(), "Runtime Information");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear random data sitting in internal buffers
            qng.Clear();
        }

        private void btnDiagnostics_Click(object sender, EventArgs e)
        {
            // Level 2, Channel 3 dx data
            //byte controlWord = 0x15;

            //byte[] dxData; // = (float[])qng.Diagnostics(controlWord);
            //foreach (byte b in dxData)
            //    Console.Write("{0:X} ", b);
            //Console.WriteLine();



        }
    }
}