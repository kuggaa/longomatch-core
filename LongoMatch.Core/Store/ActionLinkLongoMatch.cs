﻿//
//  Copyright (C) 2015 Fluendo S.A.
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Newtonsoft.Json;
using VAS.Core.Common;
using VAS.Core.Interfaces;
using VAS.Core.Store;
using LongoMatch.Core.Common;

namespace LongoMatch.Core.Store
{
	/// <summary>
	/// Defines an action link between 2 buttons in a <see cref="LongoMatch.Core.Store.Templates.Dashboard"/>.
	/// </summary>
	[Serializable]
	[PropertyChanged.ImplementPropertyChanged]
	public class ActionLinkLongoMatch : ActionLink
	{
		public ActionLinkLongoMatch ()
		{
			TeamAction = TeamLinkAction.Keep;
		}
			
		/// <summary>
		/// The type of action that will be performed in the destination.
		/// </summary>
		public LinkAction Action {
			get;
			set;
		}

		/// <summary>
		/// The type of action that will be performed in the destination
		/// for team tagged in the source event.
		/// </summary>
		public TeamLinkAction TeamAction {
			get;
			set;
		}
	}
}
