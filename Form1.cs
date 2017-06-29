using System;
using System.Windows.Forms;
using System.Diagnostics;
//Done by Baran Topal
//02-07-2010
namespace HASPHLDongleVirtualizer
{
    public partial class Form1 : Form
    {
        string currentPath = null;
        public Form1()
        {
            InitializeComponent();
            currentPath = System.Environment.CurrentDirectory + "\\";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                 MessageBox.Show("You may skip this step!");
                 MessageBox.Show("Be sure you plug the dongle!!");
                 MessageBox.Show("You don't need to *Get dumper* in the following screen, you already have with this program!!!");
                 Process.Start("Identifier.exe");
                
            }catch(Exception ex)
            {
                MessageBox.Show("Check for Dongle Identifier.exe, if you cannot find it, no problem,\nWe know it's purple!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Is it purple? :), You \"must\" plug it!");
            MessageBox.Show("Let's check the aladdin.com and find the dongle there!");
            try{
            Process.Start("http://www.aladdin.com/hasp/protection-keys-benefits-models.aspx", null);
            }catch(Exception ex)
            {
                MessageBox.Show("Page removed by aladdin!");
            }
        }        

        private void button3_Click(object sender, EventArgs e)
        {
            try{
            Process.Start("HASPHL2010.exe"); 
                }catch(Exception ex){
                    MessageBox.Show("Failed to open HASPHL2010.exe, open it manually!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string key1 = textBox1.Text;
            string key2 = textBox2.Text;

            string finalKey = key1 + " " + key2;
            try
            {                                
                Process.Start(currentPath + "h5api\\h5dmp.exe", " " + finalKey);

            }
            catch (Exception ex)
            {
                MessageBox.Show("If it flashes or stucks as winver, manually rerun h5dmp.exe as \"h5dmp.exe HexKey1 HexKey2\", via cmd!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open your hasp.dmp created by h5dmp, \"not\" the hhl_mem.dmp file, hasp.dmp is the name, \nSelect vUSB HL, press Go!");
            try
            {
                Process.Start("UniDumpToReg.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open UniDumpToReg.exe, open it manually!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Be sure, you plugged your dongle, start analyzing with hasploger and save the file!");
            MessageBox.Show("In the program, you can also see your hex keys!");           
            try
            {
                Process.Start(currentPath +"haSploGer\\haSploGer.exe");
                MessageBox.Show("May flash and may not work or work, it depends, if fails open it manually!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open haSploGer.exe, open it manually  or use another USB tracer like Toro Monitor which may fail or USBTrace!");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open the txt file, have the Table Type as Decrypt/Encrypt, then save it!");
            try
            {
                Process.Start(currentPath + "LogsToTables\\LogsToTables.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open LogsToTables.exe, open it manually!");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            String strFileName = string.Empty;
            const int regeditTimeOut = 10000; //10 second timeout 


            openFileDialog1.Title = "Select the dump-after-registry file!";
            
            //Present to the user. 

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

                strFileName = openFileDialog1.FileName;

            if (strFileName == String.Empty)

                return;//user didn't select a file
            try{
            Process regeditProcess = Process.Start("regedit.exe", " /c /s " + strFileName);

            regeditProcess.WaitForExit(regeditTimeOut); 

            }catch (Exception ex)
                {
                    MessageBox.Show("Registry append failure, check your registry file and redump your original registry, then manually merge it with the dump-after-registry file!");
                }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start(currentPath + "VUsbBus_01601_Chingachguk_Denger2k\\install.bat");
            MessageBox.Show("Remove your dongle and rerun your application, \nThis was the final process!!!\nIs it working?\nIf not refer to 8b!");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have applied this to this dongle, your keys are 0x47DD and 0x1608, \nIf you see this window, please don't forget to uninstall driver in HASP HL 2010!!");             
            MessageBox.Show("Be sure, you uninstalled that driver in HASP HL 2010!!");
            textBox1.AppendText("47DD");
            textBox2.AppendText("1608");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your reg file is named as 47DD1608.reg under h5api folder!!");
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            DialogResult temp = new DialogResult();
            DialogResult dr = MessageBox.Show("If fail, Click OK to remove the emulator completely and contact Baran Topal at btopal@bilkent.edu.tr!!!");
            if(dr == DialogResult.OK)
                temp = MessageBox.Show("!!!!!If you remove the working emulator, then you cannot continue to use your program *without* the dongle!!!!!");
            if (temp == DialogResult.OK)
            {
                try
                {
                    Process.Start(currentPath + "haSploGer\\delete.bat");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Check for the haSploGer\\delete.bat, it didn't execute, but not a problem");
                }
                try{
                    Process.Start(currentPath + "VUsbBus_01601_Chingachguk_Denger2k\\remove.bat");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Check for the VUsbBus_01601_Chingachguk_Denger2k\\remove.bat, it didn't execute, Your HASP drivers in your dongle may contradict in Device Manager!!!!!");
                }

            }
            else return;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("That's all, maybe a reboot!"); 
        }

        private void button14_Click(object sender, EventArgs e)
        {
             try{
             Process.Start("rstrui.exe");
             
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Unable to start system restore!!");
             }
             
        }

        private void button15_Click(object sender, EventArgs e)
        {
            String strFileName = "myregistry.reg";
             try{
                 saveFileDialog1.Title = "Backup your registry file!!";

                 //Present to the user. 

                 if (saveFileDialog1.ShowDialog() == DialogResult.OK)

                     Process.Start("regedit" + " /s strFileName");                     

                 if (strFileName == String.Empty)

                     return;//user didn't select a file                 

             }
             catch (Exception ex)
             {
                 MessageBox.Show("Unable to backup registry, do a manual backup!!");
             }

        }
    }
}
