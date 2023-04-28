using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static int day = 1;
    public static int energy = 100;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void NextDay(/**weather*/)
    {
        day++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
