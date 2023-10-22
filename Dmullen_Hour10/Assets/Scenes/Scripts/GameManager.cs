using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript Blue, Green, Red, Orange;
    public EvilOne Bumper; 
    private bool isLose = true;
    private bool isGameOver = true;
    void Update()
    {
        isGameOver = Blue.isSolved && Green.isSolved && Red.isSolved && Orange.isSolved;
        isLose = Bumper.isGood;
    }
   void OnGUI()
   {
          if(isGameOver)
          {
                Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75 );
                GUI.Box(rect, "Game Over");
                Rect rect2 = new Rect (Screen.width / 2-30, Screen.height/ 2 - 25, 60, 50);
                GUI.Label(rect2, "Good Job!");
          }
          if(isLose)
          {
                Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75 );
                GUI.Box(rect, "Game Over");
                Rect rect2 = new Rect (Screen.width / 2-30, Screen.height/ 2 - 25, 60, 50);
                GUI.Label(rect2, "Avoid the EvilBall!");               
          }

   }
}
