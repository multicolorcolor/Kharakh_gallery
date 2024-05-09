using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class controller : MonoBehaviour
{
    public UnityEvent InteractAction;
    public UnityEvent HoverOver;
    public UnityEvent HoverExit;
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    public bool ActiveonClick;
    public Bools ArtworkClick;
    public bool Transport;
    Collider m_Collider;
    //public Bools scriptBools;
    // Start is called before the first frame update
    void Start()
    {
        cursorTexture = Resources.Load<Texture2D>("look128");
        m_Collider = GetComponent<Collider>();
        ActiveonClick = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RaycastInteraction()
    {
      
            InteractAction.Invoke();
            print("Action!");
            //collideron = false;
       


    }

    void OnMouseDown()
    {
        if (Bools.ArtworkClick == true)
        {
            InteractAction.Invoke();
            print("Action!");
            Bools.ArtworkClick = false;
        }
        else
        {
            print("Not Active");
        }
        
    }

    void OnMouseOver()
    {
        if (Bools.ArtworkClick == true)
        {
            HoverOver.Invoke();
            //Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        }
        else
        {
            //Cursor.SetCursor(null, Vector2.zero, cursorMode);
        }
           
      
    
    }

    void OnMouseExit()
    {
        HoverExit.Invoke();
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
}
