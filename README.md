# WHMCS.Net

The idea behind WHMCS.Net is to provide, an easy to use and understand, interface for the WHMCS API.
It turns the JSON returned by the API into readable and useable classes, in DotNet.

## How to:

*The WHMCS.Example project is used to debug in, and may change drastically. You can look there, for ways to use the API aswell*

**This is how the wrapper is used:**

```C#
	string username = "UsernameOfMyWHMCSAPIUser";
	string password = "PasswordOfMyWHMCSAPIUser";
	string domain = "WHMCS.MyDomain.com";
	bool secure = true // True = Https, false = Http

    IApiService apiService = new ApiService(username, password, domain, secure);
    IJSONService jsonService = new JSONService();
    IApiDataBroker apiDataBroker = new ApiDataBroker(apiService, jsonService);

    WhmcsApi whmcsApi = new WhmcsApi(apiDataBroker);
    ProductsResponse whmcsApi.GetProducts();
```

The domain, According to the API documentation, needs to point to something like: https://WHMCS.MyDomain.com/includes/api.php
However the Https:// vs Http:// is set with the secure variable. True = Https://, false = Http://
The /includes/api.php is automatically suffixed in code.

Initializing of the wrapper, will be made easiere in the future. For now, the above is how it's done.

## Planned features
Currently only getters are planned.

**Implemented:**
* [getproducts](http://docs.whmcs.com/API:Get_Products)
* [getclientsdetails](http://docs.whmcs.com/API:Get_Clients_Details)
* [getclients](http://docs.whmcs.com/API:Get_Clients)
* [getcontacts](http://docs.whmcs.com/API:Get_Contacts)
* [getclientsproducts](http://docs.whmcs.com/API:Get_Clients_Products)

**Not Implemented**


## Special Thanks

* [Ben Wallis](https://github.com/ben-wallis)

## License

This library is hosted under the [MIT License](https://raw.githubusercontent.com/Fab-IT-ApS/WHMCS.Net/master/LICENSE.txt)