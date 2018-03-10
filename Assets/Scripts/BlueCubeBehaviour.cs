using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BlueCubeBehaviour : MonoBehaviour {

    public static int score = 0;

    public GameObject player;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject == player)
        {
            Debug.Log("Player-bluecube collision");
            //score++;
            Destroy(this.gameObject);
        }
    }
}
