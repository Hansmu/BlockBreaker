using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {		
	/**They work very much like start and update.**/
	/**on collision - void OnCollisionEnter2D(Collision2D collision)**/
	/**on trigger - void OnTriggerEnter2D(Collider2D collider)**/

	//Expose the LevelManager
	//Connect it via Unity by dragging and dropping.
	//Adding it here will create a new field in Unity's script.
	public LevelManager levelManager;

	void OnTriggerEnter2D(Collider2D collider) {
		print("Trigger");
		levelManager.LoadLevel ("Win");
	}

	void OnCollisionEnter2D(Collision2D collision) {
		print("Collision");
	}
}
