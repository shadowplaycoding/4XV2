using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyManager : MonoBehaviour
{

    public Galaxy Galaxy;

    // Start is called before the first frame update
    void Start()
    {
        ValidateGalaxySettings();
        CreateStarData();
        PopulateRoundGalaxy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PopulateRoundGalaxy(){

        int failCount = 0; 

        for(int i = 0; i < Galaxy.NumberOfStars; i++){
            
            Vector3 position = PositionMaths.RandomPolarPosition(Galaxy.MinimumRadius, Galaxy.MaximumRadius);
            float rad = Galaxy.MinDistanceBetweenStars;

            
            Physics.SyncTransforms();
            bool collision  = Physics.CheckSphere(position, rad);
            
            if(!collision){
                string name = Galaxy.Stars[i].Name;
                GameObject starObject = SpaceObjects.CreateSphereObject(name, position, this.transform);
                failCount = 0;
            }
            else{
                failCount++;
                
                if(failCount > Galaxy.NumberOfStars){
                    Debug.LogError("Could not fit all the stars in the Galaxy! Try changing the settings!");
                    break;
                }

                i--;
            }


        }
    }

    public void CreateStarData(){
        Galaxy.Stars.Clear();

        for(int i = 0; i <  Galaxy.NumberOfStars; i++){
            string name = "Star " + (i+1);
            int numberOfPlanets = Random.Range(1,10);
            Star star = new Star(name, numberOfPlanets);
            Galaxy.Stars.Add(star);
            Debug.Log("Created " + star.Name + " with " + star.NumberOfPlanets + " planets");
        }
    }

    void ValidateGalaxySettings(){
        if (Galaxy.MinimumRadius > Galaxy.MaximumRadius){
            int tempValue = Galaxy.MaximumRadius;
            Galaxy.MaximumRadius = Galaxy.MinimumRadius;
            Galaxy.MinimumRadius = tempValue;
        }
    }
}
