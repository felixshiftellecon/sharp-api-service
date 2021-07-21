/*
 * CFD
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing ImageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ImageApiTests
    {
        private ImageApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ImageApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ImageApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ImageApi
            //Assert.IsInstanceOf(typeof(ImageApi), instance);
        }

        
        /// <summary>
        /// Test AddImage
        /// </summary>
        [Test]
        public void AddImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream fileName = null;
            //var response = instance.AddImage(fileName);
            //Assert.IsInstanceOf(typeof(InlineResponse200), response, "response is InlineResponse200");
        }
        
        /// <summary>
        /// Test DeleteImage
        /// </summary>
        [Test]
        public void DeleteImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int imageId = null;
            //instance.DeleteImage(imageId);
            
        }
        
        /// <summary>
        /// Test GetImage
        /// </summary>
        [Test]
        public void GetImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int imageId = null;
            //var response = instance.GetImage(imageId);
            //Assert.IsInstanceOf(typeof(System.IO.Stream), response, "response is System.IO.Stream");
        }
        
    }

}
