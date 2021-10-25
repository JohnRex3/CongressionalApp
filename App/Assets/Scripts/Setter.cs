using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteKey("CBool");
        //PlayerPrefs.DeleteKey("DBool");
        //PlayerPrefs.DeleteKey("SBool");
        if (PlayerPrefs.HasKey("CBool") == true)
        {
            PlayerPrefs.SetString("CBool", "false");
        }
        if (PlayerPrefs.HasKey("DBool") == true)
        {
            PlayerPrefs.SetString("DBool", "false");
        }
        if (PlayerPrefs.HasKey("SBool") == true)
        {
            PlayerPrefs.SetString("SBool", "false");
        }
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
