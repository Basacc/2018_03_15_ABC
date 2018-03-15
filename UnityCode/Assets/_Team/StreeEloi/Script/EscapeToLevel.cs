using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeToLevel : MonoBehaviour {

    public string _menuSceneName;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene(_menuSceneName);
        }
	}
}
