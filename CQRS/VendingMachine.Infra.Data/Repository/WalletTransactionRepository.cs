﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Domain.Common.Interfaces;
using VendingMachine.Domain.Interface;
using VendingMachine.Domain.Model;
using VendingMachine.Infra.Data.Context;

namespace VendingMachine.Infra.Data.Repository
{
    public class WalletTransactionRepository : UnitOfWork<WalletTransaction>, IWalletTransactionRepository
    {
        public WalletTransactionRepository(VendingMachineContext context) : base(context)
        {
        }
    }
}
