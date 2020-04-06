using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This class Manages the application
namespace Assignment6
{
    class MultiSDIApplication : WindowsFormsApplicationBase
    {
        //Helper method to expose this custom WindowsFormsApplicationBase type 
        //Found on pg 562(single) & 564(multi) of the textbook
        static MultiSDIApplication application;
        internal static MultiSDIApplication Application
        {
            get
            {
                if (application == null)
                {
                    application = new MultiSDIApplication();
                }

                return application;
            }
        }

        // Must call base constructor to ensure correct initial
        // WindowsFormsApplicationBase configuration
        public MultiSDIApplication()
        {
            // This ensures OnStartupNextInstance is fired
            this.IsSingleInstance = true;

            // Needed for multiple SDI because no form is the main form
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }

        protected override void OnCreateMainForm()
        {
            this.MainForm = this.CreateTopLevelWindow(this.CommandLineArgs);
        }

        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs e)
        {
            this.CreateTopLevelWindow(e.CommandLine);
        }

        MainForm CreateTopLevelWindow(ReadOnlyCollection<string> args)
        {
            string fileName = (args.Count > 0 ? args[0] : null);

            return Assignment6.MainForm.CreateTopLevelWindow(fileName);
        }

        public void AddMainForm(MainForm form)
        {
            // Add form to collection of forms and
            // watch for it to activate and close
            form.Activated += Form_Activated;
            form.FormClosed += Form_FormClosed;

            // Register the new form's Window menu using IWindowMenu interface
            AddWindowMenu(form.WindowToolStripMenuItem);

            // Set initial top-level form to activate
            if (this.OpenForms.Count == 1) this.MainForm = form;
        }

        //Activated Forms become the MainForm
        void Form_Activated(object sender, EventArgs e)
        {
            // Set the currently active form
            this.MainForm = (Form)sender;
        }

        void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Number of open Forms: " + this.OpenForms.Count);

            // Set a new "main" if necessary
            if (((Form)sender == this.MainForm) && (this.OpenForms.Count > 0))
            {
                Console.WriteLine("MainForm Closed");
                this.MainForm = (Form)this.OpenForms[0];
            }

            //Changed these lines from the textbook because "form" doesnt exist in this context(pg 569)
            /*
            form.Activated -= Form_Activated;
            form.FormClosed -= Form_FormClosed;
            */

            ((Form)sender).Activated -= Form_Activated;
            ((Form)sender).FormClosed -= Form_FormClosed;
        }

        public void AddWindowMenu(ToolStripMenuItem windowMenu)
        {
            // Handle tool strip menu item's drop-down opening event
            windowMenu.DropDownOpening += windowMenu_DropDownOpening;
        }

        void windowMenu_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;

            // Clear current menu
            if (menu.DropDownItems.Count > 0)
            {
                menu.DropDown.Dispose();
            }

            menu.DropDown = new ToolStripDropDown();

            // Populate menu with one item for each open top-level form
            foreach (Form form in this.OpenForms)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Text = form.Text;
                item.Tag = form;
                menu.DropDownItems.Add(item);
                item.Click += WindowMenuItem_Click;

                // Check menu item that represents currently active window - This does not appear to work
                if (form == this.MainForm)
                {
                    item.Checked = true;
                }
            }
        }

        void WindowMenuItem_Click(object sender, EventArgs e)
        {
            // Activate top-level form based on selection
            ((Form)((ToolStripMenuItem)sender).Tag).Activate();
        }
    }
}
