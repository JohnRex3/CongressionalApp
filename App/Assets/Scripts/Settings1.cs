using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings1 : MonoBehaviour
{
    private ExerciseArray1 ArrayGetter;
    public Button CalBtn;

    // Start is called before the first frame update
    void Start()
    {
        CalBtn = gameObject.GetComponent<Button>();
        CalBtn.onClick.AddListener(delegate { Toggle(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Toggle()
    {

    }
}
