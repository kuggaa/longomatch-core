﻿//
//  Copyright (C) 2017 FLUENDO S.A.
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
using System.Collections.Generic;
using VAS.Core.Hotkeys;

namespace LongoMatch.Core.Hotkeys
{
	public static class LMGeneralUIHotkeys
	{
		static List<KeyConfig> hotkeys;
		public const string CATEGORY = "General Interface";

		// Keep this sorted alphabetically
		public const string SHOW_ZONAL_TAGS = "SHOW_ZONAL_TAGS";

		static LMGeneralUIHotkeys ()
		{
			hotkeys = new List<KeyConfig> {
				new KeyConfig {
					Name = SHOW_ZONAL_TAGS,
					Key = App.Current.Keyboard.ParseName ("<Shift_L>+c"),
					Category = CATEGORY,
					Description = Catalog.GetString("Show zonal tags")
				},
			};
		}

		/// <summary>
		/// Registers the default UI hotkeys
		/// </summary>
		public static void RegisterDefaultHotkeys ()
		{
			App.Current.HotkeysService.Register (hotkeys);
		}
	}
}
