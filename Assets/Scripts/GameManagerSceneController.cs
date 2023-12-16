using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerSceneController : MonoBehaviour
{
    public void GoGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void GoMenu()
    {
        SceneManager.LoadScene("StarScene");
    }
}
