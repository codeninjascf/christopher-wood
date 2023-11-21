using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Level level;
    public GridManager gridManager;
    
    private bool _gameEnded;

    void Start()
    {
        _gameEnded = false;
    }

    void Update()
    {
       if(level.GameOver && gridManager.MoveComplete && !_gameEnded)
       {
            _gameEnded = true;

            level.UpdateHighScore(gridManager.Score);
            level.UpdateStarsAchieved(gridManager.Score);
       } 
    }

    void LateUpdate()
    {
        if (gridManager.MadeMove)
        {
            level.MovesRemaining--;
        }
    }
}





