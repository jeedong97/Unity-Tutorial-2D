using UnityEngine;

public class MoveMent : MonoBehaviour
{
   public float MoveSpeed;
    void Start()
    {

    }

    void Update()
    {
        //this.transform.position = this.transform.position + Vector3.forward * speed;
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * (Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * (Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * (Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * (Time.deltaTime * MoveSpeed);
        }
    }
}
