using UnityEngine;

public class MoveMent : MonoBehaviour
{
    public float MoveSpeed;
    void Start()
    {

    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v).normalized;
        Vector3 normalDir = dir.normalized;

        transform.position += normalDir * MoveSpeed * Time.deltaTime;

        transform.LookAt(transform.position + normalDir);

    }
}
