using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExerciseArray1 : MonoBehaviour
{
    // Will's Edit: made an array for calisthenic exercises.
    public string[] exercisesCalisthenics = new string[] { "Pushups", "Squats", "Lunges", "Planks", "Stair Steps", "Burpees", "Wall Sits", "Crunches/ Situps", "Bicycle Kicks" };
    Text ExerciseText;
    // Start is called before the first frame update
    void Start()
    {
        //Will's Edit: calling for text exercise text
        ExerciseText = GameObject.Find("ExerciseText").GetComponent<Text>();
        string Etext = exercisesCalisthenics[Random.Range(0, exercisesCalisthenics.Length)];
        ExerciseText.text = Etext;

    }


    // Update is called once per frame
    void Update()
    {

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