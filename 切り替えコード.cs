using UnityEngine;
using UnityEngine.SceneManagement; // シーン切り替えに必要な呪文です

public class SceneChanger : MonoBehaviour
{
    // ボタンから呼び出される命令
    public void GoToNext()
    {
        // "Scene2" の部分を、あなたが作った「移動先のシーンの名前」に書き換えてください
        SceneManager.LoadScene("Scene2");
    }
}