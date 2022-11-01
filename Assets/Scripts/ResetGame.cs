using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPinball() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        KeepScore.score = 0;
    }

    public void GameOver()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        KeepScore.score = 0;
    }
}
