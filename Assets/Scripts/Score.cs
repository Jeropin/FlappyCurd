using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score = 0;   

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Pipe")
        {
            score++;
        }
    }
}
