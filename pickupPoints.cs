using UnityEngine;
using System.Collections;

public class pickupPoints : MonoBehaviour {
	public int scoreToGive;
	private ScoreManager theScoreManager;
	private AudioSource squareSound;

	// Use this for initialization
	void Start () {
		theScoreManager = FindObjectOfType<ScoreManager> ();
		squareSound = GameObject.Find ("Pickup_Coin").GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "Player") {
			theScoreManager.AddScore(scoreToGive);
			gameObject.SetActive(false);
			if(squareSound.isPlaying){
				squareSound.Stop ();
				squareSound.Play ();
			}
			else{
				squareSound.Play ();
			}
		}
	}
}
