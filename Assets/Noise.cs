using UnityEngine;
using System.Collections;

public class Noise : MonoBehaviour {
	
	public AudioClip sound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision){
		audio.PlayOneShot(sound);
	}
}
