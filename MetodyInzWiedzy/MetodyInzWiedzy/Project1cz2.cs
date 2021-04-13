using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MetodyInzWiedzy
{
  public partial class Project1cz2 : UserControl
  {
    public Project1cz2()
    {
      InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      SendToBack();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void btnBack_Click(object sender, EventArgs e)
    {
      SendToBack();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      string[] struktura = (textStruktura.Text.Split('-'));

      double max = Convert.ToDouble(textBox3.Text.Replace('.', ','));
      double min = Convert.ToDouble(textBox2.Text.Replace('.', ','));

      int suma = 0;

      for (int i = 0; i < struktura.Length - 1; i++)
      {
        suma += Convert.ToInt32(struktura[i]) * Convert.ToInt32(struktura[i + 1]) + Convert.ToInt32(struktura[i + 1]);

      }
      double[] DaneWygenerowane = new double[suma];
      Random R = new Random();

      for (int i = 0; i < DaneWygenerowane.Length; i++)
      {
        DaneWygenerowane[i] = R.NextDouble() * (max - min) + min;
      }

      dataGridView1.Rows.Clear();

      dataGridView1.ColumnCount = DaneWygenerowane.Length;
      DataGridViewRow deklaracja = new DataGridViewRow();  //deklaracja rekordu w grid
      deklaracja.CreateCells(dataGridView1); // tworzenie komórek
      for (int j = 0; j < struktura.Length; j++)
      {
        deklaracja.Cells[j].Value = struktura[j]; // dodawanie danych w celu wyswietlenia
      }
      dataGridView1.Rows.Add(deklaracja); // dodanie Rows

      DataGridViewRow deklaracja2 = new DataGridViewRow();  //deklaracja rekordu w grid
      deklaracja2.CreateCells(dataGridView1); // tworzenie komórek
      for (int j = 0; j < DaneWygenerowane.Length; j++)
      {
        deklaracja2.Cells[j].Value = DaneWygenerowane[j]; // dodawanie danych w celu wyswietlenia
      }
      dataGridView1.Rows.Add(deklaracja2); // dodanie Rows





    }

    private void button2_Click_1(object sender, EventArgs e)
    {
      string txt = "";
      foreach (DataGridViewRow row in dataGridView1.Rows)
      {
        foreach (DataGridViewCell cell in row.Cells)
        {
          if(cell.Value != null)
          { 
          txt += cell.Value.ToString()  + ' ' ;
          }

        }
        txt += "\n";
      }

      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
      saveFileDialog1.FilterIndex = 2;
      saveFileDialog1.RestoreDirectory = true;
      saveFileDialog1.OverwritePrompt = true;

      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
        using (StreamWriter sw = new StreamWriter(s))
        {
          sw.Write(txt);
        }
      }
    }
  }
}
