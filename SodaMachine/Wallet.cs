﻿using System;
using System.Collections.Generic;
namespace SodaMachine
{
    public class Wallet
    {
        public double totalWallet;
        public List<Coin> coins;
        public int quarterCount;
        public int dimeCount;
        public int nickelCount;
        public int pennyCount;
        public SodaMachine sodaMachine;
        public Customer customer;
        public CreditCard appleCard;


        public Wallet()
        {

            totalWallet = 0;
            coins = new List<Coin>();

            for (int i = 0; i < 15; i++)
            {
                coins.Add(new Quarter());
                coins.Add(new Dime());
                coins.Add(new Nickel());
                coins.Add(new Penny());
            }

            appleCard = new CreditCard();

        }
        public double TotalWallet()
        {
            totalWallet = 0;
            for (int i = 0; i < coins.Count; i++)
            {
                totalWallet = Math.Round(totalWallet + coins[i].Value, 2);
            }
            return totalWallet;
        }

        public void CurrentChange()
        {
            quarterCount = 0; dimeCount = 0; nickelCount = 0; pennyCount = 0;
            for (int i = 0; i < coins.Count; i++)
            {
                if (coins[i].name == "penny")
                {
                    pennyCount = ++pennyCount;
                }
                else if (coins[i].name == "nickel")
                {
                    nickelCount = ++nickelCount;
                }
                else if (coins[i].name == "dime")
                {
                    dimeCount = ++dimeCount;
                }
                else if (coins[i].name == "quarter")
                {
                    quarterCount = ++quarterCount;
                }

            }

        }

    }
}