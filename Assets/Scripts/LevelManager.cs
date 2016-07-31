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

	public void LoadNextLevel() { //You have to consider the build settings with this, they have to be in the right order.
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void BrickDestroyed() {
		if (Brick.breakableCount <= 0) {
			LoadNextLevel();
		}
	}
}
