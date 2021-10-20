using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject pipe;
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObject", 0.0f, 3.0f);
    }

    void spawnObject()
    {
        float rand = Random.Range(-6.5f, 2.0f);
        GameObject createName1 = Instantiate(pipe, new Vector2(25, rand), Quaternion.identity);
        createName1.name = "Pipe";

        if (rand <= 1.5)
        {
            GameObject createName2 = Instantiate(pipe, new Vector2(25, rand + 6f), Quaternion.Euler(180f, 0f, 0f));
            createName2.name = "Pipe1";
        }
    }

}
