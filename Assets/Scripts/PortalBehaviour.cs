using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalBehaviour : MonoBehaviour {

    public GameObject player;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Portal Collision!");
        if (collision.gameObject == player)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            Debug.Log("Player-portal collison!");
        }
    }


}
