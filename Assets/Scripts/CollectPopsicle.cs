using UnityEngine;
using System.Collections;


/// <summary>
/// Collects popsicle. And tell spawner to create bears
/// </summary>
public class CollectPopsicle : MonoBehaviour {
	
	public GameObject Spawner;

	//JC - need this reference if we are NOT creating a static class/function
	SoundManager mySound;

	void Start (){
		//JC - use this if we are NOT creating a static class/function
		GameObject myNewSounds = GameObject.Find("AudioObject");
		mySound = myNewSounds.GetComponent<SoundManager>();
	}
	
	void DoCollect(Collider collider)
	{
		if(!enabled) return;
		
		if(collider.gameObject.tag == "Player")
		{
			//JC - use this call combined with the mySound object aboev and Start function if we arenot creating a static class/function
			mySound.PlayObjectSoundOnce(this.gameObject);

//			if (!GetComponent<AudioSource>().isPlaying){
//				GetComponent<AudioSource>().Play();
//			}

			//JC - if the function/method is marked as Static, we can simply call it directly
//			SoundManager.PlayObjectSoundOnce (this.gameObject);
			Destroy(gameObject,GetComponent<AudioSource>().clip.length);
			
			Spawner.GetComponent<Spawner>().BeginSpawning();
		}
	}
	
	void OnTriggerStay(Collider collider)
	{
		DoCollect (collider);
	}
	
	void OnTriggerEnter(Collider collider)
	{
		DoCollect (collider);
	}
}
