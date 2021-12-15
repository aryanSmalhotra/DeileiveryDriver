using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  
  [SerializeField] Color32 hasPackageColor = new Color32(44,226,44,1);
  [SerializeField] Color32 NoPackageColor = new Color32(1,1,1,1);
  [SerializeField] float destroyDelay = 0.2f;
  bool hasPakage = false;
  SpriteRenderer spriteRenderer;
  private void Start() 
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
    
  }
  

  
    // Start is called before the first frame update

   void OnTriggerEnter2D(Collider2D other) {
     if(other.tag == "Pakage" && !hasPakage){
       Debug.Log("Package Picked Up!");
       hasPakage = true;
       spriteRenderer.color = hasPackageColor;
       Destroy(other.gameObject, destroyDelay);
      
     }
     if(other.tag =="Customer" && hasPakage){
       Debug.Log("Pakage Given");
       hasPakage= false;
       spriteRenderer.color = NoPackageColor;
     }
   }


}
