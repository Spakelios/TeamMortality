using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetButtons : MonoBehaviour
{
    public AudioSource woosh;
    public Animator _animator;
    public void IceP()
    {
        StartCoroutine(ice());
    }

    public void FireP()
    {
        StartCoroutine(Fire());
    }

    public void PlantP()
    {
        StartCoroutine(plant());
    }
    
    public void MetalP()
    {
        StartCoroutine(metal());
    }


    public IEnumerator ice()
    {
        _animator.Play("button pressy");
        woosh.Play();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Ice Planet");
    }
    
   public IEnumerator Fire()
    {
        _animator.Play("button pressy");
        woosh.Play();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Fire Planet");
    }
   
   public IEnumerator plant()
   {
       _animator.Play("button pressy");
       woosh.Play();
       yield return new WaitForSeconds(1f);
       SceneManager.LoadScene("Plant Planet");
   }
   
   public IEnumerator metal()
   {
       _animator.Play("button pressy");
       woosh.Play();
       yield return new WaitForSeconds(1f);
       SceneManager.LoadScene("Rock & Metal Planet");
   }
}

