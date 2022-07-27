using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KuanLun
{
    public class CardHandler : MonoBehaviour
    {
        [SerializeField, Header("KID�Ϥ�")]
        private DefaultObserverEventHandler observerKID;


        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);
            observerKID.OnTargetLost.AddListener(CardLost);
        }

        private void CardFound()
        {
            print("���d��");
        }
        private void CardLost()
        {
            print("�L�k�����d��");
        }
    }
}
