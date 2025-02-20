using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDestroyer : MonoBehaviour
{
    void OnTriggerEnter(Collide other) 
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
