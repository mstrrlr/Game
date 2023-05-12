using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void GameStart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }
}
