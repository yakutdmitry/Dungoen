using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScriptButtons : MonoBehaviour
{
    public ButtonsCript button1;
    public ButtonsCript button2;
    public ButtonsCript button3;
    
    // Start is called before the first frame update
    private void Update()
    {
        if(button1.pressed && button2.pressed && button3.pressed)
        {
            Destroy(gameObject);
        }
    }
}
