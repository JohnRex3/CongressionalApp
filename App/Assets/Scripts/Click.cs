using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{

    public AudioSource audioData;

    private void Awake()
    {
        //audioData = GetComponent<AudioSource>();
        audioData.PlayDelayed(0);
        //GameObject[] objs = GameObject.FindGameObjectsWithTag("Saved");
        //DontDestroyOnLoad(this.gameObject);
    }
    public void LoadScene(string sceneName)
    {
        //float audioData = PlayerPrefs.GetFloat("MasterVolume");
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneName);
    }
}
