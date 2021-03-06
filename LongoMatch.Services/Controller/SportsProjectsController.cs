﻿//
//  Copyright (C) 2016 Fluendo S.A.
//
//
using LongoMatch.Core.Store;
using LongoMatch.Core.ViewModel;
using VAS.Core.MVVMC;
using VAS.Services.Controller;

namespace LongoMatch.Services.Controller
{

	/// <summary>
	/// Controller for sports projects.
	/// </summary>
	[ControllerAttribute ("ProjectsManager")]
	public class SportsProjectsController : ProjectsController<LMProject, LMProjectVM>
	{
		// FIXME: Currently this is used only in mobile. It will be used in LongoMatch, and we will need to remove all the current behaviour
	}
}

