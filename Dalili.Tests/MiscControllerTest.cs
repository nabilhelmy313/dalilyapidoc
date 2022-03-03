// <copyright file="MiscControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Dalili.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using Dalili.Standard;
    using Dalili.Standard.Controllers;
    using Dalili.Standard.Exceptions;
    using Dalili.Standard.Http.Client;
    using Dalili.Standard.Http.Response;
    using Dalili.Standard.Utilities;
    using Dalili.Tests.Helpers;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;

    /// <summary>
    /// MiscControllerTest.
    /// </summary>
    [TestFixture]
    public class MiscControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private MiscController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.MiscController;
        }

        /// <summary>
        /// TestProductionProductsFilterPage1OsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionProductsFilterPage1OsAndroid()
        {
            // Parameters for the API call
            int page = 1;
            string os = "Android";
            string lang = "en";
            List<int> categories = ApiHelper.JsonDeserialize<List<int>>("[31]");
            int lat = 0;
            int mLong = 0;

            // Perform API call
            try
            {
                await this.controller.ProductionProductsFilterPage1OsAndroidAsync(page, os, lang, categories, lat, mLong);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionProductLoggedId3ProductId39OsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionProductLoggedId3ProductId39OsAndroid()
        {
            // Parameters for the API call
            int loggedId = 1;
            int productId = 449;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.ProductionProductLoggedId3ProductId39OsAndroidAsync(loggedId, productId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionProfileProducts.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionProfileProducts()
        {
            // Parameters for the API call
            int userId = 1;
            int loggedId = 1;
            string lang = "en";
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.ProductionProfileProductsAsync(userId, loggedId, lang, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionOnlineCategoriesLoggedId1CountryId3OsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionOnlineCategoriesLoggedId1CountryId3OsAndroid()
        {
            // Parameters for the API call
            int loggedId = 1;
            int countryId = 1;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.ProductionOnlineCategoriesLoggedId1CountryId3OsAndroidAsync(loggedId, countryId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionDriverOrderOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionDriverOrderOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            string lang = "en";
            string startDate = string.Empty;
            string endDate = string.Empty;
            int orderId = 1;
            int userId = 21;

            // Perform API call
            try
            {
                await this.controller.ProductionDriverOrderOsAndroidAsync(os, nasser, aPPVERSION, mOBILEOS, lang, startDate, endDate, orderId, userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionNotificationsLoggedId207UserId207Page1OsAndroidInAppPopup1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionNotificationsLoggedId207UserId207Page1OsAndroidInAppPopup1()
        {
            // Parameters for the API call
            int loggedId = 1;
            int userId = 1;
            int page = 1;
            string os = "android";
            string objectType = "order";

            // Perform API call
            try
            {
                await this.controller.ProductionNotificationsLoggedId207UserId207Page1OsAndroidInAppPopup1Async(loggedId, userId, page, os, objectType);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53OsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53OsAndroid()
        {
            // Parameters for the API call
            int userId = 31;
            int productId = 401;
            string comment = "test";
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53OsAndroidAsync(userId, productId, comment, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53CommentId105OsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53CommentId105OsAndroid()
        {
            // Parameters for the API call
            int userId = 3;
            int countryId = 3;
            int productId = 53;
            int commentId = 105;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53CommentId105OsAndroidAsync(userId, countryId, productId, commentId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionLoginOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionLoginOsAndroid()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "ar";
            string password = "aaaaaa";
            string email = "m.shaaban@dalili.com";

            // Perform API call
            try
            {
                await this.controller.ProductionLoginOsAndroidAsync(os, lang, password, email);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiSocialLogin.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiSocialLogin()
        {
            // Parameters for the API call
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            string email = "dev.m.shaabanqqq@gmail.com";
            string name = "Mahmoud";
            string sName = "Sheboo";
            long mobile = 20115335266;
            int gender = 1;
            int countryCode = 20;
            string lang = "en";
            int countryId = 1;
            long providerId = 332128662324552829;
            double facebookId = 33212866242323552829;
            string googleId = string.Empty;
            string twitterToken = string.Empty;
            string twitterSecretToken = string.Empty;
            string providerImage = "https://graph.facebook.com/3321286624552829/picture?type=large&width=150&height=150";
            string provider = "Facebook";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiSocialLoginAsync(nasser, aPPVERSION, mOBILEOS, email, name, sName, mobile, gender, countryCode, lang, countryId, providerId, facebookId, googleId, twitterToken, twitterSecretToken, providerImage, provider);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiRegister.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiRegister()
        {
            // Parameters for the API call
            string os = "android";
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            string email = "aya88@gmail.com";
            int password = 000000;
            string name = "Aya";
            string sName = "Mohamed";
            long mobile = 15335269274;
            int gender = 1;
            int countryCode = 966;
            string lang = "en";
            string birthDate = string.Empty;
            int countryId = 3;
            int isConfirm = 1;
            int isDriver = 0;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiRegisterAsync(os, nasser, aPPVERSION, mOBILEOS, email, password, name, sName, mobile, gender, countryCode, lang, birthDate, countryId, isConfirm, isDriver);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiPasswordEmail.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiPasswordEmail()
        {
            // Parameters for the API call
            string lang = "en";
            string email = "dev.m.shaaban@gmail.com";
            int userId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiPasswordEmailAsync(lang, email, userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProfileChangePassword.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProfileChangePassword()
        {
            // Parameters for the API call
            string lang = "en";
            string password = "aaaaaa";
            int userId = 1;
            string oldPassword = "ssssss";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProfileChangePasswordAsync(lang, password, userId, oldPassword);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionProfileOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionProfileOsAndroid()
        {
            // Parameters for the API call
            int loggedId = 1;
            int userId = 1;
            string os = "android";
            int countryId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionProfileOsAndroidAsync(loggedId, userId, os, countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProfileUpdateOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProfileUpdateOsAndroid()
        {
            // Parameters for the API call
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            int isActive = 1;
            int userId = 41;
            int isConfirm = 1;
            int isPublic = 1;
            string os = "android";
            string facebook = "https://www.facebook.com/iclick.it";
            string birthDate = "09-10-1991";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProfileUpdateOsAndroidAsync(nasser, aPPVERSION, mOBILEOS, isActive, userId, isConfirm, isPublic, os, facebook, birthDate);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDaliliHerokuappComApiSetTokenOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDaliliHerokuappComApiSetTokenOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            int userId = 1;
            int gymId = 1;
            string token = "fRs5tvZlmP0:APA91bGiSMDqfSNa86VqEn_ACPKinjEJAObRQMNeb3yj_nLrCisnKpJo6IYGdXaQELdkznfnsFlXF4Icm9o8Vo6Picyl0XYTNW7c3G4LpO-ZVYI4C16fSCA-pleuOeKwTZDiiZbt11ox";

            // Perform API call
            try
            {
                await this.controller.HttpDaliliHerokuappComApiSetTokenOsAndroidAsync(os, userId, gymId, token);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionHomeOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionHomeOsAndroid()
        {
            // Parameters for the API call
            string os = "Android";

            // Perform API call
            try
            {
                await this.controller.ProductionHomeOsAndroidAsync(os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionUserIndicatorUserId1OsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionUserIndicatorUserId1OsAndroid()
        {
            // Parameters for the API call
            int userId = 1;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.ProductionUserIndicatorUserId1OsAndroidAsync(userId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiNotificationsLoggedId7UserId7Page1OsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiNotificationsLoggedId7UserId7Page1OsAndroid()
        {
            // Parameters for the API call
            int loggedId = 7;
            int userId = 7;
            int page = 1;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiNotificationsLoggedId7UserId7Page1OsAndroidAsync(loggedId, userId, page, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDaliliHerokuappComApiPackagesOsAndroidLangEnCountryId3Type1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDaliliHerokuappComApiPackagesOsAndroidLangEnCountryId3Type1()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int countryId = 3;
            int type = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDaliliHerokuappComApiPackagesOsAndroidLangEnCountryId3Type1Async(os, lang, countryId, type);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionProductEditOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionProductEditOsAndroid()
        {
            // Parameters for the API call
            string lang = "en";
            int userId = 31;
            int paymentType = 1;
            int id = 404;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.ProductionProductEditOsAndroidAsync(lang, userId, paymentType, id, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionProfileAccountOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionProfileAccountOsAndroid()
        {
            // Parameters for the API call
            string lang = "en";
            int countryId = 1;
            int userId = 260;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.ProductionProfileAccountOsAndroidAsync(lang, countryId, userId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDaliliHerokuappComApiAccountsOsAndroidLangEnUserId1StoreId9CountryId1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDaliliHerokuappComApiAccountsOsAndroidLangEnUserId1StoreId9CountryId1()
        {
            // Parameters for the API call
            string os = "android";
            string lang = "en";
            int userId = 21;
            int countryId = 3;

            // Perform API call
            try
            {
                await this.controller.HttpDaliliHerokuappComApiAccountsOsAndroidLangEnUserId1StoreId9CountryId1Async(os, lang, userId, countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionProfileCanPostUserId1CountryId3CategoryId2.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionProfileCanPostUserId1CountryId3CategoryId2()
        {
            // Parameters for the API call
            int userId = 260;
            int countryId = 1;
            int categoryId = 322;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.ProductionProfileCanPostUserId1CountryId3CategoryId2Async(userId, countryId, categoryId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiBalancesOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiBalancesOsAndroid()
        {
            // Parameters for the API call
            int loggedId = 1;
            int userId = 1;
            string lang = "en";
            int countryId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiBalancesOsAndroidAsync(loggedId, userId, lang, countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProfileChargeOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProfileChargeOsAndroid()
        {
            // Parameters for the API call
            string lang = "en";
            string password = "password";
            string email = "user1@dalili.com";
            int userId = 1;
            int balanceId = 2;
            int paymentType = 1;
            int productId = 191;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProfileChargeOsAndroidAsync(lang, password, email, userId, balanceId, paymentType, productId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProfileFollowingsOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProfileFollowingsOsAndroid()
        {
            // Parameters for the API call
            int userId = 1;
            int followerId = 1;
            string lang = "en";
            int loggedId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProfileFollowingsOsAndroidAsync(userId, followerId, lang, loggedId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProfileFollowersOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProfileFollowersOsAndroid()
        {
            // Parameters for the API call
            int userId = 1;
            int followerId = 1;
            string lang = "en";
            int loggedId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProfileFollowersOsAndroidAsync(userId, followerId, lang, loggedId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiInboxOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiInboxOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string lang = "en";
            int loggedId = 1;
            int userId = 1;
            int offset = 0;
            int limit = 100;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiInboxOsAndroidAsync(os, lang, loggedId, userId, offset, limit);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiChatOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiChatOsAndroid()
        {
            // Parameters for the API call
            string lang = "en";
            int loggedId = 31;
            string productId = string.Empty;
            string storeId = string.Empty;
            int userId = 0;
            string os = "Android";
            int page = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiChatOsAndroidAsync(lang, loggedId, productId, storeId, userId, os, page);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionSendOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionSendOsAndroid()
        {
            // Parameters for the API call
            int senderId = 41;
            int receiverId = 0;
            string message = "test aya";
            string image = string.Empty;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.ProductionSendOsAndroidAsync(senderId, receiverId, message, image, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiUserBlockListOsAndroidLangEnLoggedId1UserId1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiUserBlockListOsAndroidLangEnLoggedId1UserId1()
        {
            // Parameters for the API call
            string lang = "en";
            int loggedId = 1;
            int userId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiUserBlockListOsAndroidLangEnLoggedId1UserId1Async(lang, loggedId, userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiUserBlockOsAndroidLangEnLoggedId69UserId69BlockedId1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiUserBlockOsAndroidLangEnLoggedId69UserId69BlockedId1()
        {
            // Parameters for the API call
            string lang = "en";
            int loggedId = 69;
            int userId = 69;
            int blockedId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiUserBlockOsAndroidLangEnLoggedId69UserId69BlockedId1Async(lang, loggedId, userId, blockedId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiUserFollowOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiUserFollowOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            int userId = 1;
            int followerId = 1;
            string lang = "en";
            int loggedId = 31;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiUserFollowOsAndroidAsync(os, userId, followerId, lang, loggedId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiPriceOfferCreateOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiPriceOfferCreateOsAndroid()
        {
            // Parameters for the API call
            int userId = 3;
            int productId = 39;
            int countryId = 3;
            int productPrice = 654;
            int price = 50000;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiPriceOfferCreateOsAndroidAsync(userId, productId, countryId, productPrice, price, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiPriceOfferOffersProductId39UserId3OsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiPriceOfferOffersProductId39UserId3OsAndroid()
        {
            // Parameters for the API call
            int productId = 39;
            int userId = 3;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiPriceOfferOffersProductId39UserId3OsAndroidAsync(productId, userId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiPriceOfferRepliesOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiPriceOfferRepliesOsAndroid()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int userId = 7;
            int loggedId = 7;
            int countryId = 3;
            int priceOfferId = 25;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiPriceOfferRepliesOsAndroidAsync(os, lang, userId, loggedId, countryId, priceOfferId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiPriceOfferDeleteOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiPriceOfferDeleteOsAndroid()
        {
            // Parameters for the API call
            int userId = 3;
            string os = "android";
            int loggedId = 3;
            int offerId = 21;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiPriceOfferDeleteOsAndroidAsync(userId, os, loggedId, offerId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiPriceOfferDeleteReplyOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiPriceOfferDeleteReplyOsAndroid()
        {
            // Parameters for the API call
            int userId = 3;
            string os = "android";
            int loggedId = 3;
            int offerId = 21;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiPriceOfferDeleteReplyOsAndroidAsync(userId, os, loggedId, offerId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProductDeleteOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProductDeleteOsAndroid()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int loggedId = 3;
            int userId = 3;
            int id = 12;
            string reasons = string.Empty;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProductDeleteOsAndroidAsync(os, lang, loggedId, userId, id, reasons);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProductDeleteReasonsOsAndroidLangEn.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProductDeleteReasonsOsAndroidLangEn()
        {
            // Parameters for the API call
            string lang = "en";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProductDeleteReasonsOsAndroidLangEnAsync(lang);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiCartUserId7CountryId3LangEnOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiCartUserId7CountryId3LangEnOsAndroid()
        {
            // Parameters for the API call
            int userId = 1;
            int countryId = 1;
            string lang = "en";
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiCartUserId7CountryId3LangEnOsAndroidAsync(userId, countryId, lang, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiCartAddOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiCartAddOsAndroid()
        {
            // Parameters for the API call
            int userId = 6;
            int productId = 1;
            int countryId = 3;
            int quantity = 6;
            int loggedId = 6;
            string colorId = "#0260E8";
            string sizeId = string.Empty;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiCartAddOsAndroidAsync(userId, productId, countryId, quantity, loggedId, colorId, sizeId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiCartClearOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiCartClearOsAndroid()
        {
            // Parameters for the API call
            string lang = "en";
            int userId = 1;
            int countryId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiCartClearOsAndroidAsync(lang, userId, countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiCartDeleteOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiCartDeleteOsAndroid()
        {
            // Parameters for the API call
            int userId = 1;
            int cartId = 14;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiCartDeleteOsAndroidAsync(userId, cartId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionCheckoutOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionCheckoutOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string lang = "en";
            int loggedId = 21;
            int userId = 21;
            int countryId = 1;
            int addressId = 87;
            int paymentType = 0;
            string date = string.Empty;
            string time = string.Empty;
            int type = 0;
            int isFast = 1;
            long mobile = 201533526929;
            string sName = "Shaaban Jordan";
            string fName = "Mahmoud";
            string points = string.Empty;

            // Perform API call
            try
            {
                await this.controller.ProductionCheckoutOsAndroidAsync(os, lang, loggedId, userId, countryId, addressId, paymentType, date, time, type, isFast, mobile, sName, fName, points);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionCalcDeliveryOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionCalcDeliveryOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            int userId = 21;
            int countryId = 1;
            int addressId = 91;
            int isFast = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionCalcDeliveryOsAndroidAsync(os, userId, countryId, addressId, isFast);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiColorsSizesOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiColorsSizesOsAndroid()
        {
            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiColorsSizesOsAndroidAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionListCategoriesOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionListCategoriesOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            int countryId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionListCategoriesOsAndroidAsync(os, countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionStoresCategoriesOsAndroidLangEnCountryId3.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionStoresCategoriesOsAndroidLangEnCountryId3()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int countryId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionStoresCategoriesOsAndroidLangEnCountryId3Async(os, lang, countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiHomeCategoriesOsAndroidCountryId3.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiHomeCategoriesOsAndroidCountryId3()
        {
            // Parameters for the API call
            int countryId = 1;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiHomeCategoriesOsAndroidCountryId3Async(countryId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiCategoryOsAndroidLangEnCategoryId1LoggedId1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiCategoryOsAndroidLangEnCategoryId1LoggedId1()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int categoryId = 1;
            int loggedId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiCategoryOsAndroidLangEnCategoryId1LoggedId1Async(os, lang, categoryId, loggedId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiCategoriesOsAndroidLoggedId1CountryId2.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiCategoriesOsAndroidLoggedId1CountryId2()
        {
            // Parameters for the API call
            int loggedId = 1;
            int countryId = 1;
            string os = "android";
            double dCCOMICS = 120.0;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiCategoriesOsAndroidLoggedId1CountryId2Async(loggedId, countryId, os, dCCOMICS);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiViewHistoryOsAndroidLangEnLoggedId1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiViewHistoryOsAndroidLangEnLoggedId1()
        {
            // Parameters for the API call
            string lang = "en";
            int loggedId = 1;
            string os = "android";
            int cityId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiViewHistoryOsAndroidLangEnLoggedId1Async(lang, loggedId, os, cityId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionTimeline.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionTimeline()
        {
            // Parameters for the API call
            string lang = "en";
            int loggedId = 1;
            int page = 1;
            int cityId = 1;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.ProductionTimelineAsync(lang, loggedId, page, cityId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53OsAndroid1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53OsAndroid1()
        {
            // Parameters for the API call
            int userId = 3;
            int countryId = 3;
            int productId = 53;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProductCommentsUserId3CountryId3ProductId53OsAndroid1Async(userId, countryId, productId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProductCommentOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProductCommentOsAndroid()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int userId = 1;
            int productId = 1;
            string image = string.Empty;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProductCommentOsAndroidAsync(os, lang, userId, productId, image);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProductRateOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProductRateOsAndroid()
        {
            // Parameters for the API call
            int userId = 1;
            int productId = 6;
            int rate = 2;
            string comment = "new one";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProductRateOsAndroidAsync(userId, productId, rate, comment);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProfileLikesOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProfileLikesOsAndroid()
        {
            // Parameters for the API call
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            int userId = 74;
            string lang = "en";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProfileLikesOsAndroidAsync(nasser, aPPVERSION, mOBILEOS, userId, lang);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDaliliHerokuappComApiOffersOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDaliliHerokuappComApiOffersOsAndroid()
        {
            // Parameters for the API call
            string os = "Android";
            int countryId = 1;
            List<int> users = ApiHelper.JsonDeserialize<List<int>>("[1]");

            // Perform API call
            try
            {
                await this.controller.HttpDaliliHerokuappComApiOffersOsAndroidAsync(os, countryId, users);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionOffersListsOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionOffersListsOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            int loggedId = 1;
            int userId = 1;
            int countryId = 3;
            List<string> categories = ApiHelper.JsonDeserialize<List<string>>("[]");

            // Perform API call
            try
            {
                await this.controller.ProductionOffersListsOsAndroidAsync(os, loggedId, userId, countryId, categories);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiOffersCategoriesOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiOffersCategoriesOsAndroid()
        {
            // Parameters for the API call
            int userId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiOffersCategoriesOsAndroidAsync(userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDaliliHerokuappComApiOffersSwitchNotificationOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDaliliHerokuappComApiOffersSwitchNotificationOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            List<Standard.Models.Category> categories = ApiHelper.JsonDeserialize<List<Standard.Models.Category>>("[
  {
    \"id\": 1,
    \"icon\": \"1547401714.png\",
    \"image\": \"1547401714.JPG\",
    \"name\": \"Cars\",
    \"is_notify\": 0
  },
  {
    \"id\": 3,
    \"icon\": \"1547401946.png\",
    \"image\": \"1547401946.jpg\",
    \"name\": \"Electronics\",
    \"is_notify\": 0
  },
  {
    \"id\": 4,
    \"icon\": \"1547402113.jpg\",
    \"image\": \"1547402113.jpg\",
    \"name\": \"furniture\",
    \"is_notify\": 1
  },
  {
    \"id\": 6,
    \"icon\": \"1547455526.png\",
    \"image\": \"1547413638.jpg\",
    \"name\": \"Fashsion\",
    \"is_notify\": 1
  },
  {
    \"id\": 7,
    \"icon\": \"1547455582.png\",
    \"image\": \"1547455582.jpeg\",
    \"name\": \"Gifts & Toys\",
    \"is_notify\": 1
  },
  {
    \"id\": 8,
    \"icon\": \"1547455661.png\",
    \"image\": \"1547455661.jpg\",
    \"name\": \"Furneture\",
    \"is_notify\": 1
  },
  {
    \"id\": 9,
    \"icon\": \"1547455750.png\",
    \"image\": \"1547455750.jpg\",
    \"name\": \"Real Estate\",
    \"is_notify\": 1
  },
  {
    \"id\": 10,
    \"icon\": \"1547455939.png\",
    \"image\": \"1547455939.jpg\",
    \"name\": \"Foods\",
    \"is_notify\": 1
  },
  {
    \"id\": 11,
    \"icon\": \"1547456002.png\",
    \"image\": \"1547456002.jpg\",
    \"name\": \"Appliances\",
    \"is_notify\": 1
  },
  {
    \"id\": 12,
    \"icon\": \"1547456157.png\",
    \"image\": \"1547456157.jpg\",
    \"name\": \"Supermarket\",
    \"is_notify\": 1
  },
  {
    \"id\": 20,
    \"icon\": \"assets/images/categories/defaultIcon.png\",
    \"image\": \"1571960553.jpg\",
    \"name\": \"Jobs\",
    \"is_notify\": 1
  },
  {
    \"id\": 22,
    \"icon\": \"assets/images/categories/defaultIcon.png\",
    \"image\": \"1571961414.jpg\",
    \"name\": \"Properties for Rent\",
    \"is_notify\": 1
  },
  {
    \"id\": 26,
    \"icon\": \"1572008345.jpg\",
    \"image\": \"1572008345.jpg\",
    \"name\": \"New TEST\",
    \"is_notify\": 0
  },
  {
    \"id\": 27,
    \"icon\": \"1572008723_icon.jpg\",
    \"image\": \"1572008723_banner.jpg\",
    \"name\": \"New TEST2\",
    \"is_notify\": 0
  }
]");
            int userId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDaliliHerokuappComApiOffersSwitchNotificationOsAndroidAsync(os, categories, userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiOffersCommentOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiOffersCommentOsAndroid()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int offerId = 1;
            int userId = 1;
            string comment = "Test from Android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiOffersCommentOsAndroidAsync(os, lang, offerId, userId, comment);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiOffersCommentsOsAndroidLangEnOfferId1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiOffersCommentsOsAndroidLangEnOfferId1()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int offerId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiOffersCommentsOsAndroidLangEnOfferId1Async(os, lang, offerId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDaliliHerokuappComApiOffersCreateOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDaliliHerokuappComApiOffersCreateOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            int loggedId = 1;
            int userId = 1;
            string lang = "en";
            string enName = "Jacket 2";
            string arName = "Jacket 2";
            int categoryId = 4;
            int isActive = 1;
            int storeId = 1;
            string image = string.Empty;
            string enDesc = "line 1<br>- line 2<br>- line 3";
            string arDesc = "line 1<br>- line 2<br>- line 3";
            int countryId = 1;
            int regionId = 2;
            int cityId = 1;
            string address = "new address";
            string bg = string.Empty;

            // Perform API call
            try
            {
                await this.controller.HttpDaliliHerokuappComApiOffersCreateOsAndroidAsync(os, loggedId, userId, lang, enName, arName, categoryId, isActive, storeId, image, enDesc, arDesc, countryId, regionId, cityId, address, bg);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiOffersEditOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiOffersEditOsAndroid()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            List<string> categories = ApiHelper.JsonDeserialize<List<string>>("[]");
            int userId = 1;
            int loggedId = 1;
            int countryId = 3;
            int offerId = 9;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiOffersEditOsAndroidAsync(os, lang, categories, userId, loggedId, countryId, offerId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiStoreCreateOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiStoreCreateOsAndroid()
        {
            // Parameters for the API call
            string os = "Android";
            int loggedId = 1;
            int userId = 1;
            string lang = "en";
            string enName = "new new line2";
            string arName = "new new line2";
            List<int> categories = ApiHelper.JsonDeserialize<List<int>>("[1]");
            int isActive = 1;
            string image = string.Empty;
            string enDesc = "line 1<br>- line 2<br>- line 3";
            string arDesc = "line 1<br>- line 2<br>- line 3";
            int countryId = 3;
            int regionId = 6;
            int cityId = 11;
            string address = "new address";
            string bg = string.Empty;
            int lat = 0;
            int mLong = 0;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiStoreCreateOsAndroidAsync(os, loggedId, userId, lang, enName, arName, categories, isActive, image, enDesc, arDesc, countryId, regionId, cityId, address, bg, lat, mLong);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiStoreEditOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiStoreEditOsAndroid()
        {
            // Parameters for the API call
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            int userId = 1;
            string lang = "en";
            int storeId = 23;
            int isActive = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiStoreEditOsAndroidAsync(nasser, aPPVERSION, mOBILEOS, userId, lang, storeId, isActive);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionUserStoresOsAndroidLangEnLoggedId1UserId1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionUserStoresOsAndroidLangEnLoggedId1UserId1()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int loggedId = 1;
            int userId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionUserStoresOsAndroidLangEnLoggedId1UserId1Async(os, lang, loggedId, userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiUserStoresOsAndroidLangEnLoggedId1UserId1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiUserStoresOsAndroidLangEnLoggedId1UserId1()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int loggedId = 1;
            int userId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiUserStoresOsAndroidLangEnLoggedId1UserId1Async(os, lang, loggedId, userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionStoreOsAndroidLangEnUserId1StoreId21Page1LoggedId1CountryId3.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionStoreOsAndroidLangEnUserId1StoreId21Page1LoggedId1CountryId3()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int userId = 1;
            int storeId = 286;
            int page = 1;
            int loggedId = 1;
            int countryId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionStoreOsAndroidLangEnUserId1StoreId21Page1LoggedId1CountryId3Async(os, lang, userId, storeId, page, loggedId, countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionStoresOsAndroidLangEnLoggedId73UserId73CategoryId1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionStoresOsAndroidLangEnLoggedId73UserId73CategoryId1()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int loggedId = 1;
            int userId = 1;
            int categoryId = 2;
            List<string> cityId = ApiHelper.JsonDeserialize<List<string>>("[]");
            List<string> regionId = ApiHelper.JsonDeserialize<List<string>>("[]");
            int lat = 0;
            int mLong = 0;
            int countryId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionStoresOsAndroidLangEnLoggedId73UserId73CategoryId1Async(os, lang, loggedId, userId, categoryId, cityId, regionId, lat, mLong, countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiStoreRatesOsAndroidLangEnUserId1StoreId4Page1LoggedId1CountryId3.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiStoreRatesOsAndroidLangEnUserId1StoreId4Page1LoggedId1CountryId3()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int userId = 1;
            int storeId = 4;
            int page = 1;
            int loggedId = 1;
            int countryId = 3;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiStoreRatesOsAndroidLangEnUserId1StoreId4Page1LoggedId1CountryId3Async(os, lang, userId, storeId, page, loggedId, countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiStoreRateOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiStoreRateOsAndroid()
        {
            // Parameters for the API call
            string lang = "en";
            int userId = 1;
            int storeId = 20;
            string comment = "second rate store";
            int loggedId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiStoreRateOsAndroidAsync(lang, userId, storeId, comment, loggedId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionStoreProductsOsAndroidLangEnUserId1StoreId21Page1CountryId3KeywordShirt.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionStoreProductsOsAndroidLangEnUserId1StoreId21Page1CountryId3KeywordShirt()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int userId = 1;
            int storeId = 21;
            int page = 1;
            int countryId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionStoreProductsOsAndroidLangEnUserId1StoreId21Page1CountryId3KeywordShirtAsync(os, lang, userId, storeId, page, countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiStoreFollowOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiStoreFollowOsAndroid()
        {
            // Parameters for the API call
            string lang = "en";
            int loggedId = 31;
            int userId = 31;
            int storeId = 286;
            int followerId = 31;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiStoreFollowOsAndroidAsync(lang, loggedId, userId, storeId, followerId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiStoreFollowersStoreId1OsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiStoreFollowersStoreId1OsAndroid()
        {
            // Parameters for the API call
            int storeId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiStoreFollowersStoreId1OsAndroidAsync(storeId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionOrdersStoresOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionOrdersStoresOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string lang = "en";
            int loggedId = 1;
            int storeId = 286;

            // Perform API call
            try
            {
                await this.controller.ProductionOrdersStoresOsAndroidAsync(os, lang, loggedId, storeId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiOrdersStoresOsAndroidStoreId1LangEn.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiOrdersStoresOsAndroidStoreId1LangEn()
        {
            // Parameters for the API call
            int storeId = 1;
            string lang = "en";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiOrdersStoresOsAndroidStoreId1LangEnAsync(storeId, lang);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDaliliHerokuappComApiStoreOrderOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDaliliHerokuappComApiStoreOrderOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string lang = "en";
            int loggedId = 21;
            int userId = 21;
            int orderId = 25;
            int storeId = 286;

            // Perform API call
            try
            {
                await this.controller.HttpDaliliHerokuappComApiStoreOrderOsAndroidAsync(os, lang, loggedId, userId, orderId, storeId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionOrderActionOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionOrderActionOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            int cartId = 379;
            int action = 1;
            string comment = string.Empty;

            // Perform API call
            try
            {
                await this.controller.ProductionOrderActionOsAndroidAsync(os, cartId, action, comment);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiOrderReportOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiOrderReportOsAndroid()
        {
            // Parameters for the API call
            string lang = "en";
            int userId = 7;
            int orderId = 26;
            string comment = "test image";
            string image = string.Empty;
            string os = "Android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiOrderReportOsAndroidAsync(lang, userId, orderId, comment, image, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDaliliHerokuappComApiStoreSalesOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDaliliHerokuappComApiStoreSalesOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string lang = "en";
            int loggedId = 1;
            int storeId = 283;

            // Perform API call
            try
            {
                await this.controller.HttpDaliliHerokuappComApiStoreSalesOsAndroidAsync(os, lang, loggedId, storeId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiBestSellerStoresOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiBestSellerStoresOsAndroid()
        {
            // Parameters for the API call
            string lang = "en";
            int loggedId = 1;
            int storeId = 21;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiBestSellerStoresOsAndroidAsync(lang, loggedId, storeId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiPaidOrdersStoresOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiPaidOrdersStoresOsAndroid()
        {
            // Parameters for the API call
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            string lang = "en";
            int storeId = 4;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiPaidOrdersStoresOsAndroidAsync(nasser, aPPVERSION, mOBILEOS, lang, storeId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionUnpaidOrdersStoresOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionUnpaidOrdersStoresOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            string lang = "en";
            int storeId = 286;

            // Perform API call
            try
            {
                await this.controller.ProductionUnpaidOrdersStoresOsAndroidAsync(os, nasser, aPPVERSION, mOBILEOS, lang, storeId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiUserAddAddressOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiUserAddAddressOsAndroid()
        {
            // Parameters for the API call
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            int userId = 7;
            string lang = "en";
            int countryId = 3;
            int cityId = 3;
            string name = "New Address 2";
            string address = "Ahram";
            string street = "Zone A";
            int mobile = 1153352692;
            double mLong = 31.0932859;
            int building = 300;
            int phone = 1153352693;
            int regionId = 1;
            double lat = 29.9818178;
            int floor = 4;
            string apartment = string.Empty;
            string landmark = string.Empty;
            string postalCode = string.Empty;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiUserAddAddressOsAndroidAsync(nasser, aPPVERSION, mOBILEOS, userId, lang, countryId, cityId, name, address, street, mobile, mLong, building, phone, regionId, lat, floor, apartment, landmark, postalCode, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionUserAddressOsAndroidLangEnUserId7.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionUserAddressOsAndroidLangEnUserId7()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int userId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionUserAddressOsAndroidLangEnUserId7Async(os, lang, userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiUserUpdateAddressOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiUserUpdateAddressOsAndroid()
        {
            // Parameters for the API call
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            int userId = 1;
            string lang = "en";
            int countryId = 1;
            int cityId = 1;
            string name = "New Address";
            string address = "Ahram";
            string street = "Zone A";
            int building = 300;
            int floor = 4;
            int apartment = 20;
            string landmark = "Exception market";
            int mobile = 1153352692;
            int phone = 1153352693;
            int postalCode = 20;
            double lat = 29.9818178;
            double mLong = 31.0932859;
            int addressId = 7;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiUserUpdateAddressOsAndroidAsync(nasser, aPPVERSION, mOBILEOS, userId, lang, countryId, cityId, name, address, street, building, floor, apartment, landmark, mobile, phone, postalCode, lat, mLong, addressId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiRecentlyViewLoggedId1CountryId2OsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiRecentlyViewLoggedId1CountryId2OsAndroid()
        {
            // Parameters for the API call
            int loggedId = 1;
            int countryId = 1;
            string os = "Android";
            int userId = 1;
            int page = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiRecentlyViewLoggedId1CountryId2OsAndroidAsync(loggedId, countryId, os, userId, page);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionAutoCompleteOsAndroidKeyWordMazType2CountryId3.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionAutoCompleteOsAndroidKeyWordMazType2CountryId3()
        {
            // Parameters for the API call
            string keyWord = "ip mah";
            int type = 2;
            int countryId = 1;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.ProductionAutoCompleteOsAndroidKeyWordMazType2CountryId3Async(keyWord, type, countryId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionSearchKeywordDPage1UserId1LoggedId1CountryId3OsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionSearchKeywordDPage1UserId1LoggedId1CountryId3OsAndroid()
        {
            // Parameters for the API call
            string keyword = "tech";
            int page = 1;
            int userId = 1;
            int loggedId = 1;
            int countryId = 3;
            string os = "Android";
            List<string> cities = ApiHelper.JsonDeserialize<List<string>>("[]");

            // Perform API call
            try
            {
                await this.controller.ProductionSearchKeywordDPage1UserId1LoggedId1CountryId3OsAndroidAsync(keyword, page, userId, loggedId, countryId, os, cities);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiCountriesOsAndroidLangEn.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiCountriesOsAndroidLangEn()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiCountriesOsAndroidLangEnAsync(os, lang);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiCitiesOsAndroidLangEnCountryId1LoggedId1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiCitiesOsAndroidLangEnCountryId1LoggedId1()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int countryId = 1;
            int loggedId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiCitiesOsAndroidLangEnCountryId1LoggedId1Async(os, lang, countryId, loggedId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiProductCounterOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiProductCounterOsAndroid()
        {
            // Parameters for the API call
            int productId = 8;
            int type = 0;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiProductCounterOsAndroidAsync(productId, type);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiUserOrderOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiUserOrderOsAndroid()
        {
            // Parameters for the API call
            int loggedId = 21;
            int userId = 21;
            int orderId = 635;
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiUserOrderOsAndroidAsync(loggedId, userId, orderId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionUserOrdersOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionUserOrdersOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            int loggedId = 21;
            int userId = 21;
            int isComplete = 1;
            int page = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionUserOrdersOsAndroidAsync(os, loggedId, userId, isComplete, page);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionSellerOrderOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionSellerOrderOsAndroid()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int userId = 21;
            int orderId = 41;

            // Perform API call
            try
            {
                await this.controller.ProductionSellerOrderOsAndroidAsync(os, lang, userId, orderId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiSellerUnpaidOrdersOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiSellerUnpaidOrdersOsAndroid()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int loggedId = 1;
            int userId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiSellerUnpaidOrdersOsAndroidAsync(os, lang, loggedId, userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiSellerPaidOrdersOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiSellerPaidOrdersOsAndroid()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int loggedId = 1;
            int userId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiSellerPaidOrdersOsAndroidAsync(os, lang, loggedId, userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiSellerUnpaidOrdersOsAndroid1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiSellerUnpaidOrdersOsAndroid1()
        {
            // Parameters for the API call
            string os = "Android";
            string lang = "en";
            int loggedId = 1;
            int userId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiSellerUnpaidOrdersOsAndroid1Async(os, lang, loggedId, userId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiAdsCountryId3OsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiAdsCountryId3OsAndroid()
        {
            // Parameters for the API call
            int countryId = 3;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiAdsCountryId3OsAndroidAsync(countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionApisOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionApisOsAndroid()
        {
            // Parameters for the API call
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.ProductionApisOsAndroidAsync(os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDaliliHerokuappComApiDriverOrderOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDaliliHerokuappComApiDriverOrderOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            string lang = "en";
            int driverId = 7;
            string startDate = string.Empty;
            string endDate = string.Empty;
            int orderId = 151;

            // Perform API call
            try
            {
                await this.controller.HttpDaliliHerokuappComApiDriverOrderOsAndroidAsync(os, nasser, aPPVERSION, mOBILEOS, lang, driverId, startDate, endDate, orderId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiDriverShipmentProductOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiDriverShipmentProductOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string lang = "en";
            string code = "15914034989uke3w2h";
            int driverId = 1;
            int sellerId = 3;
            int cartId = 48;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiDriverShipmentProductOsAndroidAsync(os, lang, code, driverId, sellerId, cartId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionDriverOrders.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionDriverOrders()
        {
            // Parameters for the API call
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            string lang = "en";
            int driverId = 81;
            string os = "Android";

            // Perform API call
            try
            {
                await this.controller.ProductionDriverOrdersAsync(nasser, aPPVERSION, mOBILEOS, lang, driverId, os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiDriverDeliverProductOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiDriverDeliverProductOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            int orderId = 637;
            int sellerId = 21;
            int cartId = 1;
            string code = "161224202950z9a2cksp1612242029";
            int driverId = 1;
            string image = string.Empty;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiDriverDeliverProductOsAndroidAsync(os, orderId, sellerId, cartId, code, driverId, image);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiDriverShipmentProductOsAndroid1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiDriverShipmentProductOsAndroid1()
        {
            // Parameters for the API call
            int orderId = 7;
            int sellerId = 3;
            int cartId = 3;
            string code = "1588521177r6jqdt1s";
            int driverId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiDriverShipmentProductOsAndroid1Async(orderId, sellerId, cartId, code, driverId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionDriverUnpaidOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionDriverUnpaidOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            string lang = "en";
            int driverId = 81;
            string startDate = string.Empty;
            string endDate = string.Empty;
            int page = 2;

            // Perform API call
            try
            {
                await this.controller.ProductionDriverUnpaidOsAndroidAsync(os, nasser, aPPVERSION, mOBILEOS, lang, driverId, startDate, endDate, page);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionDriverPaidOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionDriverPaidOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string nasser = "eyJ0b2tlbiI6ImQ2ZjU4ZDM4ZGU2ZDVhNDBhODExODg5ZjJkNTI0MDViIiwiaWQiOiIxNTI0NTYwMzgyNTA2In0=";
            int aPPVERSION = 44;
            string mOBILEOS = "ios";
            string lang = "en";
            int driverId = 81;
            int orderId = 21;
            string startDate = string.Empty;
            string endDate = string.Empty;
            int page = 2;

            // Perform API call
            try
            {
                await this.controller.ProductionDriverPaidOsAndroidAsync(os, nasser, aPPVERSION, mOBILEOS, lang, driverId, orderId, startDate, endDate, page);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionDriverStoreScanOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionDriverStoreScanOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string lang = "en";
            string code = "1628979810atgilcwsrn1628979810";
            int driverId = 81;
            int sellerId = 21;

            // Perform API call
            try
            {
                await this.controller.ProductionDriverStoreScanOsAndroidAsync(os, lang, code, driverId, sellerId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDaliliHerokuappComApiDriverUserScanOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDaliliHerokuappComApiDriverUserScanOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string lang = "en";
            string code = "1635217310ydkqgx1m041635217310";
            int driverId = 81;
            int sellerId = 1;

            // Perform API call
            try
            {
                await this.controller.HttpDaliliHerokuappComApiDriverUserScanOsAndroidAsync(os, lang, code, driverId, sellerId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestHttpDalilishopSmartstepEgComApiDriverCalculatorOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestHttpDalilishopSmartstepEgComApiDriverCalculatorOsAndroid()
        {
            // Parameters for the API call
            string lang = "en";
            int driverId = 43;

            // Perform API call
            try
            {
                await this.controller.HttpDalilishopSmartstepEgComApiDriverCalculatorOsAndroidAsync(lang, driverId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionOfferOsAndroidLoggedId41OfferId674Page1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionOfferOsAndroidLoggedId41OfferId674Page1()
        {
            // Parameters for the API call
            string os = "android";
            int loggedId = 41;
            int offerId = 674;
            int page = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionOfferOsAndroidLoggedId41OfferId674Page1Async(os, loggedId, offerId, page);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionSellerOrdersOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionSellerOrdersOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string lang = "en";
            int loggedId = 1;
            int userId = 1;
            int page = 2;

            // Perform API call
            try
            {
                await this.controller.ProductionSellerOrdersOsAndroidAsync(os, lang, loggedId, userId, page);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionContactusOsAndroidd.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionContactusOsAndroidd()
        {
            // Parameters for the API call
            string os = "androidd";
            string name = "test aya";
            string email = "aya@gmail.com";
            int mobile = 01272371464;
            string message = " test test test test test test";

            // Perform API call
            try
            {
                await this.controller.ProductionContactusOsAndroiddAsync(os, name, email, mobile, message);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionSubCategoriesOsAndroidCountryId1CategoryId2.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionSubCategoriesOsAndroidCountryId1CategoryId2()
        {
            // Parameters for the API call
            string os = "android";
            int countryId = 1;
            int categoryId = 2;

            // Perform API call
            try
            {
                await this.controller.ProductionSubCategoriesOsAndroidCountryId1CategoryId2Async(os, countryId, categoryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionCategoryPackagesOsAndroidUserId1CategoryId310CountryId1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionCategoryPackagesOsAndroidUserId1CategoryId310CountryId1()
        {
            // Parameters for the API call
            string os = "android";
            int userId = 260;
            int categoryId = 322;
            int countryId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionCategoryPackagesOsAndroidUserId1CategoryId310CountryId1Async(os, userId, categoryId, countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionDriverDeliverOrderOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionDriverDeliverOrderOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string code = "1627615714_162761571418e9tfh5";
            int driverId = 81;

            // Perform API call
            try
            {
                await this.controller.ProductionDriverDeliverOrderOsAndroidAsync(os, code, driverId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionSubscribeCategoryPackageOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionSubscribeCategoryPackageOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            int userId = 1;
            int categoryId = 310;
            int packageId = 6;

            // Perform API call
            try
            {
                await this.controller.ProductionSubscribeCategoryPackageOsAndroidAsync(os, userId, categoryId, packageId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionRepostProductOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionRepostProductOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            int userId = 1;
            int productId = 448;
            int countryId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionRepostProductOsAndroidAsync(os, userId, productId, countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionCategoryPropertiesOsAndroidCategoryId1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionCategoryPropertiesOsAndroidCategoryId1()
        {
            // Parameters for the API call
            string os = "android";
            int categoryId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionCategoryPropertiesOsAndroidCategoryId1Async(os, categoryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionCategoryPropertiesOsAndroidCategoryId1.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionCategoryPropertiesOsAndroidCategoryId1()
        {
            // Parameters for the API call
            string os = "android";
            int categoryId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionCategoryPropertiesOsAndroidCategoryId11Async(os, categoryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionDriverReturnProductOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionDriverReturnProductOsAndroid()
        {
            // Parameters for the API call
            string os = "android";

            // Perform API call
            try
            {
                await this.controller.ProductionDriverReturnProductOsAndroidAsync(os);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionDriverSellerScanOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionDriverSellerScanOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string code = "1634434670jc87ir9bmw1634434670";
            int driverId = 81;
            int sellerId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionDriverSellerScanOsAndroidAsync(os, code, driverId, sellerId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionCartAddBulkOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionCartAddBulkOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            int userId = 21;
            List<Standard.Models.Product> products = ApiHelper.JsonDeserialize<List<Standard.Models.Product>>("[{\"product_id\":464,\"quantity\":3,\"color_id\":\"#E20338\",\"size_id\":\"xl\"},{\"product_id\":423,\"quantity\":1,\"color_id\":\"#fafd3f\",\"size_id\":\"m\"},{\"product_id\":521,\"quantity\":2,\"color_id\":\"#fafd3f\",\"size_id\":\"xl\"}]");
            int countryId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionCartAddBulkOsAndroidAsync(os, userId, products, countryId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestProductionApiDeliverOsAndroid.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestProductionApiDeliverOsAndroid()
        {
            // Parameters for the API call
            string os = "android";
            string code = "1635216633pb4mx5qtc01635216633";
            int driverId = 81;
            int sellerId = 1;

            // Perform API call
            try
            {
                await this.controller.ProductionApiDeliverOsAndroidAsync(os, code, driverId, sellerId);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }
    }
}