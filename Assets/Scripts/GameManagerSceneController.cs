using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void GoGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoMenu()
    {
        SceneManager.LoadScene("StarScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
