using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetButtons : MonoBehaviour
{
    public Animator _animator;
    public void IceP()
    {
        StartCoroutine(ice());
    }

    public void RockP()
    {
        StartCoroutine(rock());
    }
    

    public IEnumerator ice()
    {
        _animator.Play("button pressy");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Ice Planet");
    }
    
   public IEnumerator rock()
    {
        _animator.Play("button pressy");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Fire Planet");
    }
}
