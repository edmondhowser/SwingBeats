﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RescueMe : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.Get(OVRInput.Button.One))
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            // SceneManager.LoadScene("Demo");
        }
	}
}
