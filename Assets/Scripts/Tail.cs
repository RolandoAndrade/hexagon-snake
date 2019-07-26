using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    private int n = 0;
    private Board board;
    private Snake snake;
    private Vector2 firstPos, secondPos;
    private Vector3 currentSwipe;
	void Start ()
    {
        snake = new Snake();
        board = new Board(gameObject.GetComponentsInChildren<SpriteRenderer>(),snake);
	}
	/*UP=-1
     DOWN=+1
     RIGHT=+14
     LEFT=-14*/
	// Update is called once per frame

    
	void Update ()
    {

        if(n==0)
        {
            board.Update();
        }
        n = (n + 1) % 10;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
                snake.ChangeDirection(new LeftDown());
            else if (Input.GetKey(KeyCode.RightArrow))
                snake.ChangeDirection(new RightDown());
            else
                snake.ChangeDirection(new Down());

        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
                snake.ChangeDirection(new LeftUp());
            else if (Input.GetKey(KeyCode.RightArrow))
                snake.ChangeDirection(new RightUp());
            else
                snake.ChangeDirection(new Up());
        }
        Swipe();

	}/*
    public void Swipe()
    {
        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
            {
                //save began touch 2d point
                firstPos = new Vector2(t.position.x, t.position.y);
            }
            if (t.phase == TouchPhase.Ended)
            {
                //save ended touch 2d point
                secondPos = new Vector2(t.position.x, t.position.y);

                //create vector from the two points
                currentSwipe = new Vector3(secondPos.x - firstPos.x, secondPos.y - firstPos.y);

                //normalize the 2d vector
                currentSwipe.Normalize();

                //swipe upwards
                if (currentSwipe.y > 0 && currentSwipe.x > -0.5f && currentSwipe.x < 0.5f)
             {
                    Debug.Log("up swipe");
                }
                //swipe down
                if (currentSwipe.y < 0 && currentSwipe.x > -0.5f  &&currentSwipe.x < 0.5f)
             {
                    Debug.Log("down swipe");
                }
                //swipe left
                if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
             {
                    Debug.Log("left swipe");
                }
                //swipe right
                if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
             {
                    Debug.Log("right swipe");
                }
            }
        }
    }*/
    public void Swipe()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //save began touch 2d point
            firstPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        if (Input.GetMouseButtonUp(0))
        {
            //save ended touch 2d point
            secondPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            //create vector from the two points
            currentSwipe = new Vector2(secondPos.x - firstPos.x, secondPos.y - firstPos.y);

            //normalize the 2d vector
            currentSwipe.Normalize();

            if (currentSwipe.y > 0)
            {
                if (currentSwipe.x > 0.5f)
                    snake.ChangeDirection(new RightUp());
                else if (currentSwipe.x < -0.5f)
                    snake.ChangeDirection(new LeftUp());
                else
                    snake.ChangeDirection(new Up()) ;

            }
            //swipe down
            if (currentSwipe.y < 0)
            {
                if (currentSwipe.x > 0.5f)
                    snake.ChangeDirection(new RightDown());
                else if (currentSwipe.x < -0.5f)
                    snake.ChangeDirection(new LeftDown());
                else
                    snake.ChangeDirection(new Down());
            }
        }
    }
}
