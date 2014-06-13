using UnityEngine;
using System.Collections;

public class daySystem : MonoBehaviour {
	
	public float minutes = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		minutes += Time.deltaTime * 180;
		transform.RotateAround(Vector3.forward, Time.deltaTime);
		if(minutes >= 360)
		{
			minutes = 0.0f;	
		}
		float intensity = minutes / 360;
		//light.intensity = intensity;
	}
}
