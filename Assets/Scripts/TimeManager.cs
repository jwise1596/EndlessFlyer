using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text timerText;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            timer += 1 * Time.deltaTime;
            timerText.text = ((int)timer).ToString();
        }
    }
}
