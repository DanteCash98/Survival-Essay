using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using MouseButton = UnityEngine.Experimental.UIElements.MouseButton;

public class MeleeObject : MonoBehaviour
{
   private Animator anim;
   public float damage = 10;
   public float range = 10f;
   
   public GameObject playerOwner;
   
   private int layerMask = ~(1 << 8); //hit all but layer 8
   private Entity ownerEntity;
   
   private void Start()
   {
      anim = GetComponent<Animator>();
      ownerEntity = playerOwner.GetComponent<Entity>();
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
            if (hit.GetType() != typeof(EnemyEntity)) return;
            hit.transform.SendMessage("ApplyDamage", new AttackData(ownerEntity, (int)damage), SendMessageOptions.DontRequireReceiver);
            Debug.Log("Hit from melee");
         }
      }
      
   }
}
