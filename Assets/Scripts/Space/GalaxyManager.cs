using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyManager : MonoBehaviour
{

    public Galaxy Galaxy;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < Galaxy.NumberOfStars; i++){
            Vector3 position = PostitionMaths.RandomPolarPosition(0, Galaxy.MaximumRadius);
            GameObject starObject = SpaceObjects.CreateShereObject(position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
