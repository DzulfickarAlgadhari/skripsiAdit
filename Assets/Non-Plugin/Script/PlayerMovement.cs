using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isMoving;
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            MoveTo(target);
        }

        CheckPosition();
    }

    public void MoveTo(Vector3 pos)
    {
        transform.position = Vector3.MoveTowards(transform.position, pos, 1* Time.deltaTime);
    }


    public void SetTarget(Vector3 pos)
    {
        if (isMoving) return;

        target = pos;
        isMoving = true;
    }

    public void CheckPosition()
    {
        if(transform.position.x == target.x && transform.position.z == target.z)
        {
            isMoving = false;
            //Debug.Log("arrive");
        }
    }

}
