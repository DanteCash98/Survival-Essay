using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using MouseButton = UnityEngine.Experimental.UIElements.MouseButton;

public class MeleeObject : MonoBehaviour
{
   private Animator anim;
   public float damage = 10f;
   private float distance;
   public float range = 10f;
   private int layerMask = ~(1 << 8); //hit all but layer 8

   private void Start()
   {
      anim = GetComponent<Animator>();
   }
   
   private void Update()
   {
      if (Input.GetButtonDown("Fire1"))
      {
         anim.SetTrigger("Swing");
         RaycastHit hit;
         if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, range,
            layerMask))
         {
            distance = hit.distance;
            hit.transform.SendMessage("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
            Debug.Log("Hit from melee");
         }
      }
      
   }
}
