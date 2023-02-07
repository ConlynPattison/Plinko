using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.GameObject());
    }
}
