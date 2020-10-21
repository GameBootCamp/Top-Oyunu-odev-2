using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
   public GameObject topum;
   Vector3 mesafe;
    void Start()
    {
        mesafe=transform.position-topum.transform.position;
    }

   
    void LateUpdate()
    {
        transform.position=topum.transform.position+mesafe;
    }
}
