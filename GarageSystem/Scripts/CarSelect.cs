using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSelect : MonoBehaviour
{
   public Rigidbody[] cars;
   public int[] priceOfCars;
   public bool[] purchasedCars;
   public int currentCar;
   public Text textOfPrice;
   public GameObject buttonRun;
   public GameObject buttonBuy;
   public AudioSource[] carAudio;
   public bool isCarAudio;

   int maxCars;

   private void Start()
   {
        purchasedCars = new bool[cars.Length];
        for(int y = 0; y < cars.Length; y++)
        {
            cars[y].isKinematic = true;
            if(isCarAudio)
            {
                carAudio[y].enabled = false;
            }
        }
   }

   private void Update() 
   {
        maxCars = cars.Length - 1;
        if(currentCar >= 0 && currentCar <= maxCars)
        {
            textOfPrice.text = "por: " + priceOfCars[currentCar] + " MZN";
        }
        SelectCars();
   }

   void SelectCars()
   {
        if(currentCar <= 0)
        {
            currentCar = 0;
        }
        if(currentCar >= maxCars)
        {
            currentCar = maxCars;
        }

        for(int y = 0; y < cars.Length;y++)
        {
            if(y == currentCar)
            {
                cars[currentCar].gameObject.SetActive(true);
            }
            else
            {
                cars[y].gameObject.SetActive(false);
            }
        }
        buttonRun.SetActive(purchasedCars[currentCar]);
        buttonBuy.SetActive(!purchasedCars[currentCar]);
        textOfPrice.gameObject.SetActive(!purchasedCars[currentCar]);
   }

   public void SelectCarCurrent(int value)
   {
        currentCar += value;
   }
   public void Disable() 
   {
       for(int y = 0; y < cars.Length; y++)
        {
            cars[y].isKinematic = false;
            if(isCarAudio)
            {
                carAudio[currentCar].enabled = true;
            }
        }
   }
}
