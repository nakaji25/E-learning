using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;//追加
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Judge : MonoBehaviour
{
    // eventSystem型の変数を宣言　
    private EventSystem eventSystem;

    //GameObject型の変数を宣言　ボタンオブジェクトを入れる箱
    private GameObject button_ob;

    //GameObject型の変数を宣言　テキストオブジェクトを入れる箱
    private GameObject NameText_ob;

    //Text型の変数を宣言　テキストコンポーネントを入れる箱
    private Text selected_Button;

    //選択したボタンのテキストラベルと正解のテキストを比較して正誤を判定
    public void JudgeAnswer()
    {
        //選択したボタンのテキストラベルを取得する

        //有効なイベントシステムを取得
        eventSystem = EventSystem.current;

        //押されたボタンのオブジェクトをイベントシステムのcurrentSelectedGameObject関数から取得　
        button_ob = eventSystem.currentSelectedGameObject;

        //ボタンの子のテキストオブジェクトを名前指定で取得 この場合Text100と名前が付いているテキストオブジェクトを探す
        NameText_ob = button_ob.transform.Find("ButtonText").gameObject;

        //テキストオブジェクトのテキストを取得
        selected_Button = NameText_ob.GetComponent<Text>();

        if (selected_Button.text == EnglishQuestionManager.answer)
        {
            ResultManager.SetJudgeData("正解");
            SceneManager.LoadScene("ResultScene");
        }
        else
        {
            ResultManager.SetJudgeData("不正解");
            SceneManager.LoadScene("ResultScene");
        }
    }
}
