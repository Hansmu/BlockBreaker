using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private bool hasGameStarted = false;
	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>(); //Generic
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasGameStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;

			if (Input.GetMouseButton (0)) {
				GetComponent<AudioSource>().Play();
				hasGameStarted = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));

		if (hasGameStarted) {
			print(collision.gameObject.name);
			if (!collision.gameObject.name.ToLower().Contains("hit")) {
				GetComponent<AudioSource>().Play();
			}

			this.GetComponent<Rigidbody2D>().velocity += tweak;
		}
	}
}
