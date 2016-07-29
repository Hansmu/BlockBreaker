using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	private const int WORLD_UNITS = 16;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float mousePositionInBlocks = Input.mousePosition.x / Screen.width * WORLD_UNITS;
		print(mousePositionInBlocks);

		//This refers to the script that is connected with the object.
		Vector3 paddlePosition = new Vector3(
			Mathf.Clamp(mousePositionInBlocks, 0.5f, WORLD_UNITS - 0.5f), 
			this.transform.position.y, 
			this.transform.position.z
		);

		this.transform.position = paddlePosition;
	}
}
