using System.Drawing.Drawing2D;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private List<Event> events;
        public Form1()
        {
            InitializeComponent();
            events = new List<Event>();

        }
        
        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItem != null)
            {
                events[lstEvents.SelectedIndex].IsCompleted = true;
                lstEvents_SelectedIndexChanged(sender, e);
            }
        }



        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstEvents.Items.Clear();
            foreach (Event ev in events)
            {
                lstEvents.Items.Add(ev.ToString());
                progressBar.Value += 1;
            }


        }

        private void btnMarkCompleted_CheckedChanged_1(object sender, EventArgs e)
        {
            if (lstEvents.SelectedItem != null)
            {
                events[lstEvents.SelectedIndex].IsCompleted = true;
                lstEvents_SelectedIndexChanged(sender, e);
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEventName.Text) && dtpEventDate.Value != null)
            {
                Event newEvent = new Event()
                {
                    Name = txtEventName.Text,
                    Date = dtpEventDate.Value,
                    IsCompleted = false

                };
                events.Add(newEvent);
                lstEvents_SelectedIndexChanged(sender, e);
                
            }
        }
    }

    public class Event
    {
        public string Name { get; set; } 
        public DateTime Date { get; set; } 
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Date.ToShortDateString()} " +
                   $"{(IsCompleted ? "[Удалено]" : "")}";
        }
    }
}
