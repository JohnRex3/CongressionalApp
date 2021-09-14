using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewAlarms : MonoBehaviour
{
    [SerializeField] GameObject Alarm;
    [SerializeField] GameObject Canvas;

    public Button AddAlarm;
    //public GameObject Alarm;

    private Canvas CanvasObject1;
    private Canvas CanvasObject2;

    bool add = true;

    // Start is called before the first frame update
    void Start()
    {
        CanvasObject1 = GetComponent<Canvas>();
        CanvasObject2 = GetComponent<Canvas>();
        Alarm = GameObject.Find("Alarm");

        Button btn = AddAlarm.GetComponent<Button>();
        btn.onClick.AddListener(CreateAlarm);
        


    }

    private void Update()
    {
        GameObject[] alarm = GameObject.FindGameObjectsWithTag("Alarm");
        int alarmCount = alarm.Length;
        print(alarm.Length);

        if(add == true)
        {
            CanvasObject1.GetComponent<Canvas>().enabled = true;
            CanvasObject2.GetComponent<Canvas>().enabled = false;
        }
        else
        {
            CanvasObject1.GetComponent<Canvas>().enabled = false;
            CanvasObject2.GetComponent<Canvas>().enabled = true;
        }

        //if(Input.)
    }

    public void OnClick()
    {
        add = !add;
    }

    public void CreateAlarm()
    {
        GameObject alarm = Instantiate(Alarm, transform.position, Quaternion.identity);
        alarm.transform.SetParent(Canvas.transform);
        //alarm.transform.Vector3(0,y,0);
    }

    
}
