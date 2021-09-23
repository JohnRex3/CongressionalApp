using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EditAlarm : MonoBehaviour
{
    public TMPro.TMP_Text words;

    public Button Switch;
    bool on = true;

    

    // Start is called before the first frame update
    void Start()
    {
        

        //Button btn = Switch.GetComponent<Button>();
        //btn.onClick.AddListener(swap);
    }

    // Update is called once per frame
    void Update()
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
        }
        else
        {
            Color gr = new Color(1f, 0f, 0f, 1f);
            words.text = "Off";
            ColorBlock col = Switch.colors;
            col.normalColor = gr;
            col.highlightedColor = gr;
            col.pressedColor = gr;
            col.selectedColor = gr;
            Switch.colors = col;
        }
    }

    public void swap()
    {
        on = !on;
    }
}
