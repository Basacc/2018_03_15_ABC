using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLevelManager : MonoBehaviour {

    private static GameLevelManager _instance;

    public static GameLevelManager InstanceInScene
    {
        get { return _instance; }
        private set { _instance = value; }
    }

    public string[] Level { get { return _levelsName; } }

    public string _menuName;
    public string [] _levelsName;
    public int _index;

    
	void Awake () {
        InstanceInScene = this;
        DontDestroyOnLoad(this.gameObject);
	}

    public void LoadMenu() {
        LoadLevel(_menuName);
    }

    public void LoadNextLevel() {
        _index++;
        if (_index >= _levelsName.Length)
            _index = 0;
        LoadLevel(_levelsName[_index]);
    }

    public void LoadLevel(string name) {
            SceneManager.LoadScene(name);
    }
    
}
