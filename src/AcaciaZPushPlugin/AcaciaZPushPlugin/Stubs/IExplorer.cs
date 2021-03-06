﻿/// Copyright 2017 Kopano b.v.
/// 
/// This program is free software: you can redistribute it and/or modify
/// it under the terms of the GNU Affero General Public License, version 3,
/// as published by the Free Software Foundation.
/// 
/// This program is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
/// GNU Affero General Public License for more details.
/// 
/// You should have received a copy of the GNU Affero General Public License
/// along with this program.If not, see<http://www.gnu.org/licenses/>.
/// 
/// Consult LICENSE file for details

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSOutlookDelegates = Microsoft.Office.Interop.Outlook;

namespace Acacia.Stubs
{
    public interface IExplorer : IOutlookWindow
    {
        /// <summary>
        /// Returns the currently selected folder, or null if no folder is selected.
        /// </summary>
        /// <returns>The folder. The caller is responsible for disposing.</returns>
        IFolder GetCurrentFolder();

        /// <summary>
        /// Closes the explorer window.
        /// </summary>
        void Close();

        #region Events
        // TODO: custom delegates
        event NSOutlookDelegates.ExplorerEvents_10_SelectionChangeEventHandler SelectionChange;

        #endregion
    }
}
