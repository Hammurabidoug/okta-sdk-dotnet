﻿// <copyright file="IOktaClient.cs" company="Okta, Inc">
// Copyright (c) 2014-2017 Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System.Threading;
using System.Threading.Tasks;
using Okta.Sdk.Internal;

namespace Okta.Sdk
{
    /// <summary>
    /// A client that communicates with the Okta Management API.
    /// </summary>
    public interface IOktaClient
    {
        /// <summary>
        /// Gets a <see cref="UserClient"/> that interacts with the Okta Users API.
        /// </summary>
        /// <value>
        /// A <see cref="UserClient"/> that interacts with the Okta Users API.
        /// </value>
        UserClient Users { get; }

        /// <summary>
        /// Gets a <see cref="GroupClient"/> that interacts with the Okta Groups API.
        /// </summary>
        /// <value>
        /// A <see cref="GroupClient"/> that interacts with the Okta Groups API.
        /// </value>
        GroupClient Groups { get; }

        /// <summary>
        /// Gets a resource by URL and deserializes it to a <see cref="Resource"/> type.
        /// </summary>
        /// <remarks>You typically only need to use this method if you are working with resources not natively handled by this library.</remarks>
        /// <typeparam name="T">The <see cref="Resource"/> type to deserialize the returned data to.</typeparam>
        /// <param name="href">The resource URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The deserialized resource.</returns>
        /// <exception cref="OktaApiException">An API error occurred.</exception>
        Task<T> GetAsync<T>(string href, CancellationToken cancellationToken = default(CancellationToken))
            where T : Resource, new();

        /// <summary>
        /// Gets a resource by specifying the HTTP request options, and deserializes it to a <see cref="Resource"/> type.
        /// </summary>
        /// <remarks>You typically only need to use this method if you are working with resources not natively handled by this library.</remarks>
        /// <typeparam name="T">The <see cref="Resource"/> type to deserialize the returned data to.</typeparam>
        /// <param name="request">The request options.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The deserialized resource.</returns>
        /// <exception cref="OktaApiException">An API error occurred.</exception>
        Task<T> GetAsync<T>(HttpRequest request, CancellationToken cancellationToken = default(CancellationToken))
            where T : Resource, new();

        /// <summary>
        /// Posts data to an endpoint by URL.
        /// </summary>
        /// <remarks>You typically only need to use this method if you are working with resources not natively handled by this library.</remarks>
        /// <param name="href">The endpoint URL.</param>
        /// <param name="model">The data to serialize and attach to the request body.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        /// <exception cref="OktaApiException">An API error occurred.</exception>
        Task PostAsync(
            string href,
            object model,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Posts data to an endpoint by URL, and deserializes the response payload to a <see cref="Resource"/> type.
        /// </summary>
        /// <remarks>You typically only need to use this method if you are working with resources not natively handled by this library.</remarks>
        /// <typeparam name="TResponse">The <see cref="Resource"/> type to deserialize the returned data to.</typeparam>
        /// <param name="href">The endpoint URL.</param>
        /// <param name="model">The data to serialize and attach to the request body.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The deserialized response data.</returns>
        /// <exception cref="OktaApiException">An API error occurred.</exception>
        Task<TResponse> PostAsync<TResponse>(
            string href,
            object model,
            CancellationToken cancellationToken = default(CancellationToken))
            where TResponse : Resource, new();

        /// <summary>
        /// Posts data to an endpoint by specifying the HTTP request options.
        /// </summary>
        /// <remarks>You typically only need to use this method if you are working with resources not natively handled by this library.</remarks>
        /// <param name="request">The request options.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        /// <exception cref="OktaApiException">An API error occurred.</exception>
        Task PostAsync(
            HttpRequest request,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Posts data to an endpoint by specifying the HTTP request options, and deserializes the response payload to a <see cref="Resource"/> type.
        /// </summary>
        /// <remarks>You typically only need to use this method if you are working with resources not natively handled by this library.</remarks>
        /// <typeparam name="TResponse">The <see cref="Resource"/> type to deserialize the returned data to.</typeparam>
        /// <param name="request">The request options.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The deserialized response data.</returns>
        /// <exception cref="OktaApiException">An API error occurred.</exception>
        Task<TResponse> PostAsync<TResponse>(
            HttpRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
            where TResponse : Resource, new();

        /// <summary>
        /// Puts data to an endpoint by URL.
        /// </summary>
        /// <remarks>You typically only need to use this method if you are working with resources not natively handled by this library.</remarks>
        /// <param name="href">The endpoint URL.</param>
        /// <param name="model">The data to serialize and attach to the request body.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        /// <exception cref="OktaApiException">An API error occurred.</exception>
        Task PutAsync(
            string href,
            object model,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Puts data to an endpoint by URL and deserializes the response payload to a <see cref="Resource"/> type.
        /// <remarks>You typically only need to use this method if you are working with resources not natively handled by this library.</remarks>
        /// </summary>
        /// <typeparam name="TResponse">The <see cref="Resource"/> type to deserialize the returned data to.</typeparam>
        /// <param name="href">The endpoint URL.</param>
        /// <param name="model">The data to serialize and attach to the request body.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The deserialized response data.</returns>
        /// <exception cref="OktaApiException">An API error occurred.</exception>
        Task<TResponse> PutAsync<TResponse>(
            string href,
            object model,
            CancellationToken cancellationToken = default(CancellationToken))
            where TResponse : Resource, new();

        /// <summary>
        /// Puts data to an endpoint by specifying the HTTP request options.
        /// </summary>
        /// <remarks>You typically only need to use this method if you are working with resources not natively handled by this library.</remarks>
        /// <param name="request">The endpoint URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        /// <exception cref="OktaApiException">An API error occurred.</exception>
        Task PutAsync(
            HttpRequest request,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Puts data to an endpoint by specifying the HTTP request options, and deserializes the response payload to a <see cref="Resource"/> type.
        /// </summary>
        /// <remarks>You typically only need to use this method if you are working with resources not natively handled by this library.</remarks>
        /// <typeparam name="TResponse">The <see cref="Resource"/> type to deserialize the returned data to.</typeparam>
        /// <param name="request">The request options.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The deserialized response data.</returns>
        /// <exception cref="OktaApiException">An API error occurred.</exception>
        Task<TResponse> PutAsync<TResponse>(
            HttpRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
            where TResponse : Resource, new();

        /// <summary>
        /// Deletes a resource by URL.
        /// </summary>
        /// <remarks>You typically only need to use this method if you are working with resources not natively handled by this library.</remarks>
        /// <param name="href">The resource URL.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        /// <exception cref="OktaApiException">An API error occurred.</exception>
        Task DeleteAsync(
            string href,
            CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes a resource by specifying the HTTP request options.
        /// </summary>
        /// <remarks>You typically only need to use this method if you are working with resources not natively handled by this library.</remarks>
        /// <param name="request">The request options.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        /// <exception cref="OktaApiException">An API error occurred.</exception>
        Task DeleteAsync(
            HttpRequest request,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}