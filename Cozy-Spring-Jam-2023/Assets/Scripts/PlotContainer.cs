using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlotContainer : MonoBehaviour
{
    public Plant plant;

    //public GameObject plantPrefab;

    private Image image;
    private bool containsPlant = false;

    void Start ()
    {
        image = this.GetComponent<Image>();
    }

    private void OnMouseDown()
    {
        if (PlantSelector.selectedPlant != null && containsPlant == false)
        {
            containsPlant = true;
            // Instantiate the plantPrefab at the plot's position and rotation
            //GameObject newPlant = Instantiate(plantPrefab, transform.position, transform.rotation);
            
            // Set the parent of the new plant to the plot
            //newPlant.transform.SetParent(transform);
            
            // Set the position of the new plant to be slightly above the plot
            //newPlant.transform.position += new Vector3(0f, 0.1f, 0f);
            
            // Attach the PlantData component to the new plant
            plant = PlantSelector.selectedPlant;

            image.sprite = plant.sprite[0];
            image.enabled = !image.enabled;
            
            // Reset the selected plant
            PlantSelector.isPlacing = false;
        }
    }

    private void passDay()
    {
         
    }

}
