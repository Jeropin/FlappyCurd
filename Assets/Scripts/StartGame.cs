using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGameScene();
        }
    }

    void StartGameScene()
    {
        Debug.Log("I hit the right key");

        SceneManager.LoadScene("Flap");
    }
}
