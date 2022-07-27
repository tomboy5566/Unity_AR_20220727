using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace KuanLun
{
    public class CardHandler : MonoBehaviour
    {
        [SerializeField, Header("KID�Ϥ�")]
        private DefaultObserverEventHandler observerKID;
        [SerializeField, Header("�ʵe���")]
        private Animator ani;
        [SerializeField, Header("�������s")]
        private Button attackButton;
        [SerializeField, Header("�������䨫��")]
        private VirtualButtonBehaviour vbbRun;

        private string parVictory = "�ӧQĲ�o";
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
            print("�]�_�Ӱ�!�b�V��!");
        }

        private void CardFound()
        {
            print("���d��");
            ani.SetTrigger(parVictory);
            audBGM.Play();
        }
        private void CardLost()
        {
            print("�L�k�����d��");
            audBGM.Stop();
        }
        private void Attack()
        {
            print("�@�w��A��٥��_");
        }
    }
}
