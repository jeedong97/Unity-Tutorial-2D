using UnityEngine;
using UnityEngine.Rendering;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;
    public float rotSpeed = 30f;
    public float revolutionSpeed = 100f;
    public bool isRevolution = false;
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);

        if(isRevolution)
        {
            transform.RotateAround(targetPlanet.position, Vector2.up, revolutionSpeed * Time.deltaTime);
        }
    }
}
