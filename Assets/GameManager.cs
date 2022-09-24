using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Block[] blocks;
    public GameObject gameOverUI;
    public GameObject gameClearUI;

    private bool isGameClear = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameClear != true)
        {
            if(DestroyAllBlocks())
            {
                //game clear
                Debug.Log("GameClear");
                gameClearUI.SetActive(true);
                isGameClear = true;
            }
        }

    }

    //blockが全部消えたか
    private bool DestroyAllBlocks()
    {
        foreach (Block b in blocks)
        {
            if(b != null)
            {
                return false;
            }
        }
        return true;
    }

    //ゲームオーバー時
    public void GameOver()
    {
        Debug.Log("GameOver");
        gameOverUI.SetActive(true);
    }

    //最初から
    public void GameRetry()
    {
        SceneManager.LoadScene("game");
    }
}
