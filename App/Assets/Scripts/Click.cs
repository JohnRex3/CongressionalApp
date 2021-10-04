using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    public GameObject Info;
    public void LoadScene(string sceneName)
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        DontDestroyOnLoad(Info);
        SceneManager.LoadScene(sceneName);
    }
}
