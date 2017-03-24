// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrimitiveOperations.
    /// </summary>
    public static partial class PrimitiveOperationsExtensions
    {
            /// <summary>
            /// Get complex types with integer properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IntWrapperInner GetInt(this IPrimitiveOperations operations)
            {
                return operations.GetIntAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with integer properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IntWrapperInner> GetIntAsync(this IPrimitiveOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetIntWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with integer properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put -1 and 2
            /// </param>
            public static void PutInt(this IPrimitiveOperations operations, IntWrapperInner complexBody)
            {
                operations.PutIntAsync(complexBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with integer properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put -1 and 2
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutIntAsync(this IPrimitiveOperations operations, IntWrapperInner complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutIntWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with long properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static LongWrapperInner GetLong(this IPrimitiveOperations operations)
            {
                return operations.GetLongAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with long properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LongWrapperInner> GetLongAsync(this IPrimitiveOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLongWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with long properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 1099511627775 and -999511627788
            /// </param>
            public static void PutLong(this IPrimitiveOperations operations, LongWrapperInner complexBody)
            {
                operations.PutLongAsync(complexBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with long properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 1099511627775 and -999511627788
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutLongAsync(this IPrimitiveOperations operations, LongWrapperInner complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutLongWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with float properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static FloatWrapperInner GetFloat(this IPrimitiveOperations operations)
            {
                return operations.GetFloatAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with float properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FloatWrapperInner> GetFloatAsync(this IPrimitiveOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFloatWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with float properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 1.05 and -0.003
            /// </param>
            public static void PutFloat(this IPrimitiveOperations operations, FloatWrapperInner complexBody)
            {
                operations.PutFloatAsync(complexBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with float properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 1.05 and -0.003
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutFloatAsync(this IPrimitiveOperations operations, FloatWrapperInner complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutFloatWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with double properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DoubleWrapperInner GetDouble(this IPrimitiveOperations operations)
            {
                return operations.GetDoubleAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with double properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DoubleWrapperInner> GetDoubleAsync(this IPrimitiveOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDoubleWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with double properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 3e-100 and
            /// -0.000000000000000000000000000000000000000000000000000000005
            /// </param>
            public static void PutDouble(this IPrimitiveOperations operations, DoubleWrapperInner complexBody)
            {
                operations.PutDoubleAsync(complexBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with double properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 3e-100 and
            /// -0.000000000000000000000000000000000000000000000000000000005
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutDoubleAsync(this IPrimitiveOperations operations, DoubleWrapperInner complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutDoubleWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with bool properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static BooleanWrapperInner GetBool(this IPrimitiveOperations operations)
            {
                return operations.GetBoolAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with bool properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BooleanWrapperInner> GetBoolAsync(this IPrimitiveOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBoolWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with bool properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put true and false
            /// </param>
            public static void PutBool(this IPrimitiveOperations operations, BooleanWrapperInner complexBody)
            {
                operations.PutBoolAsync(complexBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with bool properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put true and false
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutBoolAsync(this IPrimitiveOperations operations, BooleanWrapperInner complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutBoolWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with string properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static StringWrapperInner GetString(this IPrimitiveOperations operations)
            {
                return operations.GetStringAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with string properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StringWrapperInner> GetStringAsync(this IPrimitiveOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStringWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with string properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 'goodrequest', '', and null
            /// </param>
            public static void PutString(this IPrimitiveOperations operations, StringWrapperInner complexBody)
            {
                operations.PutStringAsync(complexBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with string properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 'goodrequest', '', and null
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutStringAsync(this IPrimitiveOperations operations, StringWrapperInner complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutStringWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with date properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DateWrapperInner GetDate(this IPrimitiveOperations operations)
            {
                return operations.GetDateAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with date properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DateWrapperInner> GetDateAsync(this IPrimitiveOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDateWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with date properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put '0001-01-01' and '2016-02-29'
            /// </param>
            public static void PutDate(this IPrimitiveOperations operations, DateWrapperInner complexBody)
            {
                operations.PutDateAsync(complexBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with date properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put '0001-01-01' and '2016-02-29'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutDateAsync(this IPrimitiveOperations operations, DateWrapperInner complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutDateWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with datetime properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DatetimeWrapperInner GetDateTime(this IPrimitiveOperations operations)
            {
                return operations.GetDateTimeAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with datetime properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DatetimeWrapperInner> GetDateTimeAsync(this IPrimitiveOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDateTimeWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with datetime properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put '0001-01-01T12:00:00-04:00' and '2015-05-18T11:38:00-08:00'
            /// </param>
            public static void PutDateTime(this IPrimitiveOperations operations, DatetimeWrapperInner complexBody)
            {
                operations.PutDateTimeAsync(complexBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with datetime properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put '0001-01-01T12:00:00-04:00' and '2015-05-18T11:38:00-08:00'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutDateTimeAsync(this IPrimitiveOperations operations, DatetimeWrapperInner complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutDateTimeWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with datetimeRfc1123 properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Datetimerfc1123WrapperInner GetDateTimeRfc1123(this IPrimitiveOperations operations)
            {
                return operations.GetDateTimeRfc1123Async().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with datetimeRfc1123 properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Datetimerfc1123WrapperInner> GetDateTimeRfc1123Async(this IPrimitiveOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDateTimeRfc1123WithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with datetimeRfc1123 properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 'Mon, 01 Jan 0001 12:00:00 GMT' and 'Mon, 18 May 2015 11:38:00
            /// GMT'
            /// </param>
            public static void PutDateTimeRfc1123(this IPrimitiveOperations operations, Datetimerfc1123WrapperInner complexBody)
            {
                operations.PutDateTimeRfc1123Async(complexBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with datetimeRfc1123 properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put 'Mon, 01 Jan 0001 12:00:00 GMT' and 'Mon, 18 May 2015 11:38:00
            /// GMT'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutDateTimeRfc1123Async(this IPrimitiveOperations operations, Datetimerfc1123WrapperInner complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutDateTimeRfc1123WithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with duration properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DurationWrapperInner GetDuration(this IPrimitiveOperations operations)
            {
                return operations.GetDurationAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with duration properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DurationWrapperInner> GetDurationAsync(this IPrimitiveOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDurationWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with duration properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='field'>
            /// </param>
            public static void PutDuration(this IPrimitiveOperations operations, System.TimeSpan? field = default(System.TimeSpan?))
            {
                operations.PutDurationAsync(field).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with duration properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='field'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutDurationAsync(this IPrimitiveOperations operations, System.TimeSpan? field = default(System.TimeSpan?), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutDurationWithHttpMessagesAsync(field, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get complex types with byte properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ByteWrapperInner GetByte(this IPrimitiveOperations operations)
            {
                return operations.GetByteAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types with byte properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ByteWrapperInner> GetByteAsync(this IPrimitiveOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByteWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types with byte properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='field'>
            /// </param>
            public static void PutByte(this IPrimitiveOperations operations, byte[] field = default(byte[]))
            {
                operations.PutByteAsync(field).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types with byte properties
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='field'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutByteAsync(this IPrimitiveOperations operations, byte[] field = default(byte[]), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutByteWithHttpMessagesAsync(field, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
