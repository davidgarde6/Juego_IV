using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorJugador : MonoBehaviour
{
    public static ControladorJugador Instance;
    public float velMovimiento = 6;
    public Rigidbody2D rb;
    public SpriteRenderer sprite;
    public Animator animator;

    [SerializeField] private Transform bulletPosition;
    private float moverX, moverY;
    private Vector2 dirMovimiento;
    // Update is called once per frame

    public GameObject player;

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {

        ProcesarEntradas();
        
    }

    void FixedUpdate()
    {

        //Calcular físicas
        Mover();

    }

    void ProcesarEntradas()
    {

        if (Singleton.Instance.IsActive())
        {

            moverX = Input.GetAxisRaw("Horizontal");
            moverY = Input.GetAxisRaw("Vertical");

            if (Input.GetKeyDown(KeyCode.A))
            {

                sprite.flipX = true;

            }

            if (Input.GetKeyDown(KeyCode.D))
            {

                if (sprite.flipX)
                {

                    sprite.flipX = false;

                }

            }
            if (Input.GetKeyDown(KeyCode.Space))
            {

                Disparar();

            }

            dirMovimiento = new Vector2(moverX, moverY).normalized;

        }
    }

    private void Disparar()
    {

        GameObject bullet = ObjectPool.Instance.GetPooledObject();

        if (bullet != null)
        {
            bullet.transform.position = bulletPosition.position;
            bullet.SetActive(true);

        }
    }

    private void Mover()
    {

        rb.velocity = new Vector2(dirMovimiento.x * velMovimiento, dirMovimiento.y * velMovimiento);

    }

    public bool IsFlipped()
    {

        return sprite.flipX;

    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Enemigo"))
        {

            Singleton.Instance.RestarVidas();
            animator.SetBool("isHit", true);

        }

    }


}
