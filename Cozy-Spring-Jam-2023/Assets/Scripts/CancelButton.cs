using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : MonoBehaviour
{
    // Set reference to self (shadow)
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlantSelector.isPlacing)
        {
            panel.SetActive(false);
        }
    }

    public void OnClick()
    {
        PlantSelector.isPlacing = false;
        panel.SetActive(false);
    }
}
