using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakSpot : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<Animator>().SetBool("isOnTop", true);
    }
}
