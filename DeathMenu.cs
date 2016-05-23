using UnityEngine;
using System.Collections;

public class DeathMenu : MonoBehaviour {

	public string mainMenuLevel;

public void RestartGame() {
		FindObjectOfType<GameManager> ().Reset ();
	}

public void MainMenu() {
		Application.LoadLevel (mainMenuLevel);
	}

}
