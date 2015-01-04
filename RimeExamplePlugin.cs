/*
    The MIT License (MIT)

    Copyright (c) 2005-2015 kiwidoggie productions

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// WPF User Control
using System.Windows.Controls;

// Plugin System
using Rime.Core.Plugins;

namespace RimePluginExample
{
    /// <summary>
    /// Example plugin class for Rime.
    /// </summary>
    public class RimeExamplePlugin : IPlugin
    {
        // Set these to your current configuration
        private string m_Name = "Example Plugin";
        private string m_Author = "Rime Developers (kiwidog)";
        private string m_Version = "0.01";
        private string m_Description = "A example plugin.";
        private string m_Extension = ".ext";
        private UserControl m_Control = null;

        /// <summary>
        /// Initialization with no parameters
        /// </summary>
        /// <returns>True for success, False for failure</returns>
        public bool Init()
        {
            System.Windows.MessageBox.Show("Init called.");
            return true;
        }

        /// <summary>
        /// Initalization with one parameter, plugin will have to do all type and cast checking itself.
        /// </summary>
        /// <param name="p_Object">Object passed as argument</param>
        /// <returns>True for success, False for failure</returns>
        public bool Init(object p_Object)
        {
            // Handle if one object is passed, check SDK for what is passed
            System.Windows.MessageBox.Show("Init with one parameter called.");
            return true;
        }

        /// <summary>
        /// Initialization with multiple parameters, plugin will have to do all type and cast checking itself.
        /// </summary>
        /// <param name="p_Objects">Array of objects passed as arguments</param>
        /// <returns>True for success, False for failure</returns>
        public bool Init(object[] p_Objects)
        {
            // Handle multiple plugin objects coming in at once
            System.Windows.MessageBox.Show("Init with multiple paramerters called.");
            return true;
        }

        /// <summary>
        /// Close is called when the plugin is being destroyed, free all memory, ui, resources here.
        /// </summary>
        public void Close()
        {
            // TODO: Call cleanup if nessessary
        }

        public bool UIEnabled
        {
            get { return (m_Control != null); }
        }

        public string Name
        {
            get { return m_Name; }
        }

        public string Author
        {
            get { return m_Author; }
        }

        public string Version
        {
            get { return m_Version; }
        }

        public string Description
        {
            get { return m_Description; }
        }

        public UserControl MainControl
        {
            get { return m_Control; }
        }

        public string Extension
        {
            get { return m_Extension; }
        }
    }
}
