using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnergyTracker : MonoBehaviour
{

    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<TextMeshProUGUI>().text = TimeManager.energy.ToString();
    }
}
