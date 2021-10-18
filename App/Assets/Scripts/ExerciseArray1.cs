using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExerciseArray1 : MonoBehaviour
{
    public Button ExerciseGen;

    // Will's Edit: made an array for calisthenic exercises.
    public string[] exercisesCalisthenics = new string[] { "Pushups", "Squats", "Lunges", "Planks", "Stair Steps", "Burpees", "Wall Sits", "Situps/ Crunches", "Bicycle Kicks" };
    public string[] exercisesDumbells = new string[] { "Bicep Curls", "Hammer Curls", "Shrugs", "Lawnmowers", "Arnold/ Chest Presses", "Lateral Presses", "Shoulder Presses" };
    public string[] exercisesStretches = new string[] { "Calf Stretches", "Standing Hamstring Stretch", "Tricep Stretch", "Butterfly Stretch", "Knee to Chest stretch", "Quad Stretch" };
    string[] exerciseCalisthenicsStretches = new string[] { "Pushups", "Squats", "Lunges", "Planks", "Stair Steps", "Burpees", "Wall Sits", "Situps/ Crunches", "Bicycle Kicks", "Calf Stretches", "Standing Hamstring Stretch", "Tricep Stretch", "Butterfly Stretch", "Knee to Chest stretch", "Quad Stretch" };
    string[] exerciseCalisthenicsDumbells = new string[] { "Pushups", "Squats", "Lunges", "Planks", "Stair Steps", "Burpees", "Wall Sits", "Situps/ Crunches", "Bicycle Kicks", "Bicep Curls", "Hammer Curls", "Shrugs", "Lawnmowers", "Arnold/ Chest Presses", "Lateral Presses", "Shoulder Presses" };
    string[] exerciseDumbellStretches = new string[] { "Bicep Curls", "Hammer Curls", "Shrugs", "Lawnmowers", "Arnold/ Chest Presses", "Lateral Presses", "Shoulder Presses", "Calf Stretches", "Standing Hamstring Stretch", "Tricep Stretch", "Butterfly Stretch", "Knee to Chest stretch", "Quad Stretch" };
    string[] exerciseAll = new string[] { "Calf Stretches", "Standing Hamstring Stretch", "Tricep Stretch", "Butterfly Stretch", "Knee to Chest stretch", "Quad Stretch", "Bicep Curls", "Hammer Curls", "Shrugs", "Lawnmowers", "Arnold/ Chest Presses", "Lateral Presses", "Shoulder Presses", "Pushups", "Squats", "Lunges", "Planks", "Stair Steps", "Burpees", "Wall Sits", "Situps/ Crunches", "Bicycle Kicks" };
    public Text ExerciseText;
    public bool exerciseCalisthenicsSetting; //Wills's Edit: Probably need a Setting script but these bools are here for a placeholder so i can write conditionals.
    public bool exerciseDumbellsSetting;
    public string Etext;
    public string CBool;
    public string DBool;
    public string SBool;
    

    //public SetDifficulty MyScript;
    public static int a;
    // Start is called before the first frame update
    void Start()
    {
        CBool = PlayerPrefs.GetString("CBool");
        DBool = PlayerPrefs.GetString("DBool");
        SBool = PlayerPrefs.GetString("SBool");
        
    }
    public void OnClick()
    {
        //Seth's Edit: adding imput from difficulty slider
        //var MyScript = GameObject.Find("DifficultySlider").GetComponent<SetDifficulty>();
        int diff = PlayerPrefs.GetInt("Diff");

        //MyScript.diff == 1 || 

        if (diff == 1)
        {
            a = UnityEngine.Random.Range(10, 25);
        }
        else if (diff == 2)
        {
            a = UnityEngine.Random.Range(20, 50);
        }
        else if (diff == 3)
        {
            a = UnityEngine.Random.Range(40, 100);
        }

        //Will's Edit: generating random exercise
        //Will's Edit: Conditional statement that will work with settings to check which excercise list will be selected.
        if (PlayerPrefs.GetString("CBool") == "true" && PlayerPrefs.GetString("DBool") == "false" && SBool == "false")//exerciseCalisthenicsSetting == true && exerciseDumbellsSetting == false
        {
            Etext = exercisesCalisthenics[UnityEngine.Random.Range(0, exercisesCalisthenics.Length)];
     ;
        }
        else if (PlayerPrefs.GetString("CBool") == "false" && PlayerPrefs.GetString("DBool") == "true" && SBool == "false")//exerciseCalisthenicsSetting == false && exerciseDumbellsSetting == true)
        {
            Etext = exercisesDumbells[UnityEngine.Random.Range(0, exercisesDumbells.Length)];
        }
        else if (CBool == "false" && DBool == "false" && SBool == "true")
        {
            Etext = exercisesStretches[UnityEngine.Random.Range(0, exercisesStretches.Length)];
        }
        else if (PlayerPrefs.GetString("CBool") == "true" && PlayerPrefs.GetString("DBool") == "true" && SBool == "false")   // exerciseCalisthenicsSetting == true && exerciseDumbellsSetting == true)
        {
            //Will's Edit: Adds 2 arrays together, makes it so that if the 1st or 2nd arrays change that this 3rd array is not baked in.

            Etext = exerciseCalisthenicsDumbells[UnityEngine.Random.Range(0, exerciseCalisthenicsDumbells.Length)];
        }
        else if(CBool == "true" && DBool == "false" && SBool == "true")
        {

            Etext = exerciseCalisthenicsStretches[UnityEngine.Random.Range(0, exerciseCalisthenicsStretches.Length)];
        }
        else if(CBool == "false" && DBool == "true" && SBool == "true")
        {
   
            Etext = exerciseDumbellStretches[UnityEngine.Random.Range(0, exerciseDumbellStretches.Length)];
        }
        else if(CBool == "true" && DBool == "true" && SBool == "true")
        {
            Etext = exerciseAll[UnityEngine.Random.Range(0, exerciseAll.Length)];
        }
        /*/aelse if (CBool == "true" && DBool == "true" && SBool == "true")
        {
            exerciseCalisthenicsDumbells = new string[exercisesCalisthenics.Length + exercisesStretches.Length + exercisesDumbells.Length];
            Array.Copy(exercisesCalisthenics, exerciseCalisthenicsDumbells, exercisesCalisthenics.Length);
            Array.Copy(exercisesStretches, 0, exerciseCalisthenicsDumbells, exercisesCalisthenics.Length, exercisesStretches.Length);
            Etext = exerciseCalisthenicsDumbells[UnityEngine.Random.Range(0, exerciseCalisthenicsDumbells.Length)];
        }
        /*/
        else if (PlayerPrefs.GetString("CBool") == "false" && PlayerPrefs.GetString("DBool") == "false" && SBool == "false")
        {
            Etext = "Go to Settings to select Exercises";
        }
        //int Amount = UnityEngine.Random.Range(10, 35);
        //amount = Amount.ToString;

            ExerciseText.text = a + " " + Etext;
        PlayerPrefs.Save();
    }
    public string Notif()
    {
        

        

        string Etext = exercisesCalisthenics[UnityEngine.Random.Range(0, exercisesCalisthenics.Length)];
        ExerciseText.text = Etext;
        return Etext;
        //Debug.Log(a);
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