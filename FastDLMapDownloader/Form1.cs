using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.BZip2;

namespace FastDLMapDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Find_Click(object sender, EventArgs e)
        {
            string[] servers = { "https://main.fastdl.me/maps/", "http://sukibhop.site.nfoservers.com/fastdl/maps/" };
            using (var client = new WebClient())
            {
                output.Text = "";
                for(int i = 0; i < servers.Length; i++) 
                {
                    try
                    {
                        client.DownloadFile(servers[i] + mapName.Text + ".bsp.bz2", strikepath.Text + mapName.Text + ".bsp.bz2");
                        output.Text += "Success!" + Environment.NewLine;
                        output.Text += servers[i] + mapName.Text + ".bsp.bz2" +Environment.NewLine;
                        output.Text += "----------------------------------------------------------------------------------------------" + Environment.NewLine;
                        string path = @"" + strikepath.Text + mapName.Text + ".bsp.bz2";
                        FileInfo zipFileName = new FileInfo(path);
                        using (FileStream fileToDecompressAsStream = zipFileName.OpenRead())
                        {
                            string decompressedFileName = @"" + strikepath.Text + mapName.Text + ".bsp";
                            output.Text += decompressedFileName + Environment.NewLine;
                            using (FileStream decompressedStream = File.Create(decompressedFileName))
                            {
                                try
                                {
                                    BZip2.Decompress(fileToDecompressAsStream, decompressedStream, true);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                        }

                        break;
                    }
                    catch (Exception ex)
                    {
                        output.Text += "Failed!" + Environment.NewLine;
                        output.Text += ex.ToString() + Environment.NewLine;
                        output.Text += servers[i] + mapName.Text + ".bsp.bz2" + Environment.NewLine;
                        output.Text += "----------------------------------------------------------------------------------------------" + Environment.NewLine;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
