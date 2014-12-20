using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (0.0F, 0.1F, 0.0F);
		if (Input.GetButtonUp ("Jump")) {
			Debug.Log("Type space button");
				}

		float x = Input.GetAxis ("Horizontal");
		float y = Input.GetAxis ("Vertical");

		transform.Translate (x * 0.2F, 0.0F, 0.0F);
		transform.Translate (0.0F, 0.0F, y*0.2F);
		//transform.position = transform.position + new Vector3 (0.0F, 0.0F, 0.1F);
		//transform.position += new Vector3 (0.0F, 0.0F, 0.1F);
	}

	void OnCollisionEnter(Collision obj){
		if (obj.gameObject.name == "rightWall") {
			Debug.Log("HIT to RightWall");
				}

	}
}
