using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Events;
using UnityEditor;
using UnityEngine.Events;
using UnityEngine.UI;
//scrapping this script to use Settings1.cs

public class Settings : MonoBehaviour
{
    /* Will's Edit: arraySettings is to snag variables and methods from ExerciseArray1.cs
     * i.e.
     * exampleBool = arraySettings.exerciseCalisthenicsSetting;
     * Then next 2 settings buttons are declared.
     */ 
    public ExerciseArray1 arraySettings;
    public Button CalBtn;
    public Button dumBtn;
    // Start is called before the first frame update
    void Start()
    {
        //Will's Edit: assigning buttons aswell as assigning arraySettings to ExerciseArray1.cs;
        arraySettings = gameObject.GetComponent<ExerciseArray1>();
        CalBtn = gameObject.GetComponent<Button>();
        dumBtn = gameObject.GetComponent<Button>();
        //Will's Edit: giving the buttons a listener, passes through name of Button its attached to. 
        CalBtn.onClick.AddListener(delegate{ Toggle(CalBtn); });
        dumBtn.onClick.AddListener(delegate{ Toggle(dumBtn); });
    }

    public void Toggle(Button btnPressed)
    {
        /*Will's Edit: function to toggle bool values on button click;
        btnPressed parameter passes through name of button pressed so we know which bool value to edit;
        with this code its repetitive so i can probs turn it into a method and make it far simpler;
         */
        if (btnPressed = CalBtn)
        {
            if(arraySettings.exerciseCalisthenicsSetting == true)
            {
                arraySettings.exerciseCalisthenicsSetting = false;
            }else
            {
                arraySettings.exerciseCalisthenicsSetting = true;
            }
        }else if(btnPressed = dumBtn)
        {
            if(arraySettings.exerciseDumbellsSetting == true)
            {
                arraySettings.exerciseDumbellsSetting = false;
            }else
            {
                arraySettings.exerciseDumbellsSetting = true;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
