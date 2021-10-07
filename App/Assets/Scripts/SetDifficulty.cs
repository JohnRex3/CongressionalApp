using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetDifficulty : MonoBehaviour
{
    public int diff;
    public Slider difficulty;

    void Start()
    {
        //difficulty.value = PlayerPrefs.GetInt("MasterDifficulty");
       
    }

    public void Update()
    {
        //PlayerPrefs.GetInt("MasterDifficulty", sliderValue);
        diff = (int)difficulty.value;
        //Debug.Log("hi");

        if (diff == 1)
        {
            //Debug.Log("1");
        }
        else if(diff == 2)
        {
            //Debug.Log("2");
        }
        else if(diff == 3)
        {
            //Debug.Log("3");
        }

    }
}
