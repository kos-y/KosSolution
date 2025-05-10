using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kos.Core;
using Kos.PokeAPI.Utility.CommonModels;

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
    /// <param name="button"></param>
    public static void SetData<T>(T? data, Button button)
    {
        if (data is null) {
            button.Enabled = false;
        } else {
            button.Enabled = true;
            button.Tag = data;
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

    /// <summary>
    /// データの設定
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="label"></param>
    /// <param name="dataGridView"></param>
    public static void SetData<T>(IReadOnlyList<T>? data, DataGridView dataGridView)
    {
        if (data is null) {
            dataGridView.Enabled = false;
        } else {
            dataGridView.Enabled = true;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = data;
        }
    }

    /// <summary>
    /// データの設定
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="picureBox"></param>
    public static void SetData<T>(T? data, PictureBox picureBox)
    {
        if (data is not null) {
            using Stream s
                = Singleton<HttpClient>.Instance
                                       .GetAsync(data as string)
                                       .Result
                                       .Content
                                       .ReadAsStreamAsync()
                                       .Result;

            picureBox.Image = Image.FromStream(s);
        }
    }
}
