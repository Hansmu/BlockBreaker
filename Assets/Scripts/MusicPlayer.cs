using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	//Create a static variable
	static MusicPlayer instance = null;

	//Move the code into the Awake block because otherwise there is a bug with the music being played more than once due to execution order.
	void Awake() {
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject); //gameObject is the game object attached to the script.
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
