﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace ranjen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("17d94ca0-68a4-402d-821f-80ae0b637499", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ranjenRepository repository.
        /// </summary>
        public static ranjenRepository repo = ranjenRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\KeePass Password Safe 2\\KeePass.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Program Files (x86)\\KeePass Password Safe 2\\KeePass.exe", "", "C:\\Program Files (x86)\\KeePass Password Safe 2", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KeyPromptForm.Text' at 36;8.", repo.KeyPromptForm.TextInfo, new RecordItemIndex(1));
            repo.KeyPromptForm.Text.Click("36;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'password' with focus on 'KeyPromptForm.Text'.", repo.KeyPromptForm.TextInfo, new RecordItemIndex(2));
            repo.KeyPromptForm.Text.PressKeys("password");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KeyPromptForm.MBtnOK' at 28;8.", repo.KeyPromptForm.MBtnOKInfo, new RecordItemIndex(3));
            repo.KeyPromptForm.MBtnOK.Click("28;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.AddEntry' at 14;14.", repo.MainForm.AddEntryInfo, new RecordItemIndex(4));
            repo.MainForm.AddEntry.Click("14;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.Text' at 57;7.", repo.PwEntryForm.TextInfo, new RecordItemIndex(5));
            repo.PwEntryForm.Text.Click("57;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'martin' with focus on 'PwEntryForm.Text'.", repo.PwEntryForm.TextInfo, new RecordItemIndex(6));
            repo.PwEntryForm.Text.PressKeys("martin");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.UserName' at 64;6.", repo.PwEntryForm.UserNameInfo, new RecordItemIndex(7));
            repo.PwEntryForm.UserName.Click("64;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'msmith' with focus on 'PwEntryForm.UserName'.", repo.PwEntryForm.UserNameInfo, new RecordItemIndex(8));
            repo.PwEntryForm.UserName.PressKeys("msmith");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MBtnOK' at 43;9.", repo.PwEntryForm.MBtnOKInfo, new RecordItemIndex(9));
            repo.PwEntryForm.MBtnOK.Click("43;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.Martin' at 49;10.", repo.MainForm.MartinInfo, new RecordItemIndex(10));
            repo.MainForm.Martin.Click("49;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'MainForm.Martin'.", repo.MainForm.MartinInfo, new RecordItemIndex(11));
            repo.MainForm.Martin.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.Save' at 9;16.", repo.MainForm.SaveInfo, new RecordItemIndex(12));
            repo.MainForm.Save.Click("9;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.Close' at 22;17.", repo.MainForm.CloseInfo, new RecordItemIndex(13));
            repo.MainForm.Close.Click("22;17");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
