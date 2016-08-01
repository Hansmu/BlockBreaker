using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public Sprite[] hitSprites;
	public static int breakableCount = 0;
	public AudioClip crackSound;

	private LevelManager levelManager;
	private int timesHit;
	private bool isBreakable;

	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;

		if (isBreakable) {
			breakableCount++;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		AudioSource.PlayClipAtPoint(crackSound, transform.position);
		if (isBreakable) {
			HandleHits();
		}
	}

	void HandleHits() {
		int maxHits = hitSprites.Length + 1;
		timesHit++;
		if (timesHit >= maxHits) {
			breakableCount--;
			levelManager.BrickDestroyed();
			Destroy(gameObject); //This would be a brick and not a gameObject.
		} else {
			LoadSprites();
		}
	}
		
	void LoadSprites() {
		if (hitSprites [timesHit - 1]) {
			this.GetComponent<SpriteRenderer> ().sprite = hitSprites [timesHit - 1];
		} else {
			Debug.LogError("Brick sprite missing!");
		}
	}

	// TODO Remove this method once we can actually win.
	void SimulateWin() {
		levelManager.LoadNextLevel();

	}
}
