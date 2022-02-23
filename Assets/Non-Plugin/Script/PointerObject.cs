using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerObject : MonoBehaviour
{
    public bool isClicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void OnPointerEnter()
    {       
        //Debug.Log("object hit");
        //Debug.Log(gameObject.name);
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public virtual void OnPointerExit()
    {
        //SetMaterial(false);
        //Debug.Log("object exit");
        isClicked = false;
    }

    /// <summary>
    /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
    /// is touched.
    /// </summary>
    public virtual void OnPointerClick()
    {
        //TeleportRandomly();
        if (isClicked) return;

        //Debug.Log(gameObject.name +", clicked");
        isClicked = true;
    }
}
