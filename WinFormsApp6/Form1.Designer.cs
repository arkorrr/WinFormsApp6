namespace WinFormsApp6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lstEvents = new ListBox();
            dtpEventDate = new DateTimePicker();
            txtEventName = new TextBox();
            btnAddEvent = new Button();
            btnDeleteEvent = new Button();
            progressBar = new ProgressBar();
            btnMarkCompleted = new CheckBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // lstEvents
            // 
            lstEvents.FormattingEnabled = true;
            lstEvents.ItemHeight = 15;
            lstEvents.Location = new Point(43, 45);
            lstEvents.Name = "lstEvents";
            lstEvents.Size = new Size(228, 94);
            lstEvents.TabIndex = 0;
            // 
            // dtpEventDate
            // 
            dtpEventDate.Location = new Point(43, 145);
            dtpEventDate.Name = "dtpEventDate";
            dtpEventDate.Size = new Size(200, 23);
            dtpEventDate.TabIndex = 1;
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(43, 174);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(100, 23);
            txtEventName.TabIndex = 2;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(43, 203);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(75, 23);
            btnAddEvent.TabIndex = 3;
            btnAddEvent.Text = "button1";
            toolTip1.SetToolTip(btnAddEvent, "Добавить новое событие");
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // btnDeleteEvent
            // 
            btnDeleteEvent.Location = new Point(124, 203);
            btnDeleteEvent.Name = "btnDeleteEvent";
            btnDeleteEvent.Size = new Size(75, 23);
            btnDeleteEvent.TabIndex = 4;
            btnDeleteEvent.Text = "button2";
            toolTip1.SetToolTip(btnDeleteEvent, "Удалить выбранное событие");
            btnDeleteEvent.UseVisualStyleBackColor = true;
            btnDeleteEvent.Click += btnDeleteEvent_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(43, 257);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(241, 23);
            progressBar.Step = 1;
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 5;
            // 
            // btnMarkCompleted
            // 
            btnMarkCompleted.AutoSize = true;
            btnMarkCompleted.Location = new Point(43, 232);
            btnMarkCompleted.Name = "btnMarkCompleted";
            btnMarkCompleted.Size = new Size(83, 19);
            btnMarkCompleted.TabIndex = 6;
            btnMarkCompleted.Text = "checkBox1";
            toolTip1.SetToolTip(btnMarkCompleted, "Отметить выбранное событие как выполненное");
            btnMarkCompleted.UseVisualStyleBackColor = true;
            btnMarkCompleted.CheckedChanged += btnMarkCompleted_CheckedChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMarkCompleted);
            Controls.Add(progressBar);
            Controls.Add(btnDeleteEvent);
            Controls.Add(btnAddEvent);
            Controls.Add(txtEventName);
            Controls.Add(dtpEventDate);
            Controls.Add(lstEvents);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEvents;
        private DateTimePicker dtpEventDate;
        private TextBox txtEventName;
        private Button btnAddEvent;
        private Button btnDeleteEvent;
        private ProgressBar progressBar;
        private CheckBox btnMarkCompleted;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}
