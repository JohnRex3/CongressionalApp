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
        if (PlayerPrefs.HasKey("CBool") != true)
        {
            PlayerPrefs.SetString("CBool", "true");
        }
        if (PlayerPrefs.HasKey("DBool") != true)
        {
            PlayerPrefs.SetString("DBool", "true");
        }
        if (PlayerPrefs.HasKey("SBool") != true)
        {
            PlayerPrefs.SetString("SBool", "true");
        }
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
