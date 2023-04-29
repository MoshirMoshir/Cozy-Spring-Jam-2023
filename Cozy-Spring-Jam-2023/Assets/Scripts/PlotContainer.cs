using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlotContainer : MonoBehaviour
{
    public Plant plant;
    public int growthStage = 0;
    public static int day = 1;
    public Text harvestedTextPrefab;

    //public GameObject plantPrefab;

    private Image image;
    private bool containsPlant = false;

    void Start ()
    {
        image = this.GetComponent<Image>();
    }

    void Update()
    {
        if (containsPlant && day < TimeManager.day)
        {
            passDay();
            day++;
        }

    }

    private void OnMouseDown()
    {
        if (PlantSelector.selectedPlant != null && !containsPlant && PlantSelector.isPlacing)
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

            image.sprite = plant.sprite[growthStage];
            image.enabled = !image.enabled;
            
            // Reset the selected plant
            PlantSelector.isPlacing = false;
            
        }

        if (growthStage == plant.maxStage)
        {
            StartCoroutine(DisplayHarvestedText());

            //Set Plot to Empty
            containsPlant = false;
            image.enabled = !image.enabled;
            plant = null;
            growthStage = 0;
        }
    }

    IEnumerator DisplayHarvestedText()
    {
        // create the text object
        GameObject textObj = new GameObject("HarvestedText");
        textObj.transform.position = transform.position + new Vector3(0, 1, 0);

        // add the text component
        //Font font = Resources.Load<Font>("DeterminationMonoWebRegular-Z5oq");
        //font.material = Resources.Load<Material>("DeterminationMonoWebRegular-Z5oq");
        //font.material.mainTexture = Resources.Load<Texture>("DeterminationMonoWebRegular-Z5oq");
        
        TextMesh textMesh = textObj.AddComponent<TextMesh>();
    
        textMesh.text = "Harvested!";
        textMesh.fontSize = 50;
        textMesh.characterSize = 0.1f;
        textMesh.color = Color.yellow;
        //textMesh.font = font;
        

        // animate the text
        float duration = .6f;
        float t = 0f;
        while (t < duration)
        {
            textObj.transform.position += new Vector3(0, 0.003f, 0);
            t += Time.deltaTime;
            yield return null;
        }

        // destroy the text object
        Destroy(textObj);
    }
    
    public void passDay()
    {
        if (Random.Range(1f, 0f) < plant.growthChance && growthStage < plant.maxStage && TimeManager.weather == plant.weatherNeeded[growthStage])
        {
            growthStage++;
            image.sprite = plant.sprite[growthStage];
        }
        
    }

}
