using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Galaxy
{
    public int NumberOfStars = 300;
    public int MinimumRadius = 0;
    public int MaximumRadius = 100;
    public float MinDistanceBetweenStars = 2f;

    public List<Star> Stars;

    public Galaxy(){
        this.Stars = new List<Star>();
    } 

}
