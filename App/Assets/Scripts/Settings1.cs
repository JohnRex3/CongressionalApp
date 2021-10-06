using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings1 : MonoBehaviour
{
    //will's edit: trying to use a static variable not set to an instance of an object. this should hopefully make it a bit easier instead of dont destroyonload();
    public Button SetBtn;
    public static bool SettingsBool; 
    // Start is called before the first frame update
    void Start()
    {
        //will's edit:
        SetBtn = gameObject.GetComponent<Button>();
        SetBtn.onClick.AddListener(delegate { Toggle(); });
    }

    public void Toggle()
    {

    }
}
