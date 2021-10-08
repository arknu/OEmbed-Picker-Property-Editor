# OEmbed Picker Property Editor for Umbraco  

[![Build status](https://ci.appveyor.com/api/projects/status/glmu0g4euryf70o1?svg=true)](https://ci.appveyor.com/project/dawoe/oembed-picker-property-editor)



|NuGet Packages    |Version           |
|:-----------------|:-----------------|
|**Release**|[![NuGet download](http://img.shields.io/nuget/v/Dawoe.OEmbedPickerPropertyEditor.svg)](https://www.nuget.org/packages/Dawoe.OEmbedPickerPropertyEditor)
|**Pre-release**|[![MyGet Pre Release](https://img.shields.io/myget/dawoe-umbraco/vpre/Dawoe.OEmbedPickerPropertyEditor.svg)](https://www.myget.org/feed/dawoe-umbraco/package/nuget/Dawoe.OEmbedPickerPropertyEditor)

|Umbraco Packages  |                  |
|:-----------------|:-----------------|
|**Release**|[![Our Umbraco project page](https://img.shields.io/badge/our-umbraco-orange.svg)](https://our.umbraco.org/projects/backoffice-extensions/oembed-picker-property-editor/) 
|**Pre-release**| [![AppVeyor Artifacts](https://img.shields.io/badge/appveyor-umbraco-orange.svg)](https://ci.appveyor.com/project/dawoe/oembed-picker-property-editor/build/artifacts)

## Installation

### Package

Download and install the package from : [http://our.umbraco.org/projects/backoffice-extensions/oembed-picker-property-editor](http://our.umbraco.org/projects/backoffice-extensions/oembed-picker-property-editor)

### Nuget

`Install-Package Dawoe.OEmbedPickerPropertyEditor`

If you only need the binaries you can install

`Install-Package Dawoe.OEmbedPickerPropertyEditor.Core`

## Usage

### CMS Configuration

1.  In Umbraco create a datatype and choose OEmbed Picker as your property editor
2.  If you want to allow embedding of multiple items check the box "Allow Multiple"
3.  Add a property to your documenttype using the newly created datatype

### Templates/Views

The package comes with a property value convertor for easy use in your views. The property editor returns a object containing the following properties 

- Url : The url of the embedded item
- EmbedCode : the embed code 
- Width : the width set by the editor
- Height : the height set by the editor

For a single embed :

 ```
 @using Dawoe.OEmbedPickerPropertyEditor.Models;
 @Model.Value<OEmbedItem>("propalias").EmbedCode
 ```

For multiple embeds : 

 ```
 @using Dawoe.OEmbedPickerPropertyEditor.Models;
 @foreach(var item in Model.Value<IEnumerable<OEmbedItem>>("propalias")) 
 {
     <div>@item.EmbedCode</div>
 }
 ```

## Changelog

### 4.3.0
 - Add "edit" functionality to your embeds thanks to @bjarnef ([#15](https://github.com/dawoe/OEmbed-Picker-Property-Editor/pull/15))

### 4.2.0

- Make classes for configuration public ([#4](https://github.com/dawoe/OEmbed-Picker-Property-Editor/pull/15))
- UI Improvements thanks to @TRexStark ([#5](https://github.com/dawoe/OEmbed-Picker-Property-Editor/pull/15))

### 4.1.0

- Make compatible with Umbraco 8.1.0 and up

### 4.0.0

- V8 support
- Different return type from value converter
- Macro Parameter editor support

### 3.0.0

- Better support for modelsbuilder. It now returns IHtmlstring or IEnumerable<IHtmlstring> instead of object when generating models. 
This is can be a potentially breaking changes because the models will be generated differently.

### 2.0.3

- Fix typo

### 2.0.2
- Fix issue #3: Mandatory field not working

### 2.0.1
- Fix issue #2: Property editor doesn't work when used inside Leblender editor

### 2.0.0
- Remove serving of clientside resources through handler. Now files are extracted on first run after installing.

### 1.0.1
- Fix issue #1: Conflict with nuPickers

### 1.0.0
- Initial release



## Contact

Feel free to contact me on twitter : [@dawoe21](https://twitter.com/dawoe21)


## Support this package ##

If you like this package and use it in your website, consider becoming a patreon to support ongoing maintenance

[https://www.patreon.com/dawoe](https://t.co/TBsvTMnOLB)


