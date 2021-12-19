using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    //他のスクリプトからも参照可能な変数宣言
    // 正誤データ
    public static string g_judgeData;

    // 得点データ
    public static int g_scoreData;

    // 問題回数
    public static int qCount;

    void Start()
    {
        //デフォルトは正解、不正解なら画像と文言を切り替える
        if (g_judgeData == "不正解")
        {
            /*//現在描画している画像を取得
            SpriteRenderer judgeImage = GameObject.Find("Canvas/JudgeText").GetComponent<SpriteRenderer>();
            //Resourcesから指定した名前の画像データをロード
            Sprite loadingImage = Resources.Load<Sprite>("batsu");
            //画像を置換
            judgeImage.sprite = loadingImage;*/
            //表示テキストを取得して置換
            Text judgeLabel = GameObject.Find("Canvas/JudgeText").GetComponent<Text>();
            judgeLabel.text = "不正解...";
        }
        else if (g_judgeData == "正解")
        {
            //正解であればScoreを足す
            g_scoreData++;
        }
    }
    public static int GetqCount()
    {
        return qCount;
    }
    public static int GetScoreData()
    {
        return g_scoreData;
    }
    //グローバルに宣言したスコアを他のスクリプトから書き込む
    public static int SetScoreData(int scoreData)
    {
        g_scoreData = scoreData;
        return g_scoreData;
    }
    //他のスクリプトからも参照可能な関数宣言
    public static void SetJudgeData(string judgeData)
    {
        g_judgeData = judgeData;
    }

    public void PushNextButton()
    {
        if (qCount < 4)
        {
            qCount++;
            SceneManager.LoadScene("EnglishQuestionScene");
        }
        else
        {
            qCount = 0;
            SceneManager.LoadScene("ScoreScene");
        }
    }

}
