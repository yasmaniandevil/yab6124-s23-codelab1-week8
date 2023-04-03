using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class is short for classification

[CreateAssetMenu(
    fileName = "New Location",
    menuName = "ScriptableObjects/Location",
    order = 0
)]

public class LocationScriptableObjects : ScriptableObject
{

    public string locationName;
    public string locationDescription;

    //each scriptable object has ability of NSEW
    public LocationScriptableObjects northLocation;
    public LocationScriptableObjects southLocation;
    public LocationScriptableObjects eastLocation;
    public LocationScriptableObjects westLocation;

}


