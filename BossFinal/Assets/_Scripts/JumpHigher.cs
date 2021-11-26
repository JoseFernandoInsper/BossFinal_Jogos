using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpHigher : MonoBehaviour
{
    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gm.power = gm.power + 1;
        Debug.Log(gm.power);
        Destroy(gameObject);
    }
}
