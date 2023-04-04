
//Code referenced from tutorial https://www.youtube.com/watch?v=wz7359nVGPg
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Notifications : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI notificationText;
    [SerializeField] private float fadeTime;

    // Start is called before the first frame update
    private void Start()
    {
        NotificationManager.Instance.setNewNotification("Pop as many balloons as you can!");

    }

    private void Update()
    {

        if (Time.time > 125f)
        {
            NotificationManager.Instance.setNewNotification("Your doing great, keep popping!");
            Destroy(this);

        }

    }
    
}