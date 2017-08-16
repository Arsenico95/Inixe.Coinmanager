﻿// -----------------------------------------------------------------------
// <copyright file="IFundingOperationDetails.cs" company="Inixe">
// Copyright (c) Inixe 2017. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Inixe.CoinManagement.Bitso.Api
{
    /// <summary>
    /// Interface IFundingOperationDetails
    /// </summary>
    /// <remarks>Holds the details of a funding. This can be from any currency</remarks>
    public interface IFundingOperationDetails
    {
        /// <summary>Gets or sets the funds operation identifier.</summary>
        /// <value>The funds operation identifier.</value>
        string FundsOperationId { get; set; }

        /// <summary>Gets or sets the funding method.</summary>
        /// <value>The method.</value>
        string Method { get; set; }

        /// <summary>Gets or sets the recieving address.</summary>
        /// <value>the recieving address.</value>
        string Address { get; set; }
    }
}
