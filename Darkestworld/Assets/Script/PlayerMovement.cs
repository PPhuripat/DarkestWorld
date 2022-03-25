using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody2D rb;
	private Animator myAim;
    Vector2 movement;

    [SerializeField]
	public float moveSpeed = 5f;

	private float attackTime = .25f;
	private float attackCounter = .25f;
	private bool isAttacking;
	public int act = 0;

	private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		myAim = GetComponent<Animator>();
     
    }

	// Update is called once per frame
	void Update()
    {
		rb.velocity = new Vector2(Input.GetAxis("Horizontal") , Input.GetAxis("Vertical")) * moveSpeed;

		myAim.SetFloat("moveX", rb.velocity.x);
		myAim.SetFloat("moveY", rb.velocity.y);


		if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
		{
			myAim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
			myAim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
		}

		if (isAttacking)
		{
			rb.velocity = Vector2.zero;
			attackCounter -= Time.deltaTime;
			if (attackCounter <= 0)
			{
				myAim.SetBool("isAttacking", false);
				isAttacking = false;
			}
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			attackCounter = attackTime;
			myAim.SetBool("isAttacking", true);
			isAttacking = true;
			getAction();
		}
	}

		void getAction()
		{
			act--;
			if (act <= 0)
			{
				gameObject.SetActive(false);
				
              
        }
		}

		
}
