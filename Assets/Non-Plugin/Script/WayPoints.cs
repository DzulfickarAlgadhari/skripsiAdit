using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : PointerObject
{
    PlayerMovement playerMovement;

    private Renderer _myRenderer;

    [SerializeField] private Material InactiveMaterial;
    [SerializeField] private Material GazedAtMaterial;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        _myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnPointerEnter()
    {
        base.OnPointerEnter();
        SetMaterial(true);
    }

    public override void OnPointerExit()
    {
        base.OnPointerExit();
        SetMaterial(false);
    }

    public override void OnPointerClick()
    {
        base.OnPointerClick();
        playerMovement.SetTarget(transform.position);
    }

    private void SetMaterial(bool gazedAt)
    {
        if (InactiveMaterial != null && GazedAtMaterial != null)
        {
            _myRenderer.material = gazedAt ? GazedAtMaterial : InactiveMaterial;
        }
    }
}
