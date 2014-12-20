using UnityEngine;
using System.Collections;

public class ballBoxScript : MonoBehaviour {
	public Transform ball;
	private int n=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetButtonUp ("Jump")) {
			Instantiate(ball,this.transform.position, this.transform.rotation); 
			n++;
				}
		if (n > 10) {
			Application.LoadLevel("GameOverScene");
				}
	}
}
