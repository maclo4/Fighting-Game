﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;
using System.Security.Cryptography;
using UnityEngine;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using System;
using System.Threading.Tasks;
//using InputTime;

/*

public class InputBuffer
{
	// input buffer variable to store 10 most recent inputs
	List<InputTime> inputBuffer;
	Stopwatch stopwatch;

	public int size { get; private set; }

	// constructor (kinda pointless)
	public InputBuffer()
	{
		inputBuffer = new List<InputTime>();
		stopwatch = new Stopwatch();
		stopwatch.Start();
		size = 10;
	}


	// add an input to the end of the list
	public void Enqueue(string input)
	{
		InputTime inputTime = new InputTime(input, stopwatch.ElapsedMilliseconds);

		inputBuffer.Add(inputTime);

		while (inputBuffer.Count > size)
		{

			inputBuffer.RemoveAt(0);
		}
	}
	// returns a specified amount of the most recent inputs from the list
	public List<InputTime> getTopInputs(int numInputs = 3)
	{
		List<InputTime> topInputs = new List<InputTime>(numInputs);
		int i = inputBuffer.Count - 1;

		while (i >= inputBuffer.Count - numInputs && i >= 0)
		{
			topInputs.Add(inputBuffer[i]);
			i--;
		}

		return topInputs;
	}

	// mainly for testing
	public void printBuffer()
	{
		List<InputTime> printTop = getTopInputs(20);
		int i = 0;
		foreach (InputTime inputs in printTop)
		{
			UnityEngine.Debug.Log(i + ": " + inputs.input + ", " + inputs.elapsedMilliseconds);
			i++;
		}
	}

	public long getCurrentTime()
	{
		return stopwatch.ElapsedMilliseconds;
	}

}




public class CustomInputSystem : ScriptableObject
{

	bool lastXAxisState = false;
	bool lastYAxisState = false;
	bool currentYAxisState = false;
	bool currentXAxisState = false;


	bool lastAirdashState = false;

	bool lastLightState = false;
	/// <summary>
	/// Gets the axis input like an on key down event, returning <c>true</c> only 
	/// on the first press, after this return <c>false</c> until the next press. 
	/// Only works for axis between 0 (zero) to 1 (one).
	/// </summary>
	// <param name="axisName">Axis name configured on input manager.</param>
	// TODO GET RID OF THIS PARAM AXISNAME
	public void getXAxisButtonDown(Vector2 joystickAxis, ref bool horizontalDownThisFrame, ref bool verticalDownThisFrame)
	{
		bool tempLastX = lastXAxisState;
		currentXAxisState = (joystickAxis.x > 0.5 || joystickAxis.x < -0.5);
		currentYAxisState = (joystickAxis.y > 0.5 || joystickAxis.y < -0.5);

		if (currentXAxisState && lastYAxisState && !currentYAxisState)
		{
			horizontalDownThisFrame = true;
			//verticalDownThisFrame = false;
		}
		// prevent keep returning true when axis still pressed.
		else if (currentXAxisState && lastXAxisState)
		{
			//UnityEngine.Debug.Log("getaxisbuttondown return false bc last input was true= " + lastInputAxisState);
			horizontalDownThisFrame = false;
		}
		else
		{
			lastXAxisState = currentXAxisState;
			horizontalDownThisFrame = currentXAxisState;
		}


		// now for the y axis
		if (currentYAxisState && tempLastX && !currentXAxisState)
		{
			//horizontalDownThisFrame = false;
			verticalDownThisFrame = true;
		}

		else if (currentYAxisState && lastYAxisState)
		{
			//UnityEngine.Debug.Log("getaxisbuttondown return false bc last input was true= " + lastInputAxisState);
			verticalDownThisFrame = false;
		}
		else
		{
			lastYAxisState = currentYAxisState;
			verticalDownThisFrame = currentYAxisState;
		}



	}
	public bool getAirdashDownThisFrame(bool airdashButtonDown)
	{



		// prevent keep returning true when axis still pressed.
		if (airdashButtonDown && lastAirdashState)
		{
			//UnityEngine.Debug.Log("getaxisbuttondown return false bc last input was true= " + lastInputAxisState);
			return false;
		}


		lastAirdashState = airdashButtonDown;

		//UnityEngine.Debug.Log("getaxisbuttondown last value was false so return current value= " + currentInputValue + Input.GetAxis(axisName));
		return airdashButtonDown;
	}
	public bool getLightDownThisFrame(bool lightButtonDown)
	{



		// prevent keep returning true when axis still pressed.
		if (lightButtonDown && lastLightState)
		{
			//UnityEngine.Debug.Log("getaxisbuttondown return false bc last input was true= " + lastInputAxisState);
			return false;
		}


		lastLightState = lightButtonDown;

		//UnityEngine.Debug.Log("getaxisbuttondown last value was false so return current value= " + currentInputValue + Input.GetAxis(axisName));
		return lightButtonDown;
	}


}
*/


//public class LightAttack : MonoBehaviour, IHitboxResponder
//{

//    public int damage { get; set; }
//	public Hitbox hitbox { get; set; }
//	//public Hitbox hitbox2;
//	bool attacking = false;

//	int i = 0;
//	public void Awake()
//	{
//		hitbox = gameObject.GetComponent<Hitbox>();

//		//Vector2 hitboxPoint = transform.position;
//		//hitboxPoint.x = hitboxPoint.x + .5f;
//		//Vector2 hitboxSize = new Vector2(1, .5f);
//		//hitbox.initializeHitbox(hitboxPoint, hitboxSize, 0);
//		hitbox.setResponder(this);
//		//hitbox.hitboxSize = new Vector2(1, .5f);

//	}

//	public void Update()
//    {

//		//UnityEngine.Debug.Log("updating light attack");
//		if(attacking == true)
//        {
//			if (i > 4)
//			{
//				attacking = false;
//				hitbox.stopCheckingCollision();
//				i = 0;
//				UnityEngine.Debug.Log("Stop checking collision");
//				return;
//			}
//			else
//			{
//				hitbox.startCheckingCollision();
//			}

//			hitbox.hitboxUpdate();

//			i++;
//		}
//    }
//	public void attack()
//	{

//		// and do the rest of your attack
//		attacking = true;
//		//hitbox.startCheckingCollision();
//		//hitbox.hitboxUpdate();

//	}

//	public void endAttack()
//    {
//		hitbox.stopCheckingCollision();
//	}

//	void IHitboxResponder.collisionedWith(Collider2D collider)
//	{
//		UnityEngine.Debug.Log("collisioned with being called");
//		//Hurtbox hurtbox = collider.GetComponent<Hurtbox>();
//		//hurtbox?.getHitBy(damage);
//	}

//}


public class CharacterController : MonoBehaviour
{

	[SerializeField] private LayerMask platformLayerMask;
	[SerializeField] private LayerMask playerLayerMask;
	[SerializeField] private LayerMask pushboxLayerMask;
	private enum CharState { Normal, Dashing, Jump, Tumble, AirDash, Block, Crouch, Walk, Backdash, LightAttack, Hitstun }
	CharState state = CharState.Normal;
	
	public enum DirectionFacing { Left, Right}
	public DirectionFacing directionFacing { get; set; }
	private enum AirDashDirection { Right, Left, Neutral }
	private enum AirDashState { NA, Ready }
	AirDashDirection airDashDirection;
	AirDashState airDashState = AirDashState.Ready;
	public static int DASHFRAMES = 0;
	public static int AIRDASHFRAMES = 15;
	public static float AIRDASHSPEED = .11f;
	public static float AIRDASHVELOCITY = 10f;
	public static int PREWALKFRAMES = 2;
	public static float WALKSPEED = 3f;
	public static float MAXAIRDRIFTSPEED = 10f;
	public static float AIRDRIFTMULTIPLIER = .2f;
	public static float BACKDASHSPEED = .17f;
	public static int BACKDASHFRAMES = 12;
	public static float MOVESPEED = 12f;
	public static float JUMPVELOCITY = 20.5f;
	int backdashFrames = BACKDASHFRAMES;
	int prewalkframes = PREWALKFRAMES;
	int airdashFrames = AIRDASHFRAMES;
	int dashFrames = DASHFRAMES;
	//public float movesSpeed;
	float moveSpeed = MOVESPEED;
	float jumpVelocity = JUMPVELOCITY;
	float airdashSpeed = AIRDASHSPEED;
	int hitstunFrames = 0;
	int blockstunFrames = 0;


	// JOYSTICK INPUTS
	CustomInputSystem inputSystem;
	CustomInputSystem joyStickInputsVertical;
	private string[] keys = new string[] { "Jump", "Joystick", "Airdash", "Light", "Medium", "Heavy" };
	private InputBuffer inputQueue;

	// PAUSE SCRIPT
	public PauseController pauseController;

	//private Player_Base playerBase;
	private Rigidbody2D rigidbody2d;

	// todo make private
	private BoxCollider2D boxCollider2d;
	public BoxCollider2D enemyBoxCollider2d;
	public BoxCollider2D hurtbox;
	float dirX, dirY;
	Animator animator;

	public int health = 100;
	// POSSIBLY DELETE BUT THIS IS FOR LOOKING AT THE OTHER CHARACTER

	public Transform target;

	// ==========================================================
	// hitbox testing
	/*
	public LightAttack lightAttackClass = new LightAttack();
	private Hitbox hitbox;
	Vector2 hitboxSize = new Vector2(5, 10); 
	Vector2 hitboxCenter = new Vector2(0, 2);
	*/
	public CuteAlienLightAttack lightAttack;
	// ===========================================================

	// variable to hold a reference to our SpriteRenderer component
	private SpriteRenderer mySpriteRenderer;


	// =======================================================================
	// =======================================================================

	// TODO uncomment this
	InputMaster controls;
	//PlayerInput controls;
	Vector2 joystickAxis;
	float left;

	bool airdashDownThisFrame;
	bool horizontalDownThisFrame;
	bool verticalDownThisFrame;
	bool lightDownThisFrame;
	bool mediumDownThisFrame;
	//bool downButtonDown;
	//bool upButtonDown;
	//bool leftButtonDown;
	//bool rightButtonDown;
	// =======================================================================
	// =======================================================================
	// Use this for initialization
	void Start()
	{

		//TODO: MOVE SOME OF THESE OUTSIDE OF START IF POSSIBLE.. DONE?h
		
		pauseController = GameObject.FindObjectOfType(typeof(PauseController)) as PauseController;
		Application.targetFrameRate = 60;
		animator = GetComponent<Animator>(); // todo uncomment


		inputQueue = new InputBuffer();


	}

	void OnEnable()
	{
		//controls.PlayerControls.Enable();
	}
	void OnDisable()
	{
		//controls.PlayerControls.Disable();
	}

	// This function is called just one time by Unity the moment the component loads
	private void Awake()
	{
		// testing

		UnityEngine.Debug.Log("health left = " + health);
		inputSystem = ScriptableObject.CreateInstance<CustomInputSystem>();
		joyStickInputsVertical = ScriptableObject.CreateInstance<CustomInputSystem>();
		//hitbox = ScriptableObject.CreateInstance<Hitbox>();
		lightAttack = gameObject.GetComponent<CuteAlienLightAttack>();
		// get a reference to the SpriteRenderer component on this gameObject
		mySpriteRenderer = GetComponent<SpriteRenderer>();
		//playerBase = gameObject.GetComponent<Player_Base>();
		rigidbody2d = transform.GetComponent<Rigidbody2D>();

		boxCollider2d = transform.GetComponent<BoxCollider2D>();

		UnityEngine.Debug.Log("transform: " + transform.name);
		//UnityEngine.Debug.Log("target: " + target.name);
		// todo make sure this works
		//SetTarget();
		//target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		// todo recomment this
		enemyBoxCollider2d = target.GetComponent<BoxCollider2D>();


		// TODO: UNCOMMENT THIS
		//controls = new InputMaster();

		//     controls.PlayerControls.Joystick.performed += context => joystickAxis = context.ReadValue<Vector2>();
		//     controls.PlayerControls.Joystick.canceled += context => joystickAxis = Vector2.zero;



		//     controls.PlayerControls.Airdash.performed += context => airdashDownThisFrame = buttonDown(context);
		//     controls.PlayerControls.Airdash.canceled += context => airdashDownThisFrame = false;

		//     controls.PlayerControls.Light.performed += context => lightDownThisFrame = buttonDown(context);
		//     controls.PlayerControls.Light.canceled += context => lightDownThisFrame = false;

		/*
		controls.PlayerControls.Up.performed += context => upButtonDown = buttonDown(context); 
		controls.PlayerControls.Up.canceled += context => upButtonDown = false;

		controls.PlayerControls.Down.performed += context => downButtonDown = buttonDown(context); 
		controls.PlayerControls.Down.canceled += context => downButtonDown = false;

		controls.PlayerControls.Left.performed += context => leftButtonDown = buttonDown(context);
		controls.PlayerControls.Left.canceled += context => leftButtonDown = false;

		controls.PlayerControls.Right.performed += context => rightButtonDown = buttonDown(context);
		controls.PlayerControls.Right.canceled += context => rightButtonDown = false;
		*/

	}

	public void SetTarget()
    {
		bool targetSet = false;
		GameObject[] characters;
	
		UnityEngine.Debug.Log("SetTargetCalled");
		//do
		//{
			characters = GameObject.FindGameObjectsWithTag("Player");
			if (characters.Length <= 1)
			{
				
				UnityEngine.Debug.Log("characters size: " + characters.Length + " " + characters[0].name);
			}

			foreach (GameObject player in characters)
			{
				
				if (player.GetInstanceID() != gameObject.GetInstanceID())
				{
					UnityEngine.Debug.Log("target was set! " + player.name + " " + gameObject.name + " " + player.transform.position.x + " " + gameObject.transform.position.x);
					target = player.GetComponent<Transform>();
					targetSet = true;
					break;
				}
			}
		//} while (targetSet == false);

		//target = characters[1].GetComponent<Transform>();
		//	target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		enemyBoxCollider2d = target.GetComponent<BoxCollider2D>();
		
		UnityEngine.Debug.Log("SetTargetended");

	}
	public void OnMove(InputAction.CallbackContext context)
	{
		
		UnityEngine.Debug.Log("onmove called");
		joystickAxis = context.ReadValue<Vector2>();
	}
	public void OnAirdash(InputAction.CallbackContext context)
	{
		airdashDownThisFrame = buttonDown(context);
	}

	//     controls.PlayerControls.Airdash.performed += context => airdashDownThisFrame = buttonDown(context);
	//     controls.PlayerControls.Airdash.canceled += context => airdashDownThisFrame = false;

	public void OnLightAttack(InputAction.CallbackContext context)
	{
		lightDownThisFrame = buttonDown(context);
	}

	//     controls.PlayerControls.Light.performed += context => lightDownThisFrame = buttonDown(context);
	//     controls.PlayerControls.Light.canceled += context => lightDownThisFrame = false;
	bool buttonDown(InputAction.CallbackContext context)
	{

		bool buttonBool;
		var control = context.control; // Grab control.
									   //var value = context.GetValue<float>(); // Read value from control.

		// Can do control-specific checks.
		var button = control as ButtonControl;
		if (button != null && button.wasPressedThisFrame)
		{
			buttonBool = true;
		}
		else
		{
			buttonBool = false;
		}

		//UnityEngine.Debug.Log(buttonBool);
		return buttonBool;
	}
	void LateUpdate()
	{
		//todo delete this
		//if (target.position != null)
		//{
		//UnityEngine.Debug.Log("target transform: " + target.root.name + ": " + target.GetInstanceID() + ": " + target.position);
		//UnityEngine.Debug.Log("current transform: " + transform.root.name + ": " + transform.GetInstanceID() + ": " + transform.position);
		//}

		
		if (target.position.x < transform.position.x && state != CharState.Dashing && IsGrounded())
		{
			//Vector2 rotation = new Vector2(.35f, .35f);
			Quaternion rotation = new Quaternion(0, 0, 0, 0);
			//mySpriteRenderer.flipX = false;
			//transform.localScale.x = transform.localScale.x * -1;
			//UnityEngine.Debug.Log("flipping rotation 180");
			transform.rotation = rotation;
			directionFacing = DirectionFacing.Left;
			
		}
		else if (target.position.x > transform.position.x && state != CharState.Dashing && IsGrounded())
		{
			//Vector2 rotation = new Vector2(-.35f, .35f);
			Quaternion rotation = new Quaternion(0, 180, 0, 0);
			//mySpriteRenderer.flipX = true;
			transform.rotation = rotation;
			directionFacing = DirectionFacing.Right;
			//UnityEngine.Debug.Log("flipping rotation -180");
			//transform.localScale.x = 1;
		}


	}



	// Update is called once per frame
	void Update()
	{

		
		//lightAttackClass.attack();

		inputSystem.getXAxisButtonDown(joystickAxis, ref horizontalDownThisFrame, ref verticalDownThisFrame);
		airdashDownThisFrame = inputSystem.getAirdashDownThisFrame(airdashDownThisFrame);
		lightDownThisFrame = inputSystem.getLightDownThisFrame(lightDownThisFrame);
		

		//UnityEngine.Debug.Log("HorizontalDown: " + horizontalDownThisFrame);
		/*
		if (pauseController.isPaused)
        {
			return;
        }
		*/
		// get inputs each frame and add them to the queue
		setInputQueue();



		switch (state)
		{
			case CharState.Normal:


				if (state == CharState.Normal)
				{
					dash();
				}
				if (state == CharState.Normal)
				{
					backDash();
				}
				// jumping is allowed, handles checking for jumps as well
				if (state == CharState.Normal)
				{
					jump();
				}
				// running is allowed, handles checking for dashes as well
				if (state == CharState.Normal)
				{
					isWalk();
				}

				if (state == CharState.Normal)
				{
					checkForLightAttack();
				}
				if(state == CharState.Normal)
                {
					crouch();
                }
				

				break;

			case CharState.Dashing:

				//if (jump()) { UnityEngine.Debug.Log("just from a dash"); }
				jump();
				if(state == CharState.Dashing) {
					checkForLightAttack();
				}
				
				if (state == CharState.Dashing)
				{
					isDashing();
					dash();
				}


				break;


			case CharState.Jump:

				aerialDrift();
				if (IsGrounded() && rigidbody2d.velocity.y <= 0)
				{
					//inputQueue.printBuffer();
					state = CharState.Normal;
					airDashState = AirDashState.Ready;
					animator.SetBool("isJumping", false);
					animator.SetBool("isGrounded", true);

				}
				else if (airdashDownThisFrame && airDashState == AirDashState.Ready)
				{
					setAirdash();
				}

				/*else
				{
					state = CharState.Jump;
				}
				*/


				break;

			case CharState.AirDash:

				airdash();
				//float airDashSpeedDropMultiplier = 5f;
				//rollSpeed -= rollSpeed * airDashSpeedDropMultiplier * Time.deltaTime;

				//float rollSpeedMinimum = 50f;
				//GetComponent<Rigidbody2D>().useGravity = false;

				rigidbody2d.gravityScale = 0;
				airdashFrames--;

				if (airdashFrames == 0)
				{
					animator.SetBool("isAirdash", false);
					animator.SetBool("isAirdashForward", false);
					animator.SetBool("isJumping", true);
					state = CharState.Jump;
					airdashFrames = AIRDASHFRAMES;

					rigidbody2d.gravityScale = 5;

					//rb.useGravity = true;
				}
				break;
		
			case CharState.Crouch:

				if (state == CharState.Crouch)
				{
					checkForLightAttack();
				}
				if (state == CharState.Crouch)
				{
					jump();
				}
				if(state == CharState.Crouch)
                {
					crouch();
                }

				break;
			case CharState.Walk:

				//dash();
				jump();
				if(state == CharState.Walk)
                {
					checkForLightAttack();
                }
				if (state == CharState.Walk)
				{
					crouch();
				}
				if (state == CharState.Walk && isWalk())
				{

					walk();
				}
				break;
			case CharState.Backdash:
				if (isBackDash())
				{
					executeBackdash();
				}
				break;
			case CharState.Block:

				blockstunFrames--;
				UnityEngine.Debug.Log("blockstun left: " + hitstunFrames);
				if (blockstunFrames <= 0)
				{
					setNormalState();

				}
				break;

			case CharState.Hitstun:

				hitstunFrames--;
				UnityEngine.Debug.Log("hitstun left: " + hitstunFrames);
				if(hitstunFrames <= 0)
                {
					setNormalState();

                }
				break;
		}


	}

	// TODO MAYBE USE FIXED UPDATE AGAIN AT SOME POINT? APPARENTLY ITS BETTER FOR PHYSICS
	/*
	private void FixedUpdate()

	{
		switch (state) {
			case CharState.Normal:
				
				// jumping is allowed
				jump();
				// running is allowed
				dash();
		
					//anim.SetBool("isWalking", false);
				
					//anim.SetBool("isRunning", false);
					//anim.SetBool("isJumping", false);
				
				break;

			case CharState.Jump:



                //if (IsGrounded() && rigidbody2d.velocity.y <= 0)
                //{
                //    state = CharState.Normal;
                //    airDashState = AirDashState.Ready;
                //    anim.SetBool("isJumping", false);
                //    anim.SetBool("isGrounded", true);

                //}
                //else if (Input.GetButtonDown("Block") && airDashState == AirDashState.Ready)
                //{
                //    //airDash();
                //    airDashState = AirDashState.NA;
                //    state = CharState.AirDash;
                //    anim.SetBool("isAirdash", true);
                //    anim.SetBool("isJumping", false);

                //    if (Input.GetAxisRaw("Horizontal") > .1)
                //    {
                //        rigidbody2d.velocity = Vector2.zero;

                //        airDashDirection = AirDashDirection.Right;

                //    }
                //    else if (Input.GetAxisRaw("Horizontal") < -.1)
                //    {

                //        rigidbody2d.velocity = Vector2.zero;

                //        airDashDirection = AirDashDirection.Left;

                //    }
                //    else
                //    {
                //        rigidbody2d.velocity = Vector2.zero;

                //        airDashDirection = AirDashDirection.Neutral;
                //    }
                //}
                //else
                //{
                //    state = CharState.Jump;
                //}
                break;

			case CharState.Dashing:

			//	dash();
			//	jump();
			//	if(IsGrounded() && rigidbody2d.velocity.x < 10 && rigidbody2d.velocity.x > -10)
   //             {
			//		state = CharState.Normal;
			//		anim.SetBool("isIdle", true);
   //             }
			//	//else if()
			//	break;
			//case CharState.AirDash:

			//	if (airDashDirection == AirDashDirection.Right)
			//	{
			//		transform.position = new Vector2(transform.position.x + .30f, transform.position.y);
					

			//	}
			//	else
   //             {
			//		transform.position = new Vector2(transform.position.x - .30f, transform.position.y);
				
			//	}

				break;
		}
	}
	*/

	public long getElapsedTimeBetweenInputs(long first, long last)
	{

		return first - last;
	}

	//todo make this syncronous
	private async Task setInputQueue()
	{
		foreach (string key in keys)
		{
			// basically, each key takes turns checking if it needs to be added to the queue, when it's the axes turns 
			// you gotta use a special function but for the rest of the keys you can use getbuttondown
			// 
			// Input.GetButtonDown(key)
	
	
			if ((key == "Airdash" && airdashDownThisFrame) || (key == "Light" && lightDownThisFrame) || (key == "Joystick" && (horizontalDownThisFrame || verticalDownThisFrame)))
			{


				if (key == "Joystick" && joystickAxis.x > 0.1 && joystickAxis.y > 0.1f)
				{
					inputQueue.Enqueue("UpRight");
					UnityEngine.Debug.Log("upright enqueed");
				}
				else if (key == "Joystick" && joystickAxis.x < -0.1 && joystickAxis.y > 0.1f)
				{
					UnityEngine.Debug.Log("upleft enqueed");
					inputQueue.Enqueue("UpLeft");
				}
				else if (key == "Joystick" && joystickAxis.x > 0.1 && joystickAxis.y < -0.1f)
				{
					inputQueue.Enqueue("DownRight");
					UnityEngine.Debug.Log("downright enqueed");
				}
				else if (key == "Joystick" && joystickAxis.x < -0.1 && joystickAxis.y < -0.1f)
				{
					inputQueue.Enqueue("DownLeft");
					UnityEngine.Debug.Log("downleft enqueed");
				}
				else if (key == "Joystick" && joystickAxis.x > 0.1 )
				{
					inputQueue.Enqueue("Right");
					UnityEngine.Debug.Log("Right enqueed");
				}
				else if (key == "Joystick" && joystickAxis.x < -0.1 )
				{
					inputQueue.Enqueue("Left");
					UnityEngine.Debug.Log("Left enqueed");
				}
				else if (key == "Joystick" && joystickAxis.y > 0.1)
				{
					UnityEngine.Debug.Log("jump enqueed from vertical axis");
					inputQueue.Enqueue("Up");
				}
				else if (key == "Joystick" && joystickAxis.y < -0.1)
				{
					inputQueue.Enqueue("Down");
					UnityEngine.Debug.Log("Down enqueed");
				}

				else if (key != "Joystick")
				{
					UnityEngine.Debug.Log(key);
					inputQueue.Enqueue(key);
				}

			}


		}
	}


	public void setNormalState()
    {
		state = CharState.Normal;
		animator.SetBool("isJumping", false);
		animator.SetBool("isGrounded", false);
		animator.SetBool("isIdle", true);
		animator.SetBool("isRunning", false);
		animator.SetBool("isWalking", false);
		animator.SetBool("isLightAttack", false);
		animator.SetBool("isBlocking", false);
		//animator.SetBool("wasHitOnGround", false);
	}

	// TODO: CHANGE TO VOID
	// todo: allow jumps from analog stick/vertical axis
	private bool jump()
	{
		//store the 2 most recent inputs to check if they are left-left or right-right
		List<InputTime> jumpInputs = new List<InputTime>();
		jumpInputs = inputQueue.getTopInputs(1);
		long elapsedTime = -1;
		if (jumpInputs.Count == 1)
		{
			elapsedTime = getElapsedTimeBetweenInputs(inputQueue.getCurrentTime(), jumpInputs[0].elapsedMilliseconds);
		}

		if ((jumpInputs.Count != 0 && (jumpInputs[0].input == "Jump" || jumpInputs[0].input == "Up" || jumpInputs[0].input == "UpRight" || jumpInputs[0].input == "UpLeft") && elapsedTime < 100)
			&& IsGrounded()) //|| Input.GetButtonDown("Jump")
		{

			// set jump states

			animator.SetBool("isJumping", true);
			animator.SetBool("isGrounded", false);
			animator.SetBool("isIdle", false);
			animator.SetBool("isRunning", false);
			animator.SetBool("isWalking", false);
			animator.SetBool("isCrouching", false);
			// give jump velocity
			//float jumpVelocity = 20f;
			if ((state == CharState.Walk || state == CharState.Normal) && jumpInputs[0].input == "UpLeft")
			{
				UnityEngine.Debug.Log("diag jump");
				rigidbody2d.velocity = (Vector2.left * jumpVelocity * .3f) + (Vector2.up * jumpVelocity);
			}
			else if ((state == CharState.Walk || state == CharState.Normal) && jumpInputs[0].input == "UpRight")
			{
				UnityEngine.Debug.Log("diag jump");
				rigidbody2d.velocity = (Vector2.right * jumpVelocity * .3f) + (Vector2.up * jumpVelocity);
			}
			else
			{
				UnityEngine.Debug.Log("noormal jump");
				rigidbody2d.velocity = rigidbody2d.velocity * .8f + (Vector2.up * jumpVelocity);
			}



			state = CharState.Jump;
			return true;
		}
		else
		{

			return false;
		}
	}

	private void aerialDrift()
	{
		if (rigidbody2d.velocity.x < MAXAIRDRIFTSPEED && rigidbody2d.velocity.x > -1 * MAXAIRDRIFTSPEED)
		{
			rigidbody2d.velocity = rigidbody2d.velocity + (Vector2.right * joystickAxis.x * AIRDRIFTMULTIPLIER);
		}


	}

	// TODO: CHANGE TO VOID
	// TODO: CHANGE ALL MOVEMENT FORMULAS TO USE TIME SINCE LAST FRAME SO THAT MOVEMENT WILL BE CONSISTENT	
	private bool dash()
	{

		//store the 2 most recent inputs to check if they are left-left or right-right
		List<InputTime> dashInputs = new List<InputTime>();
		dashInputs = inputQueue.getTopInputs(2);
		long elapsedTime = -1;
		if (dashInputs.Count == 2)
		{
			elapsedTime = getElapsedTimeBetweenInputs(dashInputs[0].elapsedMilliseconds, dashInputs[1].elapsedMilliseconds);
		}


		if ((state != CharState.Dashing && state != CharState.Normal && state != CharState.Walk) || dashInputs.Count != 2 || elapsedTime == -1)
		{
			return false;
		}
		// if you are running in the direction of the other character
		// check that the analog stick is far enough towards 1 and that it is in the direction of the enemy
		else if (elapsedTime < 250 &&
				((dashInputs[0].input == "Right" && dashInputs[1].input == "Right" && joystickAxis.x > .85 && target.position.x > transform.position.x) ||
				(dashInputs[0].input == "Left" && dashInputs[1].input == "Left" && joystickAxis.x < -.85 && target.position.x < transform.position.x)))
		{

			// set the correct animations and state
			state = CharState.Dashing;
			animator.SetBool("isRunning", true);
			animator.SetBool("isJumping", false);
			animator.SetBool("isWalking", false);

			// apply velocity to the rigidbody in the direction of the enemy
			if (target.position.x > transform.position.x)
			{
				rigidbody2d.velocity = Vector2.right * moveSpeed;
			}
			else
			{
				rigidbody2d.velocity = Vector2.left * moveSpeed;
			}

			// return true to say that the requirements for running were met
			// TODO: THIS COULD PROBABLY BE LEFT OUT AND JUST USE THE CHARSTATE INSTEAD
			return true;
		}

		else
		{
			return false;
		}



	}
	// TODO CHANGE TO VOID
	private bool backDash()
	{
		//store the 2 most recent inputs to check if they are left-left or right-right
		List<InputTime> dashInputs = new List<InputTime>();
		dashInputs = inputQueue.getTopInputs(2);
		long elapsedTime = -1;
		long timeSinceInput = -1;
		if (dashInputs.Count == 2)
		{
			elapsedTime = getElapsedTimeBetweenInputs(dashInputs[0].elapsedMilliseconds, dashInputs[1].elapsedMilliseconds);
			timeSinceInput = getElapsedTimeBetweenInputs(inputQueue.getCurrentTime(), dashInputs[0].elapsedMilliseconds);
		}



		// make sure that the char isnt in a bad state and that the elapsed time and inputs have values
		if ((state != CharState.Dashing && state != CharState.Normal && state != CharState.Walk && state != CharState.Backdash) || dashInputs.Count != 2 || elapsedTime == -1)
		{
			return false;
		}

		else if (elapsedTime < 250 && timeSinceInput < 3 && ((dashInputs[0].input == "Right" && dashInputs[1].input == "Right" && joystickAxis.x > .85 && target.position.x < transform.position.x) ||
				(dashInputs[0].input == "Left" && dashInputs[1].input == "Left" && joystickAxis.x < -.85 && target.position.x > transform.position.x)))
		{
			// set the correct animations and state
			state = CharState.Backdash;
			animator.SetBool("isRunning", false);
			animator.SetBool("isBackDashing", true);
			animator.SetBool("isJumping", false);
			animator.SetBool("isWalking", false);


			return true;
		}
		else
		{
			return false;
		}

	}
	void executeBackdash()
	{

		rigidbody2d.velocity = Vector2.zero; ;
		// apply velocity to the rigidbody in the direction of the enemy
		if (target.position.x > transform.position.x)
		{
			transform.position = new Vector2(transform.position.x + (BACKDASHSPEED * -1), transform.position.y);
		}
		else
		{
			transform.position = new Vector2(transform.position.x + BACKDASHSPEED, transform.position.y);
		}


	}
	// TODO CHANGE TO VOID
	private bool isBackDash()
	{
		if (backdashFrames >= 0)
		{
			backdashFrames--;
			return true;
		}
		else
		{
			state = CharState.Normal;
			animator.SetBool("isBackDashing", false);
			backdashFrames = BACKDASHFRAMES;
			return false;
		}
	}
	private void checkForLightAttack()
    {
		if (lightDownThisFrame)
		{
			state = CharState.LightAttack;
			animator.SetBool("isLightAttack", true);
			animator.SetBool("isRunning", false);
			animator.SetBool("isBackDashing", false);
			animator.SetBool("isJumping", false);
			animator.SetBool("isWalking", false);
			
		}
    }
	public bool wasAttackBlocked(BlockType blockType, int blockStun)
    {
		//holding back, attack hits mid
		if(blockType == BlockType.Mid && (
			(joystickAxis.x > 0.5 && directionFacing == DirectionFacing.Left) ||
			(joystickAxis.x < -0.5 && directionFacing == DirectionFacing.Right))){

			UnityEngine.Debug.Log("mid attack blocked!");
			setBlockstunState();
			calculateBlockstunLength(blockStun);
			return true;
        }
		//holding down back back, attack hits low
		else if (blockType == BlockType.Low && (
			(joystickAxis.x > 0.5 && joystickAxis.y < -0.5f && directionFacing == DirectionFacing.Left) || 
			(joystickAxis.x < -0.5 && joystickAxis.y < -0.5f && directionFacing == DirectionFacing.Right))) // target.position.x < transform.position.x
		{

			setBlockstunState();
			calculateBlockstunLength(blockStun);
			return true;
		}
		// holding back but not down, attack hits overhead
		else if(blockType == BlockType.Overhead && 
			(joystickAxis.x > 0.5 && joystickAxis.y >= -0.5f && directionFacing == DirectionFacing.Left) ||
			(joystickAxis.x < -0.5 && joystickAxis.y >= -0.5f && directionFacing == DirectionFacing.Right)) {

			setBlockstunState();
			calculateBlockstunLength(blockStun);
			return true;
		}
        else
        {
			return false;
        }
		
	
	}

	public void calculateBlockstunLength(int blockstun)
	{
		blockstunFrames = blockstun;

	}
	public void setBlockstunState()
    {
		state = CharState.Block;

		animator.SetBool("isBlocking", true);
		animator.SetBool("isLightAttack", false);
		animator.SetBool("isRunning", false);
		animator.SetBool("isBackDashing", false);
		animator.SetBool("isJumping", false);
		animator.SetBool("isWalking", false);
		animator.SetBool("isIdle", false);

	}

	public void setHitstunState(int damage, int hitstun)
    {
		state = CharState.Hitstun;
		animator.SetTrigger("wasHitOnGround");
		animator.SetBool("isLightAttack", false);
		animator.SetBool("isRunning", false);
		animator.SetBool("isBackDashing", false);
		animator.SetBool("isJumping", false);
		animator.SetBool("isWalking", false);
		animator.SetBool("isIdle", false);



		UnityEngine.Debug.Log("health left = " + health + ": " + damage);
		health = health - damage;

		UnityEngine.Debug.Log("health left = " + health + ": " + damage);
		calculateGroundedHitsunLength(hitstun);
		if (health <= 0)
		{
			animator.SetBool("isDead", true);
			hurtbox.enabled = false;
			boxCollider2d.enabled = false;
			enabled = false;
		}
	

	}
	

	// todo apply hitstun decay
	public void calculateGroundedHitsunLength(int hitstun)
    {
		hitstunFrames = hitstun;
    }

	

	// TODO CHANGE TO VOID
	private bool isDashing()
	{

		if (IsGrounded() && (rigidbody2d.velocity.x > 10 || rigidbody2d.velocity.x < -10) &&
			(state == CharState.Dashing || state == CharState.Normal || state == CharState.Walk))
		{
			state = CharState.Dashing;
			//anim.SetBool("isIdle", false);
			animator.SetBool("isRunning", true);
			animator.SetBool("isJumping", false);
			animator.SetBool("isGrounded", true);
			animator.SetBool("isIdle", false);
			return true;
		}
		//else if (dashFrames != 0)
		//{
		//	dashFrames--;
		//}
		else
		{
			animator.SetBool("isRunning", false);
			state = CharState.Normal;
			dashFrames = DASHFRAMES;
			return false;
		}

	}

	private void walk()
	{
		if (joystickAxis.x > .1 || joystickAxis.x < -.1)
		{
			state = CharState.Walk;
			animator.SetBool("isWalking", true);

			transform.position = new Vector2(transform.position.x + (WALKSPEED * joystickAxis.x * Time.deltaTime), transform.position.y);

		}

	}
	

	// TODO CHANGE TO VOID
	private bool isWalk()
	{

		// if the analog stick is being held between a certain range for a certain number of frames, PREWALKFRAMES, then start walking
		if (prewalkframes == 0 && IsGrounded() &&
			(joystickAxis.x > .1 || joystickAxis.x < -.1))// && 
														  //(Input.GetAxisRaw("Horizontal") < .75 || Input.GetAxisRaw("Horizontal") > -.75))
		{
			//prewalkframes = PREWALKFRAMES;
			animator.SetBool("isWalking", true);
			animator.SetBool("isRunning", false);
			animator.SetBool("isJumping", false);
			animator.SetBool("isIdle", false);
			state = CharState.Walk;

			return true;
		}
		else if (IsGrounded() && (joystickAxis.x > .1 || joystickAxis.x < -.1) &&
			 (joystickAxis.x < .75 || joystickAxis.x > -.75))
		{
			prewalkframes--;
			return false;
		}
		else
		{
			prewalkframes = PREWALKFRAMES;
			state = CharState.Normal;

			animator.SetBool("isWalking", false);
			return false;
		}
	}


	// TODO ADD ANIMATION
	private void crouch()
	{

		// check for crouch
		if (joystickAxis.y < -.2)
		{
			state = CharState.Crouch;
			animator.SetBool("isCrouching", true);
		}
        else
        {
            //state = CharState.Normal;
            animator.SetBool("isCrouching", false);

        }
    }
	

	private void idle()
	{
		if (IsGrounded() && rigidbody2d.velocity.x < 10 && rigidbody2d.velocity.x > -10)
		{
			state = CharState.Normal;
			animator.SetBool("isIdle", true);
			animator.SetBool("isRunning", false);
		}
	}

	private void airdash()
	{
		if (airDashDirection == AirDashDirection.Right)
		{
			transform.position = new Vector2(transform.position.x + AIRDASHSPEED, transform.position.y);
			rigidbody2d.velocity = Vector2.right * AIRDASHVELOCITY;
			//AIRDASHSPEED;

		}
		else if (airDashDirection == AirDashDirection.Left)
		{
			rigidbody2d.velocity = Vector2.left * AIRDASHVELOCITY;
			//AIRDASHSPEED;
			transform.position = new Vector2(transform.position.x - AIRDASHSPEED, transform.position.y);

		}

	}

	private void setAirdash()
	{


		// character facing left and airdashing right
		if (joystickAxis.x > .1 && directionFacing == DirectionFacing.Left ) // target.position.x < transform.position.x
		{
			// TODO: CHANGE THE NAMING OF THE AIRDASH BOOLEANS
			airDashState = AirDashState.NA;
			state = CharState.AirDash;
			airDashDirection = AirDashDirection.Right;

			animator.SetBool("isJumping", false);
			animator.SetBool("isAirdash", true);
			rigidbody2d.velocity = Vector2.zero;


		}
		// character facing right and airdashing right
		else if (joystickAxis.x > .1 && directionFacing == DirectionFacing.Right)// transform.position.x < target.position.x
		{
			// TODO: CHANGE THE NAMING OF THE AIRDASH BOOLEANS
			airDashDirection = AirDashDirection.Right;
			airDashState = AirDashState.NA;
			state = CharState.AirDash;

			rigidbody2d.velocity = Vector2.zero;
			animator.SetBool("isAirdashForward", true);
			animator.SetBool("isJumping", false);



		}
		// character facing right and airdashing left
		else if (joystickAxis.x < -.1 && directionFacing == DirectionFacing.Right) // transform.position.x < target.position.x
		{
			airDashState = AirDashState.NA;
			state = CharState.AirDash;
			airDashDirection = AirDashDirection.Left;

			rigidbody2d.velocity = Vector2.zero;
			animator.SetBool("isAirdash", true);
			animator.SetBool("isJumping", false);

		}
		// character facing left and airdashing left
		else if (joystickAxis.x < -.1 && directionFacing == DirectionFacing.Left) // target.position.x < transform.position.x
		{
			airDashDirection = AirDashDirection.Left;
			airDashState = AirDashState.NA;
			state = CharState.AirDash;

			rigidbody2d.velocity = Vector2.zero;
			animator.SetBool("isAirdashForward", true);
			animator.SetBool("isJumping", false);

		}



	}

	private bool IsGrounded()
	{
		//return transform.Find("GroundCheck").GetComponent<GroundCheck>().isGrounded;

		
		float extraHeightText = .1f;
		RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, extraHeightText, platformLayerMask);

		Color rayColor;
		if (raycastHit.collider != null)
		{
			rayColor = Color.green;
			//UnityEngine.Debug.Log("isgrounded triggered");
		}
		else
		{
			rayColor = Color.red;
			IsOnOtherPlayer(); 
		}
        UnityEngine.Debug.DrawRay(boxCollider2d.bounds.center + new Vector3(boxCollider2d.bounds.extents.x, 0), Vector2.down * (boxCollider2d.bounds.extents.y + extraHeightText), rayColor);
        UnityEngine.Debug.DrawRay(boxCollider2d.bounds.center - new Vector3(boxCollider2d.bounds.extents.x, 0), Vector2.down * (boxCollider2d.bounds.extents.y + extraHeightText), rayColor);
        UnityEngine.Debug.DrawRay(boxCollider2d.bounds.center - new Vector3(boxCollider2d.bounds.extents.x, boxCollider2d.bounds.extents.y + extraHeightText), Vector2.right * (boxCollider2d.bounds.extents.x * 2f), rayColor);

        return raycastHit.collider != null;
	}
	private bool IsOnOtherPlayer()
	{
		
		float extraHeightText = .1f;
		ContactFilter2D contactFilter = new ContactFilter2D();
		contactFilter.useTriggers = false;
		contactFilter.SetLayerMask(playerLayerMask);
		List<RaycastHit2D> raycastHits = new List<RaycastHit2D>();
		int numberHit = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, contactFilter, raycastHits,  extraHeightText);
		Vector2 verticalNormal = new Vector2(0, 1);
		//UnityEngine.Debug.Log(raycastHit.normal.x + ":" + raycastHit.normal.y);
		Color rayColor = Color.red;
		if (raycastHits.Count != 0 && rigidbody2d.velocity.y < 0.1 )
		{
			foreach(RaycastHit2D raycastHit in raycastHits)
            {
				if(raycastHit.normal == verticalNormal && raycastHit.collider.sharedMaterial.name == "pushbox")
                {
					UnityEngine.Debug.Log("is on other player triggered");
					rayColor = Color.green;

					// enemy is to the left
					if (target.position.x > transform.position.x)
					{
						//float shift = target.position.x - transform.position.x;
						float shift = (enemyBoxCollider2d.bounds.size.x + .1f); //- (target.position.x - transform.position.x)) ;
						transform.position = new Vector2(target.position.x - shift, transform.position.y - .2f);
					}
					else
					{
						//float shift = target.position.x - transform.position.x;
						float shift = (enemyBoxCollider2d.bounds.size.x + .1f); //- (target.position.x - transform.position.x)) ;
						transform.position = new Vector2(target.position.x + shift, transform.position.y - .2f);
					}

				}
				else
				{
					rayColor = Color.red;
				}
			}
			


		}
		else
		{
			rayColor = Color.red;
		}
		
		UnityEngine.Debug.DrawRay(boxCollider2d.bounds.center + new Vector3(boxCollider2d.bounds.extents.x, 0), Vector2.down * (boxCollider2d.bounds.extents.y + extraHeightText), rayColor);
		UnityEngine.Debug.DrawRay(boxCollider2d.bounds.center - new Vector3(boxCollider2d.bounds.extents.x, 0), Vector2.down * (boxCollider2d.bounds.extents.y + extraHeightText), rayColor);
		UnityEngine.Debug.DrawRay(boxCollider2d.bounds.center - new Vector3(boxCollider2d.bounds.extents.x, boxCollider2d.bounds.extents.y + extraHeightText), Vector2.right * (boxCollider2d.bounds.extents.x * 2f), rayColor);


		return raycastHits.Count != 0;
	}



}
