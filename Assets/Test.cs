using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        // �ϐ�������
        int money = 100;

        if(money <= 50)
        {
            // money��50�ȉ��������ꍇ
            Debug.Log("����𔄂�");
        }
        else if(money >= 200)
        {
            // money��200�ȏゾ�����ꍇ
            Debug.Log("����𔃂�");
        }
        else
        {
            // ����ȊO�̏ꍇ�̏���
            Debug.Log("�|�[�V�����𔃂�");
        }*/

        /*
        // num��1�ŏ���������
        int num = 1;

        // val�ɑ������l�������ɂ���ĕς���(�O�����Z�q)
        int val = (num == 1) ? -100 : 100;

        // val�̒l��\������
        Debug.Log(val);*/

        /*
        // �ϐ�a��3�ŏ���������
        int a = 3;
        if(a == 3)
        {
            int b = 5;
            Debug.Log(b);
        }*/

        /*
        int sum = 0;
        for(int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
        */

        /*
        int[] points = new int[5];

        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 80;
        // int[] points = {30,20,50,10,80,15,60,100};

        for(int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }*/

        /*
        int num = Add(3, 6, 1);
        Debug.Log(num);*/

        // �{�X�N���X
        Boss lastboss = new Boss();
        // lastboss.Attack();
        // lastboss.Defence(3);

        // Midboss midboss = new Midboss();
        // midboss.Attack();
        // midboss.Defence(5);


        // �ۑ�(�z��̐錾�E�o��)
        int[] array = {86,413,1,9375,222};
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("���Ԃɕ\���F" + array[i]);
        }
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log("�t���ɕ\���F" + array[array.Length - i - 1]);
        }

        // �ۑ�(Boss�N���X��Magic�֐����s)
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }

    }

    void Goodbye()
    {
        Debug.Log("Goodbye, UnityChan"); 
    }
    void HelloName(int name)
    {
        Debug.Log("Hello," + name);
    }
    int Add(int a, int b, int c)
    {
        int d = a + b + c;
        return d;
    }
    public class Midboss
    {
        private int hp = 30;
        private int power = 10;

        public void Attack()
        {
            Debug.Log(this.power + "�̃_���[�W��^����");
        }
        public void Defence(int damage)
        {
            Debug.Log(damage + "�̃_���[�W���󂯂�");
            this.hp -= damage;
        }
    }
    public class Boss
    {
        private int hp = 100;
        private int mp = 53;
        private int power = 25;

        public void Attack()
        {
            Debug.Log(this.power + "�̃_���[�W��^����");
        }
        public void Defence(int damage)
        {
            Debug.Log(damage + "�̃_���[�W���󂯂�");
            this.hp -= damage;
        }
        public void Magic()
        {
            if (this.mp >= 5)
            {
                this.mp -= 5;
                Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
            }
            else
            {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
