using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlanetType {
     Barren, 
     GasGiant, 
     Terran     
}

public class Planet
{
    public string Name {get; protected set;}
    public PlanetType Type;

    public Planet(string name, PlanetType type = PlanetType.Barren){
        this.Name = name;
        this.Type = type;
    }

    public void SetPlanetType(int number){
        if(number <= 20){
            this.Type = PlanetType.Terran;
        }
        else if (number > 20 && number <= 60){
            this.Type = PlanetType.Barren;
        }
        else{
            this.Type = PlanetType.GasGiant;
        }
    }

}
