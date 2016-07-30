using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int maxHits;
	public Sprite[] hitSprites;

	private LevelManager levelManager;
	private int timesHit;

	// Use this for initialization
	void Start () {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision){
		timesHit++;
		if (timesHit >= maxHits) {
			Destroy(gameObject); //This would be a brick and not a gameObject.
		} else {
			LoadSprites();
		}
	}
		
	void LoadSprites() {
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[timesHit - 1];
	}

	// TODO Remove this method once we can actually win.
	void SimulateWin() {
		levelManager.LoadNextLevel();

	}
}
