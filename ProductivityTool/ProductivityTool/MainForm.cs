using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace ProductivityTool
{
    public partial class MainForm : Form
    {
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public MainForm()
        {
            InitializeComponent();

            // Create a simple tray menu with only one item.
            trayMenu = new ContextMenu();
            trayMenu.MenuItems.Add("Show", OnShow);
            trayMenu.MenuItems.Add("Hide", OnHide);
            trayMenu.MenuItems.Add("Exit", OnExit);

            // Create a tray icon. In this example we use a
            // standard system icon for simplicity, but you
            // can of course use your own custom icon too.
            trayIcon = new NotifyIcon();
            trayIcon.Text = "Productivity Tool";
            trayIcon.Icon = new Icon(SystemIcons.Application, 40, 40);

            // Add menu to tray icon and show it.
            trayIcon.ContextMenu = trayMenu;
            trayIcon.Visible = true;

            // Create the NotifyIcon.
            this.components = new System.ComponentModel.Container();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            //SetBalloonTip();

            m_countdown_timer = new Timer();
            m_countdown_timer.Tick += new EventHandler(TimerEventProcessor);
            m_countdown_timer.Interval = 1000;
            m_countdown_timer.Stop();

            pomodoroRadioButton.Select();
        }

        protected override void OnLoad(EventArgs e)
        {
            // force application to be top most...
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnShow(object sender, EventArgs e)
        {
            Visible         = true;
            ShowInTaskbar   = false;
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }

        private void OnHide(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
        }
/*
        protected override void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                // Release the icon resource.
                trayIcon.Dispose();
            }

            base.Dispose(isDisposing);
        }
*/
        private void startButton_Click(object sender, EventArgs e)
        {
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.BalloonTipTitle = "New pomodoro started";
            notifyIcon.BalloonTipText = "It's time to get productive!";
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(5000);

            UpdateCountdownTextbox();
            m_countdown_timer.Start();
        }

        private void UpdateCountdownTextbox()
        {
            uint hours      = m_countdown/3600;
            uint minutes    = (m_countdown - 3600*hours)/60;
            uint seconds    = m_countdown - 3600*hours - 60*minutes;

            timerTextBox.Text = hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + seconds.ToString("D2");
        }

        delegate void StringArgReturningVoidDelegate(String text);
        private void UpdateCountdownTextbox(String text)
        {
            // InvokeRequired required compares the thread ID of the  
            // calling thread to the thread ID of the creating thread.  
            // If these threads are different, it returns true.  
            if (this.timerTextBox.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(UpdateCountdownTextbox);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                timerTextBox.Text = text ;
            }
        }  

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
             if (m_countdown > 0)
            {
                m_countdown--;
            }
            else
            {
                notifyIcon.Icon = SystemIcons.Information;
                notifyIcon.BalloonTipTitle = "Pomodoro reached the end...";
                notifyIcon.BalloonTipText = "It's time to take a break!";
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(5000);

                m_countdown_timer.Stop();
            }

             UpdateCountdownTextbox();
        }

        private Timer   m_countdown_timer;
        private UInt32  m_countdown;
        private System.Windows.Forms.NotifyIcon notifyIcon;

        private void stopButton_Click(object sender, EventArgs e)
        {
            m_countdown_timer.Stop();
        }

        private void pomodoroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                m_countdown = 25 * 60;
                UpdateCountdownTextbox();
            }

            UpdateCountdownTextbox();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            m_countdown_timer.Stop();

            // reset to current state default...
            if (pomodoroRadioButton.Checked)
            {
                m_countdown = 25 * 60;
                UpdateCountdownTextbox();
            }
            else if (shortBreakRadioButton.Checked)
            {
                m_countdown = 5 * 60;
                UpdateCountdownTextbox();
            }
            else if (longBreakRadioButton.Checked)
            {
                m_countdown = 10 * 60;
                UpdateCountdownTextbox();
            }
        }

        private void shortBreakRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                m_countdown = 5 * 60;
                UpdateCountdownTextbox();
            }
        }

        private void longBreakRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                m_countdown = 10 * 60;
                UpdateCountdownTextbox();
            }
        }

        private void distractionButton_Click(object sender, EventArgs e)
        {
            DistractionForm form = new DistractionForm();

            form.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        private NotifyIcon trayIcon;
        private ContextMenu trayMenu;
    }
}
