using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial1_UI_Director : MonoBehaviour
{
    GameObject MoveTutorial;
    GameObject PortalTutorial;
    GameObject character;

    void Start()
    {
        this.MoveTutorial = GameObject.Find("MoveTutorial");
        this.PortalTutorial = GameObject.Find("PortalTutorial");
        this.character = GameObject.Find("Character");
    }

    void Update()
    {
        if (character.transform.position.x >= 0)
        {
             MoveTutorial.SetActive(false);
            PortalTutorial.SetActive(true);
        }
        else
        {
            MoveTutorial.SetActive(true);
            PortalTutorial.SetActive(false);
        }
    }
}
