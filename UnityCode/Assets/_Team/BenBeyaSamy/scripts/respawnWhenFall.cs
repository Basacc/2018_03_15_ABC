using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnWhenFall : MonoBehaviour {

    public int limitY = -10;
    public Transform respawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RespawnWhenFall();
	}

    public void RespawnWhenFall()
    {
        if(gameObject.transform.position.y <= limitY)
        {
            gameObject.transform.position = respawn.position;
        }
    }
}
