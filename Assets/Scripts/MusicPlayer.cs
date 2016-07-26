using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad(gameObject); //gameObject is the game object attached to the script.
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
