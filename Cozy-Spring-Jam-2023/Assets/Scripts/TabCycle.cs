using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabCycle : MonoBehaviour
{
    public GameObject panel;

    public GameObject otherPanels;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Selected()
    {
        panel.SetActive(true);
        otherPanels.SetActive(false);
    }

}
