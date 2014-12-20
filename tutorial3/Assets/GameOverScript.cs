using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	public GUIStyle style;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.Label(new Rect(10.0F,10.0F, 200.0F,50.0F),@"Game Over", style);
		//GUI.Label(Rect(10.0F,10.0F,200.0F,50.0F), @"Game Over",style);
	}
}
