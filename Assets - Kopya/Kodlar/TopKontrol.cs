﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
     Rigidbody fizik;
     public int hiz;
     int sayac = 0;
     public int ToplanilacakObjeSayi;
     public Text sayacText;
     public Text OyunbittiText;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    
    void  FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(yatay,0,dikey);
        fizik.AddForce(vec*hiz);
    }
     void OnTriggerEnter(Collider other)
     {
          if(other.gameObject.tag=="engel")
         other.gameObject.SetActive(false);
         sayac++;
           sayacText.text="Sayac ="+ sayac;
         if(sayac==ToplanilacakObjeSayi)
         {
           OyunbittiText.text="OYUN BİTTİ";
         }
     }
}
