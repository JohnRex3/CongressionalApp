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
    // Start is called before the first frame update
    void Start()
    {
        //will's edit: praying this code should work.
        PlayerPrefs.SetString("CBool", "true");
        PlayerPrefs.SetString("DBool", "true");
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
            if (PlayerPrefs.GetString("CBool") == "false")
            {
                PlayerPrefs.SetString("CBool", "true");
            }
            else if (PlayerPrefs.GetString("CBool") == "true")
            {
                PlayerPrefs.SetString("CBool", "true");
            }
        }
        else if (btnDown == DBtn)
        {
            if (PlayerPrefs.GetString("DBool") == "false")
            {
                PlayerPrefs.SetString("DBool", "true");
            }
            else if (PlayerPrefs.GetString("DBool") == "true")
            {
                PlayerPrefs.SetString("DBool", "true");
            }
        }
        PlayerPrefs.Save();


    }
}
