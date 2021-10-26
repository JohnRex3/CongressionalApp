using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeSetter : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("CBool") == "true")
            {
            PlayerPrefs.SetString("CBool", "true");
            }
        if (PlayerPrefs.GetString("CBool") == "false")
        {
            PlayerPrefs.SetString("CBool", "false");
        }
        if (PlayerPrefs.GetString("DBool") == "true")
        {
            PlayerPrefs.SetString("DBool", "true");
        }
        if (PlayerPrefs.GetString("DBool") == "false")
        {
            PlayerPrefs.SetString("DBool", "false");
        }
        if (PlayerPrefs.GetString("SBool") == "true")
        {
            PlayerPrefs.SetString("SBool", "true");
        }
        if (PlayerPrefs.GetString("SBool") == "false")
        {
            PlayerPrefs.SetString("SBool", "false");
        }
        PlayerPrefs.Save();
    }
}
