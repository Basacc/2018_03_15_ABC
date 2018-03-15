using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerForButton : MonoBehaviour {

  
    public void LoadNextLevel() {
        GameLevelManager.InstanceInScene.LoadNextLevel();
    }

    public void LoadLevel(string name) {
        SceneManager.LoadScene(name);
    }
}
