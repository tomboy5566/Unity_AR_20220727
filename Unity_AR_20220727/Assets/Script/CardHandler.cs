using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace KuanLun
{
    public class CardHandler : MonoBehaviour
    {
        [SerializeField, Header("KID圖片")]
        private DefaultObserverEventHandler observerKID;
        [SerializeField, Header("動畫控制器")]
        private Animator ani;
        [SerializeField, Header("攻擊按鈕")]
        private Button attackButton;
        [SerializeField, Header("虛擬按鍵走路")]
        private VirtualButtonBehaviour vbbRun;

        private string parVictory = "勝利觸發";
        private AudioSource audBGM;

        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);
            observerKID.OnTargetLost.AddListener(CardLost);
            attackButton.onClick.AddListener(Attack);
            vbbRun.RegisterOnButtonPressed(OnRunPressed);
            audBGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        }

        private void OnRunPressed(VirtualButtonBehaviour obj)
        {
            print("跑起來啊!在混啊!");
        }

        private void CardFound()
        {
            print("找到卡片");
            ani.SetTrigger(parVictory);
            audBGM.Play();
        }
        private void CardLost()
        {
            print("無法偵測卡片");
            audBGM.Stop();
        }
        private void Attack()
        {
            print("一定把你鼻樑打斷");
        }
    }
}
