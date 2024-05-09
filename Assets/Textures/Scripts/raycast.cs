using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raycast : MonoBehaviour
{
    [SerializeField]
    private int rayLength = 2;
    [SerializeField]
    private LayerMask layerMaskInteract;
    [SerializeField]
    private string excludeLayerName = null;

    private controller raycastedObj;

    [SerializeField]
    private KeyCode act = KeyCode.Mouse0;

    [SerializeField]
    public Image crosshair = null;
    private bool isCrosshairActive;
    private bool doOnce;

    private const string interactableTag = "InteractiveObject";

    public bool RaycastActive;

    // Start is called before the first frame update
    void Start()
    {
        RaycastActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;
        if (Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
           if (hit.collider.CompareTag(interactableTag))
            {
                //print("I'm hit");
                raycastedObj = hit.collider.gameObject.GetComponent<controller>();
                CrosshairChange(true);
                isCrosshairActive = true;
                if (Input.GetKeyDown(act) && RaycastActive == true)
                {
                  RaycastActive = false;
                  raycastedObj.RaycastInteraction();
                }
            }
        }
        else
        {
            if (isCrosshairActive)
            {
               CrosshairChange(false);
            }
        }
    }

    void CrosshairChange (bool on)
    {
        if (on)
        {
            crosshair.color = Color.red;
        }
        else
        {
            crosshair.color = Color.white;
            isCrosshairActive = false;
        }
    }
}
