using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal");
		transform.Translate (x * 1.0F, 0.0F, 0.0F);
	}
}
