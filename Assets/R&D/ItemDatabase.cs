using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    
    public Item glove;
    // Start is called before the first frame update
    void Start()
    {
        glove = new Item("randomID", "The Glove", "For all your glove needs", 2, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
