using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Saved");
        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadScene(string sceneName)
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneName);
    }
}
