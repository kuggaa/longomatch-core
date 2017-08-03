﻿//
//  Copyright (C) 2016 Fluendo S.A.
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
using System.Threading.Tasks;
using LongoMatch.Addins.ExtensionPoints;
using LongoMatch.Core;
using VAS.Core.Serialization;
using VAS.Core.Store;
using VAS.Plugins;

namespace LongoMatch.Plugins
{
	public class LongoMatchExporter : ProjectExporterBase, IExportProject
	{
		public override string Name {
			get {
				return Catalog.GetString ("LongoMatch export plugin");
			}
		}

		public override string Description {
			get {
				return Catalog.GetString ("Export project to LongoMatch file");
			}
		}

		public override string Format {
			get {
				return "LGM";
			}
		}

		public override string Extension {
			get {
				return App.Current.ProjectExtension;
			}
		}

		protected override async Task ExportProject (Project project, string filename)
		{
			await Task.Run (() => {
				Serializer.Instance.Save (project, filename);
				ExportDone = true;
			});
		}
	}
}

