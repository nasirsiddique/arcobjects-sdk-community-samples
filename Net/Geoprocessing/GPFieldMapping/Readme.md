## Geoprocessing field mapping

  <div xmlns="http://www.w3.org/1999/xhtml" xmlns:my="http://schemas.microsoft.com/office/infopath/2003/myXSD/2006-02-10T23:25:53">This sample demonstrates how to set up field mapping for tools such as Merge, Table to Table, Feature Class to Feature Class, and Append.</div>  


<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#, VB
Subject:               Geoprocessing
Organization:          Esri, http://www.esri.com
Date:                  11/17/2017
ArcObjects SDK:        10.6
Visual Studio:         2015, 2017
.NET Target Framework: 4.5
```

### Resources

* [ArcObjects .NET API Reference online](http://desktop.arcgis.com/en/arcobjects/latest/net/webframe.htm)  
* [Sample Data Download](../../releases)  
* [What's new](http://desktop.arcgis.com/en/arcobjects/latest/net/webframe.htm#05247c04-bfd9-4e36-ae09-bc6e833c3b14.htm)  
* [Download the ArcObjects SDK for .Net from MyEsri.com](https://my.esri.com/)  

### Usage
1. Provide local data. You need to update the code to reference your dataset and its fields. You also need to update the path to the output table to the location where you want it created.  
1. Compile and run the project.   





#### Additional information  
<div xmlns="http://www.w3.org/1999/xhtml" xmlns:my="http://schemas.microsoft.com/office/infopath/2003/myXSD/2006-02-10T23:25:53">In this sample, a table containing United States (U.S.) census data is converted to a new table. One of the input attributes in the input table is a text field, STFID. This 15-digit value is a unique identifier for all census blocks for the U.S. The value can be broken into four components. The first two digits provide the state code, the next three indicate the county, the following six identify the census tract, and the last four identify the census block.</div>  
<div xmlns="http://www.w3.org/1999/xhtml" xmlns:my="http://schemas.microsoft.com/office/infopath/2003/myXSD/2006-02-10T23:25:53"> </div>  
<div xmlns="http://www.w3.org/1999/xhtml" xmlns:my="http://schemas.microsoft.com/office/infopath/2003/myXSD/2006-02-10T23:25:53">The value 360899912001006 represents the census block (1006) containing the State University of New York at Potsdam in upstate New York (36), in census tract 991200 of the county of St. Lawrence (089). This sample converts this table and also creates a field, TRACTID, because the input data only has the STFID attribute. To do this, the GPFieldMapping object is initialized using the AddTable method to enter the input table. The default IGPFieldMapping object is then modified by creating an IGPFieldMap object, populating its properties, and adding them to the IGPFieldMapping object. </div>  


#### See Also  
[Mapping fields](http://desktop.arcgis.com/search/?q=Mapping%20fields&p=0&language=en&product=arcobjects-sdk-dotnet&version=&n=15&collection=help)  


---------------------------------

#### Licensing  
| Development licensing | Deployment licensing | 
| ------------- | ------------- | 
| ArcGIS Desktop Basic | ArcGIS Desktop Basic |  
| ArcGIS Desktop Standard | ArcGIS Desktop Standard |  
| ArcGIS Desktop Advanced | ArcGIS Desktop Advanced |  
| Engine Developer Kit | Engine |  


