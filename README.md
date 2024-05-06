# GChartsBlazorfied

Author: Ryan Kueter  
Updated: May, 2024

## About

**GChartsBlazorfied** is a free .NET library available from the [NuGet Package Manager](https://www.nuget.org/packages/GChartsBlazorfied) that allows Blazor developers to easily add Google Maps, Geo Charts, and other popular charts from the Google Charts javascript library using C#.

### Targets:
- .NET 7, .NET 8

## Introduction

GChartsBlazorfied currently provides a limited number of Google Charts, including:
* Google Maps
* Geo Charts
* Area Chart
* Bar Chart
* Column Chart
* Histogram
* Line Chart
* Pie Chart
* Scatter Chart

## Setup

### Step 1: Reference Google's Loader.js

First, you need to reference the [Google Charts](https://developers.google.com/chart) library: 

Note: The loader.js file used to test this library is included in the source folder.

```html
<script rel="prefetch" src="https://www.gstatic.com/charts/loader.js"></script>
```

### Step 2: Install GChartsBlazorfied
* [https://www.nuget.org/packages/GChartsBlazorfied](https://www.nuget.org/packages/GChartsBlazorfied)

### Step 3: Google Maps Initialization

Google maps or geo charts require one instance of the ```<GMapsInitialize />``` element somewhere on the main page to initialize google maps, similar to the following:

```<GMapsInitialize ApiKey="YOUR-GOOGLE-MAPS-API-KEY" Language="en" />```

## Data Sources

GChartsBlazorfied provides a couple of built in classes for loading data:
* ObjectArray
* DataTable

### ObjectArray
```csharp
///
/// Example object array:
///
private gcObjectArray GeoChartData =>
    new gcObjectArray()
        .AddRow("City", "Population", "Area")
        .AddRow("Rome", 2761477, 1285.31)
        .AddRow("Milan", 1324110, 181.76)
        .AddRow("Naples", 959574, 117.27)
        .AddRow("Turin", 907563, 130.17)
        .AddRow("Palermo", 655875, 158.9)
        .AddRow("Genoa", 607906, 243.60)
        .AddRow("Bologna", 380181, 140.7)
        .AddRow("Florence", 371282, 102.41)
        .AddRow("Fiumicino", 67370, 213.44)
        .AddRow("Anzio", 52192, 43.43)
        .AddRow("Ciampino", 38262, 11);
```

### DataTable

The DataTable builder provides additional functionality including Html tooltips and bar chart styles.

```csharp
///
/// Example DataTable:
///
private gcDataTableBuilder GetDataTable() =>
    new gcDataTableBuilder()
        .AddColumn(c =>
        {
            c.label = "Year";
            c.type = gcType.String;
        })
        .AddColumn(c =>
        {
            c.label = "Sales";
            c.type = gcType.Number;
        })
        .AddColumn(c =>
        {
            c.type = gcType.String;
            c.role = gcRole.Tooltip;
            c.P(p => p.html = true);
        })
        .AddColumn(c =>
        {
            c.label = "Expenses";
            c.type = gcType.Number;
        })
        .AddColumn(c =>
        {
            c.type = gcType.String;
            c.role = gcRole.Tooltip;
            c.P(p => p.html = true);
        })
        .AddRow(o =>
        {
            o.AddCell("2013");
            o.AddCell(1000);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2013</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(400);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2013</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(100);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2013</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
        })
        .AddRow(o =>
        {
            o.AddCell("2014");
            o.AddCell(1170);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2014</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(460);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2014</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(50);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2014</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
        })
        .AddRow(o =>
        {
            o.AddCell("2015");
            o.AddCell(660);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2015</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(1120);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2015</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(20);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2015</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
        })
        .AddRow(o =>
        {
            o.AddCell("2016");
            o.AddCell(1030);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2016</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(540);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2016</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(30);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2016</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
        });
```

## Additional Features

GChartsBlazorfied also provides the ability to add click event handlers. And some google charts provide a material theme. Where provided, that material theme can be used by specifying the UseMaterialTheme = "true" attribute.

Currently, Google's library only provides the material theme with the following charts:
* Bar Chart
* Line Chart
* Scatter Chart
* Column Chart

### Click Event Handlers

The following example includes the OnClick attribute to supply the click handler:

```csharp
<BarChart 
    Title="Population of Largest U.S. Cities"
    Style="width: 800px; height: 500px;"
    ObjectArray="BarChartObjectArray"
    OnClick="ClickEventHandler"
    UseMaterialTheme = "true"
    Options="@(o =>
    {
        o.colors("#2196F3", "#4CAF50");
        o.HAxis(o => 
        {
            o.title = "Total Population"; 
            o.minValue = 0;
            o.format = "short";
            o.direction = 1;
            o.slantedText = true;
            o.slantedTextAngle = 30;
        });
        o.VAxis(o =>
        {
            o.title = "City";
            o.direction = -1;
            o.Gridlines(o => o.count = 4);
        });
        o.Legend(o =>
        {
            o.position = "top"; 
            o.maxLines = 3;
        });
        o.Bar(o => o.groupWidth = "75%");
        o.Annotations(o =>
        {
            o.alwaysOutside = true;
            o.TextStyle(o =>
            {
                o.fontSize = 14;
                o.color = "#000";
                o.auraColor = "none";
            });
        });
        o.Animation(o =>
        {
            o.duration = 500;
            o.easing = gcAnimationEasingType.Out;
            o.startup = true;
        });
        o.Tooltip(o =>
        {
            o.isHtml = true;
        });
    })" />

<h2>Click the chart to view click events:</h2>
@foreach (var c in ClickEvents)
{
    <div>@c</div>
}

@code {
    public List<string> ClickEvents = new();
    private void ClickEventHandler(gcClickEventArgs e) =>
        ClickEvents.Add($"Clicked Row: {e.row}, Column: {e.column}");
}
```

### Configurations

In the example above, the chart is configured with the Optons attribute. Those options may also be decoupled to enable a developer to provide the same configuration to multiple charts with different data.

* Map Chart (IMapChartOptions)
* Geo Chart (IGeoChartOptions)
* Area Chart (IAreaChartOptions)
* Bar Chart (IBarChartOptions)
* Column chart (IColumnChartOptions)
* Histogram (IHistogramChartOptions)
* Line Chart (ILineChartOptions)
* Pie chart (IPieChartOptions)
* Scatter Chart (IScatterChartOptions)

The following is an example of how you may use the options file:

```csharp
<ColumnChart 
    Title="Company Performance"
    Options="@GetOptions()"
    Style="width: 800px; height: 500px;"
    ObjectArray="ColumnChartObjectArray" />

@code {
    public Action<IColumnChartOptions> GetOptions() => (o =>
    {
        o.Bar(o => o.groupWidth = "75%");
        o.Legend(o => o.position = "bottom");
        o.VAxis(o =>
        {
            o.title = "Amount";
            o.minValue = 0;
            o.maxValue = 1500;
            o.format = "#,###";
        });
        o.HAxis(o =>
        {
            o.title = "Year";
            o.slantedText = true;
            o.slantedTextAngle = 45;
        });
        o.Animation(o =>
        {
            o.duration = 1000;
            o.easing = gcAnimationEasingType.Out;
            o.startup = true;
        });
        o.BackgroundColor(o =>
        {
            o.fill = "#FFFFFF";
        });
        o.enableInteractivity = true;
        o.Annotations(o =>
        {
            o.alwaysOutside = true;
        });
        o.axisTitlesPosition = "out";
        o.Tooltip(o =>
        {
            o.trigger = "hover";
            o.showColorCode = true;
        });
        o.colors("#2196F3", "#4CAF50", "#FFC107");
        o.isStacked = gcStackType.False;
    });
}
```

### Map Chart Example

To use maps, a single instance of GMapsInitialize element needs to added to the main page to initialize google maps.

```<GMapsInitialize ApiKey="YOUR-GOOGLE-MAPS-API-KEY" Language="en" />```

```csharp
<MapChart 
    ObjectArray="MapData" 
    Style="height: 500px; width: 900px;" 
    ApiKey="YOUR-GOOGLE-MAPS-API-KEY"
    Options="@(o =>
    {
        o.mapType = "styledMap";
        o.zoomLevel = 12;
        o.showTooltip = true;
        o.showInfoWindow = true;
        o.useMapTypeControl = true;
        o.Maps(o =>
        {
            o.AddMap("styledMap", o =>
            {
                o.name = "Styled Map";
                o.Styles(o =>
                {
                    o.AddMapStyle(o =>
                    {
                        o.featureType = "poi.attraction";
                        o.AddStyler(gcStylers.color, "#fce8b2");
                    });
                    o.AddMapStyle(o =>
                    {
                        o.featureType = "road.highway";
                        o.AddStyler(gcStylers.hue, "#0277bd");
                        o.AddStyler(gcStylers.saturation, -50);
                    });
                    o.AddMapStyle(o =>
                    {
                        o.featureType = "road.highway";
                        o.elementType = "labels.icon";
                        o.AddStyler(gcStylers.hue, "#000");
                        o.AddStyler(gcStylers.saturation, 100);
                        o.AddStyler(gcStylers.lightness, 50);
                    });
                    o.AddMapStyle(o =>
                    {
                        o.featureType = "landscape";
                        o.AddStyler(gcStylers.hue, "#259b24");
                        o.AddStyler(gcStylers.saturation, 10);
                        o.AddStyler(gcStylers.lightness, -22);
                    });
                });
            });
        });
    })" 
/>

@code {
    gcObjectArray MapData =>
        new gcObjectArray()
            .AddRow("Address", "Location")
            .AddRow("Lake Buena Vista, FL 32830, United States", "Walt Disney World")
            .AddRow("6000 Universal Boulevard, Orlando, FL 32819, United States", "Universal Studios")
            .AddRow("7007 Sea World Drive, Orlando, FL 32821, United States", "Seaworld Orlando");
}
```

### Geo Chart Example

Geo Charts are similar to maps in that a single instance of GMapsInitialize element needs to added to the main page to initialize google maps.

```<GMapsInitialize ApiKey="YOUR-GOOGLE-MAPS-API-KEY" Language="en" />```

#### Exmaple 1:

```csharp
<GeoChart ObjectArray="GeoChartData" Style="height: 500px; width: 900px;" />

@code {
private gcObjectArray GeoChartData =>
    new gcObjectArray()
        .AddRow("Country", "Popularity")
        .AddRow("Germany", 400)
        .AddRow("United States", 700)
        .AddRow("Brazil", 400)
        .AddRow("Canada", 500)
        .AddRow("France", 600)
        .AddRow("RU", 100);
}
```

#### Exmaple 2:

```csharp
<GeoChart 
    ObjectArray="GeoChartData" 
    Style="height: 500px; width: 900px;" 
    ApiKey="YOUR-GOOGLE-MAPS-API-KEY"
    Options="@(o =>
    {
        o.region = "IT";
        o.displayMode = "markers";
        o.ColorAxis(o =>
        {
            o.colors("green", "blue");
        });
    })" 
/>

@code {
private gcObjectArray GeoChartData =>
    new gcObjectArray()
        .AddRow("City", "Population", "Area")
        .AddRow("Rome", 2761477, 1285.31)
        .AddRow("Milan", 1324110, 181.76)
        .AddRow("Naples", 959574, 117.27)
        .AddRow("Turin", 907563, 130.17)
        .AddRow("Palermo", 655875, 158.9)
        .AddRow("Genoa", 607906, 243.60)
        .AddRow("Bologna", 380181, 140.7)
        .AddRow("Florence", 371282, 102.41)
        .AddRow("Fiumicino", 67370, 213.44)
        .AddRow("Anzio", 52192, 43.43)
        .AddRow("Ciampino", 38262, 11);
}
```

### Area Chart

This area chart uses a Datatable. However, an object array may also be used.

```csharp
<AreaChart 
    Title="My New Chart"
    Style="width: 800px; height: 500px;"
    OnClick="ClickEventHandler"
    DataTable="GetDataTable()"
    Options="@(o =>
    {
        o.TitleTextStyle(o =>
        {
            o.color = "#555555";
            o.fontSize = 16;
        });
        o.HAxis(o =>
        {
            o.title = "Year";
            o.TextStyle(o =>
            {
                o.color = "#330000";
            });
            o.minValue = 0;
            o.maxValue = 5;
            o.format = "short";
        });
        o.VAxis(o =>
        {
            o.minValue = 0;
            o.maxValue = 1200;
            o.format = "currency";
        });
        o.Series(o =>
        {
            o.AddFormatter(o =>
            {
                o.color = "#2196F3";
                o.opacity = 0.8;
                o.lineWidth = 2;
            });
            o.AddFormatter(o =>
            {
                o.color = "#4CAF50";
                o.opacity = 0.8;
                o.lineWidth = 2;
            });
            o.AddFormatter(o =>
            {
                o.color = "#FFC107";
                o.opacity = 0.8;
                o.lineWidth = 2;
            });
        });
        o.isStacked = gcStackType.False;
        o.pointSize = 5;
        o.Legend(o =>
        {
            o.position = "bottom";
            o.alignment = "end";
        });
        o.BackgroundColor(o =>
        {
            o.fill = "#FFFFFF";
        });
        o.areaOpacity = 0.8;
        o.lineWidth = 2;
        o.Tooltip(o =>
        {
            o.trigger = "both";
            o.isHtml = true;
        });
        o.Animation(o =>
        {
            o.duration = 500;
            o.easing = gcAnimationEasingType.Out;
            o.startup = true;
        });
    })" />

@code {
private gcDataTableBuilder GetDataTable() =>
    new gcDataTableBuilder()
        .AddColumn(c =>
        {
            c.label = "Year";
            c.type = gcType.String;
        })
        .AddColumn(c =>
        {
            c.label = "Sales";
            c.type = gcType.Number;
        })
        .AddColumn(c =>
        {
            c.type = gcType.String;
            c.role = gcRole.Tooltip;
            c.P(p => p.html = true);
        })
        .AddColumn(c =>
        {
            c.label = "Expenses";
            c.type = gcType.Number;
        })
        .AddColumn(c =>
        {
            c.type = gcType.String;
            c.role = gcRole.Tooltip;
            c.P(p => p.html = true);
        })
        .AddRow(o =>
        {
            o.AddCell("2013");
            o.AddCell(1000);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2013</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(400);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2013</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(100);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2013</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
        })
        .AddRow(o =>
        {
            o.AddCell("2014");
            o.AddCell(1170);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2014</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(460);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2014</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(50);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2014</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
        })
        .AddRow(o =>
        {
            o.AddCell("2015");
            o.AddCell(660);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2015</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(1120);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2015</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(20);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2015</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
        })
        .AddRow(o =>
        {
            o.AddCell("2016");
            o.AddCell(1030);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2016</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(540);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2016</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
            o.AddCell(30);
            o.AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2016</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
        });
}
```

### Bar Chart

```csharp
<BarChart 
    Title="Population of Largest U.S. Cities"
    Style="width: 800px; height: 500px;"
    ObjectArray="BarChartObjectArray"
    OnClick="ClickEventHandler"
    UseMaterialTheme = "true"
    Options="@(o =>
    {
        o.colors("#2196F3", "#4CAF50");
        o.HAxis(o => 
        {
            o.title = "Total Population"; 
            o.minValue = 0;
            o.format = "short";
            o.direction = 1;
            o.slantedText = true;
            o.slantedTextAngle = 30;
        });
        o.VAxis(o =>
        {
            o.title = "City";
            o.direction = -1;
            o.Gridlines(o => o.count = 4);
        });
        o.Legend(o =>
        {
            o.position = "top"; 
            o.maxLines = 3;
        });
        o.Bar(o => o.groupWidth = "75%");
        o.Annotations(o =>
        {
            o.alwaysOutside = true;
            o.TextStyle(o =>
            {
                o.fontSize = 14;
                o.color = "#000";
                o.auraColor = "none";
            });
        });
        o.Animation(o =>
        {
            o.duration = 500;
            o.easing = gcAnimationEasingType.Out;
            o.startup = true;
        });
        o.Tooltip(o =>
        {
            o.isHtml = true;
        });
    })" />

@code {
    private gcObjectArray BarChartObjectArray => 
        new gcObjectArray()
            .AddRow("City", "2010 Population", "2000 Population")
            .AddRow("New York City, NY", 8175000, 8008000)
            .AddRow("Los Angeles, CA", 3792000, 3694000);
}
```

### Column Chart

```csharp
<ColumnChart 
    Title="Company Performance"
    Style="width: 800px; height: 500px;"
    ObjectArray="ColumnChartObjectArray"
    UseMaterialTheme = "true"
    Options="@(o =>
    {
        o.Bar(o => o.groupWidth = "75%");
        o.Legend(o => o.position = "bottom");
        o.VAxis(o =>
        {
            o.title = "Amount";
            o.minValue = 0;
            o.maxValue = 1500;
            o.format = "#,###";
        });
        o.HAxis(o =>
        {
            o.title = "Year";
            o.slantedText = true;
            o.slantedTextAngle = 45;
        });
        o.Animation(o =>
        {
            o.duration = 1000;
            o.easing = gcAnimationEasingType.Out;
            o.startup = true;
        });
        o.BackgroundColor(o =>
        {
            o.fill = "#FFFFFF";
        });
        o.enableInteractivity = true;
        o.Annotations(o =>
        {
            o.alwaysOutside = true;
        });
        o.axisTitlesPosition = "out";
        o.Tooltip(o =>
        {
            o.trigger = "hover";
            o.showColorCode = true;
        });
        o.colors("#2196F3", "#4CAF50", "#FFC107");
        o.isStacked = gcStackType.False;
    })" />

@code {
private gcObjectArray ColumnChartObjectArray => 
    new gcObjectArray()
        .AddRow("Year", "Sales", "Expenses", "Profit")
        .AddRow("2014", 1000, 400, 200)
        .AddRow("2015", 1170, 460, 250)
        .AddRow("2016", 660, 1120, 300)
        .AddRow("2017", 1030, 540, 350);
}
```

### Histogram

```csharp
<HistogramChart 
    Title="Country Populations"
    Style="width: 900px; height: 500px;"
    ObjectArray="HistogramChartData"
    Options="@(o =>
    {
        o.Legend(o => o.position = "none");
        o.colors("#2196F3");
        o.Animation(o =>
        {
            o.duration = 500;
            o.easing = gcAnimationEasingType.Out;
            o.startup = true;
        });
    })" />

@code {
private gcObjectArray HistogramChartData => 
    new gcObjectArray()
        .AddRow("Dinosaur", "Length")
        .AddRow("Acrocanthosaurus (top-spined lizard)", 12.2)
        .AddRow("Albertosaurus (Alberta lizard)", 9.1)
        .AddRow("Allosaurus (other lizard)", 12.2)
        .AddRow("Apatosaurus (deceptive lizard)", 22.9)
        .AddRow("Archaeopteryx (ancient wing)", 0.9)
        .AddRow("Argentinosaurus (Argentina lizard)", 36.6)
        .AddRow("Baryonyx (heavy claws)", 9.1)
        .AddRow("Brachiosaurus (arm lizard)", 30.5)
        .AddRow("Ceratosaurus (horned lizard)", 6.1)
        .AddRow("Coelophysis (hollow form)", 2.7)
        .AddRow("Compsognathus (elegant jaw)", 0.9)
        .AddRow("Deinonychus (terrible claw)", 2.7)
        .AddRow("Diplodocus (double beam)", 27.1)
        .AddRow("Dromicelomimus (emu mimic)", 3.4)
        .AddRow("Gallimimus (fowl mimic)", 5.5)
        .AddRow("Mamenchisaurus (Mamenchi lizard)", 21.0)
        .AddRow("Megalosaurus (big lizard)", 7.9)
        .AddRow("Microvenator (small hunter)", 1.2)
        .AddRow("Ornithomimus (bird mimic)", 4.6)
        .AddRow("Oviraptor (egg robber)", 1.5)
        .AddRow("Plateosaurus (flat lizard)", 7.9)
        .AddRow("Sauronithoides (narrow-clawed lizard)", 2.0)
        .AddRow("Seismosaurus (tremor lizard)", 45.7)
        .AddRow("Spinosaurus (spiny lizard)", 12.2)
        .AddRow("Supersaurus (super lizard)", 30.5)
        .AddRow("Tyrannosaurus (tyrant lizard)", 15.2)
        .AddRow("Ultrasaurus (ultra lizard)", 30.5)
        .AddRow("Velociraptor (swift robber)", 1.8);
}
```

### Line Chart

```csharp
<LineChart 
    Title="Box Office Earnings in First Two Weeks of Opening"
    Style="width: 800px; height: 500px;"
    ObjectArray="LineChartData"
    Options="@(o =>
    {
        o.colors("#2196F3", "#4CAF50", "#FFC107");
        o.Animation(o =>
        {
            o.duration = 500;
            o.easing = gcAnimationEasingType.Out;
            o.startup = true;
        });
    })" />

@code {
private gcObjectArray LineChartData = new gcObjectArray()
    .AddRow("Day", "Guardians of the Galaxy", "The Avengers", "Transformers: Age of Extinction")
    .AddRow(1, 37.8, 80.8, 41.8)
    .AddRow(2, 30.9, 69.5, 32.4)
    .AddRow(3, 25.4, 57.0, 25.7)
    .AddRow(4, 11.7, 18.8, 10.5)
    .AddRow(5, 11.9, 17.6, 10.4)
    .AddRow(6, 8.8, 13.6, 7.7)
    .AddRow(7, 7.6, 12.3, 9.6)
    .AddRow(8, 12.3, 29.2, 10.6)
    .AddRow(9, 16.9, 42.9, 14.8)
    .AddRow(10, 12.8, 30.9, 11.6)
    .AddRow(11, 5.3, 7.9, 4.7)
    .AddRow(12, 6.6, 8.4, 5.2)
    .AddRow(13, 4.8, 6.3, 3.6)
    .AddRow(14, 4.2, 6.2, 3.4);
}
```

### Line Chart with Crosshairs

```csharp
<LineChart 
    Title="Company Performance"
    Style="width: 800px; height: 500px;"
    ObjectArray="LineChartData"
    Options="@(o =>
    {
        o.curveType = "function";
        o.Legend(o => o.position = "bottom");
        o.HAxis(o =>
        {
            o.title = "Year";
            o.format = "short";
            o.direction = 1;
            o.slantedText = true;
            o.slantedTextAngle = 30;
            o.TextStyle(o => o.color = "#333");
        });
        o.VAxis(o =>
        {
            o.title = "Values";
            o.direction = 1;
            o.Gridlines(o => o.count = 4);
            o.minValue = 0;
            o.maxValue = 1200;
            o.format = "$#,###";
        });
        o.pointSize = 7;
        o.lineWidth = 2;
        o.Annotations(o => o.alwaysOutside = true);
        o.Crosshair(o =>
        {
            o.trigger = "both";
            o.orientation = "both";
        });
        o.Trendlines(o =>
        {
            o.AddFormatter(o =>
            {
                o.type = "exponential";
                o.color = "#2196F3";
                o.lineWidth = 3;
                o.opacity = 0.3;
            });
            o.AddFormatter(o =>
            {
                o.type = "linear";
                o.color = "#4CAF50";
                o.lineWidth = 3;
                o.opacity = 0.3;
            });
        });
        o.Series(o =>
        {
            o.AddFormatter(o =>
            {
                o.targetAxisIndex = 0;
                o.type = "line";
                o.lineDashStyle(4, 4);
                o.pointsVisible = true;
                o.color = "#2196F3";
            });
            o.AddFormatter(o =>
            {
                o.targetAxisIndex = 1;
                o.type = "line";
                o.lineDashStyle(1, 3);
                o.pointsVisible = true;
                o.color = "#4CAF50";
            });
        });
        o.BackgroundColor(o => o.fill = "#FFFFFF");
        o.isStacked = gcStackType.True;
        o.Tooltip(o => o.isHtml = true);
        o.focusTarget = "category";
        o.Explorer(o =>
        {
            o.actions("dragToZoom", "rightClickToReset");
            o.axis = "horizontal";
            o.keepInBounds = true;
            o.maxZoomIn = 0.1;
        });
        o.Animation(o =>
        {
            o.duration = 500;
            o.easing = gcAnimationEasingType.Out;
            o.startup = true;
        });
    })" />

@code {
    private gcObjectArray LineChartData2 => 
        new gcObjectArray()
            .AddRow("Year", "Sales", "Expenses")
            .AddRow("2004", 1000, 400)
            .AddRow("2005", 1170, 460)
            .AddRow("2006", 660, 1120)
            .AddRow("2007", 1030, 540);
}
```

### Pie Chart

```csharp
<PieChart 
    Title="My Daily Activities"
    Style="width: 900px; height: 500px;"
    ObjectArray="PieChartData"
    Options="@(o =>
    {
        o.is3D = true;
        o.pieHole = 0.4;
        o.Slices(o =>
        {
            o.AddFormatter(o => o.color = "#4285f4");
            o.AddFormatter(o => o.color = "#0f9d58");
            o.AddFormatter(o => o.color = "#f4b400");
            o.AddFormatter(o => o.color = "#db4437");
            o.AddFormatter(o => o.color = "#1e8e3e");
        });
        o.Legend(o =>
        {
            o.position = gcLegendPositionType.Top;
            o.TextStyle(o =>
            {
                o.color = "blue";
                o.fontSize = 16;
            });
        });
        o.Tooltip(o =>
        {
            o.trigger = "selection";
            o.showColorCode = true;
        });
        o.BackgroundColor(o => o.fill = "#FFFFFF");
        o.Animation(o =>
        {
            o.duration = 500;
            o.easing = gcAnimationEasingType.Out;
            o.startup = true;
        });
        o.pieStartAngle = 100;
        o.reverseCategories = false;
        o.sliceVisibilityThreshold = 0.01;
        o.pieSliceText = "percentage";
        o.pieSliceBorderColor = "#ffffff";
        o.enableInteractivity = true;
        o.focusTarget = "category";
    })" />

@code {
    private gcObjectArray PieChartData => 
        new gcObjectArray()
            .AddRow("Task", "Hours per Day")
            .AddRow("Work", 11)
            .AddRow("Eat", 2)
            .AddRow("Commute", 2)
            .AddRow("Watch TV", 2)
            .AddRow("Sleep", 7);
}
```

### Donut Chart

```csharp
<PieChart 
    Title="My Daily Activities"
    Style="width: 900px; height: 500px;"
    ObjectArray="DonutChartData"
    Options="@(o =>
    {
        o.pieHole = 0.4;
        o.Slices(o =>
        {
            o.AddFormatter(o => o.color = "#4285f4");
            o.AddFormatter(o => o.color = "#0f9d58");
            o.AddFormatter(o => o.color = "#f4b400");
            o.AddFormatter(o => o.color = "#db4437");
            o.AddFormatter(o => o.color = "#1e8e3e");
        });
        o.Legend(o =>
        {
            o.position = gcLegendPositionType.Top;
            o.TextStyle(o =>
            {
                o.color = "blue";
                o.fontSize = 16;
            });
        });
        o.Tooltip(o =>
        {
            o.trigger = "selection";
            o.showColorCode = true;
        });
        o.BackgroundColor(o => o.fill = "#FFFFFF");
        o.Animation(o =>
        {
            o.duration = 500;
            o.easing = gcAnimationEasingType.Out;
            o.startup = true;
        });
        o.reverseCategories = false;
        o.sliceVisibilityThreshold = 0.01;
        o.pieSliceText = "percentage";
        o.pieSliceBorderColor = "#ffffff";
        o.PieSliceTextStyle(o => o.color = "black");
        o.enableInteractivity = true;
        o.focusTarget = "category";
    })" />

@code {
private gcObjectArray DonutChartData =>
    new gcObjectArray()
        .AddRow("Task", "Hours per Day")
        .AddRow("Work", 11)
        .AddRow("Eat", 2)
        .AddRow("Commute", 2)
        .AddRow("Watch TV", 2)
        .AddRow("Sleep", 7);
}
```

### Pie Chart Exploded

```csharp
<PieChart 
    Title="Indian Language Use"
    Style="width: 900px; height: 500px;"
    ObjectArray="PieChartExplodedData"
    Options="@(o =>
    {
        o.Legend(o =>
        {
            o.position = gcLegendPositionType.Bottom;
            o.TextStyle(o =>
            {
                o.color = "blue";
                o.fontSize = 14;
            });
        });
        o.pieSliceText = "label";

        o.Slices(o =>
        {
            o.AddFormatter("4", o =>  o.offset = 0.2);
            o.AddFormatter("12", o =>  o.offset = 0.3);
            o.AddFormatter("14", o =>  o.offset = 0.4);
            o.AddFormatter("15", o =>  o.offset = 0.5);
        });
        o.BackgroundColor(o => o.fill = "#FFFFFF");
        o.Animation(o =>
        {
            o.duration = 500;
            o.easing = gcAnimationEasingType.Out;
            o.startup = true;
        });
        o.enableInteractivity = true;
        o.sliceVisibilityThreshold = 0.01;
        o.reverseCategories = false;
        o.Tooltip(o =>
        {
            o.trigger = "selection";
            o.showColorCode = true;
        });
        o.is3D = false;
        o.pieResidueSliceLabel = "Other";
        o.pieSliceBorderColor = "#ffffff";
        o.pieStartAngle = 30;
        o.focusTarget = "category";
        o.Annotations(o =>
        {
            o.alwaysOutside = true;
            o.TextStyle(o =>
            {
                o.color = "black";
                o.fontSize = 12;
            });
        });
        o.pieSliceText = "percentage";
        o.pieSliceBorderColor = "#ffffff";
        o.PieSliceTextStyle(o => o.color = "black");
        o.axisTitlesPosition = "out";
        o.fontSize = 12;
        o.fontName = "Arial";
    })" />

@code {  
    private gcObjectArray PieChartExplodedData =>
        new gcObjectArray()
            .AddRow("Language", "Speakers (in millions)")
            .AddRow("Assamese", 13)
            .AddRow("Bengali", 83)
            .AddRow("Bodo", 1.4)
            .AddRow("Dogri", 2.3)
            .AddRow("Gujarati", 46)
            .AddRow("Hindi", 300)
            .AddRow("Kannada", 38)
            .AddRow("Kashmiri", 5.5)
            .AddRow("Konkani", 5)
            .AddRow("Maithili", 20)
            .AddRow("Malayalam", 33)
            .AddRow("Manipuri", 1.5)
            .AddRow("Marathi", 72)
            .AddRow("Nepali", 2.9)
            .AddRow("Oriya", 33)
            .AddRow("Punjabi", 29)
            .AddRow("Sanskrit", 0.01)
            .AddRow("Santhali", 6.5)
            .AddRow("Sindhi", 2.5)
            .AddRow("Tamil", 61)
            .AddRow("Telugu", 74)
            .AddRow("Urdu", 52);
}
```

### Scatter Chart

```csharp
<ScatterChart 
    Title="Age vs. Weight comparison"
    Style="width: 900px; height: 500px;"
    ObjectArray="ScatterChartData"
    Options="@(o =>
    {
        o.colors("#2196F3");
        o.HAxis(o =>
        {
            o.title = "Age";
            o.minValue = 0;
            o.maxValue = 15;
            o.Gridlines(o => o.count = 8);
            o.TextStyle(o => o.color = "#333");
        });
        o.VAxis(o =>
        {
            o.title = "Weight";
            o.minValue = 0;
            o.maxValue = 15;
            o.Gridlines(o => o.count = 8);
            o.TextStyle(o => o.color = "#333");
        });
        o.pointSize = 5;
        o.Animation(o =>
        {
            o.duration = 500;
            o.easing = gcAnimationEasingType.Out;
            o.startup = true;
        });
    })" />

@code {
    private gcObjectArray ScatterChartData => 
        new gcObjectArray()
            .AddRow("Age", "Weight")
            .AddRow(8, 12)
            .AddRow(4, 5.5)
            .AddRow(11, 14)
            .AddRow(4, 5)
            .AddRow(3, 3.5)
            .AddRow(6.5, 7);
}
```

### Scatter Chart with Trendline

```csharp
<ScatterChart 
    Title="Descendants by Generation"
    Style="width: 900px; height: 500px;"
    ObjectArray="TrendlineChartData"
    Options="@(o =>
    {
        o.colors("#2196F3");
        o.HAxis(o =>
        {
            o.title = "Generation";
            o.minValue = 0;
            o.maxValue = 3;
        });
        o.VAxis(o =>
        {
            o.title = "Descendants";
            o.minValue = 0;
            o.maxValue = 2100;
        });
        o.Trendlines(o =>
        {
            o.AddFormatter(o =>
            {
                o.type = gcTrendlineType.Exponential;
                o.visibleInLegend = true;
                o.color = "#4CAF50";
            });
        });
        o.Animation(o =>
        {
            o.duration = 500;
            o.easing = gcAnimationEasingType.Out;
            o.startup = true;
        });
    })" />

@code {
    private gcObjectArray TrendlineChartData => new gcObjectArray()
        .AddRow("Generation", "Descendants")
        .AddRow(0, 1)
        .AddRow(1, 33)
        .AddRow(2, 269)
        .AddRow(2, 269)
        .AddRow(3, 2013);
}
```

###
## Contributions

This project is being developed for free by me, Ryan Kueter, in my spare time. So, if you would like to contribute, please submit your ideas on the Github project page.