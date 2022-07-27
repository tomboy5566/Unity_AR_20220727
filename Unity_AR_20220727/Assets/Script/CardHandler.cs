using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KuanLun
{
    public class CardHandler : MonoBehaviour
    {
        [SerializeField, Header("KID圖片")]
        private DefaultObserverEventHandler observerKID;


        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);
            observerKID.OnTargetLost.AddListener(CardLost);
        }

        private void CardFound()
        {
            print("找到卡片");
        }
        private void CardLost()
        {
            print("無法偵測卡片");
        }
    }
}
