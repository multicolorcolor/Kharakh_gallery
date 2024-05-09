using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bools : MonoBehaviour
{
    public static bool ArtworkClick;
    // Start is called before the first frame update
    void Start()
    {
        ArtworkClick = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickableAgain()
    {
        ArtworkClick = true;
    }
}
