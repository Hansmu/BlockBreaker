using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;

	private const int WORLD_UNITS = 16;

	private Ball ball;

	void Start() {
		ball = GameObject.FindObjectOfType<Ball>();
	}

	void Update () {
		if (!autoPlay) {
			MoveWithMouse ();
		} else {
			AutoPlay();
		}
	}

	void MoveWithMouse() {
		float mousePositionInBlocks = Input.mousePosition.x / Screen.width * WORLD_UNITS;

		//This refers to the script that is connected with the object.
		Vector3 paddlePosition = new Vector3(
			Mathf.Clamp(mousePositionInBlocks, 0.5f, WORLD_UNITS - 0.5f), 
			this.transform.position.y, 
			this.transform.position.z
		);

		this.transform.position = paddlePosition;
	}

	void AutoPlay() {
		Vector3 paddlePosition = new Vector3(0.5f, this.transform.position.y, 0f);
		Vector3 ballPosition = ball.transform.position;
		paddlePosition.x = Mathf.Clamp(ballPosition.x, 0.5f, 15.5f);
		this.transform.position = paddlePosition;
	}
}
