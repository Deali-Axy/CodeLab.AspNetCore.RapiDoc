<div align="center">
<h1 align="center"> <img alt="MrinDoc logo" src="docs/images/logo.png" width="40px" />  IGeekFan.AspNetCore.RapiDoc </h1>

**[RapiDoc](https://github.com/mrin9/RapiDoc)** Custom Element for Open-API spec viewing ，Support .NET Core3.1 、.NET Standard2.0、.NET5.0。


[![nuget](https://img.shields.io/nuget/v/IGeekFan.AspNetCore.RapiDoc.svg?style=flat-square)](https://www.nuget.org/packages/IGeekFan.AspNetCore.RapiDoc)
[![stats](https://img.shields.io/nuget/dt/IGeekFan.AspNetCore.RapiDoc.svg?style=flat-square)](https://www.nuget.org/stats/packages/IGeekFan.AspNetCore.RapiDoc?groupby=Version) [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://raw.githubusercontent.com/luoyunchong/IGeekFan.AspNetCore.RapiDoc/master/LICENSE)
<p>
    <span>English</span> |  
    <a href="README.zh-CN.md">中文</a>
</p>
</div>

An API document that implements swagger 2.0 and OpenAPI 3.0. I integrate it into aspnetcore。

## Features
- Supports Swagger 2.0 and OpenAPI 3.0
- Works with any framework or with no framework
- Allows making API calls. And More....
- For more features, please refer to **[RapiDoc](https://github.com/mrin9/RapiDoc) README**
## Dependencies
### [RapiDoc](https://github.com/mrin9/RapiDoc)
- rapidoc^(version) [https://www.npmjs.com/package/rapidoc](https://www.npmjs.com/package/rapidoc)
### [Swashbuckle.AspNetCore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- Swashbuckle.AspNetCore.Swagger
- Swashbuckle.AspNetCore.SwaggerGen

## Demo
- [Basic](https://github.com/luoyunchong/IGeekFan.AspNetCore.RapiDoc/blob/master/test/Basic)
- [RapiDocDemo](https://github.com/luoyunchong/IGeekFan.AspNetCore.RapiDoc/blob/master/test/RapiDocDemo)
- [OAuth2Integration](https://github.com/luoyunchong/IGeekFan.AspNetCore.RapiDoc/blob/master/test/WebSites/OAuth2Integration)

## 📚 QuickStart

### 🚀 Install Package
use Swashbuckle.AspNetCore.Swagger Components

1.Install the standard Nuget package into your ASP.NET Core application.

```
Package Manager : 

Install-Package Swashbuckle.AspNetCore.Swagger
Install-Package Swashbuckle.AspNetCore.SwaggerGen
Install-Package IGeekFan.AspNetCore.RapiDoc

OR

CLI :

dotnet add package Swashbuckle.AspNetCore.Swagger
dotnet add package Swashbuckle.AspNetCore.SwaggerGen
dotnet add package IGeekFan.AspNetCore.RapiDoc
```

2.In the ConfigureServices method of Startup.cs, register the Swagger generator, defining one or more Swagger documents.

```
using Microsoft.AspNetCore.Mvc.Controllers
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using IGeekFan.AspNetCore.RapiDoc;
```
### 🚁 ConfigureServices

3.Services Configure
```
   services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1",new OpenApiInfo{Title = "API V1",Version = "v1"});
        var filePath = Path.Combine(System.AppContext.BaseDirectory $"{typeof(Startup).Assembly.GetName().Name}.xml");
        c.IncludeXmlComments(filePath, true);
    });
```

### 💪 Configure
4. Middleware Configure
```
app.UseSwagger();

app.UseRapiDocUI(c =>
{
    c.RoutePrefix = ""; // serve the UI at root
    c.SwaggerEndpoint("/v1/api-docs", "V1 Docs");
});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapSwagger("{documentName}/api-docs");
});
```


### 🔎 Views
Run Project，Open WebSite https://localhost:5001/index.html#/home

![docs/images/view.png](docs/images/view.png)

5.More Configure

To add comments to a document, right-click on the project - properties - generate

![](https://pic.downk.cc/item/5f34161d14195aa59413f0fc.jpg)

In AddSwaggerGen Methods You should add this methond

```
c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "SwaggerDemo.xml"),true);
```
The last parameter is set to true to enable comments on the controller



### NSwag.AspNetCore

Another way

Please refer to the table of contents [test/WebSites/NSwag.Swagger.RapiDoc](https://github.com/luoyunchong/IGeekFan.AspNetCore.RapiDoc/tree/master/test/WebSites/NSwag.Swagger.RapiDoc)

```
Package Manager : 

Install-Package IGeekFan.AspNetCore.RapiDoc

OR

CLI :

dotnet add package NSwag.AspNetCore
```

```
public void ConfigureServices(IServiceCollection services)
 {
    // 其它Service
     services.AddOpenApiDocument();
 }
```

```
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
        // 其它 Use
      app.UseOpenApi();
      app.UseRapiDocUI(c =>
     {
           c.RoutePrefix = "";
           c.SwaggerEndpoint("/swagger/v1/swagger.json");
      });
}
```
Every Things is Ok. Now， You can visist RapiDoc



### More Configure

- [https://github.com/domaindrivendev/Swashbuckle.AspNetCore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- [https://mrin9.github.io/RapiDoc/api.html](https://mrin9.github.io/RapiDoc/api.html)

