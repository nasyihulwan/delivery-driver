using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(0,0,0,0); 
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1); 

    
    
    bool hasPackage;
    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Oops...");
    }
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false ;
            spriteRenderer.color = noPackageColor;
        }

        
    }
}
