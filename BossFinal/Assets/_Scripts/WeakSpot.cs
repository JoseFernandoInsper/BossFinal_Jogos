using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WeakSpot : MonoBehaviour
{
    public bool boss = false;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(boss){
            GetComponent<Animator>().SetBool("isOnTop", true);
        }
        
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        GetComponent<Animator>().SetBool("isOnTop", false);
    }
}
