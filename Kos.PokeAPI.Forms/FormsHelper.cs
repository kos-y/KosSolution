using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kos.PokeAPI.Utility.CommonModels;
using static System.Net.Mime.MediaTypeNames;

namespace Kos.PokeAPI.Forms;

/// <summary>
/// ヘルパー
/// </summary>
public static class FormsHelper
{
    /// <summary>
    /// データの設定
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="label"></param>
    /// <param name="textBox"></param>
    public static void SetData<T>(T? data, Label label, TextBox textBox)
    {
        if (!textBox.Multiline) {
            if (data is null) {
                label.Enabled = false;
                textBox.Text = string.Empty;
                textBox.Enabled = false;
            } else {
                label.Enabled = true;
                textBox.Text = $"{data}";
                textBox.Enabled = true;
            }
        } else {
            if (data is null) {
                label.Enabled = false;
                textBox.Text = string.Empty;
                textBox.Enabled = false;
            } else {
                label.Enabled = true;
                textBox.Text
                    = $"{data}".Replace("\r\n", "\n")
                               .Replace("\n", Environment.NewLine);
                textBox.Enabled = true;
            }
        }
    }

    /// <summary>
    /// データの設定
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="button"></param>
    /// <param name="textBox"></param>
    public static void SetData<T>(T? data, Button button, TextBox textBox)
    {
        if (data is null) {
            button.Enabled = false;
            textBox.Text = string.Empty;
            textBox.Enabled = false;
        } else {
            button.Enabled = true;
            button.Tag = data;
            if (data is NamedAPIResource api) {
                textBox.Text = $"{api.Name}";
            } else {
                textBox.Text = $"{data}";
            }
            textBox.Enabled = true;
        }
    }

    /// <summary>
    /// データの設定
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="label"></param>
    /// <param name="dataGridView"></param>
    public static void SetData<T>(IReadOnlyList<T>? data, Label label, DataGridView dataGridView)
    {
        if (data is null) {
            label.Enabled = false;
            dataGridView.Enabled = false;
        } else {
            label.Enabled = true;
            dataGridView.Enabled = true;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = data;
        }
    }
}
