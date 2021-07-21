# Org.OpenAPITools.Api.MenuApi

All URIs are relative to *http://localhost:8080/CFD/1.0.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMenuItem**](MenuApi.md#addmenuitem) | **POST** /menu | Create a menu item
[**ListMenu**](MenuApi.md#listmenu) | **GET** /menu | List all menu items
[**ShowMenuItemById**](MenuApi.md#showmenuitembyid) | **GET** /menu/{itemId} | Info for a specific menu item



## AddMenuItem

> void AddMenuItem (MenuItem menuItem)

Create a menu item

Creates a new item in the menu. Duplicates are allowed

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddMenuItemExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/CFD/1.0.0";
            var apiInstance = new MenuApi(Configuration.Default);
            var menuItem = new MenuItem(); // MenuItem | Item to add to the store

            try
            {
                // Create a menu item
                apiInstance.AddMenuItem(menuItem);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MenuApi.AddMenuItem: " + e.Message );
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
 **menuItem** | [**MenuItem**](MenuItem.md)| Item to add to the store | 

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


## ListMenu

> List&lt;MenuItem&gt; ListMenu (int? limit = null)

List all menu items

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListMenuExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/CFD/1.0.0";
            var apiInstance = new MenuApi(Configuration.Default);
            var limit = 56;  // int? | How many items to return at one time (max 100) (optional) 

            try
            {
                // List all menu items
                List<MenuItem> result = apiInstance.ListMenu(limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MenuApi.ListMenu: " + e.Message );
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
| **200** | A paged array of menu items |  * x-next - A link to the next page of responses <br>  |
| **0** | unexpected error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ShowMenuItemById

> MenuItem ShowMenuItemById (string itemId)

Info for a specific menu item

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ShowMenuItemByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost:8080/CFD/1.0.0";
            var apiInstance = new MenuApi(Configuration.Default);
            var itemId = itemId_example;  // string | The id of the menu item to retrieve

            try
            {
                // Info for a specific menu item
                MenuItem result = apiInstance.ShowMenuItemById(itemId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MenuApi.ShowMenuItemById: " + e.Message );
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
 **itemId** | **string**| The id of the menu item to retrieve | 

### Return type

[**MenuItem**](MenuItem.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Expected response to a valid request |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

