using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public LocationScriptableObjects currentLocation;
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;

    public Button north;

    public Button south;

    public Button east;

    public Button west;
    
    // Start is called before the first frame update
    void Start()
    {
        TextAsset fileText = Resources.Load<TextAsset>("Data");
        Debug.Log(fileText.text);
        
        UpdateLocation();
    }

    //creating a function
    //returns nothing because its void
    //() takes no peramators
    void UpdateLocation()
    {
        title.text = currentLocation.locationName;
        description.text = currentLocation.locationDescription;

        if (currentLocation.northLocation == null)
        {
            north.gameObject.SetActive(false);
        }
        else
        {
            north.gameObject.SetActive(true);
            currentLocation.northLocation.southLocation = currentLocation;
        }

        if (currentLocation.southLocation == null)
        {
            south.gameObject.SetActive(false);
        }
        else
        {
            south.gameObject.SetActive(true);
            currentLocation.southLocation.northLocation = currentLocation;
        }

        if (currentLocation.eastLocation == null)
        {
            east.gameObject.SetActive(false);
        }
        else
        {
            east.gameObject.SetActive(true);
            currentLocation.eastLocation.westLocation = currentLocation;
        }

        if (currentLocation.westLocation == null)
        {
            west.gameObject.SetActive(false);
        }
        else
        {
            west.gameObject.SetActive(true);
            currentLocation.westLocation.eastLocation = currentLocation;
        }
    }

    //returns nothing
    //takes an argument called int dir
    public void MoveDirection(int dir)
    {
        switch (dir)
        {
            case 0://north
                currentLocation = currentLocation.northLocation;
                break;
            case 1://south
                currentLocation = currentLocation.southLocation;
                break;
            case 2:
                currentLocation = currentLocation.eastLocation;
                break;
            case 3:
                currentLocation = currentLocation.westLocation;
                break;
        }
        
        
        UpdateLocation();

    }

}
