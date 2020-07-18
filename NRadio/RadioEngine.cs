﻿using System;
using Dartware.NRadio.BassWrapper;

namespace Dartware.NRadio
{
	/// <summary>
	/// Radio-engine implementation based on the cross-platform library bass.dll. Requires: bass.dll - Bass Audio Library - available <see href="http://www.un4seen.com">here</see>.
	/// </summary>
	internal sealed partial class RadioEngine : IRadioEngine
	{

		/// <summary>
		/// The channel handle. A HSTREAM, HMUSIC, or HRECORD.
		/// </summary>
		private Int32 handle;

		/// <summary>
		/// Initializes a new instance of the <see cref="RadioEngine"/> class.
		/// </summary>
		internal RadioEngine()
		{
			
			this.volume = 100;

			Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);

		}

	}
}