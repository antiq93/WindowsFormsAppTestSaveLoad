using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsAppTestSaveLoad.Properties;

namespace WindowsFormsAppTestSaveLoad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbB_recent.Text = Properties.Settings.Default.NumRecent;            
            showrecent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void addrecent(string path)
        {
            bool k = true;
            
            //try
            //{

            
                for (var i = 0; i < 9; i++)
                {
                
                

                
                    if (path == listB_recent.Items[i].ToString())
                    {
                        k = false;
                        switch (i)
                        {
                            case 0:
                            
                                break;
                            case 1:
                                Properties.Settings.Default.Recent2 = Properties.Settings.Default.Recent1;
                                Properties.Settings.Default.Recent1 = path;

                                break;
                            case 2:
                                Properties.Settings.Default.Recent3 = Properties.Settings.Default.Recent2;
                                Properties.Settings.Default.Recent2 = Properties.Settings.Default.Recent1;
                                Properties.Settings.Default.Recent1 = path;
                                break;
                            case 3:
                                Properties.Settings.Default.Recent4 = Properties.Settings.Default.Recent3;
                                Properties.Settings.Default.Recent3 = Properties.Settings.Default.Recent2;
                                Properties.Settings.Default.Recent2 = Properties.Settings.Default.Recent1;
                                Properties.Settings.Default.Recent1 = path;
                                break;
                            case 4:
                                Properties.Settings.Default.Recent5 = Properties.Settings.Default.Recent4;
                                Properties.Settings.Default.Recent4 = Properties.Settings.Default.Recent3;
                                Properties.Settings.Default.Recent3 = Properties.Settings.Default.Recent2;
                                Properties.Settings.Default.Recent2 = Properties.Settings.Default.Recent1;
                                Properties.Settings.Default.Recent1 = path;
                                break;
                            case 5:
                                Properties.Settings.Default.Recent6 = Properties.Settings.Default.Recent5;
                                Properties.Settings.Default.Recent5 = Properties.Settings.Default.Recent4;
                                Properties.Settings.Default.Recent4 = Properties.Settings.Default.Recent3;
                                Properties.Settings.Default.Recent3 = Properties.Settings.Default.Recent2;
                                Properties.Settings.Default.Recent2 = Properties.Settings.Default.Recent1;
                                Properties.Settings.Default.Recent1 = path;
                                break;
                            case 6:
                                Properties.Settings.Default.Recent7 = Properties.Settings.Default.Recent6;
                                Properties.Settings.Default.Recent6 = Properties.Settings.Default.Recent5;
                                Properties.Settings.Default.Recent5 = Properties.Settings.Default.Recent4;
                                Properties.Settings.Default.Recent4 = Properties.Settings.Default.Recent3;
                                Properties.Settings.Default.Recent3 = Properties.Settings.Default.Recent2;
                                Properties.Settings.Default.Recent2 = Properties.Settings.Default.Recent1;
                                Properties.Settings.Default.Recent1 = path;
                                break;
                            case 7:
                                Properties.Settings.Default.Recent8 = Properties.Settings.Default.Recent7;
                                Properties.Settings.Default.Recent7 = Properties.Settings.Default.Recent6;
                                Properties.Settings.Default.Recent6 = Properties.Settings.Default.Recent5;
                                Properties.Settings.Default.Recent5 = Properties.Settings.Default.Recent4;
                                Properties.Settings.Default.Recent4 = Properties.Settings.Default.Recent3;
                                Properties.Settings.Default.Recent3 = Properties.Settings.Default.Recent2;
                                Properties.Settings.Default.Recent2 = Properties.Settings.Default.Recent1;
                                Properties.Settings.Default.Recent1 = path;
                                break;
                            case 8:
                                Properties.Settings.Default.Recent9 = Properties.Settings.Default.Recent8;
                                Properties.Settings.Default.Recent8 = Properties.Settings.Default.Recent7;
                                Properties.Settings.Default.Recent7 = Properties.Settings.Default.Recent6;
                                Properties.Settings.Default.Recent6 = Properties.Settings.Default.Recent5;
                                Properties.Settings.Default.Recent5 = Properties.Settings.Default.Recent4;
                                Properties.Settings.Default.Recent4 = Properties.Settings.Default.Recent3;
                                Properties.Settings.Default.Recent3 = Properties.Settings.Default.Recent2;
                                Properties.Settings.Default.Recent2 = Properties.Settings.Default.Recent1;
                                Properties.Settings.Default.Recent1 = path;
                                break;
                            case 9:
                                Properties.Settings.Default.Recent10 = Properties.Settings.Default.Recent9;
                                Properties.Settings.Default.Recent9 = Properties.Settings.Default.Recent8;
                                Properties.Settings.Default.Recent8 = Properties.Settings.Default.Recent7;
                                Properties.Settings.Default.Recent7 = Properties.Settings.Default.Recent6;
                                Properties.Settings.Default.Recent6 = Properties.Settings.Default.Recent5;
                                Properties.Settings.Default.Recent5 = Properties.Settings.Default.Recent4;
                                Properties.Settings.Default.Recent4 = Properties.Settings.Default.Recent3;
                                Properties.Settings.Default.Recent3 = Properties.Settings.Default.Recent2;
                                Properties.Settings.Default.Recent2 = Properties.Settings.Default.Recent1;
                                Properties.Settings.Default.Recent1 = path;
                                break;
                        }
                
                    }
                }
            //}
           // catch
            //{
                
            
                if (k == true)
                {            
                    Properties.Settings.Default.Recent10 = Properties.Settings.Default.Recent9;
                    Properties.Settings.Default.Recent9 = Properties.Settings.Default.Recent8;
                    Properties.Settings.Default.Recent8 = Properties.Settings.Default.Recent7;
                    Properties.Settings.Default.Recent7 = Properties.Settings.Default.Recent6;
                    Properties.Settings.Default.Recent6 = Properties.Settings.Default.Recent5;
                    Properties.Settings.Default.Recent5 = Properties.Settings.Default.Recent4;
                    Properties.Settings.Default.Recent4 = Properties.Settings.Default.Recent3;
                    Properties.Settings.Default.Recent3 = Properties.Settings.Default.Recent2;
                    Properties.Settings.Default.Recent2 = Properties.Settings.Default.Recent1;
                    Properties.Settings.Default.Recent1 = path;
                }
           // }

            Properties.Settings.Default.Save();
            showrecent();
        }

        public void showrecent()
        {
            listB_recent.Items.Clear();
            cmbB_recent.Text = Properties.Settings.Default.NumRecent;
            for (var i = 0; i < Int32.Parse(Properties.Settings.Default.NumRecent); i++) //this can be optimized, i could start from 4 and the current first 4 cases would execute outside of the switch no matter what
            {
                switch (i)
                {
                    case 0:
                        listB_recent.Items.Add(Properties.Settings.Default.Recent1);
                        break;
                    case 1:
                        listB_recent.Items.Add(Properties.Settings.Default.Recent2);
                        break;
                    case 2:
                        listB_recent.Items.Add(Properties.Settings.Default.Recent3);
                        break;
                    case 3:
                        listB_recent.Items.Add(Properties.Settings.Default.Recent4);
                        break;
                    case 4:
                        listB_recent.Items.Add(Properties.Settings.Default.Recent5);
                        break;
                    case 5:
                        listB_recent.Items.Add(Properties.Settings.Default.Recent6);
                        break;
                    case 6:
                        listB_recent.Items.Add(Properties.Settings.Default.Recent7);
                        break;
                    case 7:
                        listB_recent.Items.Add(Properties.Settings.Default.Recent8);
                        break;
                    case 8:
                        listB_recent.Items.Add(Properties.Settings.Default.Recent9);
                        break;
                    case 9:
                        listB_recent.Items.Add(Properties.Settings.Default.Recent10);
                        break;
                }
            }
        }

        public void errormsg(int i)
        {
            string message, title;            
            switch (i)
            {            
                case 0:
                    btn_clear.PerformClick();
                    message = "Selected file not properly formatted";
                    title = "Error";
                    MessageBox.Show(message, title);
                    break;
                case 1:
                    message = "Cannot save changes to file because no file path exists.\r\nPlease use the Save As feature to create a project file.";
                    title = "Error";
                    MessageBox.Show(message, title);
                    break;
            }
        }

        public bool compare()
        {
            //This method is supposed to compare the file with located at the listed program path location with the current textbox entries
            //If they are the same, returns 1, if not returns 0, which should trigger a pop up message asking if you want to save changes
            //Might be easiest to get the data of the current entry and store it in a temp variable, then save current entry in a temp file
            //Then load the file with the listed program path, get it's data and compare it with the temp variable, then load the temp file back and delete the temp file

            return true; //functionality to be implemented
        }

        public void savedata(string path)
        {

            string[] tempArray = getdata();
            StreamWriter File = new StreamWriter(path); //app crashes here when using the Save(not Save As) feature. Not sure why, tried troubleshooting it to no avail.
            File.Write("***valid project file***" + "\r\n");
            for (var i = 0; i < tempArray.Count(); i++)
            {
                File.Write(tempArray[i] + "\r\n");
            }

            File.Close();
            lbl_path.Text = path;
        }

        public string[] getdata()
        {

            var n = rtxtB_parms.Lines.Count();
            

            string[] entries = new string[n+3];
            entries[0] = txtB_sName.Text;
            entries[1] = txtB_dbName.Text;
            entries[2] = txtB_uname.Text;
            entries[3] = txtB_pword.Text;
         

            
            if (rtxtB_parms.TextLength != 0) //app keps crashes if rich text box is empty when attempting to save or save as, this was supposed to fix it
            {                
                string[] tempArray = rtxtB_parms.Lines;
                for (var i = 4; i < n+3; i++)
                {
                    entries[i] = tempArray[i - 4];
                };
            }
            
            return entries;
        }

        public void cleardata(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                //for textbox
                if (ctrl is TextBox)
                {
                    ctrl.Text="";
                }
                
                //for richtextbox
                if (ctrl is RichTextBox)
                {
                    ctrl.Text = "";
                }

            }
        }

        public void loaddata(string myPath)
        {
            //StreamReader reader = new StreamReader(myStream);
            //rtxtB_parms.Text = reader.ReadToEnd();
            //rtxtB_parms.Text = myPath;

            //rtxtB_parms.Text = File.ReadAllText(myPath);           

            string myData = File.ReadAllText(myPath);

            char[] delimiters = new[] { '\r', '\n' };
            string[] entries = myData.Split(delimiters);
               
            if (entries[0] == "***valid project file***")
            {
                lbl_path.Text = myPath;
                addrecent(myPath);
                showrecent();


                for (var i = 2; i < entries.Count(); i+=2) 
                {
                    switch (i)
                    {
                        case 2:
                            txtB_sName.Text = entries[i];
                            break;
                        case 4:
                            txtB_dbName.Text = entries[i];
                            break;
                        case 6:
                            txtB_uname.Text = entries[i];
                            break;
                        case 8:
                            txtB_pword.Text = entries[i];
                            break;
                        default:                        
                            rtxtB_parms.AppendText(entries[i] + "\r\n");
                            break;                    
                    }
                }
            }
            else
            {
                lbl_path.Text = "No Path";

                //string message = "Selected file not properly formatted";
                //string title = "Error";
                //MessageBox.Show(message, title);

                errormsg(0);

            }



            return;
        }



        private void btn_clear_Click(object sender, EventArgs e)
        {
            cleardata(this.Controls);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {            



                Stream myStream;
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    btn_clear.PerformClick();
                    //lbl_path.Text = openFileDialog1.FileName;
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        /*
                        string filetext = File.ReadAllText(openFileDialog1.FileName);
                        loaddata(filetext);
                        */
                        loaddata(openFileDialog1.FileName);
                        showrecent();
                    }
                }
            
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_clear.PerformClick();
            if (lbl_path.Text != "No Path")
            loaddata(lbl_path.Text);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (lbl_path.Text == "No Path")
            {
                errormsg(1);
            }
            else
            {

                savedata(lbl_path.Text);
                    /*
                string[] tempArray = getdata();
                StreamWriter File = new StreamWriter(lbl_path.Text);
                File.Write("***valid project file***" + "\r\n");
                for (var i = 0; i < tempArray.Count(); i++)
                {
                    File.Write(tempArray[i] + "\r\n");
                }

                File.Close();*/
                }
                
        }

        private void btn_saveAs_Click(object sender, EventArgs e)
        {         



            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.AddExtension = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                savedata(saveFileDialog1.FileName);
                addrecent(saveFileDialog1.FileName);
                showrecent();
                /*
            string[] tempArray = getdata();
            StreamWriter File = new StreamWriter(saveFileDialog1.FileName);
            File.Write("***valid project file***" + "\r\n");
            for (var i = 0; i < tempArray.Count(); i++)
            {
                File.Write(tempArray[i] + "\r\n");
            }

            File.Close();*/
            }

            /*string[] tempArray = getdata();
            StreamWriter File = new StreamWriter(@"C:\test\proba.txt");
            File.Write("***valid project file***" + "\r\n");            
            for (var i = 0; i < tempArray.Count(); i++)
            {
                File.Write(tempArray[i] + "\r\n");
            }
                
            File.Close();*/
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            bool i = compare();
            if (i == true)
            {
                btn_clear.PerformClick();
                lbl_path.Text = "No Path";
            }

        }

        private void cmbB_recent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_recent_Click(object sender, EventArgs e)
        {
            //showrecent();

            
                string text = listB_recent.GetItemText(listB_recent.SelectedItem);

            btn_clear.PerformClick();
            loaddata(text);



        }

        private void btn_recentSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NumRecent = cmbB_recent.Text;
            Properties.Settings.Default.Save();
            showrecent();            
        }

        private void txtB_sName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
