﻿using UnityEngine;
using System.Collections;

public class MenuThemeController : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (gameObject.audio);
	}
}
