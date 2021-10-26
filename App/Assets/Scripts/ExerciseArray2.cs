using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExerciseArray2 : MonoBehaviour
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
    public string Etext;
    public string CBool;
    public string DBool;
    public string SBool;


    //public SetDifficulty MyScript;
    public static int a;

    // Start is called before the first frame update
    void Start()
    {

    }
    int Difficulty()
    {
        //will's edit: this script assures only difficulty numbers can be evens aswell as generates the number.
        a = 3;
        int diff = PlayerPrefs.GetInt("Diff");
        while (a % 2 != 0)
        {
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
            if(a % 2 == 0)
            {
                break;
            }
        }
        return a;
    }
    public void OnClick()
    {
        CBool = PlayerPrefs.GetString("CBool");
        DBool = PlayerPrefs.GetString("DBool");
        SBool = PlayerPrefs.GetString("SBool");
        //Seth's Edit: adding imput from difficulty slider
        //var MyScript = GameObject.Find("DifficultySlider").GetComponent<SetDifficulty>();
        int diff = PlayerPrefs.GetInt("Diff");

        //MyScript.diff == 1 || 
        Difficulty();
        //Will's Edit: generating random exercise
        //Will's Edit: Conditional statement that will work with settings to check which excercise list will be selected.
        if (CBool == "true" && DBool == "false" && SBool =="false" )//exerciseCalisthenicsSetting == true && exerciseDumbellsSetting == false
        {
            ExerciseText.text = a +" "+ exercisesCalisthenics[UnityEngine.Random.Range(0, exercisesCalisthenics.Length)] ;

        }
        else if (CBool == "false" && DBool == "true" && SBool == "false" )//exerciseCalisthenicsSetting == false && exerciseDumbellsSetting == true)
        {
            ExerciseText.text = a + " " + exercisesDumbells[UnityEngine.Random.Range(0, exercisesDumbells.Length)];

        }
        else if (CBool == "false" && DBool == "false"&& SBool == "true"  )
        {
            ExerciseText.text = a +" "+ exercisesStretches[UnityEngine.Random.Range(0, exercisesStretches.Length)];
        }
        else if (CBool == "true" && DBool == "true" && SBool == "false" )
        {
            ExerciseText.text = a + " " + exerciseCalisthenicsDumbells[UnityEngine.Random.Range(0, exerciseCalisthenicsDumbells.Length)];
        }
        else if (CBool == "true" && DBool == "false" && SBool == "true")
        {
            ExerciseText.text = a + " " + exerciseCalisthenicsStretches[UnityEngine.Random.Range(0, exerciseCalisthenicsStretches.Length)];
        }
        else if (CBool == "false" && DBool == "true" && SBool == "true")
        {
            ExerciseText.text = a + " " + exerciseDumbellStretches[UnityEngine.Random.Range(0, exerciseDumbellStretches.Length)];
        }
        else if (CBool == "true" && DBool == "true" && SBool == "true")
        {
            ExerciseText.text = a + " " + exerciseAll[UnityEngine.Random.Range(0, exerciseAll.Length)];
        }
        else
        {
            ExerciseText.text = "Select excercises in settings";
        }
        //int Amount = UnityEngine.Random.Range(10, 35);
        //amount = Amount.ToString;
        //Etext = ExerciseText.text;
        //ExerciseText.text = a + " " + Etext;
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