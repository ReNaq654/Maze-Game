using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void StartGame()
    {
        //Loads Next Scene (first level) when start button is clicked (Uses Unity Build Settings)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }
}
