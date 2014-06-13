using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class rtgthtfrhtf : MonoBehaviour {

	public List<AudioClip> sounds = new List<AudioClip>();
	float timer = 2.0f;
	
	// Use this for initialization
	void Start () {
		//playSound ();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
	}
	
	void OnCollisionEnter(Collision collision)
	{	
		if(timer >= 3.00f) {
			playSound ();
			timer = 0.0f;
		}
	}
	
	private void playSound()
	{
		int r = Random.Range(0, sounds.Count);
		AudioClip sound = sounds[r];
		audio.PlayOneShot(sound);			
	}
}
