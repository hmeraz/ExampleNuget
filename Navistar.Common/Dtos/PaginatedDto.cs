// <summary>
// <copyright file="PaginatedDto.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>
namespace Navistar.Common.Dtos
{
    using System.Collections.Generic;

    /// <summary>
    /// Generic class to paginate.
    /// </summary>
    /// <typeparam name="T">Type object.</typeparam>
    public class PaginatedDto<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedDto{T}"/> class.
        /// </summary>
        public PaginatedDto()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedDto{T}"/> class.
        /// </summary>
        /// <param name="limit">Number of records per page.</param>
        /// <param name="offset">Number of records to skip.</param>
        /// <param name="registries">Total records.</param>
        /// <param name="data"><see cref="IEnumerable{T}"/>.</param>
        public PaginatedDto(int limit, int offset, int registries, IEnumerable<T> data)
        {
            this.Page = offset / limit;
            int pages = registries / limit;
            if (registries % limit > 0)
            {
                pages++;
            }

            this.Pages = pages;
            this.Registries = registries;
            this.Size = limit;
            this.Data = data;
        }

        /// <summary>
        /// Gets or sets Page.
        /// </summary>
        /// <value>
        /// Int Page.
        /// </value>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets Size.
        /// </summary>
        /// <value>
        /// Int Size.
        /// </value>
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets Pages.
        /// </summary>
        /// <value>
        /// Int Pages.
        /// </value>
        public int Pages { get; set; }

        /// <summary>
        /// Gets or sets TotalRecords.
        /// </summary>
        /// <value>
        /// Int TotalRecords.
        /// </value>
        public int Registries { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        /// <value>
        /// List<typeparamref name="T"/> Data.
        /// </value>
        public IEnumerable<T> Data { get; set; }
    }
}
