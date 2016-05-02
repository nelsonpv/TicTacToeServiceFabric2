﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.IT.GRM.ServiceClient.Models;
using Microsoft.Rest;

namespace Microsoft.IT.GRM.ServiceClient
{
    public partial interface ICalendar
    {
        /// <param name='calendarRequest'>
        /// Required.
        /// </param>
        /// <param name='trackingId'>
        /// Required. TrackingId (Guid) for Tracing. This will be present in
        /// Response Headers as well.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> GetWithOperationResponseAsync(GetCalendarRequest calendarRequest, string trackingId, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='calendarRequest'>
        /// Required.
        /// </param>
        /// <param name='trackingId'>
        /// Required. TrackingId (Guid) for Tracing. This will be present in
        /// Response Headers as well.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> PostWithOperationResponseAsync(CreateCalendarRequest calendarRequest, string trackingId, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
