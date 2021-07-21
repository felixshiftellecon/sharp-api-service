# Org.OpenAPITools.Api.ImageApi

All URIs are relative to *http://localhost:8080/CFD/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddImage**](ImageApi.md#addimage) | **POST** /image | Add an image to the restaraunt
[**DeleteImage**](ImageApi.md#deleteimage) | **DELETE** /image/{imageId} | Remove image
[**GetImage**](ImageApi.md#getimage) | **GET** /image/{imageId} | Get image



## AddImage

> InlineResponse200 AddImage (System.IO.Stream fileName = null)

Add an image to the restaraunt

Creates an image. Duplicates are allowed. Returns the image id

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/CFD/1.0.0";
            var apiInstance = new ImageApi(Configuration.Default);
            var fileName = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // Add an image to the restaraunt
                InlineResponse200 result = apiInstance.AddImage(fileName);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.AddImage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileName** | **System.IO.Stream**|  | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteImage

> void DeleteImage (int imageId)

Remove image

The imageId must exist 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/CFD/1.0.0";
            var apiInstance = new ImageApi(Configuration.Default);
            var imageId = 56;  // int | The imageId to delete

            try
            {
                // Remove image
                apiInstance.DeleteImage(imageId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.DeleteImage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageId** | **int**| The imageId to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Null response |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetImage

> System.IO.Stream GetImage (int imageId)

Get image

Returns the image as image/png 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetImageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/CFD/1.0.0";
            var apiInstance = new ImageApi(Configuration.Default);
            var imageId = 56;  // int | The imageId of the image to retrieve

            try
            {
                // Get image
                System.IO.Stream result = apiInstance.GetImage(imageId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ImageApi.GetImage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imageId** | **int**| The imageId of the image to retrieve | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/png


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | image |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

