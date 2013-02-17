using System;
using System.Collections.Generic;
using System.Text;
using Growl.Destinations;

namespace Pushover_plugin
{
    public class WebhookInputs : DestinationSettingsPanel
    {
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Label labelName;
        private Growl.Destinations.HighlightTextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private Growl.Destinations.HighlightTextBox textBox1;
        private System.Windows.Forms.Label label4;
        private Growl.Destinations.HighlightTextBox textBoxUrl;

        public WebhookInputs()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxUrl = new Growl.Destinations.HighlightTextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.textBoxName = new Growl.Destinations.HighlightTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new Growl.Destinations.HighlightTextBox();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.textBox1);
            this.panelDetails.Controls.Add(this.label4);
            this.panelDetails.Controls.Add(this.label3);
            this.panelDetails.Controls.Add(this.comboBox2);
            this.panelDetails.Controls.Add(this.label2);
            this.panelDetails.Controls.Add(this.checkBox1);
            this.panelDetails.Controls.Add(this.label1);
            this.panelDetails.Controls.Add(this.comboBox1);
            this.panelDetails.Controls.Add(this.labelName);
            this.panelDetails.Controls.Add(this.textBoxName);
            this.panelDetails.Controls.Add(this.labelUrl);
            this.panelDetails.Controls.Add(this.textBoxUrl);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(184)))));
            this.textBoxUrl.Location = new System.Drawing.Point(88, 46);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(227, 20);
            this.textBoxUrl.TabIndex = 2;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBoxUrl_TextChanged);
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(19, 49);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(48, 13);
            this.labelUrl.TabIndex = 0;
            this.labelUrl.Text = "API Key:";
            // 
            // textBoxName
            // 
            this.textBoxName.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(184)))));
            this.textBoxName.Location = new System.Drawing.Point(88, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(227, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Description:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Very Low",
            "Moderate",
            "Normal",
            "High",
            "Emergency"});
            this.comboBox1.Location = new System.Drawing.Point(209, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Only forward when priority is at LEAST:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 147);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Only forward when idle or away";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Note: Moderate and High are considered Normal to Pushover!";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "   ",
            "Pushover",
            "Bike",
            "Bugle",
            "Cashregister",
            "Classical",
            "Cosmic",
            "Falling",
            "Gamelan",
            "Incoming",
            "Intermission",
            "Magic",
            "Mechanical",
            "Pianobar",
            "Siren",
            "Spacealarm",
            "Tugboat",
            "None (silent)"});
            this.comboBox2.Location = new System.Drawing.Point(209, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pushover notification sound(optional):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Device Name(optional):";
            // 
            // textBox1
            // 
            this.textBox1.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(184)))));
            this.textBox1.Location = new System.Drawing.Point(209, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // WebhookInputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "WebhookInputs";
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        /// <summary>
        /// Initializes the configuration UI when a webhook is being added or edited.
        /// </summary>
        /// <param name="isSubscription">will always be <c>false</c> for <see cref="ForwardDestination"/>s</param>
        /// <param name="dli">The <see cref="DestinationListItem"/> that the user selected</param>
        /// <param name="db">The <see cref="DestinationBase"/> of the item if it is being edited;<c>null</c> otherwise</param>
        public override void Initialize(bool isSubscription, DestinationListItem dli, DestinationBase db)
        {
            // set text box values
            this.textBoxName.Text = String.Empty;
            this.textBoxName.Enabled = true;
            this.textBoxUrl.Text = String.Empty;
            this.textBoxUrl.Enabled = true;
            this.textBox1.Text = String.Empty;
            this.textBox1.Enabled = true;

            WebhookDestination whd = db as WebhookDestination;
            if (whd != null)
            {
                this.textBoxName.Text = whd.Description;
                this.textBoxUrl.Text = whd.API;
                this.comboBox1.SelectedIndex = whd.Selected;
                this.comboBox2.SelectedIndex = whd.Sound;
                this.checkBox1.Checked = whd.Idle;
                this.textBox1.Text = whd.Device;
            }

            ValidateInputs();

            this.textBoxName.Focus();
        }

        /// <summary>
        /// Creates a new instance of the webhook forwarder.
        /// </summary>
        /// <returns>New <see cref="WebhookDestination"/></returns>
        /// <remarks>
        /// This is called when the user is adding a new destination and clicks the 'Save' button.
        /// </remarks>
        public override DestinationBase Create()
        {
            return new WebhookDestination(this.textBoxName.Text, this.textBoxUrl.Text, this.checkBox1.Checked, this.comboBox1.SelectedIndex, this.comboBox2.SelectedIndex, this.textBox1.Text);
        }

        /// <summary>
        /// Updates the specified webhook instance.
        /// </summary>
        /// <param name="db">The <see cref="WebhookDestination"/> to update</param>
        /// <remarks>
        /// This is called when a user is editing an existing webhook and clicks the 'Save' button.
        /// </remarks>
        public override void Update(DestinationBase db)
        {
            WebhookDestination whd = db as WebhookDestination;
            whd.Description = this.textBoxName.Text;
            whd.API = this.textBoxUrl.Text;
            whd.Idle = this.checkBox1.Checked;
            whd.Selected = this.comboBox1.SelectedIndex;
            whd.Sound = this.comboBox2.SelectedIndex;
            whd.Device = this.textBox1.Text;
        }


        private void ValidateInputs()
        {
            bool valid = true;

            // Description
            if (String.IsNullOrEmpty(this.textBoxName.Text))
            {
                this.textBoxName.Highlight();
                valid = false;
            }
            else
            {
                this.textBoxName.Unhighlight();
            }

            // API
            if (String.IsNullOrEmpty(this.textBoxUrl.Text))
            {
                this.textBoxUrl.Highlight();
                valid = false;
            }
            else
            {
                this.textBoxUrl.Unhighlight();
            }
            //Device
            if (String.IsNullOrEmpty(this.textBox1.Text))
            {
                this.textBox1.Highlight();
            }
            else
            {
                this.textBox1.Unhighlight();
            }
            OnValidChanged(valid);
        }

        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }
    }
}
