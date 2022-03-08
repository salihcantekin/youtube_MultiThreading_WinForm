using MultiThreading.Models;

namespace MultiThreading
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LogManager.Default.OnLogAdded += (s, e) => { AddLog(e); };
        }














        private void AddLog(string logMessage)
        {
            if (lbLogs.InvokeRequired)
            {
                lbLogs.Invoke(new Action(() => AddLog(logMessage)));
                return;
            }

            logMessage = $"[{DateTime.Now:dd.MM.yyy HH:mm:ss:fff}] - {logMessage}";
            lbLogs.Items.Add(logMessage);
            lbLogs.SelectedIndex = lbLogs.Items.Count - 1;
        }

        private void btnListMailTasks_Click(object sender, EventArgs e)
        {
            var smtpMailTask = new MailTask(MailProviderType.Smtp)
            {
                Second = 10
            };

            var googleMailTask = new MailTask(MailProviderType.GoogleMail)
            {
                Second = 60
            };

            mailTaskBindingSource.Clear();
            mailTaskBindingSource.Add(smtpMailTask);
            mailTaskBindingSource.Add(googleMailTask);
        }

        private void mailTaskBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;

            if (mailTask == null) return;

            btnStartTask.Enabled = !mailTask.IsStarted;
            btnStopTask.Enabled = mailTask.IsStarted;
            btnRunTask.Enabled = mailTask.IsStarted && !mailTask.IsRunning;
        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            mailTask.Start();
        }

        private void btnStopTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            mailTask.Stop();
        }

        private async void btnRunTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;

            await mailTask.Run(50);
        }
    }
}