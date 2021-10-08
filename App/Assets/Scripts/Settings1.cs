using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings1 : MonoBehaviour
{
    //will's edit: trying to use a static variable not set to an instance of an object. this should hopefully make it a bit easier instead of dont destroyonload();
    public Button SetBtn;
    public static bool SettingsBoolCal;
    public static bool SettingsBoolDum;
    public GameObject btnPressed;
    public string btnPressedCal;
    public string btnPressedDum;
    // Start is called before the first frame update
    void Start()
    {
        //will's edit: merge error fix
       
        SetBtn = gameObject.GetComponent<Button>();
        btnPressed = SetBtn.gameObject;
        SetBtn.onClick.AddListener(delegate { Toggle(btnPressed); });
    }

    public void Toggle(GameObject btnPressedProp)
    {
        if(btnPressedProp.name == btnPressedCal )
        {
            SettingsBoolCal = !SettingsBoolCal;
        }else if (btnPressedProp.name == btnPressedCal)
        {
            SettingsBoolDum = !SettingsBoolDum;
        }
    }
}
