using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onFinish : MonoBehaviour {

    public Transform respawnOnFinish;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            col.transform.position = respawnOnFinish.position;
        }
    }
}
