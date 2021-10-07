using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayExercise : MonoBehaviour
{
    public Text displayText;

    public void DisplayText()

    {
        displayText.text = "What ever you want to display";
    }
    // Start is called before the first frame update
    void Start()
    {
          displayText.text = "";
        Debug.Log("DisplayExercise.cs");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
