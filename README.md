RimeExamplePlugin
=================

Create your own tools to integrate into Rime.

Currently the way that the plugin system works is...

1. Rime checks .\plugins directory for any plugin with a .dll.
2. Rime checks to see if it matches the IPlugin interface, if it does not then quietly returns.
3. Plugin is stored for use in memory for a later time.

A user requests to open content (done internally via Rime)

1. The watchdog system will scan all available plugins by extension to see which ones can be loaded
2. If there are matches then load the first available plugin (later on may be changed to have user selectable when multiple matches occur)
3. Call IPlugin.Init() if Args are null (sent via Rime) or IPlugin.Init(object p_Object).
4. If the plugin's initialization phase goes through successfully, then the plugin is sent off to the main window (with UI if there is one available)
5. Rime's main UI will auto-add the UI to the main window if there is one available.

Plugin Creators
There are many things that will probably change in the upcoming releases of Rime.

But for now, during the Init call's YOU the developer will have to do all error checking, type checking, and exception handling within the plugin.

Reason being, Rime's plugin system does not have that strong of a hypervisor, watchdog, whatever you want to call it. So the entire app has the potential to crash from poorly written plugins.
Personally, I will eventually get around to making it a bit stronger, more secure, and be able to interact with the application as well.

Also, you WILL have to compile for x64, get over it. x86 libraries will not load in Rime. (Yes, Rime is x64 only...So are most newer FB games anyway)

To add a new UI, the "Main Window" of your plugin will have to be a WPF User Control. You do not have to manually create them in code, just...

1. Add a new WPF User Control in Visual Studio
2. Name it something useful
3. In whichever Init function you need, just call something similar to 'm_Control = new MyWpfUserControl();'

From there, you can actually do all of your logic, loading, whatever from that user control, or from the plugin it does not matter to Rime.

This has been a terrible readme, I am sorry and will eventually update the documentation for you to use.