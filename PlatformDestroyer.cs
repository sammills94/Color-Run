using UnityEngine;
using System.Collections;

public class PlatformDestroyer : MonoBehaviour {

	public GameObject platformDestroyerPoint;

	// Use this for initialization
	void Start () {
		platformDestroyerPoint = GameObject.Find ("PlatformDestroyerPoint");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < platformDestroyerPoint.transform.position.x) {
			//Destroy (gameObject);
			gameObject.SetActive(false);
		}
	}
}
