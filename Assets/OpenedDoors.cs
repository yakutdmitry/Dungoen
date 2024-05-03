using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenedDoors : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
    
}
