using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderColor : MonoBehaviour
{
    public Slider slider;

    public int diff;
    Color c1 = new Color(1, 0.92f, 0.016f, 1);
    Color c2 = new Color(1, 0, 0, 1);


    void Start()
    {
        int diff = PlayerPrefs.GetInt("Diff");
    }
    
    void Update()
    {
        //Debug.Log("update");
        if (diff == 2)
        {
            slider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = c1;
            Debug.Log("c1");
        }
        if (diff == 3)
        {
            slider.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = c2;
            Debug.Log("c2");
        }
    }

}
