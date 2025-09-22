using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionarAnimacionAtaque : MonoBehaviour
{

    public Animator animator;
    public Collider2D collider;

    void Start()
    {

        collider.enabled = false;

    }

    private void Atacked()
    {

        animator.SetBool("isAtacking", false);
        animator.SetBool("Atacked", true);
        collider.enabled = true;

    }

    private void GoingBack()
    {

        animator.SetBool("Atacked", false);
        animator.SetBool("GoingBack", true);

    }

    private void Reset()
    {

        animator.SetBool("GoingBack", false);
        animator.SetBool("reset", true);
        collider.enabled = false;

    }

    private void SetCooldown()
    {

        ZonaDeteccionPlanta.Instance.cooldownAtaque = 3f;

    }
}
