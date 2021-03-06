﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BankAccount
{
    private int id;

    private double balance;

    public int ID
    {
        get { return this.id; }

        set { this.id = value; }
    }

    public double Balance
    {
        get { return this.balance; }

        set { this.balance = value; }
    }

    public void Deposit(Double amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(Double amount)
    {
        this.Balance -= amount;
    }

    public override string ToString()
    {
        return $"Account ID{this.ID}, balance {this.Balance:F2}";
    }
}

