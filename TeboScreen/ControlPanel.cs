using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using ScreenshotCapture.Properties;

namespace ScreenshotCapture
{

    public partial class ControlPanel : Form
    {

        string ScreenPath;
        private static bool TipsShowing;
        string projectNumber;
        string projectName;
        string fileName;
        string version;
        string author;
        string date;

        private Form m_InstanceRef = null;
        public Form InstanceRef
        {

            get
            {

                return m_InstanceRef;

            }
            set
            {

                m_InstanceRef = value;

            }

        }

        public ControlPanel()
        {

            InitializeComponent();

        }

        public ControlPanel(bool Save)
        {

            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form_Close);

        }

        public void key_press(object sender, KeyEventArgs e)
        {

            keyTest(e);

        }


        private void keyTest(KeyEventArgs e)
        {

            if (e.KeyCode.ToString() == "S")
            {

                screenCapture(true);

            }

        }


        private void Form_Close(object sender, FormClosedEventArgs e)
        {
            Settings.Default.projectNumber = this.projectNumber;
            Settings.Default.projectName = this.projectName;
            Settings.Default.fileName = this.fileName;
            Settings.Default.version = this.version;
            Settings.Default.author = this.author;
            Settings.Default.Save();
            Application.Exit();

        }

        private void bttCaptureArea_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form1 form1 = new Form1();
            form1.InstanceRef = this;
            //fileDetails();
            form1.Show();
            //projectNumber = Settings.Default.projectNumber;
            //projectName = Settings.Default.projectName;
            //fileName = Settings.Default.fileName;
            //version = Settings.Default.version;
            //author = Settings.Default.author;
            //date = DateTime.Now.ToString("yymmd");
            //saveFileDialog1.FileName = date + "_" + projectNumber + "_" + projectName + "_" + fileName + "_" + version + "_" + author;

            


        }

        public void screenCapture(bool showCursor)
        {
            Point curPos = new Point(Cursor.Position.X, Cursor.Position.Y);
            Size curSize = new Size();
            curSize.Height = Cursor.Current.Size.Height;
            curSize.Width = Cursor.Current.Size.Width;

            ScreenPath = "";

            if (!ScreenShot.saveToClipboard)
            {
                fileDetails();
                saveFileDialog1.DefaultExt = "png";
                //saveFileDialog1.Filter = "bmp files (*.bmp)|*.bmp|jpg files (*.jpg)|*.jpg|gif files (*.gif)|*.gif|tiff files (*.tiff)|*.tiff|png files (*.png)|*.png";
                saveFileDialog1.Filter = "png files (*.png)|*.png|bmp files (*.bmp)|*.bmp|jpg files (*.jpg)|*.jpg|gif files (*.gif)|*.gif|tiff files (*.tiff)|*.tiff";
                saveFileDialog1.Title = "Save screenshot to...";
                saveFileDialog1.FileName = date + "_" + projectNumber + "_" + projectName + "_" + fileName + "_" + version + "_" + author;
                saveFileDialog1.ShowDialog();
                ScreenPath = saveFileDialog1.FileName;

            }

            

            if (ScreenPath!=""||ScreenShot.saveToClipboard)
            {
                fileDetails();
                //Conceal this form while the screen capture takes place
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                this.TopMost = false;

                //Allow 250 milliseconds for the screen to repaint itself (we don't want to include this form in the capture)
                System.Threading.Thread.Sleep(250);

                Rectangle bounds = Screen.GetBounds(Screen.GetBounds(Point.Empty));
                string fi = "";

                if (ScreenPath != "")
                {

                    fi = new FileInfo(ScreenPath).Extension;

                }

                ScreenShot.CaptureImage(showCursor, curSize, curPos, Point.Empty, Point.Empty, bounds, ScreenPath, fi);
                          
                //The screen has been captured and saved to a file so bring this form back into the foreground
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                this.TopMost = true;

                if (ScreenShot.saveToClipboard)
                {

                    MessageBox.Show("Screen saved to clipboard", "Screen Capture", MessageBoxButtons.OK);

                }
                else
                {

                    MessageBox.Show("Screen saved to file", "Screen Capture", MessageBoxButtons.OK);

                }


            }


        }

        private void bttCaptureScreen_Click(object sender, EventArgs e)
        {
            fileDetails();
            screenCapture(false);

        }

        private void fileDetails()
        {
            projectNumber = projNumTxtBox.Text;
            projectName = projNameTxtBox.Text;
            fileName = fileNameTxtBox.Text;
            version = versionTxtBox.Text;
            author = authorTxtBox.Text;
            date = DateTime.Now.ToString("yymmd");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
                this.projectNumber = Settings.Default.projectNumber;
                this.projectName = Settings.Default.projectName;
                this.fileName = Settings.Default.fileName;
                this.version = Settings.Default.version;
                this.author = Settings.Default.author;

            this.KeyUp += new KeyEventHandler(key_press);

            System.Text.Encoding Encoder = System.Text.ASCIIEncoding.Default;
            Byte[] buffer = new byte[] { (byte)149 };
            string bullet = System.Text.Encoding.GetEncoding(1252).GetString(buffer);

            TipsShowing = true;
            txtTips.Visible = true;

            txtTips.Text =
                bullet + "Press Save Settings to save filename details if settings have changed." + Environment.NewLine + Environment.NewLine + 
            bullet + "To capture an area:" + Environment.NewLine + 
            "  Click and hold down the left mouse button." + Environment.NewLine +
            "  Draw the selection area required." + Environment.NewLine + 
            "  Once the selection area is drawn you can" + Environment.NewLine +
            "  drag it to move it." + Environment.NewLine + Environment.NewLine +
            "  The selection area can also be resized at its" + Environment.NewLine +
            "  four sides and four corners." + Environment.NewLine + Environment.NewLine +
            "  Once you are satisfied with the selection area" + Environment.NewLine +
            "  simply double click anywhere within or outside" + Environment.NewLine +
            "  the selection area to save the selection to an" + Environment.NewLine +
            "  image file." + Environment.NewLine + Environment.NewLine +
            bullet + " With this form active press the 'S' key to" + Environment.NewLine +
            "  capture the screen with the cursor included." + Environment.NewLine +
            "  Alternatively press the 'S' key when you" + Environment.NewLine +
            "  have selected an area in order to include the" + Environment.NewLine +
            "  cursor in the area captured.";

            //this.Width = 140;

        }

        private void saveToClipboard_CheckedChanged(object sender, EventArgs e)
        {

            ScreenShot.saveToClipboard = saveToClipboard.Checked;
            
        }

        private void saveToClipboard_KeyUp(object sender, KeyEventArgs e)
        {

            keyTest(e);

        }

        private void bttCaptureArea_KeyUp(object sender, KeyEventArgs e)
        {

            keyTest(e);

        }

        private void bttTips_KeyUp(object sender, KeyEventArgs e)
        {

            keyTest(e);

        }

        private void bttCaptureScreen_KeyUp(object sender, KeyEventArgs e)
        {

            keyTest(e);

        }

        private void txtTips_KeyUp(object sender, KeyEventArgs e)
        {

            keyTest(e);

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Settings.Default.projectNumber = this.projectNumber;
            Settings.Default.projectName = this.projectName;
            Settings.Default.fileName = this.fileName;
            Settings.Default.version = this.version;
            Settings.Default.author = this.author;
            Settings.Default.Save();
            Application.Exit();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Settings.Default.projectNumber = this.projectNumber;
            Settings.Default.projectName = this.projectName;
            Settings.Default.fileName = this.fileName;
            Settings.Default.version = this.version;
            Settings.Default.author = this.author;
            //Settings.Default.Save();
            /*projNumTxtBox.Text = Settings.Default.projectNumber;
            projNameTxtBox.Text = Settings.Default.projectName;
            fileNameTxtBox.Text = Settings.Default.fileName;
            versionTxtBox.Text = Settings.Default.version;
            authorTxtBox.Text = Settings.Default.author;*/
        }

    }
}