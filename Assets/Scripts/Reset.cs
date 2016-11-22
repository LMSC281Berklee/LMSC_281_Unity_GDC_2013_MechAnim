using UnityEngine;
using System.Collections;

//using the scenemanager class
using UnityEngine.SceneManagement;


/// <summary>
/// Resets the game
/// </summary>
public class Reset : MonoBehaviour {
	void OnGUI() 
	{
		if (GUI.Button(new Rect(Screen.width-65, 0, 65, 20),"Reset"))
		{
			SceneManager.LoadScene ("Bearpocalypse");
		}
	}
}
