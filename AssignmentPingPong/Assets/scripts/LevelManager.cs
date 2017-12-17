using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel (string levelname)
    {
        Debug.Log("Level1: " + levelname);
        SceneManager.LoadScene(levelname);
    }

public void QuitGame()
{
    UnityEditor.EditorApplication.isPlaying = false; // takes you out of the game
}

public void LoadNextLevel()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //load next scene
}

}