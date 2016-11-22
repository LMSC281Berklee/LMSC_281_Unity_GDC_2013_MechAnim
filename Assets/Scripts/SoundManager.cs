using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//JC - if we want to call this function/method directly, without needing a reference, we could mark it as static
	//public static void PlayObjectSoundOnce (GameObject thisObject) {

	public void PlayObjectSoundOnce (GameObject thisObject) {

		if (!thisObject.GetComponent<AudioSource>().isPlaying){
			thisObject.GetComponent<AudioSource>().Play();
		}


	}
}
