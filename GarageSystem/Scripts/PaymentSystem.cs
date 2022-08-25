using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PaymentSystem : MonoBehaviour
{
   public float MoneyBank = 500;
   public Text textMoney;

   private CarSelect select;

   private void Start() 
   {
        select = GetComponent<CarSelect>();
   }

   float result;

   private void Update() 
   {
        textMoney.text = MoneyBank + " MZN";
   }

   public void Buy(int value)
   {
        if(MoneyBank >= value && !select.purchasedCars[select.currentCar])
        {
            MoneyBank = MoneyBank - value;
            select.purchasedCars[select.currentCar] = true;
            Debug.Log("Compra Realizada!");
        }
        else
        {
            if(select.purchasedCars[select.currentCar])
            {
                Debug.Log("Este ja foi comprado!");
            }
            else
            {
                Debug.Log("O dinherio na conta é insuficiente!");
            }
        }
   }

   public void Gain(int value)
   {
        MoneyBank = MoneyBank + value;
        Debug.Log("Adicionados: +" + value + "MZN"); 
   }
}
