using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //スコア表示用のゲームオブジェクトを取得
        Text scoreLabel = GameObject.Find("Canvas/Score").GetComponent<Text>();
        scoreLabel.color = Color.red;
        //グローバルに宣言したスコアをResultMgrのスクリプトから読み込む
        int Score = ResultManager.GetScoreData();
        scoreLabel.text = Score.ToString() + " 点";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PushMenuButton()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
