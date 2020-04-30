using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinish : MonoBehaviour
{
    public GameObject Player;
    public GameObject StartPosition;
    public GameObject[] SpawnableObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            Player.transform.position = StartPosition.transform.position;
            Player.GetComponent<PlayerController>().levelsComplete += 1;
            foreach (GameObject SpawnableObject in SpawnableObjects)
            {
                SpawnableObject.GetComponent<SpawnableController>().RandomizeLevel();
            }
        }        
    }
}
