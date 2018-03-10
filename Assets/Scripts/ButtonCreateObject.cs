using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCreateObject : MonoBehaviour {

    
    public GameObject hiddenObject;

    private bool pressed = false;

    void Start()
    {
        hiddenObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!pressed)
        {
            hiddenObject.SetActive(true);
        }
    }
}
