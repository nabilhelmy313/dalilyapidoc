// <copyright file="MiscController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Dalili.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using Dalili.Standard;
    using Dalili.Standard.Authentication;
    using Dalili.Standard.Http.Client;
    using Dalili.Standard.Http.Request;
    using Dalili.Standard.Http.Response;
    using Dalili.Standard.Utilities;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// MiscController.
    /// </summary>
    public class MiscController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiscController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal MiscController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// {{production}}/products/filter?page=1&os=Android EndPoint.
        /// </summary>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="categories">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="mLong">Required parameter: Example: .</param>
        public void ProductionProductsFilterPage1OsAndroid(
                int page,
                string os,
                string lang,
                List<int> categories,
                int lat,
                int mLong)
        {
            Task t = this.ProductionProductsFilterPage1OsAndroidAsync(page, os, lang, categories, lat, mLong);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/products/filter?page=1&os=Android EndPoint.
        /// </summary>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="categories">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionProductsFilterPage1OsAndroidAsync(
                int page,
                string os,
                string lang,
                List<int> categories,
                int lat,
                int mLong,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/products/filter");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "page", page },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("lat", lat),
                new KeyValuePair<string, object>("long", mLong),
            };
            fields.AddRange(ApiHelper.PrepareFormFieldsFromObject("categories", categories, arrayDeserializationFormat: this.ArrayDeserializationFormat));

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/product?logged_id=3&product_id=39&os=android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionProductLoggedId3ProductId39OsAndroid(
                int loggedId,
                int productId,
                string os)
        {
            Task t = this.ProductionProductLoggedId3ProductId39OsAndroidAsync(loggedId, productId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/product?logged_id=3&product_id=39&os=android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionProductLoggedId3ProductId39OsAndroidAsync(
                int loggedId,
                int productId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/product");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "logged_id", loggedId },
                { "product_id", productId },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/profile/products EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionProfileProducts(
                int userId,
                int loggedId,
                string lang,
                string os)
        {
            Task t = this.ProductionProfileProductsAsync(userId, loggedId, lang, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/profile/products EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionProfileProductsAsync(
                int userId,
                int loggedId,
                string lang,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/profile/products");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("os", os),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/online_categories?logged_id=1&country_id=3&os=android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionOnlineCategoriesLoggedId1CountryId3OsAndroid(
                int loggedId,
                int countryId,
                string os)
        {
            Task t = this.ProductionOnlineCategoriesLoggedId1CountryId3OsAndroidAsync(loggedId, countryId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/online_categories?logged_id=1&country_id=3&os=android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionOnlineCategoriesLoggedId1CountryId3OsAndroidAsync(
                int loggedId,
                int countryId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/online_categories");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "logged_id", loggedId },
                { "country_id", countryId },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/driver/order?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        public void ProductionDriverOrderOsAndroid(
                string os,
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                string startDate,
                string endDate,
                int orderId,
                int userId)
        {
            Task t = this.ProductionDriverOrderOsAndroidAsync(os, nasser, aPPVERSION, mOBILEOS, lang, startDate, endDate, orderId, userId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/driver/order?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionDriverOrderOsAndroidAsync(
                string os,
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                string startDate,
                string endDate,
                int orderId,
                int userId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/order");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("start_date", startDate),
                new KeyValuePair<string, object>("end_date", endDate),
                new KeyValuePair<string, object>("order_id", orderId),
                new KeyValuePair<string, object>("user_id", userId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/notifications?logged_id=207&user_id=207&page=1&os=android&in_app_popup=1 EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="objectType">Required parameter: Example: .</param>
        public void ProductionNotificationsLoggedId207UserId207Page1OsAndroidInAppPopup1(
                int loggedId,
                int userId,
                int page,
                string os,
                string objectType)
        {
            Task t = this.ProductionNotificationsLoggedId207UserId207Page1OsAndroidInAppPopup1Async(loggedId, userId, page, os, objectType);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/notifications?logged_id=207&user_id=207&page=1&os=android&in_app_popup=1 EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="objectType">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionNotificationsLoggedId207UserId207Page1OsAndroidInAppPopup1Async(
                int loggedId,
                int userId,
                int page,
                string os,
                string objectType,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/notifications");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "logged_id", loggedId },
                { "user_id", userId },
                { "page", page },
                { "os", os },
                { "object_type", objectType },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/comments?user_id=3&country_id=3&product_id=53&os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="comment">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53OsAndroid(
                int userId,
                int productId,
                string comment,
                string os)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53OsAndroidAsync(userId, productId, comment, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/comments?user_id=3&country_id=3&product_id=53&os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="comment">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53OsAndroidAsync(
                int userId,
                int productId,
                string comment,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/product/comments");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "user_id", userId },
                { "product_id", productId },
                { "comment", comment },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/comments?user_id=3&country_id=3&product_id=53&comment_id=105&os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="commentId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53CommentId105OsAndroid(
                int userId,
                int countryId,
                int productId,
                int commentId,
                string os)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53CommentId105OsAndroidAsync(userId, countryId, productId, commentId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/comments?user_id=3&country_id=3&product_id=53&comment_id=105&os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="commentId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53CommentId105OsAndroidAsync(
                int userId,
                int countryId,
                int productId,
                int commentId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/product/comments");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "user_id", userId },
                { "country_id", countryId },
                { "product_id", productId },
                { "comment_id", commentId },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/login?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="password">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        public void ProductionLoginOsAndroid(
                string os,
                string lang,
                string password,
                string email)
        {
            Task t = this.ProductionLoginOsAndroidAsync(os, lang, password, email);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/login?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="password">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionLoginOsAndroidAsync(
                string os,
                string lang,
                string password,
                string email,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/login");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("password", password),
                new KeyValuePair<string, object>("email", email),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/social-login EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="sName">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="gender">Required parameter: Example: .</param>
        /// <param name="countryCode">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="providerId">Required parameter: Example: .</param>
        /// <param name="facebookId">Required parameter: Example: .</param>
        /// <param name="googleId">Required parameter: Example: .</param>
        /// <param name="twitterToken">Required parameter: Example: .</param>
        /// <param name="twitterSecretToken">Required parameter: Example: .</param>
        /// <param name="providerImage">Required parameter: Example: .</param>
        /// <param name="provider">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiSocialLogin(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string email,
                string name,
                string sName,
                long mobile,
                int gender,
                int countryCode,
                string lang,
                int countryId,
                long providerId,
                double facebookId,
                string googleId,
                string twitterToken,
                string twitterSecretToken,
                string providerImage,
                string provider)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiSocialLoginAsync(nasser, aPPVERSION, mOBILEOS, email, name, sName, mobile, gender, countryCode, lang, countryId, providerId, facebookId, googleId, twitterToken, twitterSecretToken, providerImage, provider);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/social-login EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="sName">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="gender">Required parameter: Example: .</param>
        /// <param name="countryCode">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="providerId">Required parameter: Example: .</param>
        /// <param name="facebookId">Required parameter: Example: .</param>
        /// <param name="googleId">Required parameter: Example: .</param>
        /// <param name="twitterToken">Required parameter: Example: .</param>
        /// <param name="twitterSecretToken">Required parameter: Example: .</param>
        /// <param name="providerImage">Required parameter: Example: .</param>
        /// <param name="provider">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiSocialLoginAsync(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string email,
                string name,
                string sName,
                long mobile,
                int gender,
                int countryCode,
                string lang,
                int countryId,
                long providerId,
                double facebookId,
                string googleId,
                string twitterToken,
                string twitterSecretToken,
                string providerImage,
                string provider,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/social-login");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("email", email),
                new KeyValuePair<string, object>("name", name),
                new KeyValuePair<string, object>("s_name", sName),
                new KeyValuePair<string, object>("mobile", mobile),
                new KeyValuePair<string, object>("gender", gender),
                new KeyValuePair<string, object>("country_code", countryCode),
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("provider_id", providerId),
                new KeyValuePair<string, object>("facebook_id", facebookId),
                new KeyValuePair<string, object>("google_id", googleId),
                new KeyValuePair<string, object>("twitter_token", twitterToken),
                new KeyValuePair<string, object>("twitter_secret_token", twitterSecretToken),
                new KeyValuePair<string, object>("provider_image", providerImage),
                new KeyValuePair<string, object>("provider", provider),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/register EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="password">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="sName">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="gender">Required parameter: Example: .</param>
        /// <param name="countryCode">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="birthDate">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="isConfirm">Required parameter: Example: .</param>
        /// <param name="isDriver">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiRegister(
                string os,
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string email,
                int password,
                string name,
                string sName,
                long mobile,
                int gender,
                int countryCode,
                string lang,
                string birthDate,
                int countryId,
                int isConfirm,
                int isDriver)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiRegisterAsync(os, nasser, aPPVERSION, mOBILEOS, email, password, name, sName, mobile, gender, countryCode, lang, birthDate, countryId, isConfirm, isDriver);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/register EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="password">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="sName">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="gender">Required parameter: Example: .</param>
        /// <param name="countryCode">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="birthDate">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="isConfirm">Required parameter: Example: .</param>
        /// <param name="isDriver">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiRegisterAsync(
                string os,
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string email,
                int password,
                string name,
                string sName,
                long mobile,
                int gender,
                int countryCode,
                string lang,
                string birthDate,
                int countryId,
                int isConfirm,
                int isDriver,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/register");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("email", email),
                new KeyValuePair<string, object>("password", password),
                new KeyValuePair<string, object>("name", name),
                new KeyValuePair<string, object>("s_name", sName),
                new KeyValuePair<string, object>("mobile", mobile),
                new KeyValuePair<string, object>("gender", gender),
                new KeyValuePair<string, object>("country_code", countryCode),
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("birth_date", birthDate),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("is_confirm", isConfirm),
                new KeyValuePair<string, object>("is_driver", isDriver),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/password/email EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiPasswordEmail(
                string lang,
                string email,
                int userId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiPasswordEmailAsync(lang, email, userId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/password/email EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiPasswordEmailAsync(
                string lang,
                string email,
                int userId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/password/email");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("email", email),
                new KeyValuePair<string, object>("user_id", userId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/profile/change_password EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="password">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="oldPassword">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProfileChangePassword(
                string lang,
                string password,
                int userId,
                string oldPassword)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProfileChangePasswordAsync(lang, password, userId, oldPassword);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/profile/change_password EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="password">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="oldPassword">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProfileChangePasswordAsync(
                string lang,
                string password,
                int userId,
                string oldPassword,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/profile/change_password");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("password", password),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("old_password", oldPassword),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/profile?os=android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void ProductionProfileOsAndroid(
                int loggedId,
                int userId,
                string os,
                int countryId)
        {
            Task t = this.ProductionProfileOsAndroidAsync(loggedId, userId, os, countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/profile?os=android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionProfileOsAndroidAsync(
                int loggedId,
                int userId,
                string os,
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/profile");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("os", os),
                new KeyValuePair<string, object>("country_id", countryId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/profile/update?os=android EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="isActive">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="isConfirm">Required parameter: Example: .</param>
        /// <param name="isPublic">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="facebook">Required parameter: Example: .</param>
        /// <param name="birthDate">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProfileUpdateOsAndroid(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                int isActive,
                int userId,
                int isConfirm,
                int isPublic,
                string os,
                string facebook,
                string birthDate)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProfileUpdateOsAndroidAsync(nasser, aPPVERSION, mOBILEOS, isActive, userId, isConfirm, isPublic, os, facebook, birthDate);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/profile/update?os=android EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="isActive">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="isConfirm">Required parameter: Example: .</param>
        /// <param name="isPublic">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="facebook">Required parameter: Example: .</param>
        /// <param name="birthDate">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProfileUpdateOsAndroidAsync(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                int isActive,
                int userId,
                int isConfirm,
                int isPublic,
                string os,
                string facebook,
                string birthDate,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/profile/update");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("is_active", isActive),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("is_confirm", isConfirm),
                new KeyValuePair<string, object>("is_public", isPublic),
                new KeyValuePair<string, object>("os", os),
                new KeyValuePair<string, object>("facebook", facebook),
                new KeyValuePair<string, object>("birth_date", birthDate),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/set-token?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="gymId">Required parameter: Example: .</param>
        /// <param name="token">Required parameter: Example: .</param>
        public void HttpDaliliHerokuappComApiSetTokenOsAndroid(
                string os,
                int userId,
                int gymId,
                string token)
        {
            Task t = this.HttpDaliliHerokuappComApiSetTokenOsAndroidAsync(os, userId, gymId, token);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/set-token?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="gymId">Required parameter: Example: .</param>
        /// <param name="token">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDaliliHerokuappComApiSetTokenOsAndroidAsync(
                string os,
                int userId,
                int gymId,
                string token,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server3);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/set-token");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Content-Type", "application/x-www-form-urlencoded" },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("gym_id", gymId),
                new KeyValuePair<string, object>("token", token),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/home?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionHomeOsAndroid(
                string os)
        {
            Task t = this.ProductionHomeOsAndroidAsync(os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/home?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionHomeOsAndroidAsync(
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/home");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/user/indicator?user_id=1&os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionUserIndicatorUserId1OsAndroid(
                int userId,
                string os)
        {
            Task t = this.ProductionUserIndicatorUserId1OsAndroidAsync(userId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/user/indicator?user_id=1&os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionUserIndicatorUserId1OsAndroidAsync(
                int userId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/user/indicator");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "user_id", userId },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/notifications?logged_id=7&user_id=7&page=1&os=android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiNotificationsLoggedId7UserId7Page1OsAndroid(
                int loggedId,
                int userId,
                int page,
                string os)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiNotificationsLoggedId7UserId7Page1OsAndroidAsync(loggedId, userId, page, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/notifications?logged_id=7&user_id=7&page=1&os=android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiNotificationsLoggedId7UserId7Page1OsAndroidAsync(
                int loggedId,
                int userId,
                int page,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/notifications");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "logged_id", loggedId },
                { "user_id", userId },
                { "page", page },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/packages?os=Android&lang=en&country_id=3&type=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        public void HttpDaliliHerokuappComApiPackagesOsAndroidLangEnCountryId3Type1(
                string os,
                string lang,
                int countryId,
                int type)
        {
            Task t = this.HttpDaliliHerokuappComApiPackagesOsAndroidLangEnCountryId3Type1Async(os, lang, countryId, type);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/packages?os=Android&lang=en&country_id=3&type=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDaliliHerokuappComApiPackagesOsAndroidLangEnCountryId3Type1Async(
                string os,
                string lang,
                int countryId,
                int type,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/packages");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
                { "country_id", countryId },
                { "type", type },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/product/create?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="enName">Required parameter: Example: .</param>
        /// <param name="arName">Required parameter: Example: .</param>
        /// <param name="enDesc">Required parameter: Example: .</param>
        /// <param name="arDesc">Required parameter: Example: .</param>
        /// <param name="isOnline">Required parameter: Example: .</param>
        /// <param name="isAvail">Required parameter: Example: .</param>
        /// <param name="price">Required parameter: Example: .</param>
        /// <param name="properties">Required parameter: Example: .</param>
        /// <param name="colors">Required parameter: Example: .</param>
        /// <param name="sizes">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="quantity">Required parameter: Example: .</param>
        /// <param name="video">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="parentId">Required parameter: Example: .</param>
        public void ProductionProductCreateOsAndroid(
                string lang,
                int loggedId,
                int userId,
                int categoryId,
                int storeId,
                int countryId,
                int cityId,
                int regionId,
                string enName,
                string arName,
                string enDesc,
                string arDesc,
                int isOnline,
                int isAvail,
                int price,
                List<Models.Property> properties,
                List<Models.Color> colors,
                List<string> sizes,
                double lat,
                double mLong,
                long mobile,
                int quantity,
                string video,
                string image,
                string os,
                int parentId)
        {
            Task t = this.ProductionProductCreateOsAndroidAsync(lang, loggedId, userId, categoryId, storeId, countryId, cityId, regionId, enName, arName, enDesc, arDesc, isOnline, isAvail, price, properties, colors, sizes, lat, mLong, mobile, quantity, video, image, os, parentId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/product/create?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="enName">Required parameter: Example: .</param>
        /// <param name="arName">Required parameter: Example: .</param>
        /// <param name="enDesc">Required parameter: Example: .</param>
        /// <param name="arDesc">Required parameter: Example: .</param>
        /// <param name="isOnline">Required parameter: Example: .</param>
        /// <param name="isAvail">Required parameter: Example: .</param>
        /// <param name="price">Required parameter: Example: .</param>
        /// <param name="properties">Required parameter: Example: .</param>
        /// <param name="colors">Required parameter: Example: .</param>
        /// <param name="sizes">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="quantity">Required parameter: Example: .</param>
        /// <param name="video">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="parentId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionProductCreateOsAndroidAsync(
                string lang,
                int loggedId,
                int userId,
                int categoryId,
                int storeId,
                int countryId,
                int cityId,
                int regionId,
                string enName,
                string arName,
                string enDesc,
                string arDesc,
                int isOnline,
                int isAvail,
                int price,
                List<Models.Property> properties,
                List<Models.Color> colors,
                List<string> sizes,
                double lat,
                double mLong,
                long mobile,
                int quantity,
                string video,
                string image,
                string os,
                int parentId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/product/create");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("category_id", categoryId),
                new KeyValuePair<string, object>("store_id", storeId),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("city_id", cityId),
                new KeyValuePair<string, object>("region_id", regionId),
                new KeyValuePair<string, object>("en_name", enName),
                new KeyValuePair<string, object>("ar_name", arName),
                new KeyValuePair<string, object>("en_desc", enDesc),
                new KeyValuePair<string, object>("ar_desc", arDesc),
                new KeyValuePair<string, object>("is_online", isOnline),
                new KeyValuePair<string, object>("is_avail", isAvail),
                new KeyValuePair<string, object>("price", price),
                new KeyValuePair<string, object>("lat", lat),
                new KeyValuePair<string, object>("long", mLong),
                new KeyValuePair<string, object>("mobile", mobile),
                new KeyValuePair<string, object>("quantity", quantity),
                new KeyValuePair<string, object>("video", video),
                new KeyValuePair<string, object>("image", image),
                new KeyValuePair<string, object>("os", os),
                new KeyValuePair<string, object>("parent_id", parentId),
            };
            fields.AddRange(ApiHelper.PrepareFormFieldsFromObject("properties", properties, arrayDeserializationFormat: this.ArrayDeserializationFormat));
            fields.AddRange(ApiHelper.PrepareFormFieldsFromObject("colors", colors, arrayDeserializationFormat: this.ArrayDeserializationFormat));
            fields.AddRange(ApiHelper.PrepareFormFieldsFromObject("sizes", sizes, arrayDeserializationFormat: this.ArrayDeserializationFormat));

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/product/edit?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="paymentType">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionProductEditOsAndroid(
                string lang,
                int userId,
                int paymentType,
                int id,
                string os)
        {
            Task t = this.ProductionProductEditOsAndroidAsync(lang, userId, paymentType, id, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/product/edit?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="paymentType">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionProductEditOsAndroidAsync(
                string lang,
                int userId,
                int paymentType,
                int id,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/product/edit");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("payment_type", paymentType),
                new KeyValuePair<string, object>("id", id),
                new KeyValuePair<string, object>("os", os),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/profile/account?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionProfileAccountOsAndroid(
                string lang,
                int countryId,
                int userId,
                string os)
        {
            Task t = this.ProductionProfileAccountOsAndroidAsync(lang, countryId, userId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/profile/account?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionProfileAccountOsAndroidAsync(
                string lang,
                int countryId,
                int userId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/profile/account");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("os", os),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/accounts?os=Android&lang=en&user_id=1&store_id=9&country_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void HttpDaliliHerokuappComApiAccountsOsAndroidLangEnUserId1StoreId9CountryId1(
                string os,
                string lang,
                int userId,
                int countryId)
        {
            Task t = this.HttpDaliliHerokuappComApiAccountsOsAndroidLangEnUserId1StoreId9CountryId1Async(os, lang, userId, countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/accounts?os=Android&lang=en&user_id=1&store_id=9&country_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDaliliHerokuappComApiAccountsOsAndroidLangEnUserId1StoreId9CountryId1Async(
                string os,
                string lang,
                int userId,
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/accounts");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
                { "user_id", userId },
                { "country_id", countryId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, null, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/profile/can_post?user_id=1&country_id=3&category_id=2 EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionProfileCanPostUserId1CountryId3CategoryId2(
                int userId,
                int countryId,
                int categoryId,
                string os)
        {
            Task t = this.ProductionProfileCanPostUserId1CountryId3CategoryId2Async(userId, countryId, categoryId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/profile/can_post?user_id=1&country_id=3&category_id=2 EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionProfileCanPostUserId1CountryId3CategoryId2Async(
                int userId,
                int countryId,
                int categoryId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/profile/can_post");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "user_id", userId },
                { "country_id", countryId },
                { "category_id", categoryId },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/balances?os=android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiBalancesOsAndroid(
                int loggedId,
                int userId,
                string lang,
                int countryId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiBalancesOsAndroidAsync(loggedId, userId, lang, countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/balances?os=android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiBalancesOsAndroidAsync(
                int loggedId,
                int userId,
                string lang,
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/balances");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("country_id", countryId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/profile/charge?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="password">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="balanceId">Required parameter: Example: .</param>
        /// <param name="paymentType">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProfileChargeOsAndroid(
                string lang,
                string password,
                string email,
                int userId,
                int balanceId,
                int paymentType,
                int productId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProfileChargeOsAndroidAsync(lang, password, email, userId, balanceId, paymentType, productId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/profile/charge?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="password">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="balanceId">Required parameter: Example: .</param>
        /// <param name="paymentType">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProfileChargeOsAndroidAsync(
                string lang,
                string password,
                string email,
                int userId,
                int balanceId,
                int paymentType,
                int productId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/profile/charge");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("password", password),
                new KeyValuePair<string, object>("email", email),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("balance_id", balanceId),
                new KeyValuePair<string, object>("payment_type", paymentType),
                new KeyValuePair<string, object>("product_id", productId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/profile/followings?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="followerId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProfileFollowingsOsAndroid(
                int userId,
                int followerId,
                string lang,
                int loggedId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProfileFollowingsOsAndroidAsync(userId, followerId, lang, loggedId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/profile/followings?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="followerId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProfileFollowingsOsAndroidAsync(
                int userId,
                int followerId,
                string lang,
                int loggedId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/profile/followings");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("follower_id", followerId),
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/profile/followers?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="followerId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProfileFollowersOsAndroid(
                int userId,
                int followerId,
                string lang,
                int loggedId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProfileFollowersOsAndroidAsync(userId, followerId, lang, loggedId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/profile/followers?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="followerId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProfileFollowersOsAndroidAsync(
                int userId,
                int followerId,
                string lang,
                int loggedId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/profile/followers");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("follower_id", followerId),
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/inbox?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="offset">Required parameter: Example: .</param>
        /// <param name="limit">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiInboxOsAndroid(
                string os,
                string lang,
                int loggedId,
                int userId,
                int offset,
                int limit)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiInboxOsAndroidAsync(os, lang, loggedId, userId, offset, limit);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/inbox?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="offset">Required parameter: Example: .</param>
        /// <param name="limit">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiInboxOsAndroidAsync(
                string os,
                string lang,
                int loggedId,
                int userId,
                int offset,
                int limit,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/inbox");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("offset", offset),
                new KeyValuePair<string, object>("limit", limit),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/chat?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiChatOsAndroid(
                string lang,
                int loggedId,
                string productId,
                string storeId,
                int userId,
                string os,
                int page)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiChatOsAndroidAsync(lang, loggedId, productId, storeId, userId, os, page);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/chat?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiChatOsAndroidAsync(
                string lang,
                int loggedId,
                string productId,
                string storeId,
                int userId,
                string os,
                int page,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/chat");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("product_id", productId),
                new KeyValuePair<string, object>("store_id", storeId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("os", os),
                new KeyValuePair<string, object>("page", page),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/send?os=android EndPoint.
        /// </summary>
        /// <param name="senderId">Required parameter: Example: .</param>
        /// <param name="receiverId">Required parameter: Example: .</param>
        /// <param name="message">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionSendOsAndroid(
                int senderId,
                int receiverId,
                string message,
                string image,
                string os)
        {
            Task t = this.ProductionSendOsAndroidAsync(senderId, receiverId, message, image, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/send?os=android EndPoint.
        /// </summary>
        /// <param name="senderId">Required parameter: Example: .</param>
        /// <param name="receiverId">Required parameter: Example: .</param>
        /// <param name="message">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionSendOsAndroidAsync(
                int senderId,
                int receiverId,
                string message,
                string image,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/send");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("sender_id", senderId),
                new KeyValuePair<string, object>("receiver_id", receiverId),
                new KeyValuePair<string, object>("message", message),
                new KeyValuePair<string, object>("image", image),
                new KeyValuePair<string, object>("os", os),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/block_list?os=android&lang=en&logged_id=1&user_id=1 EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiUserBlockListOsAndroidLangEnLoggedId1UserId1(
                string lang,
                int loggedId,
                int userId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiUserBlockListOsAndroidLangEnLoggedId1UserId1Async(lang, loggedId, userId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/block_list?os=android&lang=en&logged_id=1&user_id=1 EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiUserBlockListOsAndroidLangEnLoggedId1UserId1Async(
                string lang,
                int loggedId,
                int userId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/user/block_list");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "lang", lang },
                { "logged_id", loggedId },
                { "user_id", userId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, null, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/block?os=android&lang=en&logged_id=69&user_id=69&blocked_id=1 EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="blockedId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiUserBlockOsAndroidLangEnLoggedId69UserId69BlockedId1(
                string lang,
                int loggedId,
                int userId,
                int blockedId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiUserBlockOsAndroidLangEnLoggedId69UserId69BlockedId1Async(lang, loggedId, userId, blockedId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/block?os=android&lang=en&logged_id=69&user_id=69&blocked_id=1 EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="blockedId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiUserBlockOsAndroidLangEnLoggedId69UserId69BlockedId1Async(
                string lang,
                int loggedId,
                int userId,
                int blockedId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/user/block");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "lang", lang },
                { "logged_id", loggedId },
                { "user_id", userId },
                { "blocked_id", blockedId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, null, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/follow?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="followerId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiUserFollowOsAndroid(
                string os,
                int userId,
                int followerId,
                string lang,
                int loggedId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiUserFollowOsAndroidAsync(os, userId, followerId, lang, loggedId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/follow?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="followerId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiUserFollowOsAndroidAsync(
                string os,
                int userId,
                int followerId,
                string lang,
                int loggedId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/user/follow");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("follower_id", followerId),
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/price-offer/create?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="productPrice">Required parameter: Example: .</param>
        /// <param name="price">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiPriceOfferCreateOsAndroid(
                int userId,
                int productId,
                int countryId,
                int productPrice,
                int price,
                string os)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiPriceOfferCreateOsAndroidAsync(userId, productId, countryId, productPrice, price, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/price-offer/create?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="productPrice">Required parameter: Example: .</param>
        /// <param name="price">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiPriceOfferCreateOsAndroidAsync(
                int userId,
                int productId,
                int countryId,
                int productPrice,
                int price,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/price-offer/create");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("product_id", productId),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("product_price", productPrice),
                new KeyValuePair<string, object>("price", price),
                new KeyValuePair<string, object>("os", os),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/price-offer/offers?product_id=39&user_id=3&os=android EndPoint.
        /// </summary>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiPriceOfferOffersProductId39UserId3OsAndroid(
                int productId,
                int userId,
                string os)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiPriceOfferOffersProductId39UserId3OsAndroidAsync(productId, userId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/price-offer/offers?product_id=39&user_id=3&os=android EndPoint.
        /// </summary>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiPriceOfferOffersProductId39UserId3OsAndroidAsync(
                int productId,
                int userId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/price-offer/offers");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "product_id", productId },
                { "user_id", userId },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/price-offer/replies?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="priceOfferId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiPriceOfferRepliesOsAndroid(
                string os,
                string lang,
                int userId,
                int loggedId,
                int countryId,
                int priceOfferId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiPriceOfferRepliesOsAndroidAsync(os, lang, userId, loggedId, countryId, priceOfferId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/price-offer/replies?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="priceOfferId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiPriceOfferRepliesOsAndroidAsync(
                string os,
                string lang,
                int userId,
                int loggedId,
                int countryId,
                int priceOfferId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/price-offer/replies");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("price_offer_id", priceOfferId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/price-offer/delete?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="offerId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiPriceOfferDeleteOsAndroid(
                int userId,
                string os,
                int loggedId,
                int offerId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiPriceOfferDeleteOsAndroidAsync(userId, os, loggedId, offerId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/price-offer/delete?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="offerId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiPriceOfferDeleteOsAndroidAsync(
                int userId,
                string os,
                int loggedId,
                int offerId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/price-offer/delete");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("os", os),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("offer_id", offerId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/price-offer/delete-reply?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="offerId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiPriceOfferDeleteReplyOsAndroid(
                int userId,
                string os,
                int loggedId,
                int offerId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiPriceOfferDeleteReplyOsAndroidAsync(userId, os, loggedId, offerId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/price-offer/delete-reply?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="offerId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiPriceOfferDeleteReplyOsAndroidAsync(
                int userId,
                string os,
                int loggedId,
                int offerId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/price-offer/delete-reply");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("os", os),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("offer_id", offerId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/delete?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="reasons">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProductDeleteOsAndroid(
                string os,
                string lang,
                int loggedId,
                int userId,
                int id,
                string reasons)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProductDeleteOsAndroidAsync(os, lang, loggedId, userId, id, reasons);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/delete?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="id">Required parameter: Example: .</param>
        /// <param name="reasons">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProductDeleteOsAndroidAsync(
                string os,
                string lang,
                int loggedId,
                int userId,
                int id,
                string reasons,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/product/delete");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("id", id),
                new KeyValuePair<string, object>("reasons", reasons),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/delete_reasons?os=android&lang=en EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProductDeleteReasonsOsAndroidLangEn(
                string lang)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProductDeleteReasonsOsAndroidLangEnAsync(lang);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/delete_reasons?os=android&lang=en EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProductDeleteReasonsOsAndroidLangEnAsync(
                string lang,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/product/delete_reasons");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "lang", lang },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/cart?user_id=7&country_id=3&lang=en&os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiCartUserId7CountryId3LangEnOsAndroid(
                int userId,
                int countryId,
                string lang,
                string os)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiCartUserId7CountryId3LangEnOsAndroidAsync(userId, countryId, lang, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/cart?user_id=7&country_id=3&lang=en&os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiCartUserId7CountryId3LangEnOsAndroidAsync(
                int userId,
                int countryId,
                string lang,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/cart");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "user_id", userId },
                { "country_id", countryId },
                { "lang", lang },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/cart/add?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="quantity">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="colorId">Required parameter: Example: .</param>
        /// <param name="sizeId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiCartAddOsAndroid(
                int userId,
                int productId,
                int countryId,
                int quantity,
                int loggedId,
                string colorId,
                string sizeId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiCartAddOsAndroidAsync(userId, productId, countryId, quantity, loggedId, colorId, sizeId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/cart/add?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="quantity">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="colorId">Required parameter: Example: .</param>
        /// <param name="sizeId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiCartAddOsAndroidAsync(
                int userId,
                int productId,
                int countryId,
                int quantity,
                int loggedId,
                string colorId,
                string sizeId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/cart/add");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("product_id", productId),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("quantity", quantity),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("color_id", colorId),
                new KeyValuePair<string, object>("size_id", sizeId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/cart/clear&os=Android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiCartClearOsAndroid(
                string lang,
                int userId,
                int countryId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiCartClearOsAndroidAsync(lang, userId, countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/cart/clear&os=Android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiCartClearOsAndroidAsync(
                string lang,
                int userId,
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/cart/clear&os=Android");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("country_id", countryId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/cart/delete?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cartId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiCartDeleteOsAndroid(
                int userId,
                int cartId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiCartDeleteOsAndroidAsync(userId, cartId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/cart/delete?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cartId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiCartDeleteOsAndroidAsync(
                int userId,
                int cartId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/cart/delete");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("cart_id", cartId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/checkout?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="addressId">Required parameter: Example: .</param>
        /// <param name="paymentType">Required parameter: Example: .</param>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="time">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="isFast">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="sName">Required parameter: Example: .</param>
        /// <param name="fName">Required parameter: Example: .</param>
        /// <param name="points">Required parameter: Example: .</param>
        public void ProductionCheckoutOsAndroid(
                string os,
                string lang,
                int loggedId,
                int userId,
                int countryId,
                int addressId,
                int paymentType,
                string date,
                string time,
                int type,
                int isFast,
                long mobile,
                string sName,
                string fName,
                string points)
        {
            Task t = this.ProductionCheckoutOsAndroidAsync(os, lang, loggedId, userId, countryId, addressId, paymentType, date, time, type, isFast, mobile, sName, fName, points);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/checkout?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="addressId">Required parameter: Example: .</param>
        /// <param name="paymentType">Required parameter: Example: .</param>
        /// <param name="date">Required parameter: Example: .</param>
        /// <param name="time">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="isFast">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="sName">Required parameter: Example: .</param>
        /// <param name="fName">Required parameter: Example: .</param>
        /// <param name="points">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionCheckoutOsAndroidAsync(
                string os,
                string lang,
                int loggedId,
                int userId,
                int countryId,
                int addressId,
                int paymentType,
                string date,
                string time,
                int type,
                int isFast,
                long mobile,
                string sName,
                string fName,
                string points,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/checkout");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Content-Type", "application/x-www-form-urlencoded" },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("address_id", addressId),
                new KeyValuePair<string, object>("payment_type", paymentType),
                new KeyValuePair<string, object>("date", date),
                new KeyValuePair<string, object>("time", time),
                new KeyValuePair<string, object>("type", type),
                new KeyValuePair<string, object>("is_fast", isFast),
                new KeyValuePair<string, object>("mobile", mobile),
                new KeyValuePair<string, object>("s_name", sName),
                new KeyValuePair<string, object>("f_name", fName),
                new KeyValuePair<string, object>("points", points),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/calc_delivery?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="addressId">Required parameter: Example: .</param>
        /// <param name="isFast">Required parameter: Example: .</param>
        public void ProductionCalcDeliveryOsAndroid(
                string os,
                int userId,
                int countryId,
                int addressId,
                int isFast)
        {
            Task t = this.ProductionCalcDeliveryOsAndroidAsync(os, userId, countryId, addressId, isFast);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/calc_delivery?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="addressId">Required parameter: Example: .</param>
        /// <param name="isFast">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionCalcDeliveryOsAndroidAsync(
                string os,
                int userId,
                int countryId,
                int addressId,
                int isFast,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/calc_delivery");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("address_id", addressId),
                new KeyValuePair<string, object>("is_fast", isFast),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/colors_sizes?os=android EndPoint.
        /// </summary>
        public void HttpDalilishopSmartstepEgComApiColorsSizesOsAndroid()
        {
            Task t = this.HttpDalilishopSmartstepEgComApiColorsSizesOsAndroidAsync();
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/colors_sizes?os=android EndPoint.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiColorsSizesOsAndroidAsync(CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/colors_sizes");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/list_categories?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void ProductionListCategoriesOsAndroid(
                string os,
                int countryId)
        {
            Task t = this.ProductionListCategoriesOsAndroidAsync(os, countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/list_categories?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionListCategoriesOsAndroidAsync(
                string os,
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/list_categories");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "country_id", countryId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/stores_categories?os=Android&lang=en&country_id=3 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void ProductionStoresCategoriesOsAndroidLangEnCountryId3(
                string os,
                string lang,
                int countryId)
        {
            Task t = this.ProductionStoresCategoriesOsAndroidLangEnCountryId3Async(os, lang, countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/stores_categories?os=Android&lang=en&country_id=3 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionStoresCategoriesOsAndroidLangEnCountryId3Async(
                string os,
                string lang,
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/stores_categories");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
                { "country_id", countryId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/home-categories?os=android&country_id=3 EndPoint.
        /// </summary>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiHomeCategoriesOsAndroidCountryId3(
                int countryId,
                string os)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiHomeCategoriesOsAndroidCountryId3Async(countryId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/home-categories?os=android&country_id=3 EndPoint.
        /// </summary>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiHomeCategoriesOsAndroidCountryId3Async(
                int countryId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/home-categories");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "country_id", countryId },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/category?os=Android&lang=en&category_id=1&logged_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiCategoryOsAndroidLangEnCategoryId1LoggedId1(
                string os,
                string lang,
                int categoryId,
                int loggedId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiCategoryOsAndroidLangEnCategoryId1LoggedId1Async(os, lang, categoryId, loggedId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/category?os=Android&lang=en&category_id=1&logged_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiCategoryOsAndroidLangEnCategoryId1LoggedId1Async(
                string os,
                string lang,
                int categoryId,
                int loggedId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/category");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
                { "category_id", categoryId },
                { "logged_id", loggedId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/categories?os=android&logged_id=1&country_id=2 EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="dCCOMICS">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiCategoriesOsAndroidLoggedId1CountryId2(
                int loggedId,
                int countryId,
                string os,
                double dCCOMICS)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiCategoriesOsAndroidLoggedId1CountryId2Async(loggedId, countryId, os, dCCOMICS);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/categories?os=android&logged_id=1&country_id=2 EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="dCCOMICS">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiCategoriesOsAndroidLoggedId1CountryId2Async(
                int loggedId,
                int countryId,
                string os,
                double dCCOMICS,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/categories");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "logged_id", loggedId },
                { "country_id", countryId },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "DCCOMICS", dCCOMICS.ToString() },
                { "Content-Type", "text/plain" },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/view_history?os=android&lang=en&logged_id=1 EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiViewHistoryOsAndroidLangEnLoggedId1(
                string lang,
                int loggedId,
                string os,
                int cityId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiViewHistoryOsAndroidLangEnLoggedId1Async(lang, loggedId, os, cityId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/view_history?os=android&lang=en&logged_id=1 EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiViewHistoryOsAndroidLangEnLoggedId1Async(
                string lang,
                int loggedId,
                string os,
                int cityId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/view_history");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "lang", lang },
                { "logged_id", loggedId },
                { "os", os },
                { "city_id", cityId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, null, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/timeline EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionTimeline(
                string lang,
                int loggedId,
                int page,
                int cityId,
                string os)
        {
            Task t = this.ProductionTimelineAsync(lang, loggedId, page, cityId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/timeline EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionTimelineAsync(
                string lang,
                int loggedId,
                int page,
                int cityId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/timeline");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("page", page),
                new KeyValuePair<string, object>("city_id", cityId),
                new KeyValuePair<string, object>("os", os),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/comments?user_id=3&country_id=3&product_id=53&os=android1 EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53OsAndroid1(
                int userId,
                int countryId,
                int productId,
                string os)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53OsAndroid1Async(userId, countryId, productId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/comments?user_id=3&country_id=3&product_id=53&os=android1 EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53OsAndroid1Async(
                int userId,
                int countryId,
                int productId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/product/comments");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "user_id", userId },
                { "country_id", countryId },
                { "product_id", productId },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/comment?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProductCommentOsAndroid(
                string os,
                string lang,
                int userId,
                int productId,
                string image)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProductCommentOsAndroidAsync(os, lang, userId, productId, image);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/comment?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProductCommentOsAndroidAsync(
                string os,
                string lang,
                int userId,
                int productId,
                string image,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/product/comment");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("product_id", productId),
                new KeyValuePair<string, object>("image", image),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/rate?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="rate">Required parameter: Example: .</param>
        /// <param name="comment">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProductRateOsAndroid(
                int userId,
                int productId,
                int rate,
                string comment)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProductRateOsAndroidAsync(userId, productId, rate, comment);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product/rate?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="rate">Required parameter: Example: .</param>
        /// <param name="comment">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProductRateOsAndroidAsync(
                int userId,
                int productId,
                int rate,
                string comment,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/product/rate");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("product_id", productId),
                new KeyValuePair<string, object>("rate", rate),
                new KeyValuePair<string, object>("comment", comment),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/profile/likes?os=android EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProfileLikesOsAndroid(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                int userId,
                string lang)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProfileLikesOsAndroidAsync(nasser, aPPVERSION, mOBILEOS, userId, lang);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/profile/likes?os=android EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProfileLikesOsAndroidAsync(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                int userId,
                string lang,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/profile/likes");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("lang", lang),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/offers?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="users">Required parameter: Example: .</param>
        public void HttpDaliliHerokuappComApiOffersOsAndroid(
                string os,
                int countryId,
                List<int> users)
        {
            Task t = this.HttpDaliliHerokuappComApiOffersOsAndroidAsync(os, countryId, users);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/offers?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="users">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDaliliHerokuappComApiOffersOsAndroidAsync(
                string os,
                int countryId,
                List<int> users,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/offers");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("country_id", countryId),
            };
            fields.AddRange(ApiHelper.PrepareFormFieldsFromObject("users", users, arrayDeserializationFormat: this.ArrayDeserializationFormat));

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/offers/lists?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="categories">Required parameter: Example: .</param>
        public void ProductionOffersListsOsAndroid(
                string os,
                int loggedId,
                int userId,
                int countryId,
                List<string> categories)
        {
            Task t = this.ProductionOffersListsOsAndroidAsync(os, loggedId, userId, countryId, categories);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/offers/lists?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="categories">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionOffersListsOsAndroidAsync(
                string os,
                int loggedId,
                int userId,
                int countryId,
                List<string> categories,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/offers/lists");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("country_id", countryId),
            };
            fields.AddRange(ApiHelper.PrepareFormFieldsFromObject("categories", categories, arrayDeserializationFormat: this.ArrayDeserializationFormat));

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/offers/categories?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiOffersCategoriesOsAndroid(
                int userId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiOffersCategoriesOsAndroidAsync(userId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/offers/categories?os=android EndPoint.
        /// </summary>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiOffersCategoriesOsAndroidAsync(
                int userId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/offers/categories");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/offers/switch_notification?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="categories">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        public void HttpDaliliHerokuappComApiOffersSwitchNotificationOsAndroid(
                string os,
                List<Models.Category> categories,
                int userId)
        {
            Task t = this.HttpDaliliHerokuappComApiOffersSwitchNotificationOsAndroidAsync(os, categories, userId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/offers/switch_notification?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="categories">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDaliliHerokuappComApiOffersSwitchNotificationOsAndroidAsync(
                string os,
                List<Models.Category> categories,
                int userId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server4);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/offers/switch_notification");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
            };
            fields.AddRange(ApiHelper.PrepareFormFieldsFromObject("categories", categories, arrayDeserializationFormat: this.ArrayDeserializationFormat));

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/offers/comment?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="offerId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="comment">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiOffersCommentOsAndroid(
                string os,
                string lang,
                int offerId,
                int userId,
                string comment)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiOffersCommentOsAndroidAsync(os, lang, offerId, userId, comment);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/offers/comment?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="offerId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="comment">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiOffersCommentOsAndroidAsync(
                string os,
                string lang,
                int offerId,
                int userId,
                string comment,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/offers/comment");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("os", os),
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("offer_id", offerId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("comment", comment),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/offers/comments?os=Android&lang=en&offer_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="offerId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiOffersCommentsOsAndroidLangEnOfferId1(
                string os,
                string lang,
                int offerId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiOffersCommentsOsAndroidLangEnOfferId1Async(os, lang, offerId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/offers/comments?os=Android&lang=en&offer_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="offerId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiOffersCommentsOsAndroidLangEnOfferId1Async(
                string os,
                string lang,
                int offerId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/offers/comments");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
                { "offer_id", offerId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/offers/create?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="enName">Required parameter: Example: .</param>
        /// <param name="arName">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="isActive">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="enDesc">Required parameter: Example: .</param>
        /// <param name="arDesc">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="address">Required parameter: Example: .</param>
        /// <param name="bg">Required parameter: Example: .</param>
        public void HttpDaliliHerokuappComApiOffersCreateOsAndroid(
                string os,
                int loggedId,
                int userId,
                string lang,
                string enName,
                string arName,
                int categoryId,
                int isActive,
                int storeId,
                string image,
                string enDesc,
                string arDesc,
                int countryId,
                int regionId,
                int cityId,
                string address,
                string bg)
        {
            Task t = this.HttpDaliliHerokuappComApiOffersCreateOsAndroidAsync(os, loggedId, userId, lang, enName, arName, categoryId, isActive, storeId, image, enDesc, arDesc, countryId, regionId, cityId, address, bg);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/offers/create?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="enName">Required parameter: Example: .</param>
        /// <param name="arName">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="isActive">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="enDesc">Required parameter: Example: .</param>
        /// <param name="arDesc">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="address">Required parameter: Example: .</param>
        /// <param name="bg">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDaliliHerokuappComApiOffersCreateOsAndroidAsync(
                string os,
                int loggedId,
                int userId,
                string lang,
                string enName,
                string arName,
                int categoryId,
                int isActive,
                int storeId,
                string image,
                string enDesc,
                string arDesc,
                int countryId,
                int regionId,
                int cityId,
                string address,
                string bg,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server4);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/offers/create");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("en_name", enName),
                new KeyValuePair<string, object>("ar_name", arName),
                new KeyValuePair<string, object>("category_id", categoryId),
                new KeyValuePair<string, object>("is_active", isActive),
                new KeyValuePair<string, object>("store_id", storeId),
                new KeyValuePair<string, object>("image", image),
                new KeyValuePair<string, object>("en_desc", enDesc),
                new KeyValuePair<string, object>("ar_desc", arDesc),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("region_id", regionId),
                new KeyValuePair<string, object>("city_id", cityId),
                new KeyValuePair<string, object>("address", address),
                new KeyValuePair<string, object>("bg", bg),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/offers/edit?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="categories">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="offerId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiOffersEditOsAndroid(
                string os,
                string lang,
                List<string> categories,
                int userId,
                int loggedId,
                int countryId,
                int offerId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiOffersEditOsAndroidAsync(os, lang, categories, userId, loggedId, countryId, offerId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/offers/edit?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="categories">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="offerId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiOffersEditOsAndroidAsync(
                string os,
                string lang,
                List<string> categories,
                int userId,
                int loggedId,
                int countryId,
                int offerId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/offers/edit");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("offer_id", offerId),
            };
            fields.AddRange(ApiHelper.PrepareFormFieldsFromObject("categories", categories, arrayDeserializationFormat: this.ArrayDeserializationFormat));

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/store/create?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="enName">Required parameter: Example: .</param>
        /// <param name="arName">Required parameter: Example: .</param>
        /// <param name="categories">Required parameter: Example: .</param>
        /// <param name="isActive">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="enDesc">Required parameter: Example: .</param>
        /// <param name="arDesc">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="address">Required parameter: Example: .</param>
        /// <param name="bg">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="mLong">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiStoreCreateOsAndroid(
                string os,
                int loggedId,
                int userId,
                string lang,
                string enName,
                string arName,
                List<int> categories,
                int isActive,
                string image,
                string enDesc,
                string arDesc,
                int countryId,
                int regionId,
                int cityId,
                string address,
                string bg,
                int lat,
                int mLong)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiStoreCreateOsAndroidAsync(os, loggedId, userId, lang, enName, arName, categories, isActive, image, enDesc, arDesc, countryId, regionId, cityId, address, bg, lat, mLong);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/store/create?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="enName">Required parameter: Example: .</param>
        /// <param name="arName">Required parameter: Example: .</param>
        /// <param name="categories">Required parameter: Example: .</param>
        /// <param name="isActive">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="enDesc">Required parameter: Example: .</param>
        /// <param name="arDesc">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="address">Required parameter: Example: .</param>
        /// <param name="bg">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiStoreCreateOsAndroidAsync(
                string os,
                int loggedId,
                int userId,
                string lang,
                string enName,
                string arName,
                List<int> categories,
                int isActive,
                string image,
                string enDesc,
                string arDesc,
                int countryId,
                int regionId,
                int cityId,
                string address,
                string bg,
                int lat,
                int mLong,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/store/create");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("en_name", enName),
                new KeyValuePair<string, object>("ar_name", arName),
                new KeyValuePair<string, object>("is_active", isActive),
                new KeyValuePair<string, object>("image", image),
                new KeyValuePair<string, object>("en_desc", enDesc),
                new KeyValuePair<string, object>("ar_desc", arDesc),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("region_id", regionId),
                new KeyValuePair<string, object>("city_id", cityId),
                new KeyValuePair<string, object>("address", address),
                new KeyValuePair<string, object>("bg", bg),
                new KeyValuePair<string, object>("lat", lat),
                new KeyValuePair<string, object>("long", mLong),
            };
            fields.AddRange(ApiHelper.PrepareFormFieldsFromObject("categories", categories, arrayDeserializationFormat: this.ArrayDeserializationFormat));

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/store/edit?os=android EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="isActive">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiStoreEditOsAndroid(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                int userId,
                string lang,
                int storeId,
                int isActive)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiStoreEditOsAndroidAsync(nasser, aPPVERSION, mOBILEOS, userId, lang, storeId, isActive);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/store/edit?os=android EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="isActive">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiStoreEditOsAndroidAsync(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                int userId,
                string lang,
                int storeId,
                int isActive,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/store/edit");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("store_id", storeId),
                new KeyValuePair<string, object>("is_active", isActive),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/user/stores?os=Android&lang=en&logged_id=1&user_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        public void ProductionUserStoresOsAndroidLangEnLoggedId1UserId1(
                string os,
                string lang,
                int loggedId,
                int userId)
        {
            Task t = this.ProductionUserStoresOsAndroidLangEnLoggedId1UserId1Async(os, lang, loggedId, userId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/user/stores?os=Android&lang=en&logged_id=1&user_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionUserStoresOsAndroidLangEnLoggedId1UserId1Async(
                string os,
                string lang,
                int loggedId,
                int userId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/user/stores");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
                { "logged_id", loggedId },
                { "user_id", userId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/stores?os=Android&lang=en&logged_id=1&user_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiUserStoresOsAndroidLangEnLoggedId1UserId1(
                string os,
                string lang,
                int loggedId,
                int userId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiUserStoresOsAndroidLangEnLoggedId1UserId1Async(os, lang, loggedId, userId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/stores?os=Android&lang=en&logged_id=1&user_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiUserStoresOsAndroidLangEnLoggedId1UserId1Async(
                string os,
                string lang,
                int loggedId,
                int userId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/user/stores");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
                { "logged_id", loggedId },
                { "user_id", userId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/store?os=Android&lang=en&user_id=1&store_id=21&page=1&logged_id=1&country_id=3 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void ProductionStoreOsAndroidLangEnUserId1StoreId21Page1LoggedId1CountryId3(
                string os,
                string lang,
                int userId,
                int storeId,
                int page,
                int loggedId,
                int countryId)
        {
            Task t = this.ProductionStoreOsAndroidLangEnUserId1StoreId21Page1LoggedId1CountryId3Async(os, lang, userId, storeId, page, loggedId, countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/store?os=Android&lang=en&user_id=1&store_id=21&page=1&logged_id=1&country_id=3 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionStoreOsAndroidLangEnUserId1StoreId21Page1LoggedId1CountryId3Async(
                string os,
                string lang,
                int userId,
                int storeId,
                int page,
                int loggedId,
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/store");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
                { "user_id", userId },
                { "store_id", storeId },
                { "page", page },
                { "logged_id", loggedId },
                { "country_id", countryId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/stores?os=Android&lang=en&logged_id=73&user_id=73&category_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void ProductionStoresOsAndroidLangEnLoggedId73UserId73CategoryId1(
                string os,
                string lang,
                int loggedId,
                int userId,
                int categoryId,
                List<string> cityId,
                List<string> regionId,
                int lat,
                int mLong,
                int countryId)
        {
            Task t = this.ProductionStoresOsAndroidLangEnLoggedId73UserId73CategoryId1Async(os, lang, loggedId, userId, categoryId, cityId, regionId, lat, mLong, countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/stores?os=Android&lang=en&logged_id=73&user_id=73&category_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionStoresOsAndroidLangEnLoggedId73UserId73CategoryId1Async(
                string os,
                string lang,
                int loggedId,
                int userId,
                int categoryId,
                List<string> cityId,
                List<string> regionId,
                int lat,
                int mLong,
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/stores");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
                { "logged_id", loggedId },
                { "user_id", userId },
                { "category_id", categoryId },
                { "city_id", cityId },
                { "region_id", regionId },
                { "lat", lat },
                { "long", mLong },
                { "country_id", countryId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/store/rates?os=Android&lang=en&user_id=1&store_id=4&page=1&logged_id=1&country_id=3 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiStoreRatesOsAndroidLangEnUserId1StoreId4Page1LoggedId1CountryId3(
                string os,
                string lang,
                int userId,
                int storeId,
                int page,
                int loggedId,
                int countryId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiStoreRatesOsAndroidLangEnUserId1StoreId4Page1LoggedId1CountryId3Async(os, lang, userId, storeId, page, loggedId, countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/store/rates?os=Android&lang=en&user_id=1&store_id=4&page=1&logged_id=1&country_id=3 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiStoreRatesOsAndroidLangEnUserId1StoreId4Page1LoggedId1CountryId3Async(
                string os,
                string lang,
                int userId,
                int storeId,
                int page,
                int loggedId,
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/store/rates");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
                { "user_id", userId },
                { "store_id", storeId },
                { "page", page },
                { "logged_id", loggedId },
                { "country_id", countryId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/store/rate?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="comment">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiStoreRateOsAndroid(
                string lang,
                int userId,
                int storeId,
                string comment,
                int loggedId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiStoreRateOsAndroidAsync(lang, userId, storeId, comment, loggedId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/store/rate?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="comment">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiStoreRateOsAndroidAsync(
                string lang,
                int userId,
                int storeId,
                string comment,
                int loggedId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/store/rate");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("store_id", storeId),
                new KeyValuePair<string, object>("comment", comment),
                new KeyValuePair<string, object>("logged_id", loggedId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/store/products?os=Android&lang=en&user_id=1&store_id=21&page=1&country_id=3&keyword=Shirt EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void ProductionStoreProductsOsAndroidLangEnUserId1StoreId21Page1CountryId3KeywordShirt(
                string os,
                string lang,
                int userId,
                int storeId,
                int page,
                int countryId)
        {
            Task t = this.ProductionStoreProductsOsAndroidLangEnUserId1StoreId21Page1CountryId3KeywordShirtAsync(os, lang, userId, storeId, page, countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/store/products?os=Android&lang=en&user_id=1&store_id=21&page=1&country_id=3&keyword=Shirt EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionStoreProductsOsAndroidLangEnUserId1StoreId21Page1CountryId3KeywordShirtAsync(
                string os,
                string lang,
                int userId,
                int storeId,
                int page,
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/store/products");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
                { "user_id", userId },
                { "store_id", storeId },
                { "page", page },
                { "country_id", countryId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/store/follow?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="followerId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiStoreFollowOsAndroid(
                string lang,
                int loggedId,
                int userId,
                int storeId,
                int followerId,
                string os)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiStoreFollowOsAndroidAsync(lang, loggedId, userId, storeId, followerId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/store/follow?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="followerId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiStoreFollowOsAndroidAsync(
                string lang,
                int loggedId,
                int userId,
                int storeId,
                int followerId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/store/follow");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("store_id", storeId),
                new KeyValuePair<string, object>("follower_id", followerId),
                new KeyValuePair<string, object>("os", os),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/store/followers?store_id=1&os=android EndPoint.
        /// </summary>
        /// <param name="storeId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiStoreFollowersStoreId1OsAndroid(
                int storeId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiStoreFollowersStoreId1OsAndroidAsync(storeId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/store/followers?store_id=1&os=android EndPoint.
        /// </summary>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiStoreFollowersStoreId1OsAndroidAsync(
                int storeId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/store/followers");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "store_id", storeId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/orders/stores?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        public void ProductionOrdersStoresOsAndroid(
                string os,
                string lang,
                int loggedId,
                int storeId)
        {
            Task t = this.ProductionOrdersStoresOsAndroidAsync(os, lang, loggedId, storeId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/orders/stores?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionOrdersStoresOsAndroidAsync(
                string os,
                string lang,
                int loggedId,
                int storeId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/orders/stores");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("store_id", storeId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/orders/stores?os=android&store_id=1&lang=en EndPoint.
        /// </summary>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiOrdersStoresOsAndroidStoreId1LangEn(
                int storeId,
                string lang)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiOrdersStoresOsAndroidStoreId1LangEnAsync(storeId, lang);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/orders/stores?os=android&store_id=1&lang=en EndPoint.
        /// </summary>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiOrdersStoresOsAndroidStoreId1LangEnAsync(
                int storeId,
                string lang,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/orders/stores");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "store_id", storeId },
                { "lang", lang },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, null, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/store/order?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        public void HttpDaliliHerokuappComApiStoreOrderOsAndroid(
                string os,
                string lang,
                int loggedId,
                int userId,
                int orderId,
                int storeId)
        {
            Task t = this.HttpDaliliHerokuappComApiStoreOrderOsAndroidAsync(os, lang, loggedId, userId, orderId, storeId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/store/order?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDaliliHerokuappComApiStoreOrderOsAndroidAsync(
                string os,
                string lang,
                int loggedId,
                int userId,
                int orderId,
                int storeId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/store/order");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("order_id", orderId),
                new KeyValuePair<string, object>("store_id", storeId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/order/action?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cartId">Required parameter: Example: .</param>
        /// <param name="action">Required parameter: Example: .</param>
        /// <param name="comment">Required parameter: Example: .</param>
        public void ProductionOrderActionOsAndroid(
                string os,
                int cartId,
                int action,
                string comment)
        {
            Task t = this.ProductionOrderActionOsAndroidAsync(os, cartId, action, comment);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/order/action?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cartId">Required parameter: Example: .</param>
        /// <param name="action">Required parameter: Example: .</param>
        /// <param name="comment">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionOrderActionOsAndroidAsync(
                string os,
                int cartId,
                int action,
                string comment,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/order/action");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("cart_id", cartId),
                new KeyValuePair<string, object>("action", action),
                new KeyValuePair<string, object>("comment", comment),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/order/report?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="comment">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiOrderReportOsAndroid(
                string lang,
                int userId,
                int orderId,
                string comment,
                string image,
                string os)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiOrderReportOsAndroidAsync(lang, userId, orderId, comment, image, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/order/report?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="comment">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiOrderReportOsAndroidAsync(
                string lang,
                int userId,
                int orderId,
                string comment,
                string image,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/order/report");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("order_id", orderId),
                new KeyValuePair<string, object>("comment", comment),
                new KeyValuePair<string, object>("image", image),
                new KeyValuePair<string, object>("os", os),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/store/sales?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        public void HttpDaliliHerokuappComApiStoreSalesOsAndroid(
                string os,
                string lang,
                int loggedId,
                int storeId)
        {
            Task t = this.HttpDaliliHerokuappComApiStoreSalesOsAndroidAsync(os, lang, loggedId, storeId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/store/sales?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDaliliHerokuappComApiStoreSalesOsAndroidAsync(
                string os,
                string lang,
                int loggedId,
                int storeId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/store/sales");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("store_id", storeId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/best_seller/stores?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiBestSellerStoresOsAndroid(
                string lang,
                int loggedId,
                int storeId,
                string os)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiBestSellerStoresOsAndroidAsync(lang, loggedId, storeId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/best_seller/stores?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiBestSellerStoresOsAndroidAsync(
                string lang,
                int loggedId,
                int storeId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/best_seller/stores");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("store_id", storeId),
                new KeyValuePair<string, object>("os", os),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/paid_orders/stores?os=android EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiPaidOrdersStoresOsAndroid(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                int storeId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiPaidOrdersStoresOsAndroidAsync(nasser, aPPVERSION, mOBILEOS, lang, storeId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/paid_orders/stores?os=android EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiPaidOrdersStoresOsAndroidAsync(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                int storeId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/paid_orders/stores");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("store_id", storeId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/unpaid_orders/stores?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        public void ProductionUnpaidOrdersStoresOsAndroid(
                string os,
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                int storeId)
        {
            Task t = this.ProductionUnpaidOrdersStoresOsAndroidAsync(os, nasser, aPPVERSION, mOBILEOS, lang, storeId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/unpaid_orders/stores?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="storeId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionUnpaidOrdersStoresOsAndroidAsync(
                string os,
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                int storeId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/unpaid_orders/stores");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("store_id", storeId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/add_address?os=android EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="address">Required parameter: Example: .</param>
        /// <param name="street">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="building">Required parameter: Example: .</param>
        /// <param name="phone">Required parameter: Example: .</param>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="floor">Required parameter: Example: .</param>
        /// <param name="apartment">Required parameter: Example: .</param>
        /// <param name="landmark">Required parameter: Example: .</param>
        /// <param name="postalCode">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiUserAddAddressOsAndroid(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                int userId,
                string lang,
                int countryId,
                int cityId,
                string name,
                string address,
                string street,
                int mobile,
                double mLong,
                int building,
                int phone,
                int regionId,
                double lat,
                int floor,
                string apartment,
                string landmark,
                string postalCode,
                string os)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiUserAddAddressOsAndroidAsync(nasser, aPPVERSION, mOBILEOS, userId, lang, countryId, cityId, name, address, street, mobile, mLong, building, phone, regionId, lat, floor, apartment, landmark, postalCode, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/add_address?os=android EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="address">Required parameter: Example: .</param>
        /// <param name="street">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="building">Required parameter: Example: .</param>
        /// <param name="phone">Required parameter: Example: .</param>
        /// <param name="regionId">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="floor">Required parameter: Example: .</param>
        /// <param name="apartment">Required parameter: Example: .</param>
        /// <param name="landmark">Required parameter: Example: .</param>
        /// <param name="postalCode">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiUserAddAddressOsAndroidAsync(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                int userId,
                string lang,
                int countryId,
                int cityId,
                string name,
                string address,
                string street,
                int mobile,
                double mLong,
                int building,
                int phone,
                int regionId,
                double lat,
                int floor,
                string apartment,
                string landmark,
                string postalCode,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/user/add_address");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("city_id", cityId),
                new KeyValuePair<string, object>("name", name),
                new KeyValuePair<string, object>("address", address),
                new KeyValuePair<string, object>("street", street),
                new KeyValuePair<string, object>("mobile", mobile),
                new KeyValuePair<string, object>("long", mLong),
                new KeyValuePair<string, object>("building", building),
                new KeyValuePair<string, object>("phone", phone),
                new KeyValuePair<string, object>("region_id", regionId),
                new KeyValuePair<string, object>("lat", lat),
                new KeyValuePair<string, object>("floor", floor),
                new KeyValuePair<string, object>("apartment", apartment),
                new KeyValuePair<string, object>("landmark", landmark),
                new KeyValuePair<string, object>("postal_code", postalCode),
                new KeyValuePair<string, object>("os", os),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/user/address?os=Android&lang=en&user_id=7 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        public void ProductionUserAddressOsAndroidLangEnUserId7(
                string os,
                string lang,
                int userId)
        {
            Task t = this.ProductionUserAddressOsAndroidLangEnUserId7Async(os, lang, userId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/user/address?os=Android&lang=en&user_id=7 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionUserAddressOsAndroidLangEnUserId7Async(
                string os,
                string lang,
                int userId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/user/address");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
                { "user_id", userId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/update_address?os=android EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="address">Required parameter: Example: .</param>
        /// <param name="street">Required parameter: Example: .</param>
        /// <param name="building">Required parameter: Example: .</param>
        /// <param name="floor">Required parameter: Example: .</param>
        /// <param name="apartment">Required parameter: Example: .</param>
        /// <param name="landmark">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="phone">Required parameter: Example: .</param>
        /// <param name="postalCode">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="addressId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiUserUpdateAddressOsAndroid(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                int userId,
                string lang,
                int countryId,
                int cityId,
                string name,
                string address,
                string street,
                int building,
                int floor,
                int apartment,
                string landmark,
                int mobile,
                int phone,
                int postalCode,
                double lat,
                double mLong,
                int addressId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiUserUpdateAddressOsAndroidAsync(nasser, aPPVERSION, mOBILEOS, userId, lang, countryId, cityId, name, address, street, building, floor, apartment, landmark, mobile, phone, postalCode, lat, mLong, addressId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/update_address?os=android EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cityId">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="address">Required parameter: Example: .</param>
        /// <param name="street">Required parameter: Example: .</param>
        /// <param name="building">Required parameter: Example: .</param>
        /// <param name="floor">Required parameter: Example: .</param>
        /// <param name="apartment">Required parameter: Example: .</param>
        /// <param name="landmark">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="phone">Required parameter: Example: .</param>
        /// <param name="postalCode">Required parameter: Example: .</param>
        /// <param name="lat">Required parameter: Example: .</param>
        /// <param name="mLong">Required parameter: Example: .</param>
        /// <param name="addressId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiUserUpdateAddressOsAndroidAsync(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                int userId,
                string lang,
                int countryId,
                int cityId,
                string name,
                string address,
                string street,
                int building,
                int floor,
                int apartment,
                string landmark,
                int mobile,
                int phone,
                int postalCode,
                double lat,
                double mLong,
                int addressId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/user/update_address");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("country_id", countryId),
                new KeyValuePair<string, object>("city_id", cityId),
                new KeyValuePair<string, object>("name", name),
                new KeyValuePair<string, object>("address", address),
                new KeyValuePair<string, object>("street", street),
                new KeyValuePair<string, object>("building", building),
                new KeyValuePair<string, object>("floor", floor),
                new KeyValuePair<string, object>("apartment", apartment),
                new KeyValuePair<string, object>("landmark", landmark),
                new KeyValuePair<string, object>("mobile", mobile),
                new KeyValuePair<string, object>("phone", phone),
                new KeyValuePair<string, object>("postal_code", postalCode),
                new KeyValuePair<string, object>("lat", lat),
                new KeyValuePair<string, object>("long", mLong),
                new KeyValuePair<string, object>("address_id", addressId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/recently_view?logged_id=1&country_id=2&os=Android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiRecentlyViewLoggedId1CountryId2OsAndroid(
                int loggedId,
                int countryId,
                string os,
                int userId,
                int page)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiRecentlyViewLoggedId1CountryId2OsAndroidAsync(loggedId, countryId, os, userId, page);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/recently_view?logged_id=1&country_id=2&os=Android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiRecentlyViewLoggedId1CountryId2OsAndroidAsync(
                int loggedId,
                int countryId,
                string os,
                int userId,
                int page,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/recently_view");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "logged_id", loggedId },
                { "country_id", countryId },
                { "os", os },
                { "user_id", userId },
                { "page", page },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/auto_complete?os=android&key_word=maz&type=2&country_id=3 EndPoint.
        /// </summary>
        /// <param name="keyWord">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionAutoCompleteOsAndroidKeyWordMazType2CountryId3(
                string keyWord,
                int type,
                int countryId,
                string os)
        {
            Task t = this.ProductionAutoCompleteOsAndroidKeyWordMazType2CountryId3Async(keyWord, type, countryId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/auto_complete?os=android&key_word=maz&type=2&country_id=3 EndPoint.
        /// </summary>
        /// <param name="keyWord">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionAutoCompleteOsAndroidKeyWordMazType2CountryId3Async(
                string keyWord,
                int type,
                int countryId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/auto_complete");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "key_word", keyWord },
                { "type", type },
                { "country_id", countryId },
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/search?keyword=d&page=1&user_id=1&logged_id=1&country_id=3&os=Android EndPoint.
        /// </summary>
        /// <param name="keyword">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cities">Required parameter: Example: .</param>
        public void ProductionSearchKeywordDPage1UserId1LoggedId1CountryId3OsAndroid(
                string keyword,
                int page,
                int userId,
                int loggedId,
                int countryId,
                string os,
                List<string> cities)
        {
            Task t = this.ProductionSearchKeywordDPage1UserId1LoggedId1CountryId3OsAndroidAsync(keyword, page, userId, loggedId, countryId, os, cities);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/search?keyword=d&page=1&user_id=1&logged_id=1&country_id=3&os=Android EndPoint.
        /// </summary>
        /// <param name="keyword">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cities">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionSearchKeywordDPage1UserId1LoggedId1CountryId3OsAndroidAsync(
                string keyword,
                int page,
                int userId,
                int loggedId,
                int countryId,
                string os,
                List<string> cities,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/search");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "keyword", keyword },
                { "page", page },
                { "user_id", userId },
                { "logged_id", loggedId },
                { "country_id", countryId },
                { "os", os },
                { "cities", cities },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/countries?os=Android&lang=en EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiCountriesOsAndroidLangEn(
                string os,
                string lang)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiCountriesOsAndroidLangEnAsync(os, lang);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/countries?os=Android&lang=en EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiCountriesOsAndroidLangEnAsync(
                string os,
                string lang,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/countries");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/cities?os=Android&lang=en&country_id=1&logged_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiCitiesOsAndroidLangEnCountryId1LoggedId1(
                string os,
                string lang,
                int countryId,
                int loggedId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiCitiesOsAndroidLangEnCountryId1LoggedId1Async(os, lang, countryId, loggedId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/cities?os=Android&lang=en&country_id=1&logged_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiCitiesOsAndroidLangEnCountryId1LoggedId1Async(
                string os,
                string lang,
                int countryId,
                int loggedId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/cities");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "lang", lang },
                { "country_id", countryId },
                { "logged_id", loggedId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product_counter?os=android EndPoint.
        /// </summary>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiProductCounterOsAndroid(
                int productId,
                int type)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiProductCounterOsAndroidAsync(productId, type);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/product_counter?os=android EndPoint.
        /// </summary>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="type">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiProductCounterOsAndroidAsync(
                int productId,
                int type,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/product_counter");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("product_id", productId),
                new KeyValuePair<string, object>("type", type),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/order?os=android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiUserOrderOsAndroid(
                int loggedId,
                int userId,
                int orderId,
                string os)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiUserOrderOsAndroidAsync(loggedId, userId, orderId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/user/order?os=android EndPoint.
        /// </summary>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiUserOrderOsAndroidAsync(
                int loggedId,
                int userId,
                int orderId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/user/order");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("order_id", orderId),
                new KeyValuePair<string, object>("os", os),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/user/orders?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="isComplete">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        public void ProductionUserOrdersOsAndroid(
                string os,
                int loggedId,
                int userId,
                int isComplete,
                int page)
        {
            Task t = this.ProductionUserOrdersOsAndroidAsync(os, loggedId, userId, isComplete, page);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/user/orders?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="isComplete">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionUserOrdersOsAndroidAsync(
                string os,
                int loggedId,
                int userId,
                int isComplete,
                int page,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/user/orders");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("is_complete", isComplete),
                new KeyValuePair<string, object>("page", page),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/seller/order?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        public void ProductionSellerOrderOsAndroid(
                string os,
                string lang,
                int userId,
                int orderId)
        {
            Task t = this.ProductionSellerOrderOsAndroidAsync(os, lang, userId, orderId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/seller/order?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionSellerOrderOsAndroidAsync(
                string os,
                string lang,
                int userId,
                int orderId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/seller/order");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("order_id", orderId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/seller/unpaid_orders?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiSellerUnpaidOrdersOsAndroid(
                string os,
                string lang,
                int loggedId,
                int userId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiSellerUnpaidOrdersOsAndroidAsync(os, lang, loggedId, userId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/seller/unpaid_orders?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiSellerUnpaidOrdersOsAndroidAsync(
                string os,
                string lang,
                int loggedId,
                int userId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/seller/unpaid_orders");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/seller/paid_orders?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiSellerPaidOrdersOsAndroid(
                string os,
                string lang,
                int loggedId,
                int userId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiSellerPaidOrdersOsAndroidAsync(os, lang, loggedId, userId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/seller/paid_orders?os=Android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiSellerPaidOrdersOsAndroidAsync(
                string os,
                string lang,
                int loggedId,
                int userId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/seller/paid_orders");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/seller/unpaid_orders?os=Android1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiSellerUnpaidOrdersOsAndroid1(
                string os,
                string lang,
                int loggedId,
                int userId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiSellerUnpaidOrdersOsAndroid1Async(os, lang, loggedId, userId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/seller/unpaid_orders?os=Android1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiSellerUnpaidOrdersOsAndroid1Async(
                string os,
                string lang,
                int loggedId,
                int userId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/seller/unpaid_orders");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/ads?country_id=3&os=android EndPoint.
        /// </summary>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiAdsCountryId3OsAndroid(
                int countryId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiAdsCountryId3OsAndroidAsync(countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/ads?country_id=3&os=android EndPoint.
        /// </summary>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiAdsCountryId3OsAndroidAsync(
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/ads");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "country_id", countryId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/apis?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionApisOsAndroid(
                string os)
        {
            Task t = this.ProductionApisOsAndroidAsync(os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/apis?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionApisOsAndroidAsync(
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/apis");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/driver/order?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        public void HttpDaliliHerokuappComApiDriverOrderOsAndroid(
                string os,
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                int driverId,
                string startDate,
                string endDate,
                int orderId)
        {
            Task t = this.HttpDaliliHerokuappComApiDriverOrderOsAndroidAsync(os, nasser, aPPVERSION, mOBILEOS, lang, driverId, startDate, endDate, orderId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/driver/order?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDaliliHerokuappComApiDriverOrderOsAndroidAsync(
                string os,
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                int driverId,
                string startDate,
                string endDate,
                int orderId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server4);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/order");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("driver_id", driverId),
                new KeyValuePair<string, object>("start_date", startDate),
                new KeyValuePair<string, object>("end_date", endDate),
                new KeyValuePair<string, object>("order_id", orderId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/driver/shipment-product?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        /// <param name="cartId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiDriverShipmentProductOsAndroid(
                string os,
                string lang,
                string code,
                int driverId,
                int sellerId,
                int cartId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiDriverShipmentProductOsAndroidAsync(os, lang, code, driverId, sellerId, cartId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/driver/shipment-product?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        /// <param name="cartId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiDriverShipmentProductOsAndroidAsync(
                string os,
                string lang,
                string code,
                int driverId,
                int sellerId,
                int cartId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/shipment-product");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("code", code),
                new KeyValuePair<string, object>("driver_id", driverId),
                new KeyValuePair<string, object>("seller_id", sellerId),
                new KeyValuePair<string, object>("cart_id", cartId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/driver/orders EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionDriverOrders(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                int driverId,
                string os)
        {
            Task t = this.ProductionDriverOrdersAsync(nasser, aPPVERSION, mOBILEOS, lang, driverId, os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/driver/orders EndPoint.
        /// </summary>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionDriverOrdersAsync(
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                int driverId,
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/orders");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("driver_id", driverId),
                new KeyValuePair<string, object>("os", os),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/driver/deliver-product?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        /// <param name="cartId">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiDriverDeliverProductOsAndroid(
                string os,
                int orderId,
                int sellerId,
                int cartId,
                string code,
                int driverId,
                string image)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiDriverDeliverProductOsAndroidAsync(os, orderId, sellerId, cartId, code, driverId, image);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/driver/deliver-product?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        /// <param name="cartId">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="image">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiDriverDeliverProductOsAndroidAsync(
                string os,
                int orderId,
                int sellerId,
                int cartId,
                string code,
                int driverId,
                string image,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/deliver-product");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("order_id", orderId),
                new KeyValuePair<string, object>("seller_id", sellerId),
                new KeyValuePair<string, object>("cart_id", cartId),
                new KeyValuePair<string, object>("code", code),
                new KeyValuePair<string, object>("driver_id", driverId),
                new KeyValuePair<string, object>("image", image),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/driver/shipment-product?os=android1 EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        /// <param name="cartId">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiDriverShipmentProductOsAndroid1(
                int orderId,
                int sellerId,
                int cartId,
                string code,
                int driverId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiDriverShipmentProductOsAndroid1Async(orderId, sellerId, cartId, code, driverId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/driver/shipment-product?os=android1 EndPoint.
        /// </summary>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        /// <param name="cartId">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiDriverShipmentProductOsAndroid1Async(
                int orderId,
                int sellerId,
                int cartId,
                string code,
                int driverId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/shipment-product");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("order_id", orderId),
                new KeyValuePair<string, object>("seller_id", sellerId),
                new KeyValuePair<string, object>("cart_id", cartId),
                new KeyValuePair<string, object>("code", code),
                new KeyValuePair<string, object>("driver_id", driverId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/driver/unpaid?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        public void ProductionDriverUnpaidOsAndroid(
                string os,
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                int driverId,
                string startDate,
                string endDate,
                int page)
        {
            Task t = this.ProductionDriverUnpaidOsAndroidAsync(os, nasser, aPPVERSION, mOBILEOS, lang, driverId, startDate, endDate, page);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/driver/unpaid?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionDriverUnpaidOsAndroidAsync(
                string os,
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                int driverId,
                string startDate,
                string endDate,
                int page,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/unpaid");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("driver_id", driverId),
                new KeyValuePair<string, object>("start_date", startDate),
                new KeyValuePair<string, object>("end_date", endDate),
                new KeyValuePair<string, object>("page", page),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/driver/paid?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        public void ProductionDriverPaidOsAndroid(
                string os,
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                int driverId,
                int orderId,
                string startDate,
                string endDate,
                int page)
        {
            Task t = this.ProductionDriverPaidOsAndroidAsync(os, nasser, aPPVERSION, mOBILEOS, lang, driverId, orderId, startDate, endDate, page);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/driver/paid?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="nasser">Required parameter: Example: .</param>
        /// <param name="aPPVERSION">Required parameter: Example: .</param>
        /// <param name="mOBILEOS">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="orderId">Required parameter: Example: .</param>
        /// <param name="startDate">Required parameter: Example: .</param>
        /// <param name="endDate">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionDriverPaidOsAndroidAsync(
                string os,
                string nasser,
                int aPPVERSION,
                string mOBILEOS,
                string lang,
                int driverId,
                int orderId,
                string startDate,
                string endDate,
                int page,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/paid");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Nasser", nasser },
                { "APPVERSION", aPPVERSION.ToString() },
                { "MOBILEOS", mOBILEOS },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("driver_id", driverId),
                new KeyValuePair<string, object>("order_id", orderId),
                new KeyValuePair<string, object>("start_date", startDate),
                new KeyValuePair<string, object>("end_date", endDate),
                new KeyValuePair<string, object>("page", page),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/driver/store-scan?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        public void ProductionDriverStoreScanOsAndroid(
                string os,
                string lang,
                string code,
                int driverId,
                int sellerId)
        {
            Task t = this.ProductionDriverStoreScanOsAndroidAsync(os, lang, code, driverId, sellerId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/driver/store-scan?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionDriverStoreScanOsAndroidAsync(
                string os,
                string lang,
                string code,
                int driverId,
                int sellerId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/store-scan");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("code", code),
                new KeyValuePair<string, object>("driver_id", driverId),
                new KeyValuePair<string, object>("seller_id", sellerId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/driver/user-scan?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        public void HttpDaliliHerokuappComApiDriverUserScanOsAndroid(
                string os,
                string lang,
                string code,
                int driverId,
                int sellerId)
        {
            Task t = this.HttpDaliliHerokuappComApiDriverUserScanOsAndroidAsync(os, lang, code, driverId, sellerId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalili.herokuapp.com/api/driver/user-scan?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDaliliHerokuappComApiDriverUserScanOsAndroidAsync(
                string os,
                string lang,
                string code,
                int driverId,
                int sellerId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/user-scan");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("code", code),
                new KeyValuePair<string, object>("driver_id", driverId),
                new KeyValuePair<string, object>("seller_id", sellerId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/driver/calculator?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        public void HttpDalilishopSmartstepEgComApiDriverCalculatorOsAndroid(
                string lang,
                int driverId)
        {
            Task t = this.HttpDalilishopSmartstepEgComApiDriverCalculatorOsAndroidAsync(lang, driverId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// http://dalilishop.smartstep-eg.com/api/driver/calculator?os=android EndPoint.
        /// </summary>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task HttpDalilishopSmartstepEgComApiDriverCalculatorOsAndroidAsync(
                string lang,
                int driverId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server2);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/calculator");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("driver_id", driverId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/offer?os=android&logged_id=41&offer_id=674&page=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="offerId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        public void ProductionOfferOsAndroidLoggedId41OfferId674Page1(
                string os,
                int loggedId,
                int offerId,
                int page)
        {
            Task t = this.ProductionOfferOsAndroidLoggedId41OfferId674Page1Async(os, loggedId, offerId, page);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/offer?os=android&logged_id=41&offer_id=674&page=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="offerId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionOfferOsAndroidLoggedId41OfferId674Page1Async(
                string os,
                int loggedId,
                int offerId,
                int page,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/offer");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "logged_id", loggedId },
                { "offer_id", offerId },
                { "page", page },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/seller/orders?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        public void ProductionSellerOrdersOsAndroid(
                string os,
                string lang,
                int loggedId,
                int userId,
                int page)
        {
            Task t = this.ProductionSellerOrdersOsAndroidAsync(os, lang, loggedId, userId, page);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/seller/orders?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="lang">Required parameter: Example: .</param>
        /// <param name="loggedId">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="page">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionSellerOrdersOsAndroidAsync(
                string os,
                string lang,
                int loggedId,
                int userId,
                int page,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/seller/orders");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("lang", lang),
                new KeyValuePair<string, object>("logged_id", loggedId),
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("page", page),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/contactus?os=androidd EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="message">Required parameter: Example: .</param>
        public void ProductionContactusOsAndroidd(
                string os,
                string name,
                string email,
                int mobile,
                string message)
        {
            Task t = this.ProductionContactusOsAndroiddAsync(os, name, email, mobile, message);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/contactus?os=androidd EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="name">Required parameter: Example: .</param>
        /// <param name="email">Required parameter: Example: .</param>
        /// <param name="mobile">Required parameter: Example: .</param>
        /// <param name="message">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionContactusOsAndroiddAsync(
                string os,
                string name,
                string email,
                int mobile,
                string message,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/contactus");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("name", name),
                new KeyValuePair<string, object>("email", email),
                new KeyValuePair<string, object>("mobile", mobile),
                new KeyValuePair<string, object>("message", message),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/sub_categories?os=android&country_id=1&category_id=2 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        public void ProductionSubCategoriesOsAndroidCountryId1CategoryId2(
                string os,
                int countryId,
                int categoryId)
        {
            Task t = this.ProductionSubCategoriesOsAndroidCountryId1CategoryId2Async(os, countryId, categoryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/sub_categories?os=android&country_id=1&category_id=2 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionSubCategoriesOsAndroidCountryId1CategoryId2Async(
                string os,
                int countryId,
                int categoryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/sub_categories");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "country_id", countryId },
                { "category_id", categoryId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/category/packages?os=android&user_id=1&category_id=310&country_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void ProductionCategoryPackagesOsAndroidUserId1CategoryId310CountryId1(
                string os,
                int userId,
                int categoryId,
                int countryId)
        {
            Task t = this.ProductionCategoryPackagesOsAndroidUserId1CategoryId310CountryId1Async(os, userId, categoryId, countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/category/packages?os=android&user_id=1&category_id=310&country_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionCategoryPackagesOsAndroidUserId1CategoryId310CountryId1Async(
                string os,
                int userId,
                int categoryId,
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/category/packages");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "user_id", userId },
                { "category_id", categoryId },
                { "country_id", countryId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/driver/deliver-order?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        public void ProductionDriverDeliverOrderOsAndroid(
                string os,
                string code,
                int driverId)
        {
            Task t = this.ProductionDriverDeliverOrderOsAndroidAsync(os, code, driverId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/driver/deliver-order?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionDriverDeliverOrderOsAndroidAsync(
                string os,
                string code,
                int driverId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/deliver-order");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("code", code),
                new KeyValuePair<string, object>("driver_id", driverId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/subscribe/category/package?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="packageId">Required parameter: Example: .</param>
        public void ProductionSubscribeCategoryPackageOsAndroid(
                string os,
                int userId,
                int categoryId,
                int packageId)
        {
            Task t = this.ProductionSubscribeCategoryPackageOsAndroidAsync(os, userId, categoryId, packageId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/subscribe/category/package?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="packageId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionSubscribeCategoryPackageOsAndroidAsync(
                string os,
                int userId,
                int categoryId,
                int packageId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/subscribe/category/package");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("category_id", categoryId),
                new KeyValuePair<string, object>("package_id", packageId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/repost/product?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void ProductionRepostProductOsAndroid(
                string os,
                int userId,
                int productId,
                int countryId)
        {
            Task t = this.ProductionRepostProductOsAndroidAsync(os, userId, productId, countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/repost/product?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="productId">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionRepostProductOsAndroidAsync(
                string os,
                int userId,
                int productId,
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/repost/product");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("product_id", productId),
                new KeyValuePair<string, object>("country_id", countryId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/category_properties?os=android&category_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        public void ProductionCategoryPropertiesOsAndroidCategoryId1(
                string os,
                int categoryId)
        {
            Task t = this.ProductionCategoryPropertiesOsAndroidCategoryId1Async(os, categoryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/category_properties?os=android&category_id=1 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionCategoryPropertiesOsAndroidCategoryId1Async(
                string os,
                int categoryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/category_properties");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "category_id", categoryId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/category/properties?os=android&category_id=11 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        public void ProductionCategoryPropertiesOsAndroidCategoryId11(
                string os,
                int categoryId)
        {
            Task t = this.ProductionCategoryPropertiesOsAndroidCategoryId11Async(os, categoryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/category/properties?os=android&category_id=11 EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="categoryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionCategoryPropertiesOsAndroidCategoryId11Async(
                string os,
                int categoryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/category/properties");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
                { "category_id", categoryId },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/driver/return-product?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        public void ProductionDriverReturnProductOsAndroid(
                string os)
        {
            Task t = this.ProductionDriverReturnProductOsAndroidAsync(os);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/driver/return-product?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionDriverReturnProductOsAndroidAsync(
                string os,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/return-product");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Get(queryBuilder.ToString(), headers, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/driver/seller-scan?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        public void ProductionDriverSellerScanOsAndroid(
                string os,
                string code,
                int driverId,
                int sellerId)
        {
            Task t = this.ProductionDriverSellerScanOsAndroidAsync(os, code, driverId, sellerId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/driver/seller-scan?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionDriverSellerScanOsAndroidAsync(
                string os,
                string code,
                int driverId,
                int sellerId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/driver/seller-scan");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("code", code),
                new KeyValuePair<string, object>("driver_id", driverId),
                new KeyValuePair<string, object>("seller_id", sellerId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/cart/add/bulk?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="products">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        public void ProductionCartAddBulkOsAndroid(
                string os,
                int userId,
                List<Models.Product> products,
                int countryId)
        {
            Task t = this.ProductionCartAddBulkOsAndroidAsync(os, userId, products, countryId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/cart/add/bulk?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="userId">Required parameter: Example: .</param>
        /// <param name="products">Required parameter: Example: .</param>
        /// <param name="countryId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionCartAddBulkOsAndroidAsync(
                string os,
                int userId,
                List<Models.Product> products,
                int countryId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/cart/add-bulk");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "Content-Type", "application/x-www-form-urlencoded" },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("user_id", userId),
                new KeyValuePair<string, object>("country_id", countryId),
            };
            fields.AddRange(ApiHelper.PrepareFormFieldsFromObject("products", products, arrayDeserializationFormat: this.ArrayDeserializationFormat));

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }

        /// <summary>
        /// {{production}}/api/deliver?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        public void ProductionApiDeliverOsAndroid(
                string os,
                string code,
                int driverId,
                int sellerId)
        {
            Task t = this.ProductionApiDeliverOsAndroidAsync(os, code, driverId, sellerId);
            ApiHelper.RunTaskSynchronously(t);
        }

        /// <summary>
        /// {{production}}/api/deliver?os=android EndPoint.
        /// </summary>
        /// <param name="os">Required parameter: Example: .</param>
        /// <param name="code">Required parameter: Example: .</param>
        /// <param name="driverId">Required parameter: Example: .</param>
        /// <param name="sellerId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the void response from the API call.</returns>
        public async Task ProductionApiDeliverOsAndroidAsync(
                string os,
                string code,
                int driverId,
                int sellerId,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri(Server.Server1);

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/api/deliver");

            // prepare specfied query parameters.
            var queryParams = new Dictionary<string, object>()
            {
                { "os", os },
            };

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
            };

            // append form/field parameters.
            var fields = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("code", code),
                new KeyValuePair<string, object>("driver_id", driverId),
                new KeyValuePair<string, object>("seller_id", sellerId),
            };

            // remove null parameters.
            fields = fields.Where(kvp => kvp.Value != null).ToList();

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().Post(queryBuilder.ToString(), headers, fields, queryParameters: queryParams);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);
        }
    }
}