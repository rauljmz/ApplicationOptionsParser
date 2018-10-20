# Application Options Parser

A simple parser for reading parameters, options, passed on to Console applications. The library is .netstandard so it can be used with .net core projects.

## Usage

1. Reference the nuget package ```ApplicationOptionsParser```.
1. Create a class with properties for all the different options you expect.
1. Decorate those properties with one of the following attributes:
    - ```[Fixed(0)]``` : this property is picked up from its position in the parameters. If it is missing an exception is thrown. The nuber in the constructor, 0-based, indicates the position.
    - ```[Optional]``` : this property may or may not be present. It will require a prefix with the same name as the property. Alternatively you can specify a different name for the prefix e.g. ```[Optional(Name = "Foo")]```.
    - ```[Flag]``` : this can be used on boolean properties. The parameter may or may not be present. Its name can be specified (```[Flag(Name = "Bar")])``` or otherwise defaults to the same name as the property.
1. Invoke the OtionsParser passing your own class as the generic attribute: ```OptionsParser.Parse<ApplicationOptions>(args);```. This returns an instance of your class, populated with the right properties from the parameters. You can define default values in the constructor. If there is an error with the parsing it will throw a ```OptionsParsingException```.  