using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour {

	// Use this for initialization
	public void RestartGame ()
    {
	    	
	}
	
	// Update is called once per frame
	public void Quit ()
    {
        Debug.Log("Quit!");
        Application.Quit();
	}
}
