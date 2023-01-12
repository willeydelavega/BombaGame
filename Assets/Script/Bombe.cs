using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    private void OnMouseDrag()
    {
        Vector3 positionSouris = new Vector3(Input.mousePosition.x,Input.mousePosition.y,transform.position.z);
        transform.position = Camera.main.ScreenToWorldPoint(positionSouris);
    }
}
