﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// A mutual fund
    /// </summary>
    public class MutualFund : InvestmentAccount
    {
        float serviceChargePercent = 0.01f;

         #region Properites
        public float ServiceChargePercent
        {
            get
            { return this.serviceChargePercent; }
        }
        #endregion

        #region Contructor
        public MutualFund(float deposit) : base(deposit)
        {
        }
        #endregion

        #region Public methods

        public override void AddMoney(float amount)
        {
            balance += amount - (amount * serviceChargePercent);
        }

        /// <summary>
        /// Updates the balance by adding 6%
        /// </summary>
        public override void UpdateBalance()
        {
            balance += (balance * 0.06f);
        }

        /// <summary>
        /// Provides balance with account type caption
        /// </summary>
        /// <returns>balance with caption</returns>
        public override string ToString()
        {
            return "Mutual Fund Balance: " + balance;
        }
        #endregion
    }
}
