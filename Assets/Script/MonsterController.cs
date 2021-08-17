using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float MaxWalkSpeed = 2.0f;
    float WalkForce = 27.0f;
    int turning_Ratio = 40;
    float turning_Span = 7.0f;
    float delta = 0;
    int key = 1;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.turning_Span)
        {
            this.delta = 0;
            int turn = Random.Range(1, 101);
            if (turn <= this.turning_Ratio && turn >= 1)
            {
                this.key *= -1;
            }
            turn = 0;
        }

        float Current_Speed = Mathf.Abs(this.rigid2D.velocity.x);

        if (Current_Speed < this.MaxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.WalkForce);
        }

        if (key != 0)
        {
            this.transform.localScale = new Vector3 (key * 0.5f, 0.5f, 1);
        }

        this.animator.speed = Current_Speed / 2.0f;

        if (transform.position.x <= -17.2f)
        {
            transform.position = new Vector3 (
                -17.2f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= 17.2f)
        {
            transform.position = new Vector3 (
                17.2f, transform.position.y, transform.position.z);
        }
    }
}
