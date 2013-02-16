using System;
using System.Collections.Generic;
using System.Text;
using Growl.Destinations;

namespace Pushover_plugin
{
    /// <summary>
    /// Manages the creation and operation of the webhook forwarder.
    /// </summary>
    public class WebhookForwardHandler : IForwardDestinationHandler
    {
        #region IDestinationHandler Members

        /// <summary>
        /// The name of the webhook instance
        /// </summary>
        /// <value>string</value>
        public string Name
        {
            get { return "Pushover Plugin"; }
        }

        /// <summary>
        /// Registers the forwarder with Growl.
        /// </summary>
        /// <returns><see cref="List[Type]"/></returns>
        public List<Type> Register()
        {
            List<Type> list = new List<Type>();
            list.Add(typeof(WebhookDestination));
            return list;
        }

        /// <summary>
        /// Gets the list of <see cref="DestinationListItem"/>s to display as choices when
        /// the user chooses 'Add Forward'.
        /// </summary>
        /// <returns><see cref="List[DestinationListItem]"/></returns>
        public List<DestinationListItem> GetListItems()
        {
            ForwardDestinationListItem item = new ForwardDestinationListItem("Pushover plugin for GrowlForWindows", GetIcon(), this);
            List<DestinationListItem> list = new List<DestinationListItem>();
            list.Add(item);
            return list;
        }

        /// <summary>
        /// Gets the settings panel associated with this forwarder.
        /// </summary>
        /// <param name="dbli">The <see cref="DestinationListItem"/> as selected by the user</param>
        /// <returns><see cref="DestinationSettingsPanel"/></returns>
        /// <remarks>
        /// This is called when a user is adding a new forwarding destination.
        /// </remarks>
        public DestinationSettingsPanel GetSettingsPanel(DestinationListItem dbli)
        {
            return new WebhookInputs();
        }

        /// <summary>
        /// Gets the settings panel associated with this forwarder.
        /// </summary>
        /// <param name="db">The <see cref="DestinationBase"/> of an exiting forwarder</param>
        /// <returns><see cref="DestinationSettingsPanel"/></returns>
        /// <remarks>
        /// This is called when a user is editing an existing forwarder.
        /// </remarks>
        public DestinationSettingsPanel GetSettingsPanel(DestinationBase db)
        {
            return new WebhookInputs();
        }

        #endregion

        /// <summary>
        /// Gets the icon associated with this forwarder.
        /// </summary>
        /// <returns><see cref="System.Drawing.Image"/></returns>
        internal static System.Drawing.Image GetIcon()
        {
            return new System.Drawing.Bitmap(Properties.Resources.internet);
        }
    }
}
