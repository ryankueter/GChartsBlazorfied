/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

/* Material themed charts */
window.GoogleChart = (chartType, chartData, chartOptions, elementId, dotNetObjectReference, usedatatable) => {
    
    switch (chartType) {
        case 'AreaChart':
            google.charts.load('current', { packages: ['corechart'] });
            break;
        case 'BarChart':
            google.charts.load('current', { packages: ['bar'] });
            break;
        case 'LineChart':
            google.charts.load('current', { packages: ['line'] });
            break;
        case 'PieChart':
            google.charts.load('current', { packages: ['corechart'] });
            break;
        case 'ColumnChart':
            google.charts.load('current', { packages: ['bar'] });
            break;
        case 'Histogram':
            google.charts.load('current', { packages: ['corechart'] });
            break;
        case 'ScatterChart':
            google.charts.load('current', { packages: ['scatter'] });
            break;
        default:
            console.error("Unsupported chart type: " + chartType);
            return;
    }
    google.charts.setOnLoadCallback(() => {

        let data;
        if (usedatatable) {
            data = new google.visualization.DataTable(chartData)
        }
        else {
            data = google.visualization.arrayToDataTable(chartData);
        }

        let chart;
        switch (chartType) {
            case 'AreaChart':
                chart = new google.visualization.AreaChart(document.getElementById(elementId));
                break;
            case 'BarChart':
                chart = new google.charts.Bar(document.getElementById(elementId));
                break;
            case 'LineChart':
                chart = new google.charts.Line(document.getElementById(elementId));
                break;
            case 'PieChart':
                chart = new google.visualization.PieChart(document.getElementById(elementId));
                break;
            case 'ColumnChart':
                chart = new google.charts.Bar(document.getElementById(elementId));
                break;
            case 'Histogram':
                chart = new google.visualization.Histogram(document.getElementById(elementId));
                break;
            case 'ScatterChart':
                chart = new google.charts.Scatter(document.getElementById(elementId));
                break;
            default:
                console.error("Unsupported chart type: " + chartType);
                return;
        }

        // Adds the click event handler.
        if (dotNetObjectReference != null) {
            google.visualization.events.addListener(chart, 'select', function () {
                var selection = chart.getSelection();
                if (selection.length > 0) {
                    var row = selection[0].row;
                    var column = selection[0].column;
                    if (row != null && column != null) {
                        dotNetObjectReference.invokeMethodAsync('ClickEvent', row, column);
                    }
                }
            });
        }

        // Clears the selection when using the Trigger = "both" option
        // This keeps the tooltip open while it can still be closed.
        google.visualization.events.addListener(chart, "onmouseover", function (event) {
            chart.setSelection(null);
        });

        chart.draw(data, chartOptions);
    });
};