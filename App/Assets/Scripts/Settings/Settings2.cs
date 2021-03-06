using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Settings2 : MonoBehaviour
{
    public Button SetBtn;
    public string CBool;
    public string DBool;
    public string SBool;
    // Start is called before the first frame update
    void Start()
    {
        SetBtn = gameObject.GetComponent<Button>();
        SetBtn.onClick.AddListener(delegate { Toggle(EventSystem.current.currentSelectedGameObject.name); });
        //PlayerPrefs.SetString("CBool", "false");
        //PlayerPrefs.SetString("DBool", "false");
        //PlayerPrefs.SetString("SBool", "false");
        CBool = PlayerPrefs.GetString("CBool");
        DBool = PlayerPrefs.GetString("DBool");
        SBool = PlayerPrefs.GetString("SBool");

    }

    void Toggle(string btnDown)
    {
        if (btnDown == "Cal Button")
        {
            if (CBool == "true")
            {
                PlayerPrefs.SetString("CBool", "false");

                // set variable to these

            }
            else if (CBool == "false")
            {
                PlayerPrefs.SetString("CBool", "true");

            }

        }
        else if (btnDown == "Dum Button")
        {

            if (DBool == "true")
            {
                PlayerPrefs.SetString("DBool", "false");

            }
            else if (DBool == "false")
            {
                PlayerPrefs.SetString("DBool", "true");

            }
        }
        else if (btnDown == "Str Button")
        {
            if (SBool == "true")
            {
                PlayerPrefs.SetString("SBool", "false");
            }
            else if (SBool == "false")
            {
                PlayerPrefs.SetString("SBool", "true");
            }
        }
        PlayerPrefs.Save();


    }
}
