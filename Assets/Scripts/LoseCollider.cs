using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {		
	/**They work very much like start and update.**/
	/**on collision - void OnCollisionEnter2D(Collision2D collision)**/
	/**on trigger - void OnTriggerEnter2D(Collider2D collider)**/

	//Expose the LevelManager
	//Connect it via Unity by dragging and dropping.
	//Adding it here will create a new field in Unity's script.
	private LevelManager levelManager;

	void OnTriggerEnter2D(Collider2D collider) {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		levelManager.LoadLevel ("Lose");
	}

	void OnCollisionEnter2D(Collision2D collision) {
		print("Collision");
	}
}
