using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageControl : MonoBehaviour
{
    private CarSelect select;
    private PaymentSystem payment;

    private void Start() 
    {
        select = GetComponent<CarSelect>();
        payment = GetComponent<PaymentSystem>();
    }

    public void OperationBuy()
    {
        payment.Buy(select.priceOfCars[select.currentCar]);
    }

    public void OperationGain(int value)
    {
        payment.Gain(value);
    }
}
