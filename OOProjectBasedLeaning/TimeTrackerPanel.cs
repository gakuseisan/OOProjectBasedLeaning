using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProjectBasedLeaning
{

    public class TimeTrackerPanel : Panel, Observer
    {

        private TimeTracker timeTracker = NullTimeTracker.Instance;

        public TimeTrackerPanel()
        {
            InitializeComponent();
        }

        public TimeTrackerPanel(TimeTracker timeTracker)
        {
    
            this.timeTracker = timeTracker;
    
            InitializeComponent();
    
        }

        public void Update(object sender)
        {
            throw new NotImplementedException();
        }

        private void InitializeComponent()
        {
            Label titleLabel = new Label()
            {
                Text = "出退勤ボタン",
                Font = new Font("Arial",14,FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
                
            };
            Controls.Add(titleLabel);


    
        }

        // Methods to handle user interactions like PunchIn, PunchOut, etc.

    }

}
