using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField] private KeyScript _key;
    [SerializeField] private bool _haveKey;

    private void Update()
    {
        _haveKey = _key.collected;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player") && _key.collected)
        {
            Destroy(gameObject);
        }
    }
}
