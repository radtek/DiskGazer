﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskGazer.Models
{
	/// <summary>
	/// Result of reading
	/// </summary>
	internal enum ReadResult
	{
		/// <summary>
		/// Reading disk has not done yet.
		/// </summary>
		NotYet = 0,

		/// <summary>
		/// Reading disk is success.
		/// </summary>
		Success,

		/// <summary>
		/// Reading disk is failure.
		/// </summary>
		Failure,
	}
}