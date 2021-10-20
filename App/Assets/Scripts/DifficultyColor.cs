using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyColor : MonoBehaviour
{
    //reference SetDifficulty script?


    // Start is called before the first frame update
    void Start()
    {
        //Initializing a unique shade of yellow for the middle color, because I feel that the default yellow shade doesn't fit well.
        Color midYellow = new Color(0.988f, 0.918f, 0.063f);

        //Reference SetDifficulty properties? such as "int diff", "Slider difficulty" (wouldn't let me do this one when I tried), and difficulty.value?

    }

    // Update is called once per frame
    void Update()
    {
        //if (diff == 1), then the color of the knob = Color.white

        //if (diff == 2), then the color of the knob = Color.midYellow

        //if (diff == 3), then the color of the knob = Color.red



    }
}
