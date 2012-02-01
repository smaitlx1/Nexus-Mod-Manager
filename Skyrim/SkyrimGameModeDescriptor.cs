﻿using System.Drawing;

namespace Nexus.Client.Games.Skyrim
{
	/// <summary>
	/// Provides the basic information about the Skyrim game mode.
	/// </summary>
	public class SkyrimGameModeDescriptor : IGameModeDescriptor
	{
        private static string[] EXECUTABLES = { "SkyrimLauncher.exe" };
        private const string MODE_ID = "Skyrim";
		
		#region Properties

		/// <summary>
		/// Gets the display name of the game mode.
		/// </summary>
		/// <value>The display name of the game mode.</value>
		public string Name
		{
			get
			{
				return "Skyrim";
			}
		}

		/// <summary>
		/// Gets the unique id of the game mode.
		/// </summary>
		/// <value>The unique id of the game mode.</value>
		public string ModeId
		{
			get
			{
				return MODE_ID;
			}
		}

		/// <summary>
		/// Gets the list of possible executable files for the game.
		/// </summary>
		/// <value>The list of possible executable files for the game.</value>
		public string[] GameExecutables
		{
			get
			{
				return EXECUTABLES;
			}
		}

		/// <summary>
		/// Gets the theme to use for this game mode.
		/// </summary>
		/// <value>The theme to use for this game mode.</value>
		public Theme ModeTheme
		{
			get
			{
				return new Theme(Properties.Resources.skyrim_logo, Color.FromArgb(50, 104, 158));
			}
		}

		#endregion
	}
}
