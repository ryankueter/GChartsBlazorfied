# GChartsBlazorfied

Author: Ryan Kueter  
Updated: September, 2023

## About

**GChartsBlazorfied** is a free .NET library, available from the [NuGet Package Manager](https://www.nuget.org/packages/GChartsBlazorfied), is a wrapper for the Google Charts javascript library that enables Blazor developers to configure and provide data to the library using C#.

### Targets:
- .NET 7

## Introduction

GChartsBlazorfied currently provides a limited number of Google Charts, including:
* Area Chart
* Bar Chart
* Column chart
* Histogram
* Line Chart
* Pie chart
* Scatter Chart

### Setup

#### Google's Loader.js

A copy of the loader.js file used to test this library is included in the source folder.

```html
<script src="https://www.gstatic.com/charts/loader.js"></script>
```

#### Classic Themed Charts

The classic theme works with all of the charts.

```html
<script src="_content/GChartsBlazorfied/js/gcharts_blazorfied_classic.js"></script>
```

#### Material Themed Charts

Currently, Google's library does not provide the material theme with all charts, nor does it support creating .png images. Supported charts include:
* Bar Chart
* Line Chart
* Scatter Chart
* Column Chart

```html
<script src="_content/GChartsBlazorfied/js/gcharts_blazorfied_material.js"></script>
```

### Data Sources

For data sources, developers have a couple of options: 
* Object array
* DataTable.

#### Object Array
```csharp
///
/// Example object array for an area chart:
///
private List<object> ObjectArray = new List<object>
{
    new List<object>() { "Year", "Sales", "Expenses", "Losses" },
    new List<object>() { "2013", 1000, 400, 100 },
    new List<object>() { "2014", 1170, 460, 50 },
    new List<object>() { "2015", 660, 1120, 20 },
    new List<object>() { "2016", 1030, 540, 30 }
};
```

#### DataTable

The DataTable builder is found in the GChartsDataTableBlazorfied library, which provides more advanced functionality, like Html tooltips and bar chart styles. This was made into a separate library so it can be added to a backend service without having to include GChartBlazorfied.

```csharp
///
/// Example DataTable for an area chart:
///
private gcDataTableBuilder GetDataTable()
{
    var DataTableBuilder = new gcDataTableBuilder();
    DataTableBuilder.Columns!.Add(new gcColumn() { label = "Year", type = gcType.String });
    DataTableBuilder.Columns!.Add(new gcColumn() { label = "Sales", type = gcType.Number });
    DataTableBuilder.Columns!.Add(new gcColumn() { type = gcType.String, role = gcRole.Tooltip, p = new gcP { html = true } });
    DataTableBuilder.Columns!.Add(new gcColumn() { label = "Expenses", type = gcType.Number });
    DataTableBuilder.Columns!.Add(new gcColumn() { type = gcType.String, role = gcRole.Tooltip, p = new gcP { html = true } });
    DataTableBuilder.Columns!.Add(new gcColumn() { label = "Losses", type = gcType.Number });
    DataTableBuilder.Columns!.Add(new gcColumn() { type = gcType.String, role = gcRole.Tooltip, p = new gcP { html = true } });
    DataTableBuilder.AddRow()
        .AddCell("2013")
        .AddCell(1000)
        .AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2013</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""")
        .AddCell(400)
        .AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2013</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""")
        .AddCell(100)
        .AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2013</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
    DataTableBuilder.AddRow()
        .AddCell("2014")
        .AddCell(1170)
        .AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2014</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""")
        .AddCell(460)
        .AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2014</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""")
        .AddCell(50)
        .AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2014</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
    DataTableBuilder.AddRow()
        .AddCell("2015")
        .AddCell(660)
        .AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2015</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""")
        .AddCell(1120)
        .AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2015</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""")
        .AddCell(20)
        .AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2015</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
    DataTableBuilder.AddRow()
        .AddCell("2016")
        .AddCell(1030)
        .AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2016</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""")
        .AddCell(540)
        .AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2016</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""")
        .AddCell(30)
        .AddCell(""""<div style="padding: 10px"><h1>Html Tooltip 2016</h1> <a href="https://developers.google.com/chart">Google Charts</a></div>"""");
    return DataTableBuilder;
}
```

### Click Event Handlers

Each chart type also provides click event handlers. The following example includes the OnClick attribute, which specifies the click handler:

```csharp
<BarChart 
    @ref="chart"
    GetImage="true"
    Title="Population of Largest U.S. Cities"
    Style="width: 800px; height: 500px;"
    Colors=@(new gcColors("#2196F3", "#4CAF50"))
    ObjectArray="BarChartObjectArray"
    HAxis=@(new gcAxis { title = "Total Population", minValue = 0, format = "short", direction = 1, slantedText = true, slantedTextAngle = 30 })
    VAxis=@(new gcAxis { title = "City", direction = -1, gridlines = new gcGridlines { count = 4 } })
    Legend=@(new gcLegend { position = "top", maxLines = 3 })
    Bar=@(new gcBar { groupWidth = "75%" })
    Annotations=@(new gcAnnotations { alwaysOutside = true, textStyle = new gcTextStyle { fontSize = 14, color = "#000", auraColor = "none" } })
    Animation=@(new gcAnimation { duration = 500, easing = gcAnimationEasingType.Out, startup = true })
    Tooltip=@(new gcTooltip { isHtml = true })
    OnClick="ClickEventHandler" />

<h2>Click the chart to view click events:</h2>
@foreach (var c in ClickEvents)
{
    <div>@c</div>
}

@code {
    public List<string> ClickEvents = new();
    private void ClickEventHandler(gcClickEventArgs e)
    {
        ClickEvents.Add($"Clicked Row: {e.row}, Column: {e.column}");
    }
}
```

### Configuration Files

Each chart can be configured using the element attributes or the chart options class. The options class enables developer to supply the same configuration to multiple charts. And to override the configuration supplied by the options, you provide configuration using the element attributes:

* Area Chart (AreaChartOptions)
* Bar Chart (BarChartOptions)
* Column chart (ColumnChartOptions)
* Histogram (HistogramChartOptions)
* Line Chart (LineChartOptions)
* Pie chart (PieChartOptions)
* Scatter Chart (ScatterChartOptions)

The following is an example of how you may use the options file:

```csharp
<ColumnChart 
    Title="Company Performance"
    Options="@GetOptions()"
    Style="width: 800px; height: 500px;"
    ObjectArray="ColumnChartObjectArray" />

@code {
    private ColumnChartOptions GetOptions()
    {
        return new ColumnChartOptions
        {
            bar = new gcBar { groupWidth = "75%" },
            legend = new gcLegend { position = "bottom" },
            vAxis = new gcAxis { title = "Amount", minValue = 0, maxValue = 1500, format = "#,###" },
            hAxis = new gcAxis { title = "Year", slantedText = true, slantedTextAngle = 45 },
            animation = new gcAnimation { duration = 1000, easing = gcAnimationEasingType.Out, startup = true },
            backgroundColor = new gcBackgroundColor { fill = "#FFFFFF" },
            enableInteractivity = true,
            annotations = new gcAnnotations { alwaysOutside = true },
            axisTitlesPosition = "out",
            tooltip = new gcTooltip { trigger = "hover", showColorCode = true },
            colors = new gcColors("#2196F3", "#4CAF50", "#FFC107").GetColors(),
            isStacked = gcStackType.False
        };
    }
}
```

### Area Chart

```csharp
<AreaChart 
    Title="My New Chart"
    Style="width: 800px; height: 500px;"
    TitleTextStyle=@(new gcTextStyle() { color = "#555555", fontSize = 16 })
    DataTable="GetDataTable()"
    HAxis=@(new gcAxis { title = "Year", textStyle = new gcTextStyle { color = "#330000" }, minValue = 0, maxValue = 5, format = "short" })
    VAxis=@(new gcAxis { minValue = 0, maxValue = 1200, format = "currency" })
    IsStacked="@gcStackType.False"
    PointSize="5"
    Legend=@(new gcLegend { position = "bottom", alignment = "end" })
    BackgroundColor=@(new gcBackgroundColor { fill = "#FFFFFF" } )
    AreaOpacity="0.8"
    LineWidth="2"
    Tooltip=@(new gcTooltip { trigger = "both", isHtml = true })
    Series=@(new gcFormatters()
        .AddFormatter(new gcFormatter { color = "#2196F3", opacity = 0.8, lineWidth = 2 })
        .AddFormatter(new gcFormatter { color = "#4CAF50", opacity = 0.8, lineWidth = 2 })
        .AddFormatter(new gcFormatter { color = "#FFC107", opacity = 0.8, lineWidth = 2 }))
    Animation=@(new gcAnimation { duration = 500, easing = gcAnimationEasingType.Out, startup = true })
     />

@code {
    private List<object> ObjectArray = new List<object>
    {
        new List<object>() { "Year", "Sales", "Expenses", "Losses" },
        new List<object>() { "2013", 1000, 400, 100 },
        new List<object>() { "2014", 1170, 460, 50 },
        new List<object>() { "2015", 660, 1120, 20 },
        new List<object>() { "2016", 1030, 540, 30 }
    };
}
```

### Bar Chart

```csharp
<BarChart 
    Title="Population of Largest U.S. Cities"
    Style="width: 800px; height: 500px;"
    Colors=@(new gcColors("#2196F3", "#4CAF50"))
    ObjectArray="BarChartObjectArray"
    HAxis=@(new gcAxis { title = "Total Population", minValue = 0, format = "short", direction = 1, slantedText = true, slantedTextAngle = 30 })
    VAxis=@(new gcAxis { title = "City", direction = -1, gridlines = new gcGridlines { count = 4 } })
    Legend=@(new gcLegend { position = "top", maxLines = 3 })
    Bar=@(new gcBar { groupWidth = "75%" })
    Annotations=@(new gcAnnotations { alwaysOutside = true, textStyle = new gcTextStyle { fontSize = 14, color = "#000", auraColor = "none" } })
    Animation=@(new gcAnimation { duration = 500, easing = gcAnimationEasingType.Out, startup = true })
    Tooltip=@(new gcTooltip { isHtml = true })
    OnClick="ClickEventHandler" />

@code {
    private List<object> BarChartObjectArray = new List<object>
    {
        new List<object> { "City", "2010 Population", "2000 Population" },
        new List<object> { "New York City, NY", 8175000, 8008000 },
        new List<object> { "Los Angeles, CA", 3792000, 3694000 },
    };
}
```

### Column Chart

```csharp
<ColumnChart 
    Title="Company Performance"
    Style="width: 800px; height: 500px;"
    Bar=@(new gcBar { groupWidth = "75%" })
    Legend=@(new gcLegend { position = "bottom" })
    VAxis=@(new gcAxis { title = "Amount", minValue = 0, maxValue = 1500, format = "#,###"})
    HAxis=@(new gcAxis { title = "Year", slantedText = true, slantedTextAngle = 45 })
    Animation=@(new gcAnimation { duration = 1000, easing = gcAnimationEasingType.Out, startup = true})
    BackgroundColor="@(new gcBackgroundColor { fill = "#FFFFFF" })"
    EnableInteractivity="true"
    Annotations=@(new gcAnnotations { alwaysOutside = true })
    AxisTitlesPosition="out"
    Tooltip=@(new gcTooltip { trigger = "hover", showColorCode = true})
    Colors=@(new gcColors("#2196F3", "#4CAF50", "#FFC107"))
    ObjectArray="ColumnChartObjectArray"
    IsStacked="@gcStackType.False" />

@code {
    private List<object> ColumnChartObjectArray = new List<object> {
        new List<object> { "Year", "Sales", "Expenses", "Profit" },
        new List<object> { "2014", 1000, 400, 200 },
        new List<object> { "2015", 1170, 460, 250 },
        new List<object> { "2016", 660, 1120, 300 },
        new List<object> { "2017", 1030, 540, 350 }
    };
}
```

### Histogram

```csharp
<HistogramChart 
    Title="Country Populations"
    Style="width: 900px; height: 500px;"
    Legend=@(new gcLegend { position = "none" })
    Colors=@(new gcColors("#2196F3"))
    ObjectArray="HistogramChartData" />

@code {
    private List<object> HistogramChartData = new List<object>
    {
        new List<object> { "Dinosaur", "Length" },
        new List<object> { "Acrocanthosaurus (top-spined lizard)", 12.2 },
        new List<object> { "Albertosaurus (Alberta lizard)", 9.1 },
        new List<object> { "Allosaurus (other lizard)", 12.2 },
        new List<object> { "Apatosaurus (deceptive lizard)", 22.9 },
        new List<object> { "Archaeopteryx (ancient wing)", 0.9 },
        new List<object> { "Argentinosaurus (Argentina lizard)", 36.6 },
        new List<object> { "Baryonyx (heavy claws)", 9.1 },
        new List<object> { "Brachiosaurus (arm lizard)", 30.5 },
        new List<object> { "Ceratosaurus (horned lizard)", 6.1 },
        new List<object> { "Coelophysis (hollow form)", 2.7 },
        new List<object> { "Compsognathus (elegant jaw)", 0.9 },
        new List<object> { "Deinonychus (terrible claw)", 2.7 },
        new List<object> { "Diplodocus (double beam)", 27.1 },
        new List<object> { "Dromicelomimus (emu mimic)", 3.4 },
        new List<object> { "Gallimimus (fowl mimic)", 5.5 },
        new List<object> { "Mamenchisaurus (Mamenchi lizard)", 21.0 },
        new List<object> { "Megalosaurus (big lizard)", 7.9 },
        new List<object> { "Microvenator (small hunter)", 1.2 },
        new List<object> { "Ornithomimus (bird mimic)", 4.6 },
        new List<object> { "Oviraptor (egg robber)", 1.5 },
        new List<object> { "Plateosaurus (flat lizard)", 7.9 },
        new List<object> { "Sauronithoides (narrow-clawed lizard)", 2.0 },
        new List<object> { "Seismosaurus (tremor lizard)", 45.7 },
        new List<object> { "Spinosaurus (spiny lizard)", 12.2 },
        new List<object> { "Supersaurus (super lizard)", 30.5 },
        new List<object> { "Tyrannosaurus (tyrant lizard)", 15.2 },
        new List<object> { "Ultrasaurus (ultra lizard)", 30.5 },
        new List<object> { "Velociraptor (swift robber)", 1.8 }
    };
}
```

### Line Chart

```csharp
<LineChart 
    Title="Box Office Earnings in First Two Weeks of Opening"
    Style="width: 800px; height: 500px;"
    Colors=@(new gcColors("#2196F3", "#4CAF50", "#FFC107"))
    ObjectArray="LineChartData" />

@code {
    private List<object> LineChartData = new List<object>
    {
        new List<object> { "Day", "Guardians of the Galaxy", "The Avengers", "Transformers: Age of Extinction" },
        new List<object> { 1, 37.8, 80.8, 41.8 },
        new List<object> { 2, 30.9, 69.5, 32.4 },
        new List<object> { 3, 25.4, 57.0, 25.7 },
        new List<object> { 4, 11.7, 18.8, 10.5 },
        new List<object> { 5, 11.9, 17.6, 10.4 },
        new List<object> { 6, 8.8, 13.6, 7.7 },
        new List<object> { 7, 7.6, 12.3, 9.6 },
        new List<object> { 8, 12.3, 29.2, 10.6 },
        new List<object> { 9, 16.9, 42.9, 14.8 },
        new List<object> { 10, 12.8, 30.9, 11.6 },
        new List<object> { 11, 5.3, 7.9, 4.7 },
        new List<object> { 12, 6.6, 8.4, 5.2 },
        new List<object> { 13, 4.8, 6.3, 3.6 },
        new List<object> { 14, 4.2, 6.2, 3.4 }
    };
}
```

### Line Chart with Crosshairs

```csharp
<LineChart 
    Title="Company Performance"
    Style="width: 800px; height: 500px;"
    ObjectArray="LineChartData2"
    CurveType="function" 
    Legend=@(new gcLegend { position = "bottom" }) 
    HAxis=@(new gcAxis { title = "Year", format = "short", direction = 1, slantedText = true, slantedTextAngle = 30, textStyle = new gcTextStyle { color = "#333" } })
    VAxis=@(new gcAxis { title = "Values", direction = 1, gridlines = new gcGridlines { count = 4 }, minValue = 0, maxValue = 1200, format = "$#,###" })
    PointSize="7"
    LineWidth="2"
    Annotations=@(new gcAnnotations { alwaysOutside = true })
    Crosshair=@(new gcCrosshair { trigger = "both", orientation = "both" })
    Trendlines=@(new gcFormatters()
        .AddFormatter(new gcFormatter { type = "exponential", color = "#2196F3", lineWidth = 3, opacity = 0.3 })
        .AddFormatter(new gcFormatter { type = "linear", color = "#4CAF50", lineWidth = 3, opacity = 0.3 }))
    Series=@(new gcFormatters()
        .AddFormatter(new gcFormatter { targetAxisIndex = 0, type = "line", lineDashStyle = new int[] { 4, 4 }, pointsVisible = true, color = "#2196F3" })
        .AddFormatter(new gcFormatter { targetAxisIndex = 1, type = "line", lineDashStyle = new int[] { 1, 3 }, pointsVisible = true, color = "#4CAF50" }))
    BackgroundColor="@(new gcBackgroundColor { fill = "#FFFFFF" })"
    IsStacked="@gcStackType.True"
    Tooltip=@(new gcTooltip { isHtml = true })
    FocusTarget="category"
    Explorer=@(new gcExplorer { actions = new string[] { "dragToZoom", "rightClickToReset" }, axis = "horizontal", keepInBounds = true, maxZoomIn = 0.1 }) />

@code {
    private List<object> LineChartData2 = new List<object> {
        new List<object> {"Year", "Sales", "Expenses"},
        new List<object> {"2004", 1000, 400},
        new List<object> {"2005", 1170, 460},
        new List<object> {"2006", 660, 1120},
        new List<object> {"2007", 1030, 540},
    };
}
```

### Pie Chart

```csharp
<PieChart 
    Title="My Daily Activities"
    Style="width: 900px; height: 500px;"
    Is3D="true"
    PieHole="0.4"
    Slices=@(new gcFormatters()
        .AddFormatter(new gcFormatter { color = "#4285f4" })
        .AddFormatter(new gcFormatter { color = "#0f9d58" })
        .AddFormatter(new gcFormatter { color = "#f4b400" })
        .AddFormatter(new gcFormatter { color = "#db4437" })
        .AddFormatter(new gcFormatter { color = "#1e8e3e" }))
    Legend=@(new gcLegend { position = gcLegendPositionType.Top, textStyle = new gcTextStyle { color = "blue", fontSize = 16 }})
    Tooltip=@(new gcTooltip { trigger = "selection", showColorCode = true })
    BackgroundColor="@(new gcBackgroundColor { fill = "#FFFFFF" })"
    Animation=@(new gcAnimation { duration = 2000, easing = "out", startup = true })
    PieStartAngle="100"
    ReverseCategories="false"
    SliceVisibilityThreshold="0.01"
    PieSliceText="percentage"
    PieSliceBorderColor="#ffffff"
    EnableInteractivity="true"
    FocusTarget="category"
    ObjectArray="PieChartData" />

@code {
    private List<object> PieChartData = new List<object> {
        new List<object> { "Task", "Hours per Day" },
        new List<object> { "Work", 11 },
        new List<object> { "Eat", 2 },
        new List<object> { "Commute", 2 },
        new List<object> { "Watch TV", 2 },
        new List<object> { "Sleep", 7 }
    };
}
```

### Donut Chart

```csharp
<PieChart 
    Title="My Daily Activities"
    Style="width: 900px; height: 500px;"
    PieHole="0.4"
    Slices=@(new gcFormatters()
        .AddFormatter(new gcFormatter { color = "#4285f4" })
        .AddFormatter(new gcFormatter { color = "#0f9d58" })
        .AddFormatter(new gcFormatter { color = "#f4b400" })
        .AddFormatter(new gcFormatter { color = "#db4437" })
        .AddFormatter(new gcFormatter { color = "#1e8e3e" }))
          Legend=@(new gcLegend { position = gcLegendPositionType.Top, textStyle = new gcTextStyle { color = "blue", fontSize = 16 } })
    Tooltip=@(new gcTooltip { trigger = "selection", showColorCode = true })
    BackgroundColor="@(new gcBackgroundColor { fill = "#FFFFFF" })"
    Animation=@(new gcAnimation { duration = 2000, easing = "out", startup = true })
    ReverseCategories="false"
    SliceVisibilityThreshold="0.01"
    PieSliceText="percentage"
    PieSliceBorderColor="#ffffff"
    PieSliceTextStyle=@(new gcPieSliceTextStyle { color = "black" })
    EnableInteractivity="true"
    FocusTarget="category"
    ObjectArray="DonutChartData" />

@code {
    private List<object> DonutChartData = new List<object> {
        new List<object> { "Task", "Hours per Day" },
        new List<object> { "Work", 11 },
        new List<object> { "Eat", 2 },
        new List<object> { "Commute", 2 },
        new List<object> { "Watch TV", 2 },
        new List<object> { "Sleep", 7 }
    };
}
```

### Pie Chart Exploded

```csharp
<PieChart 
    Title="Indian Language Use"
    Style="width: 900px; height: 500px;"
    ObjectArray="PieChartExplodedData"
    Legend=@(new gcLegend { position = gcLegendPositionType.Bottom, textStyle = new gcTextStyle { color = "blue", fontSize = 14}})
    PieSliceText="label"
    Slices=@(new gcFormatters()
        .AddFormatter("4", new gcFormatter { offset = 0.2 })
        .AddFormatter("12", new gcFormatter { offset = 0.3 })
        .AddFormatter("14", new gcFormatter { offset = 0.4 })
        .AddFormatter("15", new gcFormatter { offset = 0.5 }))
    BackgroundColor="@(new gcBackgroundColor { fill = "#FFFFFF" })"
    Animation=@(new gcAnimation { duration = 2000, easing = "out", startup = true }) 
    EnableInteractivity="true"
    SliceVisibilityThreshold="0.01"
    ReverseCategories="false"
    Tooltip=@(new gcTooltip { trigger = "selection", showColorCode = true })
    Is3D="false"
    PieResidueSliceLabel="Other"
    PieSliceBorderColor="#ffffff"
    PieStartAngle="30"
    FocusTarget="category"
    Annotations=@(new gcAnnotations { alwaysOutside = true, textStyle = new gcTextStyle { color = "black", fontSize = 12 }})
    AxisTitlesPosition="out"
    FontSize="12"
    FontName="Arial" />

@code {  
    private List<object> PieChartExplodedData = new List<object> {
        new List<object> { "Language", "Speakers (in millions)" },
        new List<object> { "Assamese", 13 }, new object[] { "Bengali", 83 }, new object[] { "Bodo", 1.4 },
        new List<object> { "Dogri", 2.3 }, new object[] { "Gujarati", 46 }, new object[] { "Hindi", 300 },
        new List<object> { "Kannada", 38 }, new object[] { "Kashmiri", 5.5 }, new object[] { "Konkani", 5 },
        new List<object> { "Maithili", 20 }, new object[] { "Malayalam", 33 }, new object[] { "Manipuri", 1.5 },
        new List<object> { "Marathi", 72 }, new object[] { "Nepali", 2.9 }, new object[] { "Oriya", 33 },
        new List<object> { "Punjabi", 29 }, new object[] { "Sanskrit", 0.01 }, new object[] { "Santhali", 6.5 },
        new List<object> { "Sindhi", 2.5 }, new object[] { "Tamil", 61 }, new object[] { "Telugu", 74 }, new object[] { "Urdu", 52 }
    };
}
```

### Scatter Chart

```csharp
<ScatterChart 
    Title="Age vs. Weight comparison"
    Style="width: 900px; height: 500px;"
    Colors=@(new gcColors("#2196F3"))
    ObjectArray="ScatterChartData"
    HAxis=@(new gcAxis { title = "Age", minValue = 0, maxValue = 15, gridlines = new gcGridlines { count = 8 }, textStyle = new gcTextStyle  { color = "#333" } })
    VAxis=@(new gcAxis { title = "Weight", minValue = 0, maxValue = 15, gridlines = new gcGridlines { count = 8 }, textStyle = new gcTextStyle { color = "#333" } })
    PointSize="5" />

@code {
    private List<object> ScatterChartData = new List<object>
    {
        new List<object> { "Age", "Weight" },
        new List<object> { 8, 12 },
        new List<object> { 4, 5.5 },
        new List<object> { 11, 14 },
        new List<object> { 4, 5 },
        new List<object> { 3, 3.5 },
        new List<object> { 6.5, 7 }
    };
}
```

### Scatter Chart with Trendline

```csharp
<ScatterChart 
    Title="Descendants by Generation"
    Style="width: 900px; height: 500px;"
    Colors=@(new gcColors("#2196F3"))
    ObjectArray="TrendlineChartData"
    HAxis=@(new gcAxis { title = "Generation", minValue = 0, maxValue = 3 })
    VAxis=@(new gcAxis { title = "Descendants", minValue = 0, maxValue = 2100 })
    TrendLines=@(new gcFormatters()
        .AddFormatter(new gcFormatter { type = gcTrendlineType.Exponential, visibleInLegend = true, color = "#4CAF50" })) />



@code {
    private List<object> TrendlineChartData = new List<object>
    {
        new List<object> { "Generation", "Descendants" },
        new List<object> { 0, 1 },
        new List<object> { 1, 33 },
        new List<object> { 2, 269 },
        new List<object> { 3, 2013 }
    };

    // DataTable Example
    private gcDataTableBuilder GetDataTable()
    {
        var DataTableBuilder = new gcDataTableBuilder();
        DataTableBuilder.Columns!.Add(new gcColumn() { label = "Generation", type = gcType.Number });
        DataTableBuilder.Columns!.Add(new gcColumn() { label = "Descendants", type = gcType.Number });
        DataTableBuilder.AddRow().AddCell(0).AddCell(1);
        DataTableBuilder.AddRow().AddCell(1).AddCell(33);
        DataTableBuilder.AddRow().AddCell(2).AddCell(269);
        DataTableBuilder.AddRow().AddCell(3).AddCell(2013);
        return DataTableBuilder;
    }
}
```

###
## Contributions

This project is being developed for free by me, Ryan Kueter, in my spare time. So, if you would like to contribute, please submit your ideas on the Github project page.