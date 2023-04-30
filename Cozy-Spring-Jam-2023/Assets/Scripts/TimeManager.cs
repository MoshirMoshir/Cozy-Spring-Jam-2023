using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        //Debug.Log("The game stage is at: "+ stage.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (tmp < stage && stage < 9)
            {
                tmp = stage;
                plantStages[stage - 1].SetActive(true);
                plotStages[stage - 1].SetActive(true);
            }

        if (stage == 9)
        {
            day = 0;
            stage = 0;
            tmp = 0;
            SceneManager.LoadScene("Win");
        }

        if (day > 365)
        {
            day = 0;
            stage = 0;
            tmp = 0;
            SceneManager.LoadScene("GameOver");
        }
    }
        
    
}
