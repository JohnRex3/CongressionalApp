using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
<<<<<<< HEAD
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Saved");
        DontDestroyOnLoad(this.gameObject);
    }
=======
    public GameObject Info;
>>>>>>> d1662680488693303440b96db0e8f95eebda517f
    public void LoadScene(string sceneName)
    {
        //will's edit; hopefully this works
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        DontDestroyOnLoad(Info);
        SceneManager.LoadScene(sceneName);
    }
}
