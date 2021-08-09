using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject character;
    public float current_angle = -50.0f;

    void Start()
    {
        this.character = GameObject.Find("Character");
    }

    void Update()
    {
        Vector3 characterPos = this.character.transform.position;
        transform.position = new Vector3(
            characterPos.x, characterPos.y-0.2f, characterPos.z);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localEulerAngles = new Vector3(
                0, 0, -current_angle);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localEulerAngles = new Vector3(
                0, 0, current_angle);
        }
    }
}
