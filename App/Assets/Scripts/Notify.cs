using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class Notify : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //Remove Notifications that have already been displayed 
        AndroidNotificationCenter.CancelAllDisplayedNotifications();

       //set up Android Notification channel to send messages 
        var c = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.High,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(c);

        //Johnathon's Edit: adding public strings for each type of exercise, to be called by notification.Text
        
            string exercise1 = "Pushups";
            string exercise2 = "Squats";
            string exercise3 = "Lunges";
            string exercise4 = "Planks";
            string exercise5 = "Stair Steps";
            string exercise6 = "Burpees";
            string exercise7 = "Wall Sits";
            string exercise8 = "Crunches";
            string exercise9 = "Bicycle Kicks";
        

        //Setup The Notification that is going to be sent
        var notification = new AndroidNotification();
        //Johnathon's Edit: Notification Title will say "Here's an exercise for you:"
        notification.Title = "Here's an exercise for you:";
        notification.Text = "Go for a short walk"; //WIP
        notification.FireTime = System.DateTime.Now.AddMinutes(5);
        
        //Send the Notification
        var id = AndroidNotificationCenter.SendNotification(notification, "channel_id");

        // if the script is run and the message is already schudeled, cancel it and re-schudule another message 
        if (AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Scheduled)
        {
            AndroidNotificationCenter.CancelAllNotifications();
            AndroidNotificationCenter.SendNotification(notification, "channel_id");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
