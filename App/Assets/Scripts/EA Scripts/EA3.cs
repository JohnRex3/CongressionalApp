using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EA3 : MonoBehaviour
{
    public TMP_Text words;

    public Button Switch;
    bool on = true;



    // Start is called before the first frame update
    void Start()
    {
        //add code to add a playerprefs state to keep button on right script
        //on = PlayerPrefs.GetInt("BtnState");
        PlayerPrefs.GetString("BtnState3");
        //Button btn = Switch.GetComponent<Button>();
        //btn.onClick.AddListener(swap);
        if (PlayerPrefs.GetString("BtnState3") == "on")
        {
            on = true;
        }
        else if (PlayerPrefs.GetString("BtnState3") == "off")
        {
            on = false;


        }
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        SwitchCol();
    }
    void SwitchCol()
    {
        var mybutton = Switch;
        if (on == true)
        {
            Color gr = new Color(0f, 1f, 0f, 1f);
            words.text = "On";
            ColorBlock col = Switch.colors;
            col.normalColor = gr;
            col.highlightedColor = gr;
            col.pressedColor = gr;
            col.selectedColor = gr;
            Switch.colors = col;
            PlayerPrefs.SetString("BtnState3", "on");
        }
        else if (on == false)
        {
            Color gr = new Color(1f, 0f, 0f, 1f);
            words.text = "Off";
            ColorBlock col = Switch.colors;
            col.normalColor = gr;
            col.highlightedColor = gr;
            col.pressedColor = gr;
            col.selectedColor = gr;
            Switch.colors = col;
            PlayerPrefs.SetString("BtnState3", "off");

        }
        PlayerPrefs.Save();
    }
    public void swap()
    {
        on = !on;

    }
}