using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPermanantRemoval : MonoBehaviour {

    public GameObject removedObject;

    private bool pressed = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!pressed)
        {
            Destroy(removedObject);
            transform.localScale -= new Vector3(0, 0.25f, 0);
            transform.Translate(new Vector3(0, -0.25f, 0));
            pressed = true;
        }
    }
}
