using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EditAlarm : MonoBehaviour
{
    public Button Switch;
    bool on = true;
    //private GameObject On;

    // Start is called before the first frame update
    void Start()
    {
        //On = GameObject.Find("On");
        
        Button btn = Switch.GetComponent<Button>();
        btn.onClick.AddListener(swap);
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        if (on == true)
        {
            //On.GetComponent<TextMeshPro>().text = "On";
            textmeshPro.SetText("On");
            //print("On");
        }
        else
        {
            //On.GetComponentInChildren<TextMeshPro>().text = "Off";
            //print("Off");
        }
    }

    public void swap()
    {
        on = !on;
    }
}
