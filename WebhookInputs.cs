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
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDetails
            // 
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
            this.textBoxUrl.Location = new System.Drawing.Point(88, 42);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(227, 20);
            this.textBoxUrl.TabIndex = 2;
            this.textBoxUrl.TextChanged += new System.EventHandler(this.textBoxUrl_TextChanged);
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(19, 45);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(48, 13);
            this.labelUrl.TabIndex = 0;
            this.labelUrl.Text = "API Key:";
            // 
            // textBoxName
            // 
            this.textBoxName.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(184)))));
            this.textBoxName.Location = new System.Drawing.Point(88, 16);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(227, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 19);
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
            this.comboBox1.Location = new System.Drawing.Point(76, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Only forward when priority is at LEAST:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Only forward when idle or away";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Note: Moderate and High are considered Normal to Pushover!";
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
        /// <remarks>
        /// When an instance is being edited (<paramref name="dli"/> != null), make sure to repopulate any
        /// inputs with the current values.
        /// 
        /// By default, the 'Save' button is disabled and you must call <see cref="DestinationSettingsPanel.OnValidChanged"/>
        /// in order to enable it when appropriate.
        /// </remarks>
        public override void Initialize(bool isSubscription, DestinationListItem dli, DestinationBase db)
        {
            // set text box values
            this.textBoxName.Text = String.Empty;
            this.textBoxName.Enabled = true;
            this.textBoxUrl.Text = String.Empty;
            this.textBoxUrl.Enabled = true;

            WebhookDestination whd = db as WebhookDestination;
            if (whd != null)
            {
                this.textBoxName.Text = whd.Description;
                this.textBoxUrl.Text = whd.API;
                this.comboBox1.SelectedIndex = whd.Selected;
                this.checkBox1.Checked = whd.Idle;
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
            return new WebhookDestination(this.textBoxName.Text, this.textBoxUrl.Text, this.checkBox1.Checked, this.comboBox1.SelectedIndex);
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
    }
}
