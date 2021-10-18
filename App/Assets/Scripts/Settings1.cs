using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings1 : MonoBehaviour
{
    //will's edit: trying to use a static variable not set to an instance of an object. this should hopefully make it a bit easier instead of dont destroyonload();
    public Button CBtn;
    public Button DBtn;
    public Button SBtn;
    public string CBool;
    public string DBool;
    public string SBool;
    // Start is called before the first frame update
    void Start()
    {
        //will's edit: praying this code should work.
        PlayerPrefs.GetString("CBool");
        PlayerPrefs.GetString("DBool");
        PlayerPrefs.GetString("SBool");
        CBool = PlayerPrefs.GetString("CBool");
        DBool = PlayerPrefs.GetString("DBool");
        SBool = PlayerPrefs.GetString("SBool");
            //will's edit: merge error fix

        CBtn = gameObject.GetComponent<Button>();
        DBtn = gameObject.GetComponent<Button>();
        SBtn = gameObject.GetComponent<Button>();
        CBtn.onClick.AddListener(delegate { Toggle(CBtn); });
        DBtn.onClick.AddListener(delegate { Toggle(DBtn); });
        SBtn.onClick.AddListener(delegate { Toggle(SBtn); });
    }

    void Toggle(Button btnDown)
    {
        if (btnDown == CBtn)
        {
            if (CBool == "true")
            {
                PlayerPrefs.SetString("CBool", "false");
                Debug.Log("should be able to hear this");
                // set variable to these

            }
            else if (CBool == "false")
            {
                PlayerPrefs.SetString("CBool", "true");
                Debug.Log("Hopefully");
            }

        }
        else if (btnDown == DBtn)
        {
            Debug.Log("btnDown not working?");
            if (DBool == "true")
            {
                PlayerPrefs.SetString("DBool", "false");
                Debug.Log("Am i being heard?");
            }
            else if (DBool == "false")
            {
                PlayerPrefs.SetString("DBool", "true");
                Debug.Log("Or not");
            }
        }
        else if (btnDown == SBtn)
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
