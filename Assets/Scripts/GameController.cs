﻿using System.Collections;
    public AudioSource gameOverSfx;
    public AudioSource gameStartSfx;
    public AudioSource loseAuctionSfx;
        player1 = Instantiate(playerPrefab, new Vector3(-33f, 13.0f, 0), Quaternion.identity);
        //player2.GetComponent<Pathfinding.AIPath>().destination = new Vector3(33.5f, 15.6f, 0);
        //player2.GetComponent<Pathfinding.AIPath>().destination = new Vector3(-52.6f, 5.11f, 0);
        player2.GetComponent<Pathfinding.AIPath>().destination = new Vector3(0, 0, 0);
        //If there's any global logic that needs to be handled for these, go ahead and do it.
        if (Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    {
        if (currentState == GameStates.GamePause &&
            !MenuToggle.Instance.StartScreen.activeSelf)
        {
            Time.timeScale = 1;
            currentState = savedState;
            gameStartSfx.Play();
            MenuToggle.Instance.StartScreen.activeSelf)
        {
            Time.timeScale = 0;
            savedState = currentState;
            currentState = GameStates.GamePause;
        }
        return currentState;
    }
            beginAuction)
            }
    {
        if (currentState == GameStates.FreePlay &&
            (MenuToggle.Instance.timer >= MenuToggle.GAME_DURATION ||  // Timed out
            player1.GetComponentInChildren<HealthBar>().currentHealth <= 0.0f ||  // Or player 1 died
            player2.GetComponentInChildren<HealthBar>().currentHealth <= 0.0f))  // Or player 2 died
        {
            currentState = player1.GetComponent<CompletePlayerController>().currentScore > player2.GetComponentInChildren<CompletePlayerController>().currentScore ? GameStates.GameVictory : GameStates.GameDefeat;
            gameOverSfx.Play();
        }
        return currentState;
    }