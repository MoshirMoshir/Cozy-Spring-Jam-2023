using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayButton : MonoBehaviour
{
    public Sprite[] sprites;

    void Update() 
    {
        this.GetComponent<Image>().sprite = sprites[TimeManager.weather];
    }

}
