﻿// *********************************************************************************************************************
// File: ResetSaveValues.cs
// Purpose: Reset the specified save values on start
// Project: Fife College Unity Toolkit
// Copyright Fife College 2018
// *********************************************************************************************************************


// *********************************************************************************************************************
#region Imports
// *********************************************************************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#endregion
// *********************************************************************************************************************


// *********************************************************************************************************************
public class ResetSaveValues : MonoBehaviour {
	// *********************************************************************************************************************


	// *****************************************************************************************************************
	#region Variables
	// *****************************************************************************************************************
	// Exposed Variables
	[Tooltip("Which save values should be reset?")]
	public List<string> m_valueNames = new List<string>();
	[Tooltip("Should we reset ALL save values? CAREFUL! THIS WILL DELETE ALL SAVES!")]
	public bool m_resetAll = false;
	#endregion
	// *****************************************************************************************************************


	// *****************************************************************************************************************
	#region Unity Functions
	// *****************************************************************************************************************
	// Called when object is created
	void Start()
	{
		// Reset everything if we are meant to
		if (m_resetAll == true)
		{
			PlayerPrefs.DeleteAll();
		}
		else
		{
			// Instead, only reset specific keys in the save data
			// Loop through trhe values we were provided
			for (int i = 0; i < m_valueNames.Count; ++i)
			{
				PlayerPrefs.DeleteKey(m_valueNames[i]);
			}
		}
	}
	#endregion
	// *****************************************************************************************************************


}
// *********************************************************************************************************************
