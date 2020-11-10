using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class canvasController : MonoBehaviour {

	public void OnPlayButtonClick() {

		SceneManager.LoadScene(1);
	}
	public void OnSelLvlButtonClick() {
		
	}
	public void OnExitButtonClick() {
		Application.Quit();
	}
    public void GoToMainMenu() {
        SceneManager.LoadScene(0);
    }
    public void RestartLevel() {
        SceneManager.LoadScene(1);
    }
}
