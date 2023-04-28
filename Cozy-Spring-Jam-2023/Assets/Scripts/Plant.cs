using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public string plantName;        // the name of the plant
    public float growthChance;      // the chance of the plant growing each day
    public float growthRate;        // the speed at which the plant grows
    public int pointsGiven;         // the number of points the plant gives when it grows

    // Method to get the growth chance of the plant
    public float GetGrowthChance()
    {
        return growthChance;
    }

    // Method to get the growth rate of the plant
    public float GetGrowthRate()
    {
        return growthRate;
    }

    // Method to get the points given by the plant
    public int GetPointsGiven()
    {
        return pointsGiven;
    }
}
