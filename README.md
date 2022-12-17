<p align="center">
  <img  src="https://github.com/mabroukmahdhi/Ettissal/blob/main/ic_connected.png">
</p>

# Ettissal
A nuget package that provides a component for Blazor WASM to check application connectivity to internet.



## Installation
Install the nuget package in your Blazor WASM project:

```shell
dotnet add package Ettissal
```

Or,

```shell
NuGet\Install-Package Ettissal
```

## How to use?
You have a Blazor WASM project and you want to check the application connectivity to internet. You can use the `Ettissal` component to do that.

### Add Ettissal Library
Add the following line to the service collection in `Program.cs` file:

```csharp
builder.Services.AddEttissal();
```

### Use Ettissal ConnectedComponent
Using this component, you can check the application connectivity to internet. You can use it in any page or component in your Blazor WASM project.

```razor
<ConnectedComponent>
    <Online>
        <p>You're Online</p>
    </Online>
    <Offline>
        <p>You're Offline</p>
    </Offline>
</ConnectedComponent>
```

This will help you to show the content based on the application connectivity to internet. As you can see, you can use the `Online` and `Offline` components to show the content when the application is online or offline.

## License
This project is licensed under the MIT License - see the [LICENSE](https://github.com/mabroukmahdhi/Ettissal/blob/main/LICENSE) file for details.

## Acknowledgments
- [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) 
- [NuGet](https://www.nuget.org/)
- [GitHub](https://github.com/mabroukmahdhi/Ettissal)
- [Visual Studio](https://visualstudio.microsoft.com/) 
- [Markdown](https://www.markdownguide.org/) 
- [Shields.io](https://shields.io/)
- [License](https://choosealicense.com/) 
- [Contributing](https://github.com/mabroukmahdhi/Ettissal/blob/main/Constributing.md) 

## Author
- [Mahdhi Mabrouk](https://mahdhi.com/)

## Contact
- [Twitter](https://twitter.com/Mabrouk_Mahdhi)
- [LinkedIn](https://www.linkedin.com/in/mabrouk-mahdhi-990017238/) 
- [GitHub](https://github.com/mabroukmahdhi)
