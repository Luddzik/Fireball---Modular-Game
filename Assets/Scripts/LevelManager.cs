using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name) {
		UnityEngine.SceneManagement.SceneManager.LoadScene (name);
	}

	public void Quit () {
		Application.Quit ();
	}
}
