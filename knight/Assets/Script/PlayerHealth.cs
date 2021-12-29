using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float initialHealth = 1f;
    private Animator anim;
    public float currentHealth { get; private set; }

    private void Awake()
    {
        anim = GetComponent<Animator>();
        currentHealth = initialHealth;
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, initialHealth);


        if (currentHealth <= 0)
        {
            anim.SetBool("isDead", true);
            GetComponent<PlayerMovement>().enabled = false;
            StartCoroutine("MoveToMainView");
        }


    }

    IEnumerator MoveToMainView()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Main View");

    }
}
