using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExerciseArray1 : MonoBehaviour
{
    public Button ExerciseGen;

    // Will's Edit: made an array for calisthenic exercises.
    public string[] exercisesCalisthenics = new string[] { "Pushups", "Squats", "Lunges", "Planks", "Stair Steps", "Burpees", "Wall Sits", "Crunches/ Situps", "Bicycle Kicks" };
    public string[] exercisesDumbells = new string[] { "Bicep Curls", "Hammer Curls", "Shrugs", "Lawnmowers", "Arnold/ Chest Presses", "Lateral Presses", "Shoulder Presses"};
    string[] exerciseCalisthenicsDumbells;
    public Text ExerciseText;
    public bool exerciseCalisthenicsSetting; //Wills's Edit: Probably need a Setting script but these bools are here for a placeholder so i can write conditionals.
    public bool exerciseDumbellsSetting;
    string Etext;

    //public SetDifficulty MyScript;
    public static int a;
    // Start is called before the first frame update
    void Start()
    {
        //Will's Edit: Removed reduntant code.
        //Wills Edit: Declaring button existence and which button it is calling
        Button btn = ExerciseGen.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
        //Seth's Edit: adding imput from difficulty slider
        //MyScript = GameObject.Find("DifficultySlider").GetComponent<SetDifficulty>();
    }
    void OnClick()
    {
        //Will's Edit: generating random exercise
        //Will's Edit: Conditional statement that will work with settings to check which excercise list will be selected.
        if (exerciseCalisthenicsSetting == true && exerciseDumbellsSetting == false)
        {
             Etext = exercisesCalisthenics[UnityEngine.Random.Range(0, exercisesCalisthenics.Length)];
        }
        else if (exerciseCalisthenicsSetting == false && exerciseDumbellsSetting == true)
        {
             Etext = exercisesDumbells[UnityEngine.Random.Range(0, exercisesDumbells.Length)];
        }
        else if (exerciseCalisthenicsSetting == true && exerciseDumbellsSetting == true)
        {
            //Will's Edit: Adds 2 arrays together, makes it so that if the 1st or 2nd arrays change that this 3rd array is not baked in.
            exerciseCalisthenicsDumbells = new string[exercisesCalisthenics.Length + exercisesDumbells.Length]; 
            Array.Copy(exercisesCalisthenics, exerciseCalisthenicsDumbells, exercisesCalisthenics.Length);
            Array.Copy(exercisesDumbells, 0, exerciseCalisthenicsDumbells, exercisesCalisthenics.Length, exercisesDumbells.Length);
            //Debug.Log(exerciseCalisthenicsDumbells); // unusable code
            Etext = exerciseCalisthenicsDumbells[UnityEngine.Random.Range(0, exerciseCalisthenicsDumbells.Length)];
        }
        int Amount = UnityEngine.Random.Range(10, 35);
        //amount = Amount.ToString;
        ExerciseText.text = Etext;
        //Debug.Log("testing testing");
    }
    public string Notif()
    {
        //if (MyScript.diff == 1)
        //{
        //    var a = UnityEngine.Random.Range(10, 25);
        //}
        //else if (MyScript.diff == 2)
        //{
        //    var a = UnityEngine.Random.Range(20, 50);
        //}
        //else if (MyScript.diff == 3)
        //{
        //    var a = UnityEngine.Random.Range(40, 100);
        //}

        string Etext = exercisesCalisthenics[UnityEngine.Random.Range(0, exercisesCalisthenics.Length)];
        ExerciseText.text = Etext;
        return a + Etext;
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