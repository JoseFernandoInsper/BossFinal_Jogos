using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject platformPrefab;

    public int numberOfPlataforms = 100;

    public float levelWidth = 3f;

    public float minY = 7f;
    public float maxY = 10f;


    // Start is called before the first frame update
    void Start()
    {

        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlataforms; i++) {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
