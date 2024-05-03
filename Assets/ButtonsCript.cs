using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsCript : MonoBehaviour
{
    public bool pressed;
    

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player") && !pressed)
        {
            transform.Translate(0, -0.4f, 0);
            pressed = true;
        }
    }
}
