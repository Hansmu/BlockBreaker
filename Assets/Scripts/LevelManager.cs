using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	//Just using it to load a new level.
	public void LoadLevel(string name) {
		Application.LoadLevel(name);
	}

	public void QuitRequest() {
		Application.Quit();
	}
}
