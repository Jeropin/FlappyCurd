using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public GameObject scoreKeeper;
    public Text scoreText;
    Score scoreScript;

    void Start()
    {
        scoreScript = scoreKeeper.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreScript.score.ToString();
    }
}
