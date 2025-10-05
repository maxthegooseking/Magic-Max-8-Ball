using System.Runtime.Serialization;
using UnityEngine;

public class Button : MonoBehaviour
{
    public float maxXPosition;
    public float maxYPosition;
    private Vector3 targetPoisiton;
    private bool isMoving = false;
    public float speed = 1f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPoisiton = transform.position;
    }

    public LayerMask teleportableLayers;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(Ray, out hit))
            {
                //transform.position = hit.point;
                //transform.position += new Vector3(0, 0.5f, 0);
                targetPoisiton = hit.point;
                isMoving = true;
                isMoving = true;
            }
            else
            {
                Debug.Log("No valid teleportation point detected.");
            }
        }
    }

    void TeleportToMousePosition()
    {
      
    }

}
