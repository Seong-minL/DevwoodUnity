using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject character;
    float x_Pos;
    float y_Pos;
    void Start()
    {
        this.character = GameObject.Find("Character");
    }

    void Update()
    {
        Vector3 characterPos = this.character.transform.position;
        transform.position = new Vector3(
            characterPos.x + 4.5f, characterPos.y + 2.2f, characterPos.z);

        if (transform.position.x >= 10.0f)
        {
            transform.position = new Vector3(
                10.0f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x <= -10.0f)
        {
            transform.position = new Vector3(
                -10.0f, transform.position.y, transform.position.z);
        }

        if (transform.position.y <= -1.0f)
        {
            transform.position = new Vector3(
                transform.position.x, -1.0f, transform.position.z);
        }
    }
}
