using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings1 : MonoBehaviour
{
    //will's edit: trying to use a static variable not set to an instance of an object. this should hopefully make it a bit easier instead of dont destroyonload();
    public Button CBtn;
    public Button DBtn;
    public GameObject btnPressed;
    public string CBool;
    public string DBool;
    // Start is called before the first frame update
    void Start()
    {
        //will's edit: praying this code should work.
        PlayerPrefs.GetString("CBool");
        PlayerPrefs.GetString("DBool");
        CBool = PlayerPrefs.GetString("CBool");
        DBool = PlayerPrefs.GetString("DBool");
        //will's edit: merge error fix

        CBtn = gameObject.GetComponent<Button>();
        DBtn = gameObject.GetComponent<Button>();
        CBtn.onClick.AddListener(delegate { Toggle(CBtn); });
        DBtn.onClick.AddListener(delegate { Toggle(DBtn); });
    }

    void Toggle(Button btnDown)
    {
        if (btnDown == CBtn)
        {
            if (CBool == "false")
            {
                PlayerPrefs.SetString("CBool", "true");
                Debug.Log("Cbool == true");
                // set variable to these

            }
            else if (CBool == "true")
            {
                PlayerPrefs.SetString("CBool", "false");
                Debug.Log("Cbool == false");
            }

        }
        else if (btnDown == DBtn)
        {
            if (DBool == "false")
            {
                PlayerPrefs.SetString("DBool", "true");
            }
            else if (DBool == "true")
            {
                PlayerPrefs.SetString("DBool", "false");
            }
        }
        PlayerPrefs.Save();


    }
}
