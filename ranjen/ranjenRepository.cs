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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace ranjen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the ranjenRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    [RepositoryFolder("136c393e-bce1-44d3-9407-9cad4b4dc2d7")]
    public partial class ranjenRepository : RepoGenBaseFolder
    {
        static ranjenRepository instance = new ranjenRepository();
        ranjenRepositoryFolders.KeyPromptFormAppFolder _keypromptform;
        ranjenRepositoryFolders.MainFormAppFolder _mainform;
        ranjenRepositoryFolders.PwEntryFormAppFolder _pwentryform;

        /// <summary>
        /// Gets the singleton class instance representing the ranjenRepository element repository.
        /// </summary>
        [RepositoryFolder("136c393e-bce1-44d3-9407-9cad4b4dc2d7")]
        public static ranjenRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public ranjenRepository() 
            : base("ranjenRepository", "/", null, 0, false, "136c393e-bce1-44d3-9407-9cad4b4dc2d7", ".\\RepositoryImages\\ranjenRepository136c393e.rximgres")
        {
            _keypromptform = new ranjenRepositoryFolders.KeyPromptFormAppFolder(this);
            _mainform = new ranjenRepositoryFolders.MainFormAppFolder(this);
            _pwentryform = new ranjenRepositoryFolders.PwEntryFormAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("136c393e-bce1-44d3-9407-9cad4b4dc2d7")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The KeyPromptForm folder.
        /// </summary>
        [RepositoryFolder("f6a6765a-d671-4b98-99e4-cd7a7891e33f")]
        public virtual ranjenRepositoryFolders.KeyPromptFormAppFolder KeyPromptForm
        {
            get { return _keypromptform; }
        }

        /// <summary>
        /// The MainForm folder.
        /// </summary>
        [RepositoryFolder("1c456c87-ab62-44ad-b3de-1cb139d022a1")]
        public virtual ranjenRepositoryFolders.MainFormAppFolder MainForm
        {
            get { return _mainform; }
        }

        /// <summary>
        /// The PwEntryForm folder.
        /// </summary>
        [RepositoryFolder("bffd6ac7-d803-4072-a5f0-c1d115dd8fcf")]
        public virtual ranjenRepositoryFolders.PwEntryFormAppFolder PwEntryForm
        {
            get { return _pwentryform; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    public partial class ranjenRepositoryFolders
    {
        /// <summary>
        /// The KeyPromptFormAppFolder folder.
        /// </summary>
        [RepositoryFolder("f6a6765a-d671-4b98-99e4-cd7a7891e33f")]
        public partial class KeyPromptFormAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _textInfo;
            RepoItemInfo _mbtnokInfo;

            /// <summary>
            /// Creates a new KeyPromptForm  folder.
            /// </summary>
            public KeyPromptFormAppFolder(RepoGenBaseFolder parentFolder) :
                    base("KeyPromptForm", "/form[@controlname='KeyPromptForm']", parentFolder, 30000, null, true, "f6a6765a-d671-4b98-99e4-cd7a7891e33f", "")
            {
                _textInfo = new RepoItemInfo(this, "Text", "?/?/text[@accessiblerole='Text']", 30000, null, "9c5a32b1-8a4e-49c4-91d1-9678333d1f6f");
                _mbtnokInfo = new RepoItemInfo(this, "MBtnOK", "button[@controlname='m_btnOK']", 30000, null, "6850934c-0c72-49a0-9f77-b14782f40015");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("f6a6765a-d671-4b98-99e4-cd7a7891e33f")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("f6a6765a-d671-4b98-99e4-cd7a7891e33f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("9c5a32b1-8a4e-49c4-91d1-9678333d1f6f")]
            public virtual Ranorex.Text Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("9c5a32b1-8a4e-49c4-91d1-9678333d1f6f")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The MBtnOK item.
            /// </summary>
            [RepositoryItem("6850934c-0c72-49a0-9f77-b14782f40015")]
            public virtual Ranorex.Button MBtnOK
            {
                get
                {
                    return _mbtnokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The MBtnOK item info.
            /// </summary>
            [RepositoryItemInfo("6850934c-0c72-49a0-9f77-b14782f40015")]
            public virtual RepoItemInfo MBtnOKInfo
            {
                get
                {
                    return _mbtnokInfo;
                }
            }
        }

        /// <summary>
        /// The MainFormAppFolder folder.
        /// </summary>
        [RepositoryFolder("1c456c87-ab62-44ad-b3de-1cb139d022a1")]
        public partial class MainFormAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _addentryInfo;
            RepoItemInfo _martinInfo;
            RepoItemInfo _saveInfo;
            RepoItemInfo _closeInfo;

            /// <summary>
            /// Creates a new MainForm  folder.
            /// </summary>
            public MainFormAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MainForm", "/form[@controlname='MainForm']", parentFolder, 30000, null, true, "1c456c87-ab62-44ad-b3de-1cb139d022a1", "")
            {
                _addentryInfo = new RepoItemInfo(this, "AddEntry", "?/?/button[@accessiblename='Add Entry']", 30000, null, "67364431-1bd3-4d9d-ba32-8b5e2d311a70");
                _martinInfo = new RepoItemInfo(this, "Martin", "container[@controlname='m_splitHorizontal']/?/?/container[@controlname='m_splitVertical']/?/?/table[@controlname='m_lvEntries']/?/?/cell[@text='martin']", 30000, null, "75ea0e96-6e1e-45db-b1f7-a50ca68af233");
                _saveInfo = new RepoItemInfo(this, "Save", "?/?/button[@accessiblename='Save']", 30000, null, "7f0fde08-b8c0-4997-b9fa-0cfd362458d8");
                _closeInfo = new RepoItemInfo(this, "Close", "?/?/button[@accessiblename='Close']", 30000, null, "af574504-5e10-40ee-a3df-de2e29d418d2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1c456c87-ab62-44ad-b3de-1cb139d022a1")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1c456c87-ab62-44ad-b3de-1cb139d022a1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The AddEntry item.
            /// </summary>
            [RepositoryItem("67364431-1bd3-4d9d-ba32-8b5e2d311a70")]
            public virtual Ranorex.Button AddEntry
            {
                get
                {
                    return _addentryInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The AddEntry item info.
            /// </summary>
            [RepositoryItemInfo("67364431-1bd3-4d9d-ba32-8b5e2d311a70")]
            public virtual RepoItemInfo AddEntryInfo
            {
                get
                {
                    return _addentryInfo;
                }
            }

            /// <summary>
            /// The Martin item.
            /// </summary>
            [RepositoryItem("75ea0e96-6e1e-45db-b1f7-a50ca68af233")]
            public virtual Ranorex.Cell Martin
            {
                get
                {
                    return _martinInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Martin item info.
            /// </summary>
            [RepositoryItemInfo("75ea0e96-6e1e-45db-b1f7-a50ca68af233")]
            public virtual RepoItemInfo MartinInfo
            {
                get
                {
                    return _martinInfo;
                }
            }

            /// <summary>
            /// The Save item.
            /// </summary>
            [RepositoryItem("7f0fde08-b8c0-4997-b9fa-0cfd362458d8")]
            public virtual Ranorex.Button Save
            {
                get
                {
                    return _saveInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Save item info.
            /// </summary>
            [RepositoryItemInfo("7f0fde08-b8c0-4997-b9fa-0cfd362458d8")]
            public virtual RepoItemInfo SaveInfo
            {
                get
                {
                    return _saveInfo;
                }
            }

            /// <summary>
            /// The Close item.
            /// </summary>
            [RepositoryItem("af574504-5e10-40ee-a3df-de2e29d418d2")]
            public virtual Ranorex.Button Close
            {
                get
                {
                    return _closeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Close item info.
            /// </summary>
            [RepositoryItemInfo("af574504-5e10-40ee-a3df-de2e29d418d2")]
            public virtual RepoItemInfo CloseInfo
            {
                get
                {
                    return _closeInfo;
                }
            }
        }

        /// <summary>
        /// The PwEntryFormAppFolder folder.
        /// </summary>
        [RepositoryFolder("bffd6ac7-d803-4072-a5f0-c1d115dd8fcf")]
        public partial class PwEntryFormAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _textInfo;
            RepoItemInfo _usernameInfo;
            RepoItemInfo _mbtnokInfo;

            /// <summary>
            /// Creates a new PwEntryForm  folder.
            /// </summary>
            public PwEntryFormAppFolder(RepoGenBaseFolder parentFolder) :
                    base("PwEntryForm", "/form[@controlname='PwEntryForm']", parentFolder, 30000, null, true, "bffd6ac7-d803-4072-a5f0-c1d115dd8fcf", "")
            {
                _textInfo = new RepoItemInfo(this, "Text", "?/?/tabpage[@controlname='m_tabEntry']/text[@controlname='m_tbTitle']/text[@accessiblerole='Text']", 30000, null, "738dae72-c68f-4ada-ad2c-205f1ead738d");
                _usernameInfo = new RepoItemInfo(this, "UserName", "?/?/tabpage[@controlname='m_tabEntry']/?/?/text[@accessiblename='User name:']", 30000, null, "59c970dd-0637-4a0e-bcf7-f9bda1124cf9");
                _mbtnokInfo = new RepoItemInfo(this, "MBtnOK", "button[@controlname='m_btnOK']", 30000, null, "d1c57036-9340-4c32-a2dd-923ccf1e16e3");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("bffd6ac7-d803-4072-a5f0-c1d115dd8fcf")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("bffd6ac7-d803-4072-a5f0-c1d115dd8fcf")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("738dae72-c68f-4ada-ad2c-205f1ead738d")]
            public virtual Ranorex.Text Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("738dae72-c68f-4ada-ad2c-205f1ead738d")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The UserName item.
            /// </summary>
            [RepositoryItem("59c970dd-0637-4a0e-bcf7-f9bda1124cf9")]
            public virtual Ranorex.Text UserName
            {
                get
                {
                    return _usernameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The UserName item info.
            /// </summary>
            [RepositoryItemInfo("59c970dd-0637-4a0e-bcf7-f9bda1124cf9")]
            public virtual RepoItemInfo UserNameInfo
            {
                get
                {
                    return _usernameInfo;
                }
            }

            /// <summary>
            /// The MBtnOK item.
            /// </summary>
            [RepositoryItem("d1c57036-9340-4c32-a2dd-923ccf1e16e3")]
            public virtual Ranorex.Button MBtnOK
            {
                get
                {
                    return _mbtnokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The MBtnOK item info.
            /// </summary>
            [RepositoryItemInfo("d1c57036-9340-4c32-a2dd-923ccf1e16e3")]
            public virtual RepoItemInfo MBtnOKInfo
            {
                get
                {
                    return _mbtnokInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}