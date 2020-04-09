using System;
using System.Drawing;
using System.Windows.Forms;

namespace A3FL_Support_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //Gather Inputs
            string applicantName = inputApplicantName.Text;
            string supportName = inputSupportName.Text;
            string applicationStatus = "";
            bool inputsValid;

            //ERROR - Input Missing: Applicant Name
            if (applicantName == "")
            {
                labelMessagePreview.Text = "ERROR: You have not entered the Applicant's Name. Try again!";
                labelMessagePreview.ForeColor = Color.Red;
                inputsValid = false;
                return;
            }

            //ERROR - Input Missing: Your Name
            if (supportName == "")
            {
                labelMessagePreview.Text = "ERROR: You have not entered Your Name. Try again!";
                labelMessagePreview.ForeColor = Color.Red;
                inputsValid = false;
                return;
            }

            //ERROR - Input Missing: Response Message
            if (inputChooseResponse.SelectedIndex == -1)
            {
                labelMessagePreview.Text = "ERROR: You have not selected a Response. Try again!";
                labelMessagePreview.ForeColor = Color.Red;
                inputsValid = false;
                return;
            }
            else
            {
                applicationStatus = inputChooseResponse.SelectedItem.ToString();
            }
    

            inputsValid = true;
            //Generate Response
            if (inputsValid == true)
            {
                labelMessagePreview.Text = " ";
                labelMessagePreview.ForeColor = Color.White;
                switch (applicationStatus)
                {
                    case "Accepted":
                        //App Accepted
                        labelMessagePreview.Text = "Congratulations [color=#0080ff]" + applicantName + "[/color],\n\n"
                            + "Thank you for your interest in joining Arma 3 Fisher's Life as a civilian. Your citizenship has been [color=#00ff00]accepted[/color] and you may proceed to the next phase of the citizenship application process. Please visit our community Teamspeak, [color=#ff8000]ts3.arma3fisherslife.net or 54.36.238.11:11690[/color], and join the 'Requesting Support' room where a member of our dedicated support team will assist you in making sure you have all the required information for the server.\n\n"
                            + "Best of luck!\n"
                            + "[color=#ff99ff]" + supportName + "\n"
                            + "Support[/color]";
                        break;
                    case "ON HOLD - Forum/RP Name Dont Match":
                        //App On Hold
                        labelMessagePreview.Text = "Hello [color=#0080ff]" + applicantName + "[/color],\n\n"
                            + "Your application is [color=#ff8000][i]On Hold[/i][/color] because of the following reasons:\n\n"
                            + "Name change required, roleplay name must match forums name, please submit a Support Ticket. If you need help or have any questions please join our community Teamspeak, [color=#ff8000]ts3.arma3fisherslife.net or 54.36.238.11:11690[/color].\n\n"
                            + "Please fix the issue(s) above so we can continue your induction process by editing your original post. Make sure that you have replied only stating that you have fixed these issues. (eg. Fixed!)\n\n"
                            + "Thanks,\n"
                            + "[color=#ff99ff]" + supportName + "\n"
                            + "Support[/color]";
                        break;
                    case "ON HOLD - Famous/Fictional Name":
                        //App On Hold
                        labelMessagePreview.Text = "Hello [color=#0080ff]" + applicantName + "[/color],\n\n"
                            + "Your application is [color=#ff8000][i]On Hold[/i][/color] because of the following reasons:\n\n"
                            + "Name change required due to your name being a famous/fictional character, please submit a Support Ticket. If you need help or have any questions please join our community Teamspeak, [color=#ff8000]ts3.arma3fisherslife.net or 54.36.238.11:11690[/color].\n\n"
                            + "Please fix the issue(s) above so we can continue your induction process by editing your original post. Make sure that you have replied only stating that you have fixed these issues. (eg. Fixed!)\n\n"
                            + "Thanks,\n"
                            + "[color=#ff99ff]" + supportName + "\n"
                            + "Support[/color]";
                        break;
                    default:
                        //No item Selected
                        labelMessagePreview.Text = "ERROR: You have not selected a Response. Try again!";
                        labelMessagePreview.ForeColor = Color.Red;
                        break;
                }
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelMessagePreview.Text);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear Inputs
            inputApplicantName.Text = "";
            inputSupportName.Text = "";

            //Clear Response chosen
            inputChooseResponse.SelectedIndex = -1;

            //Clear Output
            labelMessagePreview.Text = " ";
        }

        private void buttonActivityLogger_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/d/1H4ONK-reeO_milqTJ6GRNeO8g17kC0Vxf8RyViX7urI/viewform?edit_requested=true");
        }

        private void buttonActivityStats_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/17jeQQ2LA4xBbN_4MsLYULF9rv0ltPDfp0QFzazW9s4M/edit#gid=0");
        }

        private void buttonApplicationProcess_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1KvleMrG_Dg-jP6hMHYnn1qH-6QYTqShGTy1EX79kyNQ/edit");
        }
        private void buttonCivilianApps_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://forums.arma3fisherslife.net/forums/173/");
        }
        private void buttonSupportManual_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1aIKn5mVo5IOcYypfbgQutciar3gs-RBNh_CkUre7lNQ/edit");
        }

        private void buttonSupportRoster_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1_iT1-2ALbSDec5ztZdeTiNz8BCmgCuQsfPhtxnRrSDM/edit#gid=3534281");
        }
    }
}
