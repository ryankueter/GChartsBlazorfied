/**
 * Author: Ryan A. Kueter
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */
using System.Text;
using System.Text.Json;

using GChartsBlazorfied.Options;

namespace GChartsBlazorfied;

public class gcDataTableBuilder
{
    private List<gcColumn>? Columns { get; set; } = new();
    private List<gcRow>? Rows { get; set; } = new();
    private gcRow? CurrentRow { get; set; }
    public gcDataTableBuilder()
    {
        Columns = new List<gcColumn>();
        Rows = new List<gcRow>();
    }

    public gcDataTableBuilder AddColumn(Action<gcColumnOptions> column)
    {
        var options = new gcColumnOptions();
        if (column is not null)
            column(options);
        Columns!.Add(options.ReturnOptions());
        return this;
    }

    public gcDataTableBuilder AddRow()
    {
        CurrentRow = new gcRow();
        Rows!.Add(CurrentRow);
        return this;
    }

    public gcDataTableBuilder AddCell(object? v, string? f = null)
    {
        if (CurrentRow is null)
            return this;

        CurrentRow.Add(new gcCell(v, f));
        return this;
    }

    /// <summary>
    /// Override the "ToString" method to return the data table.
    /// </summary>
    /// <returns></returns>
    public string Build()
    {
        using var stream = new MemoryStream();
        using var writer = new Utf8JsonWriter(stream, new JsonWriterOptions());

        writer.WriteStartObject();
        WriteColumns(writer);
        WriteRows(writer);
        writer.WriteNull("p");
        writer.WriteEndObject();
        writer.Flush();

        return Encoding.UTF8.GetString(stream.ToArray());
    }

    /// <summary>
    /// Writes datatable columns.
    /// </summary>
    /// <param name="writer"></param>
    private void WriteColumns(Utf8JsonWriter writer)
    {
        writer.WriteStartArray("cols");

        if (Columns is not null)
        {
            foreach (var column in Columns)
            {
                writer.WriteStartObject();

                if (column.id is not null)
                    writer.WriteString("id", column.id);

                if (column.label is not null)
                    writer.WriteString("label", column.label);

                if (column.pattern is not null)
                    writer.WriteString("pattern", column.pattern);

                if (column.type is not null)
                    writer.WriteString("type", column.type);

                if (column.role is not null)
                    writer.WriteString("role", column.role);

                if (column.p is not null)
                {
                    writer.WriteStartObject("p");
                    writer.WriteBoolean("html", column.p!.html);
                    writer.WriteEndObject();
                }

                writer.WriteEndObject();
            }
        }
        writer.WriteEndArray();
    }

    /// <summary>
    /// Writes datatable rows.
    /// </summary>
    /// <param name="writer"></param>
    private void WriteRows(Utf8JsonWriter writer)
    {
        writer.WriteStartArray("rows");
        if (Rows is not null)
        {
            foreach (var row in Rows)
            {
                writer.WriteStartObject();
                writer.WriteStartArray("c");

                foreach (var cell in row)
                {
                    writer.WriteStartObject();

                    if (cell.v != null)
                        writer.WriteString("v", Convert.ToString(cell.v));
                    else
                        writer.WriteNull("v");

                    if (cell.f != null)
                        writer.WriteString("f", Convert.ToString(cell.f));
                    else
                        writer.WriteNull("f");

                    writer.WriteEndObject();
                }

                writer.WriteEndArray();
                writer.WriteEndObject();
            }
        }
        writer.WriteEndArray();
    }
}
