using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collission : MonoBehaviour
{
    public GameObject gameOver;

    GameOver gameOver_script;

    private void Awake()
    {
        gameOver_script = gameOver.GetComponent<GameOver>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "Pipe" || collision.gameObject.name == "Pipe1")
        {
            gameOver_script.hitPipe();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            gameOver_script.hitGround();
        }
    }
}
