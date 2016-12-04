using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    //public int brickCount;/

    public void LoadLevel(string name) {
        SceneManager.LoadSceneAsync(name);
	}

	public void QuitRequest() {
		Application.Quit ();
	}

    public void LoadNextLevel() {
        int indexSC = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(indexSC + 1);
    }

}
