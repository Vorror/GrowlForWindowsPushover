using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Growl.Destinations;

namespace Pushover_plugin
{
    /// <summary>
    /// Forwards notifications to any url using an HTTP POST request.
    /// </summary>
    [Serializable]
    public class WebhookDestination : ForwardDestination
    {
        /// <summary>
        /// The url of the webhook
        /// </summary>
        private string DEST = "https://api.pushover.net/1/messages.json";
        private string APP_API_KEY = "YOUR APP API KEY";
        private string api;
        private bool sendIfIdle;
        private int selectedpriority;
        private string[] modes = new string[] {
            "Very Low",
            "Moderate",
            "Normal",
            "High",
            "Emergency"};
        private string[] when = new string[] {
            "Always",
            "When Idle"};

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDestination"/> class.
        /// </summary>
        /// <param name="url">The URL of the webhook</param>
        public WebhookDestination(string name, string api, bool sendIfIdle, int selectedpriority)
            : base(name, true)
        {
            this.api = api;
            this.sendIfIdle = sendIfIdle;
            this.selectedpriority = selectedpriority;
            this.sendIfIdle = sendIfIdle;
        }

        /// <summary>
        /// Gets the address display.
        /// </summary>
        /// <value>The address display.</value>
        public override string AddressDisplay
        {
            get {
                return "(" + modes[this.selectedpriority] + "/" + when[Convert.ToInt32(this.sendIfIdle)] + ") - " + this.api;
            }
        }

        /// <summary>
        /// Gets or sets the URL of the webhook
        /// </summary>
        /// <value>string</value>
        public string API
        {
            get
            {
                return this.api;
            }
            set
            {
                this.api = value;
            }
        }
        public bool Idle
        {
            get
            {
                return this.sendIfIdle;
            }
            set
            {
                this.sendIfIdle = value;
            }
        }
        public int Selected
        {
            get
            {
                return this.selectedpriority;
            }
            set
            {
                this.selectedpriority = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="WebhookDestination"/> is available.
        /// </summary>
        /// <value>Always returns <c>true</c>.</value>
        public override bool Available
        {
            get
            {
                return true;
            }
            protected set
            {
                //throw new Exception("The method or operation is not implemented.");
            }
        }
        /// <summary>
        /// Converts Growl styled notifcations to Pushover Styled notifications
        /// </summary>
        /// <param name="notification">The notification information</param>
        public int ConvertNotificationStyle(Growl.Connector.Notification notification)
        {
            switch ((int)notification.Priority)
            {
                case -2:
                    return -1;
                case -1:
                    return 0;
                case 0:
                    return 0;
                case 1:
                    return 0;
                case 2:
                    return 1;

            }
            return 0;
        }
        /// <summary>
        /// Converts Selected Priority to mode styled priorty
        public int converttolocal(int priority)
        {
            switch (priority)
            {
                case 0:
                    return -1;
                case 1:
                    return 0;
                case 2:
                    return 0;
                case 3:
                    return 0;
                case 4:
                    return 1;
            }
            return 0;
        }
        
        /// </summary>
        /// <param name="notification">The notification information</param>
        /// <summary>
        /// Called when a notification is received by GfW.
        /// </summary>
        /// <param name="notification">The notification information</param>
        /// <param name="callbackContext">The callback context.</param>
        /// <param name="requestInfo">The request info.</param>
        /// <param name="isIdle"><c>true</c> if the user is currently idle;<c>false</c> otherwise</param>
        /// <param name="callbackFunction">The function GfW will run if this notification is responded to on the forwarded computer</param>
        public override void ForwardNotification(Growl.Connector.Notification notification, Growl.Connector.CallbackContext callbackContext, Growl.Connector.RequestInfo requestInfo, bool isIdle, ForwardDestination.ForwardedNotificationCallbackHandler callbackFunction)
        {
          if ((isIdle == false && sendIfIdle == true) || !( ConvertNotificationStyle(notification) >= converttolocal(this.selectedpriority)))
          {
               return;
          }
            try
            {
                QuerystringBuilder qsb = new QuerystringBuilder();
                qsb.Add("token", APP_API_KEY);
                qsb.Add("user", api);
                qsb.Add("title", notification.Title);
                qsb.Add("message",notification.Text);
                qsb.Add("priority", ConvertNotificationStyle(notification));
                string data = qsb.ToPostData();
                Growl.CoreLibrary.WebClientEx wc = new Growl.CoreLibrary.WebClientEx();
                using (wc)
                {
                    wc.Headers.Add(HttpRequestHeader.UserAgent, "Pushover GfW Plugin/1.0");
                    string result = wc.UploadString(DEST, data);
                    Console.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                // this is an example of writing to the main GfW debug log:
                Growl.CoreLibrary.DebugInfo.WriteLine(String.Format("Pushover forwarding failed: {0}", ex.Message));
            }
        }

        /// <summary>
        /// Called when an application registration is received by GfW.
        /// </summary>
        /// <param name="application">The application.</param>
        /// <param name="notificationTypes">The notification types.</param>
        /// <param name="requestInfo">The request info.</param>
        /// <param name="isIdle"><c>true</c> if the user is currently idle;<c>false</c> otherwise</param>
        public override void ForwardRegistration(Growl.Connector.Application application, List<Growl.Connector.NotificationType> notificationTypes, Growl.Connector.RequestInfo requestInfo, bool isIdle)
        {
            // do nothing
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns><see cref="WebhookDestination"/></returns>
        public override DestinationBase Clone()
        {
            return new WebhookDestination(this.Description,this.api, this.sendIfIdle, this.selectedpriority);
        }

        /// <summary>
        /// Gets the icon that represents this type of forwarder.
        /// </summary>
        /// <returns><see cref="System.Drawing.Image"/></returns>
        public override System.Drawing.Image GetIcon()
        {
            return WebhookForwardHandler.GetIcon();
        }
    }
}
