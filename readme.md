## ![Image](https://raw.github.com/Vorror/GrowlForWindowsPushover/master/Resources/growlforwindows.png) Pushover Plugin for GrowlForWindows!
You can now send your Growl for Windows Notifications to Pushover! 

### Install
- Automatic: Copy and Paste this into your web browser: `growl:forwarder*https://raw.github.com/Vorror/GrowlForWindowsPushover/master/Pushover.xml`
- Manual
	- Download [gfwpushover.zip](https://github.com/Vorror/GrowlForWindowsPushover/blob/master/gfwpushover.zip?raw=true)
	- Unzip the gfwpushover.zip and place it inside `%USERPROFILE%\Local Settings\Application Data\Growl\2.0.0.0\Forwarders`

### Usage
- Go to the *Network* tab in GfW
- Hit the plus sign and scroll down to *Forward to your Pushover account*
- Retrieve your API key from [Pushover](https://pushover.net)
- Place that API key into the API Key field
- Add a description and hit save!
- Hit the checkbox *Foward notifications to other computers*

### Features
- Only forward notifications when idle
- Set a minimum notification priority before forwarding
- Enter destination device
- Select Pushover sounds

### Priorities
Pushover only supports 3 levels of priorities whilst GfW supports 5.
- Very Low is considered Low Prority(-1) on Pushover
- Moderate is considered Normal Prority(0) on Pushover
- Normal is considered Normal Prority(0) on Pushover
- High is considered Normal Prority(0) on Pushover
- Emergency is considered High Prority(1) on Pushover

TL;DR only Very Low, Normal, and Emergency priorities affect Pushover.

### Compiling
*If you're only installing the plugin, see the install section above, otherwise this step is unnecessary*

Before compiling this plugin make sure you add your Pushover Application API Key to `WebhookDestination.cs:19` or it won't work!

### License
GrowlForWindowsPushover is licensed under a [Creative Commons Attribution 3.0 Unported License](http://creativecommons.org/licenses/by/3.0/deed.en_US). You are free to copy, distribute, transmit, or adapt the work, as long as you attribute the original author.

*Pushover is a trademark and product of Superblock, LLC. Copyright © 2012 Superblock, LLC. All rights reserved.*