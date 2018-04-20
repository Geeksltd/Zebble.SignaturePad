[logo]: https://raw.githubusercontent.com/Geeksltd/Zebble.SignaturePad/master/Shared/NuGet/Icon.png "Zebble.SignaturePad"


## Zebble.SignaturePad

![logo]

A Zebble plugin that allow you to draw smooth signature in Zebble applications.


[![NuGet](https://img.shields.io/nuget/v/Zebble.SignaturePad.svg?label=NuGet)](https://www.nuget.org/packages/Zebble.SignaturePad/)

> Signature Pad is a Zebble plugin for drawing smooth signatures. It works in all platform of Zebble application.

<br>


### Setup
* Available on NuGet: [https://www.nuget.org/packages/Zebble.SignaturePad/](https://www.nuget.org/packages/Zebble.SignaturePad/)
* Install in your platform client projects.
* Available for iOS, Android and UWP.
<br>


### Api Usage

To use this plugin in Zebble application you can use below code:
```xml
<SignaturePad Id="SignaturePad" />
```

Or, you can create it in C# code behind and add it to any View that you want:
```csharp
var signaturePad = new Zebble.Plugin.SignaturePad();
Add(signaturePad);
```