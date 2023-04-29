using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherSelector : MonoBehaviour
{
    public int weather;

    public void OnClick()
    {
        TimeManager.weather = weather;
    }
}

