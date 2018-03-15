using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneCountdown : MonoBehaviour {

    public string _sceneNameToLoad= "DefaultScene";
    public float _loadNextSceneAfter = 5;

    public void Start()
    {
        Invoke("LoadNextScene", _loadNextSceneAfter);
    }
    public void LoadNextScene() {

            SceneManager.LoadSceneAsync(_sceneNameToLoad);
    }

    

}
