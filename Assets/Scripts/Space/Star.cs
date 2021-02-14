using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star
{
    public string Name {get; protected set;}
    public int NumberOfPlanets {get; protected set;}

    public List<Planet> PlanetList;

    public Star(string name, int numberOfPlanets){
        this.Name = name;
        this.NumberOfPlanets = numberOfPlanets;
        this.PlanetList = new List<Planet>();
        GenerateRandomPlanets();
    }

    void GenerateRandomPlanets(){
        for(int i=0; i < NumberOfPlanets; i++){
            string name = this.Name + " " + (i + 1);

            int random = Random.Range(1, 100);

            Planet planet = new Planet(name);
            planet.SetPlanetType(random);
            this.PlanetList.Add(planet);
            // Debug.Log("Planet: " + PlanetList[i].Name);
        }
    }
}
