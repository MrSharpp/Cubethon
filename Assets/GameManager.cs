using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameEnded = false;
    public GameObject CompleteLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("Active");
        CompleteLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Invoke("Restart", 2f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

  
}
