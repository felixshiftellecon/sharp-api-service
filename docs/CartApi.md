# Org.OpenAPITools.Api.CartApi

All URIs are relative to *http://localhost:8080/CFD/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCartItem**](CartApi.md#addcartitem) | **POST** /cart | Add a menu item a cart
[**DeleteCartItem**](CartApi.md#deletecartitem) | **DELETE** /cart/{itemId} | Remove item from cart
[**ListCart**](CartApi.md#listcart) | **GET** /cart | List all cart items



## AddCartItem

> void AddCartItem (MenuItem menuItem)

Add a menu item a cart

Creates a new item in the cart. Duplicates are allowed

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddCartItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/CFD/1.0.0";
            var apiInstance = new CartApi(Configuration.Default);
            var menuItem = new MenuItem(); // MenuItem | Item to add to the cart

            try
            {
                // Add a menu item a cart
                apiInstance.AddCartItem(menuItem);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CartApi.AddCartItem: " + e.Message );
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
 **menuItem** | [**MenuItem**](MenuItem.md)| Item to add to the cart | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
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


## DeleteCartItem

> void DeleteCartItem (int itemId)

Remove item from cart

The item must be in the cart. If multiple of same item, call this twice 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteCartItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/CFD/1.0.0";
            var apiInstance = new CartApi(Configuration.Default);
            var itemId = 56;  // int | The menu item to delete from cart

            try
            {
                // Remove item from cart
                apiInstance.DeleteCartItem(itemId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CartApi.DeleteCartItem: " + e.Message );
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
 **itemId** | **int**| The menu item to delete from cart | 

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


## ListCart

> List&lt;MenuItem&gt; ListCart (int? limit = null)

List all cart items

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListCartExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/CFD/1.0.0";
            var apiInstance = new CartApi(Configuration.Default);
            var limit = 56;  // int? | How many items to return at one time (max 100) (optional) 

            try
            {
                // List all cart items
                List<MenuItem> result = apiInstance.ListCart(limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CartApi.ListCart: " + e.Message );
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
 **limit** | **int?**| How many items to return at one time (max 100) | [optional] 

### Return type

[**List&lt;MenuItem&gt;**](MenuItem.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A paged array of cart items |  * x-next - A link to the next page of responses <br>  |
| **0** | unexpected error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

