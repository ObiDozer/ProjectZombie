using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void MultiplayerPlay () 
	{
		SceneManager.LoadScene ("TEST");
	}

	public void QuitGame () 
	{
		Debug.Log ("QUIT");
		Application.Quit ();	
	}

}
