using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class NewAlarms : MonoBehaviour
{
    [SerializeField] GameObject Alarm;
    [SerializeField] GameObject Canvas;
    [SerializeField] GameObject Canvas1;
    [SerializeField] GameObject Canvas2;

    public Button AddAlarm1;
    public Button AddAlarm2;
    public Button RemoveAlarm;
    public Button Done;
    //public GameObject Alarm;
    public Canvas canvas;

    private Canvas CanvasObject1;
    private Canvas CanvasObject2;

    bool add = true;
    int a;

    
    void Start()
    {
        

        CanvasObject1 = Canvas1.GetComponent<Canvas>();
        CanvasObject2 = Canvas2.GetComponent<Canvas>();
        Alarm = GameObject.Find("Alarm");

        Button btn = AddAlarm1.GetComponent<Button>();
        btn.onClick.AddListener(CreateAlarm);

        Button ntb = AddAlarm2.GetComponent<Button>();
        ntb.onClick.AddListener(CreateAlarm);

        Button tnb = RemoveAlarm.GetComponent<Button>();
        tnb.onClick.AddListener(OnClick);

        Button tbn = Done.GetComponent<Button>();
        tbn.onClick.AddListener(OnClick);

    }

    private void Update()
    {
        GameObject[] alarm = GameObject.FindGameObjectsWithTag("Alarm");
        int alarmCount = alarm.Length;
        a = alarmCount;
        

        if(add == true)
        {
            CanvasObject1.enabled = true;
            CanvasObject2.enabled = false;
        }
        else
        {
            CanvasObject1.enabled = false;
            CanvasObject2.enabled = true;
        }
        
    }

    public void OnClick()
    {
        add = !add;
    }

    public void CreateAlarm()
    {
        GameObject currentObject;
        int currentIndex = 0;
        GameObject alarm = Instantiate(Alarm, transform.position = new Vector3(0, -73, 0), Quaternion.identity);
        alarm.transform.SetParent(canvas.transform);
        GameObject[] alarms = new GameObject[20];
        currentObject = Instantiate(alarms[currentIndex]);
        currentIndex ++;

        //alarms[0] = alarm;
    }
    
}
