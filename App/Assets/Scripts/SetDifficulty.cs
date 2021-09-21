using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetDifficulty : MonoBehaviour
{
    public int diff = 1;
    public int num = 0;
    public Slider difficulty;

    void Start()
    {
        difficulty.value = PlayerPrefs.GetInt("MasterDifficulty", 1);
       
    }

    public void SetLevel(float sliderValue)
    {
        PlayerPrefs.SetFloat("MasterDifficulty", sliderValue);
        diff = (int)difficulty.value;

        if(diff == 1)
        {
            
        }
        else if(diff == 2)
        {

        }
        else if(diff == 3)
        {

        }

    }
}
