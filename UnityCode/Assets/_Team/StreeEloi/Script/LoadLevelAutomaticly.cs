using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelAutomaticly : MonoBehaviour {
    public float _timeBetweenSwitch=20f;
    public void Awake()
    {
        StartCounting();
    }
   
    public void OnLevelWasLoaded(int level)
    {
        StartCounting();
    }

    public void StartCounting()
    {
        CancelInvoke();
        InvokeRepeating("GoToNextLevel", 0.1f, _timeBetweenSwitch);

    }

    public void GoToNextLevel()
    {

        if (IsSceneIsLevel(SceneManager.GetActiveScene().name))
            GameLevelManager.InstanceInScene.LoadNextLevel();
    }



    private bool IsSceneIsLevel(string name)
    {
        bool isSceneLevel = false;
        string[] levels = GameLevelManager.InstanceInScene.Level;
        for (int i = 0; i < levels.Length; i++)
        {
            if (name == levels[i])
            {
                isSceneLevel = true;
            }
        }
        return isSceneLevel;
    }

}
