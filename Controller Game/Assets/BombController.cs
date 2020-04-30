using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public GameObject PlayerOBJ;
    // Start is called before the first frame update
    void Start()
    {
        PlayerOBJ = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            PlayerOBJ.GetComponent<PlayerController>().Health -= 1;
            GetComponentInParent<SpawnableController>().ChanceToGenerate = 3;
        }
    }
}
