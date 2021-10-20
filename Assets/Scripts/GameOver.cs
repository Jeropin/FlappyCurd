using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Use this script to do all the stuff you want to do when you gameover. (Score counter disabled, player gets disabled, etc.)

/* GameObjects I want to Take over
 * -Ground
 *  - Disable the ground Script
 * -ScoreKeeper
 *  -Disable the Score Script
 * -Players
 *  -Disable the player
 *   -If it hit ground we do the spin thing
 *   -Hits the pipe we just make it fall
 */
public class GameOver : MonoBehaviour
{
    public GameObject flappy;
    public GameObject ground;
    public GameObject scoreKeeper;
    public GameObject gameOverUI;
    bool allowRestart = false;
    Score score;

    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            restartGame();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            quitGame();
        }
    }

    private void Awake()
    {
        scoreKeeper.GetComponent<Score>().enabled = false;
    }

    public void hitPipe()
    {
        flappy.GetComponent<FlappyInput>().enabled = false;
        ground.GetComponent<BoxCollider2D>().enabled = false;
        gameOver();
    }

    public void hitGround()
    {
        flappy.GetComponent<FlappyInput>().enabled = false;
        flappy.GetComponent<Rigidbody2D>().velocity = Vector2.up * 22;
        gameOver();
    }
    public void gameOver()
    {
        allowRestart = true;
        scoreKeeper.SetActive(false);
        gameOverUI.SetActive(true);
        flappy.GetComponent<SpriteRenderer>().color = Color.red;
        flappy.GetComponent<Spin>().enabled = true;
        StartCoroutine(launch());

    }

    public void restartGame()
    {
        if (allowRestart)
        {
            SceneManager.LoadScene("Flap");
        }
    }

    public void quitGame()
    {
        Debug.Log("I quit");
        Application.Quit();
    }

    IEnumerator launch()
    {
        yield return new WaitForSeconds(0.8f);

        flappy.GetComponent<Rigidbody2D>().velocity = Vector2.right * 50;
    }
}
