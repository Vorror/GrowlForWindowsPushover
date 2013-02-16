## Pushover Plugin for GrowlForWindows!
You can now send your Growl from Windows Notifications to Pushover! 

### Install
- Automatic [Click Here!](growl:forwarder*http://url.to.your/manifest.xml)
- Manual
	- Unzip the gfwpushover.zip and place it inside `%USERPROFILE%\Local Settings\Application Data\Growl\2.0.0.0\Forwarders`

### Usage
- Go to the *Network* tab in GfW
- Hit the plus sign and scroll down to "Pushover plugin for GfW"
- Retrieve your API key from [Pushover](https://pushover.net)
- Place that API key into the API Key field
- Add a description and hit save!
- Hit the checkbox "Foward notifications to other computers"

### Features
- Only forward notifications when idle
- Set a minimum notification priority before forwarding

### Priorities
Pushover only supports 3 levels of priorities whilst GfW supports 5.
- Very Low is considered Low Prority(-1) on Pushover
- Moderate is considered Normal Prority(0) on Pushover
- Normal is considered Normal Prority(0) on Pushover
- High is considered Normal Prority(0) on Pushover
- Emergency is considered High Prority(1) on Pushover

Long story short, only use Very Low, Normal, and Emergency priorities when forwarding!

### Compiling
Before compiling this plugin make sure you add your Pushover Application API Key to `WebhookDestination.cs:19` or it won't work!

### License
GrowlForWindowsPushover is licensed under a [Creative Commons Attribution 3.0 Unported License](http://creativecommons.org/licenses/by/3.0/deed.en_US). You are free to copy, distribute, transmit, or adapt the work, as long as you attribute the original author.

*Pushover is a trademark and product of Superblock, LLC. Copyright © 2012 Superblock, LLC. All rights reserved.*