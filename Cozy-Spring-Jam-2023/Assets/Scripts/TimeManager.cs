using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static int day = 1;
    public static int energy = 100;
    public static int weather = 0;
    public static float weatherModifyerGrowth;
    public static float weatherModifyerDeath;
    public static int stage = 0;
    private int tmp = 0;
    public GameObject[] plantStages;
    public GameObject[] plotStages;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < plantStages.Length; i++)
        {
            plantStages[i].SetActive(false);
            plotStages[i].SetActive(false);
        }
    }

    public void NextDay(/**weather*/)
    {
        day++;
        //Debug.Log("NextDay called, weather is: " + weather.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (tmp < stage)
            {
                tmp = stage;
                plantStages[stage - 1].SetActive(true);
                plotStages[stage - 1].SetActive(true);
            }
    }
        
    
}
