using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{

    private void Awake()
    {
        //GameObject[] objs = GameObject.FindGameObjectsWithTag("Saved");
        //DontDestroyOnLoad(this.gameObject);
    }
<<<<<<< HEAD
    
    public void LoadScene(string sceneName)
    {
=======

    public void LoadScene(string sceneName)
    {

>>>>>>> 09cae79c4b1eb372a6b0730c53aa5bd46aef1ecf
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneName);
    }
}
