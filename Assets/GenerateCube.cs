using UnityEngine;
using System.Collections;

public class GenerateCube : MonoBehaviour {
	
	public GameObject prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			GameObject a = (GameObject)Instantiate(prefab,transform.position,Quaternion.identity);
			a.rigidbody.AddForce(Vector3.forward*1000);
		}
	}
}
