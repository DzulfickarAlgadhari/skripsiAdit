using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    [SerializeField] private float rotation_speed, revolution_speed;
    [SerializeField] private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, rotation_speed) * Time.deltaTime);
        transform.RotateAround(target.transform.position, Vector3.down, revolution_speed * Time.deltaTime);
    }
}
