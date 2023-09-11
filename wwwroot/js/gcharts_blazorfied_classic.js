/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
window.GoogleChart = (chartType, chartData, chartOptions, elementId, dotNetObjectReference, usedatatable) => {
    google.charts.load('current', { packages: ['corechart'] });
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
                chart = new google.visualization.BarChart(document.getElementById(elementId));
                break;
            case 'LineChart':
                chart = new google.visualization.LineChart(document.getElementById(elementId));
                break;
            case 'PieChart':
                chart = new google.visualization.PieChart(document.getElementById(elementId));
                break;
            case 'ColumnChart':
                chart = new google.visualization.ColumnChart(document.getElementById(elementId));
                break;
            case 'GeoChart':
                chart = new google.visualization.GeoChart(document.getElementById(elementId));
                break;
            case 'Histogram':
                chart = new google.visualization.Histogram(document.getElementById(elementId));
                break;
            case 'ScatterChart':
                chart = new google.visualization.ScatterChart(document.getElementById(elementId));
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