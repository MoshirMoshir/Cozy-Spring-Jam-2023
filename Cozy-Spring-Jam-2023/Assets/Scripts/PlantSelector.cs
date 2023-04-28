using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantSelector : MonoBehaviour
{
    public GameObject plantPrefab;      // the prefab for the plant object
    public Sprite plantIcon;             // the image component of the plant button

    static public Plant selectedPlant;
    private GameObject currentPlant;   // the currently selected plant object
    private Sprite currentSprite;      // the sprite for the currently selected plant
    public static bool isPlacing = false; // Flag to indicate if we're in "plant placement" mode

     void Update()
    {

        if (isPlacing)
        {
            // Intilizes plant to mouse position
            if (Input.GetMouseButtonDown(0))
            {
                currentPlant.transform.position = GetMouseWorldPosition();
            }

            if (currentPlant != null)
            {
                // Update the position of the plant prefab to follow the mouse
                currentPlant.transform.position = GetMouseWorldPosition();
            }
        }

        if (!isPlacing && currentPlant != null)
        {
            OnPlotClicked();
        }
    }

    // Helper method to get the mouse position in the world
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }

    // Method called when the plant button is clicked
    public void OnPlantButtonClicked()
    {
        // Create the plant object from the prefab
        currentPlant = Instantiate(plantPrefab);
        selectedPlant = plantPrefab.GetComponent<Plant>();

        // Get the sprite from the plant button
        currentSprite = plantIcon;

        // Sets into placing mode [see Update()]
        isPlacing = true;


        // Add button that lets you cancel plant
    }

    // Method called when the player clicks on a plot
    public void OnPlotClicked(/**GameObject plot**/)
    {
        // Set the plant to the plot
        //currentPlant.transform.position = plot.transform.position;

        // Set the plant sprite to the plot
        //currentPlant.GetComponent<SpriteRenderer>().sprite = currentSprite;

        // Disable the follow mouse behavior
        isPlacing = false;
        Destroy(currentPlant);
        currentPlant = null;
        currentSprite = null;
        
    }
}
