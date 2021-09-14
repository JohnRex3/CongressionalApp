using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExerciseArray1 : MonoBehaviour
{
    public Button ExerciseGen;
    // Will's Edit: made an array for calisthenic exercises.
    public string[] exercisesCalisthenics = new string[] { "Pushups", "Squats", "Lunges", "Planks", "Stair Steps", "Burpees", "Wall Sits", "Crunches/ Situps", "Bicycle Kicks" };
    public Text ExerciseText;
    // Start is called before the first frame update
    void Start()
    {
        //Wills Edit: Declaring button existence and which button it is calling
        Button btn = ExerciseGen.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }
    void OnClick()
    {
        //Will's Edit: generating random exercise
        string Etext = exercisesCalisthenics[Random.Range(0, exercisesCalisthenics.Length)];
        ExerciseText.text = Etext;
        //Debug.Log("testing testing");
    }
     public string Notif()
    {
        string Etext = exercisesCalisthenics[Random.Range(0, exercisesCalisthenics.Length)];
        ExerciseText.text = Etext;
        return Etext;
    }
}

//string exercise1 = "Pushups";
//string exercise2 = "Squats";
//string exercise3 = "Lunges";
//string exercise4 = "Planks";
//string exercise5 = "Stair Steps";
//string exercise6 = "Burpees";
//string exercise7 = "Wall Sits";
//string exercise8 = "Crunches";
//string exercise9 = "Bicycle Kicks";