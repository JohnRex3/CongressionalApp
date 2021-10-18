using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EditAlarmExperimantal : MonoBehaviour
{
    public TMP_Text words;

    public Button CBtn;
    public Button DBtn;
    public Button SBtn;
    bool on = true;




    // Start is called before the first frame update
    void Start()
    {
        CBtn = gameObject.GetComponent<Button>();
        DBtn = gameObject.GetComponent<Button>();
        SBtn = gameObject.GetComponent<Button>();
        CBtn.onClick.AddListener(delegate { SwitchCol(CBtn); });
        DBtn.onClick.AddListener(delegate { SwitchCol(DBtn); });
        SBtn.onClick.AddListener(delegate { SwitchCol(DBtn); });
        //add code to add a playerprefs state to keep button on right script
        //on = PlayerPrefs.GetInt("BtnState");
        PlayerPrefs.GetString("BtnStateC");
        PlayerPrefs.GetString("BtnStateD");
        PlayerPrefs.GetString("BtnStateS");
        //Button btn = Switch.GetComponent<Button>();
        //btn.onClick.AddListener(swap);
        stateChecker("BtnStateC");
        stateChecker("BtnStateD");
        stateChecker("BtnStateS");

    }

    // Update is called once per frame
    void Update()
    {
        SwitchCol(CBtn);
        SwitchCol(DBtn);
        SwitchCol(SBtn);
    }
    void stateChecker(string btnState)
    {
        if (PlayerPrefs.GetString(btnState) == "on")
        {
            on = true;
            Debug.Log("lets see if this works");
        }
        else if (PlayerPrefs.GetString(btnState) == "off")
        {
            on = false;
            Debug.Log("Lets hope this one works");

        }
    }
    void SwitchCol(Button BtnPassThrough)
    {
        if (on == true && BtnPassThrough == CBtn)
        {
            btnOn(BtnPassThrough, "BtnStateC");
        }
        else if (on == true && BtnPassThrough == DBtn)
        {
            btnOn(BtnPassThrough, "BtnStateD");
        }
        else if (on == true && BtnPassThrough == SBtn)
        {
            btnOn(BtnPassThrough, "BtnStateS");
        }
        else if (on == false && BtnPassThrough == CBtn)
        {
            btnOff(BtnPassThrough, "BtnStateC");
        }
        else if (on == false && BtnPassThrough == DBtn)
        {
            btnOff(BtnPassThrough, "BtnStateD");
        }
        else if (on == false && BtnPassThrough == SBtn)
        {
            btnOff(BtnPassThrough, "BtnStateS");
        }
        PlayerPrefs.Save();
    }
    public void btnOn(Button btnOnDwn, string BtnState)
    {
        Color gr = new Color(0f, 1f, 0f, 1f);
        words.text = "On";
        ColorBlock col = btnOnDwn.colors;
        col.normalColor = gr;
        col.highlightedColor = gr;
        col.pressedColor = gr;
        col.selectedColor = gr;
        btnOnDwn.colors = col;
        PlayerPrefs.SetString(BtnState, "on");

        PlayerPrefs.Save();
    }
    public void btnOff(Button btnOnOff, string BtnStateOff)
    {
        Color gr = new Color(1f, 0f, 0f, 1f);
        words.text = "Off";
        ColorBlock col = btnOnOff.colors;
        col.normalColor = gr;
        col.highlightedColor = gr;
        col.pressedColor = gr;
        col.selectedColor = gr;
        btnOnOff.colors = col;
        PlayerPrefs.SetString(BtnStateOff, "off");
        PlayerPrefs.Save();
    }
    public void swap()
    {
        on = !on;

    }
}
